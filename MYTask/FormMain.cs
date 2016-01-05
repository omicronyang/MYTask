using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Resources;

namespace MYTask
{
    public partial class FormMain : Form
    {
        ShadowForm SF;

        private int TimerSideStat;
        private int TimerLogStat;
        private int TimerUserStat;
        private int LoginStat = 1;  // 0 正常登陆, 1 跳过验证
        private int DBaseStat = -1; // 0 离线数据, 1 在线数据
        private MyUser NowUser = new MyUser();
        private BackgroundWorker m_worker = new BackgroundWorker();
        private ListViewColumnSorter lvwColumnSorter;
        public MyDB DataBase = new MyDB();
        private object NowFocus;
        private Button FocusBtn = new Button();
        private Button FocusBtnS = new Button();
        private TabControl FocusTC;
        public UIColor Theme = new UIColor();

        private delegate void BGAddTaskList(MyTask[] Tlist, int Mode);
        private delegate void BGAddProjList(MyProj[] Plist, int Mode);
        private delegate void BGAddUserList(MyUser[] Ulist);
        private delegate void BGAddAnnList(MyAnnounce[] Alist);
        private delegate void BGAddMessList(MyMessage[] Mlist);
        private delegate void BGWorkComplete(object sender, DoWorkEventArgs e);

        

        

        public FormMain()
        {
            InitializeComponent();

            PanelGuide.Location = new Point(-175, 32);
            PanelGuideS.Location = new Point(0, 32);
            PanelLogin.Location = new Point(0, 32);
            PanelUser.Location = new Point(700, 32);
            TabsTask.Location = new Point(48, 32);
            TabsProject.Location = new Point(48, 32);
            PanelContacts.Location = new Point(48, 32);
            PanelContacts.BackColor = Color.Gainsboro;
            PanelMessages.Location = new Point(48, 32);


            SF = new ShadowForm(this);
            SF.Show(this);
            SetStyles();
            UIColorUpdate(Properties.Settings.Default.UIColorType);
            PanelUser.SetFatherForm(this);

            //dHeight = Height - PanelGuideS.Height;
            //dWidth = Width - PanelProfile.Width - 48;

            //跳过登陆面板
            PLogin_TextUID.RenewState(3);
            PLogin_TextUID.Enter += new EventHandler(LoginBoxGetFocus);
            PLogin_TextUID.Leave += new EventHandler(LoginBoxLostFocus);

            PLogin_TextPsw.RenewState(3);
            PLogin_TextPsw.Enter += new EventHandler(LoginBoxGetFocus);
            PLogin_TextPsw.Leave += new EventHandler(LoginBoxLostFocus);

            lvwColumnSorter = new ListViewColumnSorter();
            ContactList.ListViewItemSorter = lvwColumnSorter;

            m_worker.WorkerReportsProgress = true;
            m_worker.WorkerSupportsCancellation = true;

            

        }

        #region 优化窗体显示
        private void SetStyles()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.DoubleBuffer, true);
            //强制分配样式重新应用到控件上
            UpdateStyles();
            base.AutoScaleMode = AutoScaleMode.None;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Win32.AnimateWindow(SF.Handle, 150, Win32.AW_BLEND | Win32.AW_HIDE);
            Win32.AnimateWindow(this.Handle, 150, Win32.AW_BLEND | Win32.AW_HIDE);
            base.OnClosing(e);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style = cp.Style | Win32.WS_MINIMIZEBOX;
                return cp;
            }
        }

        private void UI_Caption_MouseDown(object sender, MouseEventArgs e)
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle, Win32.WM_SYSCOMMAND, Win32.SC_MOVE + Win32.HTCAPTION, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            SF.Close();
            Win32.AnimateWindow(this.Handle, 150, Win32.AW_BLEND | Win32.AW_HIDE);
            Environment.Exit(0);
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle, Win32.WM_SYSCOMMAND, Win32.SC_MINIMIZE, 0);
        }

        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            PLogin_TextUID.RenewState(3);
            PLogin_TextPsw.RenewState(3);
            CloudStatus.Image = Properties.Resources.Cloud_Connecting_32;
            CloudStatusS.Image = Properties.Resources.Cloud_Connecting_32;
            PLogin_PicCloud.Image = Properties.Resources.Cloud_Connecting_32;
            PLogin_BarConnecting.MarqueeAnimationSpeed = 5;
            SnycProgress.Style = ProgressBarStyle.Marquee;
            SnycProgress.MarqueeAnimationSpeed = 10;
            LabelStatus.Text = "正在连接";

            m_worker.DoWork += new DoWorkEventHandler(TestConnect);
            m_worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(RenewDBStat);
            m_worker.RunWorkerAsync();

            InitLoginBox("");
            
        }

        private void FormMain_Unload(object sender, EventArgs e)
        {
            if (DBaseStat == 1) DataBase.Close();
        }

        #region 颜色设置

        private void UIColorUpdate(int ColorType)
        {
            Theme.UpdateColor(ColorType);

            PanelLogin.BackColor = Theme.MainColor;
            UI_Caption.BackColor = Theme.MainColor;

            BtnProfile.BackColor = Theme.MainColor;

            TaskListMy.BackColor = Theme.MainColor;
            TaskListPub.BackColor = Theme.MainColor;
            TaskListAll.BackColor = Theme.MainColor;

            ProjListMy.BackColor = Theme.MainColor;
            ProjListAll.BackColor = Theme.MainColor;

            BtnCall.BackColor = Theme.MainColor;
            BtnCall.FlatAppearance.MouseOverBackColor = Theme.MouseOverColor;
            BtnCall.FlatAppearance.MouseDownBackColor = Theme.MouseDownColor;

            BtnCallback.BackColor = Theme.MainColor;
            BtnCallback.FlatAppearance.MouseOverBackColor = Theme.MouseOverColor;
            BtnCallback.FlatAppearance.MouseDownBackColor = Theme.MouseDownColor;

            BtnMin.BackColor = Theme.MainColor;
            BtnMin.FlatAppearance.MouseOverBackColor = Theme.MouseOverColor;
            BtnMin.FlatAppearance.MouseDownBackColor = Theme.MouseDownColor;

            PLogin_BtnLogin.BackColor = Theme.MainColor;
            PLogin_BtnLogin.FlatAppearance.MouseOverBackColor = Theme.MouseOverColor;
            PLogin_BtnLogin.FlatAppearance.MouseDownBackColor = Theme.MouseDownColor;

            FocusBtn.BackColor = Theme.MouseOverColor;
            FocusBtn.FlatAppearance.MouseOverBackColor = Theme.MouseOverColor;
            FocusBtn.FlatAppearance.MouseDownBackColor = Theme.MouseOverColor;

            FocusBtnS.BackColor = Theme.MouseOverColor;
            FocusBtnS.FlatAppearance.MouseOverBackColor = Theme.MouseOverColor;
            FocusBtnS.FlatAppearance.MouseDownBackColor = Theme.MouseOverColor;

            PanelUser.UpdateColor(Theme);
        }

        private void UIColorUpdate(Color UIC)
        {
            if (UIC == Color.RoyalBlue) UIColorUpdate(1);
            else if (UIC == Color.SeaGreen) UIColorUpdate(2);
            else if (UIC == Color.DarkMagenta) UIColorUpdate(3);
            else if (UIC == Color.Crimson) UIColorUpdate(4);
            else if (UIC == Color.OrangeRed) UIColorUpdate(5);
        }
        
        #endregion

        #region 数据库连接
        private void TestConnect(object sender, DoWorkEventArgs e)
        {
            Action aDelegate = delegate { this.PLogin_BarConnecting.MarqueeAnimationSpeed = 5; };
            this.PLogin_BarConnecting.Invoke(aDelegate);

            if (DataBase.Connect())
            {
                DBaseStat = DataBase.Online;
            }
            else MessageBox.Show("无法连接到数据库：请让设备连接到网络或检查离线数据文件是否完整");
        }

        private void RenewDBStat(object sender, RunWorkerCompletedEventArgs e)
        {
            PLogin_BarConnecting.MarqueeAnimationSpeed = 0;
            PLogin_BarConnecting.Visible = false;
            m_worker.DoWork -= new DoWorkEventHandler(TestConnect);
            m_worker.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(RenewDBStat);
            m_worker.DoWork += new DoWorkEventHandler(InitList);
            m_worker.RunWorkerAsync();
            if (DBaseStat == 1)
            {
                CloudStatus.Image = Properties.Resources.Cloud_Online_32;
                CloudStatusS.Image = Properties.Resources.Cloud_Online_32;
                PLogin_PicCloud.Image = Properties.Resources.Cloud_Online_32;
                LabelStatus.Text = "同步完成";
                LabelStatus.Location = new Point(3, CloudStatus.Location.Y + 12);
                SnycProgress.Visible = false;
                PLogin_BtnFindPsw.Visible = true;
            }
            else if (DBaseStat == 0)
            {
                CloudStatus.Image = Properties.Resources.Cloud_Offline_32;
                CloudStatusS.Image = Properties.Resources.Cloud_Offline_32;
                PLogin_PicCloud.Image = Properties.Resources.Cloud_Offline_32;
                LabelStatus.Text = "离线模式";
                LabelStatus.Location = new Point(3, CloudStatus.Location.Y + 12);
                SnycProgress.Visible = false;
            }
            else
            {
                CloudStatus.Image = Properties.Resources.Cloud_Sync_32;
                CloudStatusS.Image = Properties.Resources.Cloud_Sync_32;
                PLogin_PicCloud.Image = Properties.Resources.Cloud_Sync_32;
                LabelStatus.Text = "正在同步";
                LabelStatus.Location = new Point(3, CloudStatus.Location.Y);
                SnycProgress.Visible = true;
                SnycProgress.Style = ProgressBarStyle.Marquee;
                SnycProgress.MarqueeAnimationSpeed = 3;
            }

        }
        #endregion
        
        #region 面板显示控制

        private void TimerSidebar_Tick(object sender, EventArgs e)
        {
            switch (TimerSideStat)
            {
                case 0:
                    {
                        //PanelGuide shows from left
                        int x = PanelGuide.Location.X;
                        if (PanelGuide.Location.X >= 0) {
                            TimerSidebar.Stop();
                            PanelGuide.Location = new Point(0, 32);
                            return;
                        }
                        PanelGuide.Location = new Point(x + 25, 32);
                        break;
                    }
                case 1:
                    {
                        //PanelGuide exit to left
                        int x = PanelGuide.Location.X;
                        if (PanelGuide.Location.X <= -175)
                        {
                            TimerSidebar.Stop();
                            PanelGuide.Location = new Point(-175, 32);
                            return;
                        }
                        PanelGuide.Location = new Point(x - 25, 32);
                        break;
                    }
            }
        }

        private void TimerLogin_Tick(object sender, EventArgs e)
        {
            switch (TimerLogStat)
            {
                case 0:
                    {
                        //PanelLogin shows from bottom
                        int y = PanelLogin.Location.Y;
                        if (PanelLogin.Location.Y <= 32)
                        {
                            TimerLogin.Stop();
                            PanelLogin.Location = new Point(0, 32);
                            PanelUser.Location = new Point(700, 32);
                            TaskListMy.ClearTask();
                            TaskListPub.ClearTask();
                            ProjListMy.ClearProj();
                            MessList.Items.Clear();
                            return;
                        }
                        PanelLogin.Location = new Point(0, y - 25);
                        break;
                    }
                case 1:
                    {
                        //PanelLogin exit to bottom
                        int y = PanelLogin.Location.Y;
                        if (PanelLogin.Location.Y >= this.Height)
                        {
                            TimerLogin.Stop();
                            PanelLogin.Visible = false;
                            return;
                        }
                        PanelLogin.Location = new Point(0, y + 25);
                        break;
                    }
            }
        }

        private void TimerUser_Tick(object sender, EventArgs e)
        {
            switch (TimerUserStat)
            {
                case 0:
                    {
                        //PanelUser shows from right
                        int x = PanelUser.Location.X;
                        if (PanelUser.Location.X == 315)
                        {
                            TimerUser.Stop();
                            PanelUser.Location = new Point(315, 32);
                            return;
                        }
                        PanelUser.Location = new Point(x - 55, 32);
                        break;
                    }
                case 1:
                    {
                        //PanelUser exit to right
                        int x = PanelUser.Location.X;
                        if (PanelUser.Location.X == 700)
                        {
                            TimerUser.Stop();
                            PanelUser.Location = new Point(700, 32);
                            return;
                        }
                        PanelUser.Location = new Point(x + 55, 32);
                        break;
                    }
            }
        }

        private void FoldSideBar()
        {
            if (PanelGuide.Location.X == 0)
            {
                TimerSideStat = 1;
                TimerSidebar.Start();
            }
        }

        
        public void ShowPanelUser()
        {
            TimerUserStat = 0;
            TimerUser.Start();
        }

        public void FoldPanelUser()
        {
            TimerUserStat = 1;
            TimerUser.Start();
        }
        

        private void ShowTabsTask()
        {
            TabControl me = TabsTask;
            TabPage met = TaskMy;

            FocusTC = TabsTask;
            switch (TabsTask.SelectedIndex)
            {
                case 0: { UpdatePageControl(TaskListMy); break; }
                case 1: { UpdatePageControl(TaskListPub); break; }
                case 2: { UpdatePageControl(TaskListAll); break; }
            }
            LabelTitle.Text = "WSS - 任务列表";

            me.Visible = true;
            TabsProject.Visible = false;
            PanelContacts.Visible = false;
            PanelMessages.Visible = false;
        }
        private void ShowTabsProject()
        {
            TabControl me = TabsProject;

            FocusTC = TabsProject;
            switch (TabsProject.SelectedIndex)
            {
                case 0: { UpdatePageControl(ProjListMy); break; }
                case 1: { UpdatePageControl(ProjListAll); break; }
            }
            LabelTitle.Text = "WSS - 项目列表";

            me.Visible = true;
            TabsTask.Visible = false;
            PanelContacts.Visible = false;
            PanelMessages.Visible = false;
        }
        private void ShowPanelContacts()
        {
            Panel me = PanelContacts;

            BtnPageUp.Visible = false;
            BtnPageDown.Visible = false;
            LabelPage.Visible = false;
            FocusTC = null;
            LabelTitle.Text = "WSS - 联系人列表";

            me.Visible = true;
            TabsTask.Visible = false;
            TabsProject.Visible = false;
            PanelMessages.Visible = false;
        }
        private void ShowPanelMessages()
        {
            Panel me = PanelMessages;

            BtnPageUp.Visible = false;
            BtnPageDown.Visible = false;
            LabelPage.Visible = false;
            FocusTC = null;
            LabelTitle.Text = "WSS - 消息中心";

            me.Visible = true;
            TabsTask.Visible = false;
            TabsProject.Visible = false;
            PanelContacts.Visible = false;
        }
        private void SelectPanel(int index)
        {
            switch (index)
            {
                case 1: { ShowTabsTask(); break; }
                case 2: { ShowTabsProject(); break; }
                case 3: { ShowPanelContacts(); break; }
                case 4: { ShowPanelMessages(); break; }
            }
            RenewBtnStyle(index);
        }

        private void RenewBtnStyle(int index)
        {
            FocusBtn.BackColor = Color.LightGray;
            FocusBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            FocusBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
            FocusBtnS.BackColor = Color.LightGray;
            FocusBtnS.FlatAppearance.MouseOverBackColor = Color.Silver;
            FocusBtnS.FlatAppearance.MouseDownBackColor = Color.Gray;

            switch (index)
            {
                case 1: { FocusBtn = BtnTask; FocusBtnS = BtnTaskS; break; }
                case 2: { FocusBtn = BtnProject; FocusBtnS = BtnProjectS; break; }
                case 3: { FocusBtn = BtnContact; FocusBtnS = BtnContactS; break; }
                case 4: { FocusBtn = BtnMessage; FocusBtnS = BtnMessageS; break; }
            }
            if (index > 0)
            {
                FocusBtn.BackColor = Theme.MouseOverColor;
                FocusBtn.FlatAppearance.MouseOverBackColor = Theme.MouseOverColor;
                FocusBtn.FlatAppearance.MouseDownBackColor = Theme.MouseOverColor;
                FocusBtnS.BackColor = Theme.MouseOverColor;
                FocusBtnS.FlatAppearance.MouseOverBackColor = Theme.MouseOverColor;
                FocusBtnS.FlatAppearance.MouseDownBackColor = Theme.MouseOverColor;
            }
        }

        #endregion

        private void InitList(object sender, DoWorkEventArgs e)
        {
            if (ContactList.InvokeRequired)
            {
                BGWorkComplete BGWC = new BGWorkComplete(InitList);
                Invoke(BGWC, sender, e);
                return;
            }


            AddTaskList(DataBase.GetTaskList(), 2);
            AddProjList(DataBase.GetProjList(), 2);
            AddUserList(DataBase.GetUserList());
            AddAnnList(DataBase.GetAnnounceList());
            PLogin_LabelBlock.Visible = false;
        }



        public void SetProfilePanel(int uid)
        {
            MyUser tu = new MyUser();
            tu = DataBase.GetUser(uid);
            PanelUser.SetProfileInfo(tu, (tu == NowUser || NowUser.Rank == 5) ? 1 : 0);
        }


        private void BtnCall_Click(object sender, EventArgs e)
        {
            if (PanelGuide.Location.X < 0) TimerSideStat = 0;
            else TimerSideStat = 1;
            TimerSidebar.Start();
        }

        #region 登录文本框控制

        public void InitLoginBox(string uid)
        {
            PLogin_TextUID.RenewState(0);
            PLogin_TextPsw.RenewState(0);
            if (uid == "") PLogin_TextUID.Text = "用户名";
            else PLogin_TextUID.Text = uid;
            PLogin_TextPsw.UseSystemPasswordChar = false;
            PLogin_TextPsw.Text = "密码";
        }

        private void LoginBoxGetFocus(object sender, EventArgs e)
        {
            LoginTextbox tbx = (LoginTextbox)sender;
            if (tbx.State == 1) return;
            tbx.Text = "";
            tbx.RenewState(1);
        }

        private void LoginBoxLostFocus(object sender, EventArgs e)
        {
            LoginTextbox tbx = (LoginTextbox)sender;
            if (tbx.Text != "") return;
            tbx.RenewState(0);
            if (tbx.Name == "TextLogin_UID") tbx.Text = "用户名";
            else tbx.Text = "密码";
        }

        #endregion

        #region 导航栏按钮
        private void BtnTask_Click(object sender, EventArgs e)
        {
            FoldSideBar();
            SelectPanel(1);
        }

        private void BtnProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FoldSideBar();
            PanelUser.SetProfileInfo(NowUser,1);
            ShowPanelUser();
        }

        private void BtnProject_Click(object sender, EventArgs e)
        {
            FoldSideBar();
            SelectPanel(2);

        }

        private void BtnContact_Click(object sender, EventArgs e)
        {
            FoldSideBar();
            SelectPanel(3);
        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
            FoldSideBar();
            SelectPanel(4);
        }

        #endregion

        #region 登录登出
        public void Login()
        {
            if (LoginStat == 1) goto Success;

            //检测用户是否输入完整信息
            bool flag = true;
            if (PLogin_TextUID.State != 1)
            {
                PLogin_TextUID.RenewState(2);
                PLogin_TextUID.Text = "请输入用户名";
                flag = false;
            }
            if (PLogin_TextPsw.State != 1)
            {
                PLogin_TextPsw.RenewState(2);
                PLogin_TextPsw.Text = "请输入密码";
                flag = false;
            }
            if (!flag) return;

            //获取字符串值进行比对
            string UserID = PLogin_TextUID.Text;
            string UserP = PLogin_TextPsw.Text;
            PswString Psw = new PswString(UserP);
            string DBPsw = DataBase.GetUserPsw(UserID);
            //MessageBox.Show(DBPsw + "\n" + Psw.MD64);

            //数据库无用户名记录
            if (DBPsw == "@@@@")
            {
                PLogin_BtnLogin.Focus();
                PLogin_TextUID.RenewState(2);
                PLogin_TextUID.Text = "用户不存在";
                PLogin_TextPsw.RenewState(0);
                PLogin_TextPsw.Text = "密码";
                return;
            }

            //密码不匹配
            if (DBPsw != Psw.MD64)
            {
                PLogin_BtnLogin.Focus();
                PLogin_TextPsw.RenewState(2);
                PLogin_TextPsw.Text = "密码错误";
                return;
            }

        Success:  //成功登陆
            ShowTabsTask();
            if (LoginStat == 1 && PLogin_TextUID.State == 0) PLogin_TextUID.Text = "zxt_lyd";
            NowUser = DataBase.GetUser(PLogin_TextUID.Text);
            //MessageBox.Show(NowUser.Name);
            BtnProfile.Text = NowUser.Name.Replace(' ', '\n');


            AddTaskList(DataBase.GetTaskList(NowUser.UID, 0), 0);
            AddTaskList(DataBase.GetTaskList(NowUser.UID, 1), 1);
            AddProjList(DataBase.GetProjList(NowUser.UID), 0);
            AddMessList(DataBase.GetMessList(NowUser.UID));

            TaskListAll.RenewTaskPage(0);
            UpdatePageControl(TaskListMy);
            TabsTask.SelectedIndex = 0;

            FocusBtnS = BtnTaskS;
            BtnTaskS.BackColor = Theme.MouseOverColor;
            BtnTaskS.FlatAppearance.MouseOverBackColor = Theme.MouseOverColor;
            BtnTaskS.FlatAppearance.MouseDownBackColor = Theme.MouseOverColor;

            FocusBtn = BtnTask;
            BtnTask.BackColor = Theme.MouseOverColor;
            BtnTask.FlatAppearance.MouseOverBackColor = Theme.MouseOverColor;
            BtnTask.FlatAppearance.MouseDownBackColor = Theme.MouseOverColor;

            LabelTitle.Text = "WSS - 任务列表";
            TimerLogStat = 1;
            TimerLogin.Start();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void TextLogin_Psw_Keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) Login();
        }

        public void Logout()
        {

            FocusBtn.BackColor = Color.LightGray;
            FocusBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            FocusBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
            FocusBtn = null;
            FocusBtnS.BackColor = Color.LightGray;
            FocusBtnS.FlatAppearance.MouseOverBackColor = Color.Silver;
            FocusBtnS.FlatAppearance.MouseDownBackColor = Color.Gray;
            FocusBtnS = null;
            
            PanelLogin.Visible = true;
            InitLoginBox("");
            LabelTitle.Text = "WSS - 登录";
            TimerLogStat = 0;
            TimerLogin.Start();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FoldSideBar();
            Logout();
        }

        #endregion

        private void BtnFindPsw_Click(object sender, EventArgs e)
        {

        }


        #region 添加元素
        /// <summary>
        /// 为任务列表容器添加任务项
        /// </summary>
        /// <param name="Tasklist">元数据</param>
        /// <param name="Mode">0为添加指派给用户的任务，1为用户发布的任务，否则为全部任务</param>
        private void AddTaskList(MyTask[] Tasklist, int Mode)
        {
            if (TaskListMy.InvokeRequired)
            {
                BGAddTaskList BGATL = new BGAddTaskList(AddTaskList);
                Invoke(BGATL, Tasklist, Mode);
                return;
            }

            TaskPanelContainer Target;

            if (Mode == 0) Target = TaskListMy;
            else if (Mode == 1) Target = TaskListPub;
            else Target = TaskListAll;

            Target.AddTask(Tasklist);
        }

        /// <summary>
        /// 为项目列表容器添加项目项
        /// </summary>
        /// <param name="Projlist">元数据</param>
        /// <param name="Mode">0为用户负责的项目，否则为全部项目</param>
        private void AddProjList(MyProj[] Projlist, int Mode)
        {
            if (ProjListMy.InvokeRequired)
            {
                BGAddProjList BGAPL = new BGAddProjList(AddProjList);
                Invoke(BGAPL, Projlist, Mode);
                return;
            }

            ProjPanelContainer Target;

            if (Mode == 0) Target = ProjListMy;
            else Target = ProjListAll;

            Target.AddProj(Projlist);
        }

        /// <summary>
        /// 添加用户列表
        /// </summary>
        /// <param name="Ulist"></param>
        private void AddUserList(MyUser[] Ulist)
        {
            if (ContactList.InvokeRequired)
            {
                //BGAddUser X= new BGAddUser(AddUserList);
                BGAddUserList BGAUL = new BGAddUserList(AddUserList);
                Invoke(BGAUL,Ulist,1);
                return;
            }
            ContactList.AddUserList(Ulist);
        }

        private void AddAnnList(MyAnnounce[] Alist)
        {
            if (AnnList.InvokeRequired)
            {
                BGAddAnnList BGAAL = new BGAddAnnList(AddAnnList);
                Invoke(BGAAL, Alist);
                return;
            }
            AnnList.AddAnnList(Alist);
        }

        private void AddMessList(MyMessage[] Mlist)
        {
            if (MessList.InvokeRequired)
            {
                BGAddMessList BGAML = new BGAddMessList(AddMessList);
                Invoke(BGAML, Mlist);
                return;
            }
            MessList.AddMessList(Mlist);
        }


        #endregion

        private void ContactList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // 重新设置此列的排序方法.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // 设置排序列，默认为正向排序
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            // 用新的排序方法对ListView排序
            ContactList.Sort();
        }

        private void ContactList_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem target = ContactList.SelectedItems[0];
            //MessageBox.Show(target.SubItems[4].Text);
            SetProfilePanel(Convert.ToInt32(target.SubItems[4].Text));
            ShowPanelUser();
        }


        #region 翻页控制
        private void BtnPageUp_Click(object sender, EventArgs e)
        {
            if (NowFocus.GetType().ToString() == "MYTask.TaskPanelContainer")
            {
                TaskPanelContainer Target = (TaskPanelContainer)NowFocus;
                Target.PageUp();
                if (Target.NowIndex <= 0)
                    BtnPageUp.Visible = false;
                if (!BtnPageDown.Visible)
                    BtnPageDown.Visible = true;
                LabelPage.Text = string.Format("{0}/{1}",
                (Target.NowIndex / 4 + 1).ToString(),
                (Target.TaskNum % 4 == 0) ? (Target.TaskNum / 4).ToString() : (Target.TaskNum / 4 + 1).ToString());
            }
            else if (NowFocus.GetType().ToString() == "MYTask.ProjPanelContainer")
            {
                ProjPanelContainer Target = (ProjPanelContainer)NowFocus;
                Target.PageUp();
                if (Target.NowIndex <= 0)
                    BtnPageUp.Visible = false;
                if (!BtnPageDown.Visible)
                    BtnPageDown.Visible = true;
                LabelPage.Text = string.Format("{0}/{1}",
                (Target.NowIndex / 12 + 1).ToString(),
                (Target.ProjNum % 12 == 0) ? (Target.ProjNum / 12).ToString() : (Target.ProjNum / 12 + 1).ToString());
            }
                
        }

        private void BtnPageDown_Click(object sender, EventArgs e)
        {
            if (NowFocus.GetType().ToString() == "MYTask.TaskPanelContainer")
            {
                TaskPanelContainer Target = (TaskPanelContainer)NowFocus;
                Target.PageDown();
                if (Target.NowIndex + 4 > Target.TaskNum - 1)
                    BtnPageDown.Visible = false;
                if (!BtnPageUp.Visible)
                    BtnPageUp.Visible = true;
                LabelPage.Text = string.Format("{0}/{1}",
                (Target.NowIndex / 4 + 1).ToString(),
                (Target.TaskNum % 4 == 0) ? (Target.TaskNum / 4).ToString() : (Target.TaskNum / 4 + 1).ToString());
            }
            else if (NowFocus.GetType().ToString() == "MYTask.ProjPanelContainer")
            {
                ProjPanelContainer Target = (ProjPanelContainer)NowFocus;
                Target.PageDown();
                if (Target.NowIndex + 12 > Target.ProjNum - 1)
                    BtnPageDown.Visible = false;
                if (!BtnPageUp.Visible)
                    BtnPageUp.Visible = true;
                LabelPage.Text = string.Format("{0}/{1}",
                (Target.NowIndex / 12 + 1).ToString(),
                (Target.ProjNum % 12 == 0) ? (Target.ProjNum / 12).ToString() : (Target.ProjNum / 12 + 1).ToString());
            }
        }
        
        private void TabsTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FocusTC != TabsTask) return;
            switch (TabsTask.SelectedIndex)
            {
                case 0: { UpdatePageControl(TaskListMy); break; }
                case 1: { UpdatePageControl(TaskListPub); break; }
                case 2: { UpdatePageControl(TaskListAll); break; }
            }
        }

        private void TabsProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FocusTC != TabsProject) return;
            switch (TabsProject.SelectedIndex)
            {
                case 0: { UpdatePageControl(ProjListMy); break; }
                case 1: { UpdatePageControl(ProjListAll); break; }
            }
        }

        private void UpdatePageControl(TaskPanelContainer Target)
        {
            NowFocus = Target;
            BtnPageUp.Visible = (Target.NowIndex <= 0) ? false : true;
            BtnPageDown.Visible = (Target.NowIndex + 4 > Target.TaskNum - 1) ? false : true;
            LabelPage.Text = string.Format("{0}/{1}",
                (Target.NowIndex / 4 + 1).ToString(),
                (Target.TaskNum % 4 == 0) ? (Target.TaskNum / 4).ToString() : (Target.TaskNum / 4 + 1).ToString());
            LabelPage.Visible = true;
        }

        private void UpdatePageControl(ProjPanelContainer Target)
        {
            NowFocus = Target;
            BtnPageUp.Visible = (Target.NowIndex <= 0) ? false : true;
            BtnPageDown.Visible = (Target.NowIndex + 12 > Target.ProjNum - 1) ? false : true;
            LabelPage.Text = string.Format("{0}/{1}",
                (Target.NowIndex / 12 + 1).ToString(),
                (Target.ProjNum % 12 == 0) ? (Target.ProjNum / 12).ToString() : (Target.ProjNum / 12 + 1).ToString());
            LabelPage.Visible = true;
        }

        #endregion

        
    }
}