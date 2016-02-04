using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Resources;
using System.Runtime.InteropServices;

namespace MYTask
{
    [ComVisible(true)]
    public partial class FormMain : Form
    {

        

        private int LoginStat = 1;  // 0 正常登陆, 1 跳过验证
        private string DefaultLoginUserName = "xxb_yyf"; //跳过验证时的用户名
        private int DBaseStat = -1; // 0 离线数据, 1 在线数据
        private int CurrentTaskPage = 1, CurrentProjPage = 1;
        private MyUser NowUser = new MyUser();
        private BackgroundWorker m_worker = new BackgroundWorker();
        private ListViewColumnSorter lvwColumnSorter;
        public MyDB DataBase;
        private object NowFocus;
        private Button FocusBtn = new Button();
        private Button FocusBtnS = new Button();
        private Panel FocusP;
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

            DataBase = new MyDB(this);

            PanelGuide.Location = new Point(0, 32);
            PanelGuide.Hide();
            PanelGuideS.Location = new Point(0, 32);
            PanelLogin.Location = new Point(0, 32);
            PanelUser.Location = new Point(700, 32);
            PanelUser.Visible = false;
            PanelTask.Location = new Point(48, 32);
            PanelProj.Location = new Point(48, 32);
            PanelContacts.Location = new Point(48, 32);
            PanelContacts.BackColor = Color.Gainsboro;
            PanelMessages.Location = new Point(48, 32);
            PanelTaskProfile.Location = new Point(48, 32);
            PSettings.Location = new Point(48, 32);
            PSettings.Hide();

            TaskListPub.Visible = false;
            TaskListAll.Visible = false;
            ProjListAll.Visible = false;

            SF = new ShadowForm(this);
            SF.Show(this);

            
            UIColor_Update(Properties.Settings.Default.UIColorType);
            PTaskBtnSPub.BackColor = Color.Gainsboro;
            PTaskBtnSPub.FlatAppearance.MouseOverBackColor
                = PTaskBtnSPub.FlatAppearance.MouseDownBackColor
                = Theme.MainColor;
            PTaskBtnSAll.BackColor = Color.Gainsboro;
            PTaskBtnSAll.FlatAppearance.MouseOverBackColor
                = PTaskBtnSAll.FlatAppearance.MouseDownBackColor
                = Theme.MainColor;
            PProjBtnSAll.BackColor = Color.Gainsboro;
            PProjBtnSAll.FlatAppearance.MouseOverBackColor
                = PProjBtnSAll.FlatAppearance.MouseDownBackColor
                = Theme.MainColor;

            PanelUser.SetFatherForm(this);
            TaskListMy.SetMainForm(this);
            TaskListPub.SetMainForm(this);
            TaskListAll.SetMainForm(this);
            ProjListMy.SetMainForm(this);
            ProjListAll.SetMainForm(this);
            PanelTaskProfile.SetMainForm(this);
            PanelTaskProfile.TbxRemark.ObjectForScripting = this;

            //dHeight = Height - PanelGuideS.Height;
            //dWidth = Width - PanelProfile.Width - 48;
            
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

        ShadowForm SF;

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
            Win32.AnimateWindow(SF.Handle, 50, Win32.AW_BLEND | Win32.AW_HIDE);
            Win32.AnimateWindow(this.Handle, 50, Win32.AW_BLEND | Win32.AW_HIDE);
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

            if (DBaseStat == 1) DataBase.Close();
            UIColor_Save();
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
            PGuideS_CloudStat.Image = Properties.Resources.Cloud_Connecting_32;
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
        

        #region 颜色设置

        private void UIColor_Update(int ColorType)
        {
            if (ColorType != Theme.ColorType)
                Theme.UpdateColor(ColorType);

            Color main = Theme.MainColor;
            Color over = Theme.MOC;
            Color down = Theme.MDC;


            PanelLogin.BackColor = main;

            UI_SideLeft.BackColor = main;
            UI_SideRight.BackColor = main;
            UI_SideBottom.BackColor = main;
            UI_Caption.BackColor = main;

            BtnProfile.BackColor = main;
            BtnProfile.ActiveLinkColor = down;

            PGuideS_SideRight.BackColor = main;
            UIColor_UpdateButton(PGuideS_BtnCall);
            UIColor_UpdateButton(BtnCallback);

            UIColor_UpdateButton(BtnMin);
            UIColor_UpdateButton(PLogin_BtnLogin);

            PGuide_Side.BackColor = main;
            
            FocusBtn.BackColor
                = FocusBtn.FlatAppearance.MouseDownBackColor
                = FocusBtn.FlatAppearance.MouseOverBackColor
                = over;
            FocusBtnS.BackColor
                = FocusBtnS.FlatAppearance.MouseDownBackColor
                = FocusBtnS.FlatAppearance.MouseOverBackColor
                = over;

            UIColor_UpdatePanel();

            PanelUser.UpdateColor(Theme);
            PanelTaskProfile.UpdateColor(Theme);
        }

        private void UIColor_Update(Color UIC)
        {
            Theme.UpdateColor(UIC);
            UIColor_Update(Theme.ColorType);
        }

        private void UIColor_UpdateButton(Button btn)
        {
            if (btn == null) return;
            btn.BackColor = Theme.MainColor;
            btn.FlatAppearance.MouseDownBackColor = Theme.MDC;
            btn.FlatAppearance.MouseOverBackColor = Theme.MOC;
        }

        private void UIColor_UpdatePanel()
        {
            PTaskBtnSMy.ForeColor = (CurrentTaskPage == 1) ? Color.White : Color.Black;
            PTaskBtnSMy.BackColor = (CurrentTaskPage == 1) ? Theme.MainColor : Color.Gainsboro;
            PTaskBtnSMy.FlatAppearance.MouseDownBackColor = PTaskBtnSMy.FlatAppearance.MouseOverBackColor
                = Theme.MainColor;

            PTaskBtnSPub.ForeColor = (CurrentTaskPage == 2) ? Color.White : Color.Black;
            PTaskBtnSPub.BackColor = (CurrentTaskPage == 2) ? Theme.MainColor : Color.Gainsboro;
            PTaskBtnSPub.FlatAppearance.MouseDownBackColor = PTaskBtnSPub.FlatAppearance.MouseOverBackColor
                = Theme.MainColor;

            PTaskBtnSAll.ForeColor = (CurrentTaskPage == 3) ? Color.White : Color.Black;
            PTaskBtnSAll.BackColor = (CurrentTaskPage == 3) ? Theme.MainColor : Color.Gainsboro;
            PTaskBtnSAll.FlatAppearance.MouseDownBackColor = PTaskBtnSAll.FlatAppearance.MouseOverBackColor
                = Theme.MainColor;

            PProjBtnSMy.ForeColor = (CurrentProjPage == 1) ? Color.White : Color.Black;
            PProjBtnSMy.BackColor = (CurrentProjPage == 1) ? Theme.MainColor : Color.Gainsboro;
            PProjBtnSMy.FlatAppearance.MouseDownBackColor = PProjBtnSMy.FlatAppearance.MouseOverBackColor
                = Theme.MainColor;

            PProjBtnSAll.ForeColor = (CurrentProjPage == 2) ? Color.White : Color.Black;
            PProjBtnSAll.BackColor = (CurrentProjPage == 2) ? Theme.MainColor : Color.Gainsboro;
            PProjBtnSAll.FlatAppearance.MouseDownBackColor = PProjBtnSAll.FlatAppearance.MouseOverBackColor
                = Theme.MainColor;

            TaskListMy.BackColor = Theme.MainColor;
            TaskListPub.BackColor = Theme.MainColor;
            TaskListAll.BackColor = Theme.MainColor;

            ProjListMy.BackColor = Theme.MainColor;
            ProjListAll.BackColor = Theme.MainColor;
        }

        private void UIColor_Save()
        {
            Properties.Settings.Default.UIColorType = Theme.ColorType;
            Properties.Settings.Default.Save();
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
                PGuideS_CloudStat.Image = Properties.Resources.Cloud_Online_32;
                PLogin_PicCloud.Image = Properties.Resources.Cloud_Online_32;
                LabelStatus.Text = "同步完成";
                LabelStatus.Location = new Point(3, CloudStatus.Location.Y + 12);
                SnycProgress.Visible = false;
                PLogin_BtnFindPsw.Visible = true;
            }
            else if (DBaseStat == 0)
            {
                CloudStatus.Image = Properties.Resources.Cloud_Offline_32;
                PGuideS_CloudStat.Image = Properties.Resources.Cloud_Offline_32;
                PLogin_PicCloud.Image = Properties.Resources.Cloud_Offline_32;
                LabelStatus.Text = "离线模式";
                LabelStatus.Location = new Point(3, CloudStatus.Location.Y + 12);
                SnycProgress.Visible = false;
            }
            else
            {
                CloudStatus.Image = Properties.Resources.Cloud_Sync_32;
                PGuideS_CloudStat.Image = Properties.Resources.Cloud_Sync_32;
                PLogin_PicCloud.Image = Properties.Resources.Cloud_Sync_32;
                LabelStatus.Text = "正在同步";
                LabelStatus.Location = new Point(3, CloudStatus.Location.Y);
                SnycProgress.Visible = true;
                SnycProgress.Style = ProgressBarStyle.Marquee;
                SnycProgress.MarqueeAnimationSpeed = 3;
            }

        }
        #endregion

        #region 动画
        private void AsShowFromLeft(Panel Target)
        {
            if (!Target.Visible)
            {
                Animate.AnimateWindow(Target.Handle, 150,
                    Animate.AW_SLIDE |
                    Animate.AW_HOR_POSITIVE);
                Target.Show();
            }
        }
        private void AsHideToLeft(Panel Target)
        {
            if (Target.Visible)
            {
                Animate.AnimateWindow(Target.Handle, 150,
                    Animate.AW_SLIDE |
                    Animate.AW_HOR_NEGATIVE |
                    Animate.AW_HIDE);
                Target.Hide();
            }
        }
        public void AsShowFromBottom(Panel Target)
        {
            if (!Target.Visible)
            {
                Animate.AnimateWindow(Target.Handle, 150,
                    Animate.AW_SLIDE |
                    Animate.AW_VER_NEGATIVE);
                Target.Show();
            }
        }
        public void AsHideToBottom(Panel Target)
        {
            if (Target.Visible)
            {
                Animate.AnimateWindow(Target.Handle, 150,
                    Animate.AW_SLIDE |
                    Animate.AW_VER_POSITIVE |
                    Animate.AW_HIDE);
                Target.Hide();
            }
        }
        public void AsShowFromRight(Panel Target)
        {
            if (!Target.Visible)
            {
                Animate.AnimateWindow(Target.Handle, 150,
                    Animate.AW_SLIDE |
                    Animate.AW_HOR_NEGATIVE);
                Target.Show();
            }
        }
        public void AsHideToRight(Panel Target)
        {
            if (Target.Visible)
            {
                Animate.AnimateWindow(Target.Handle, 150,
                    Animate.AW_SLIDE |
                    Animate.AW_HOR_POSITIVE |
                    Animate.AW_HIDE);
                Target.Hide();
            }
        }

        public void AsShowFromNone(Panel Target)
        {
            if (!Target.Visible)
            {
                Animate.AnimateWindow(Target.Handle, 150,
                    Animate.AW_BLEND);
                Target.Show();
            }
        }
        public void AsShowFromNone(TabControl Target)
        {
            if (!Target.Visible)
            {
                Animate.AnimateWindow(Target.Handle, 150,
                    Animate.AW_BLEND);
                Target.Show();
            }
        }

        private void PUser_Anim_Tick(object sender, EventArgs e)
        {
            if (!PanelUser.Hidden)
            {
                int x = PanelUser.Location.X;
                if (x <= PanelUser.TargetX)
                {
                    PUser_Anim.Stop();
                    PanelUser.Location = new Point(PanelUser.TargetX, 32);
                    return;
                }
                PanelUser.Location = new Point(x - 55, 32);
            }
            else
            {
                int x = PanelUser.Location.X;
                if (x >= PanelUser.TargetX)
                {
                    PUser_Anim.Stop();
                    PanelUser.Location = new Point(PanelUser.TargetX, 32);
                    PanelUser.Visible = false;
                    return;
                }
                PanelUser.Location = new Point(x + 55, 32);
            }
        }

        public void PanelUser_Show()
        {
            if (PanelUser.Visible) return;
            PanelUser.Hidden = false;
            PanelUser.Visible = true;
            PanelUser.TargetX = PanelUser.Location.X - PanelUser.Width;
            PUser_Anim.Start();
        }
        public void PanelUser_Fold()
        {
            if (!PanelUser.Visible) return;
            PanelUser.Hidden = true;
            PanelUser.TargetX = PanelUser.Location.X + PanelUser.Width;
            PUser_Anim.Start();
        }

        #endregion

        #region 面板显示控制
        private void ShowPanelTask()
        {
            FocusP = PanelTask;
            switch (CurrentTaskPage)
            {
                case 1: { UpdatePageControl(TaskListMy); break; }
                case 2: { UpdatePageControl(TaskListPub); break; }
                case 3: { UpdatePageControl(TaskListAll); break; }
            }
            LabelTitle.Text = "WSS - 任务列表";
        }
        private void ShowPanelProj()
        {
            FocusP = PanelProj;
            switch (CurrentProjPage)
            {
                case 1: { UpdatePageControl(ProjListMy); break; }
                case 2: { UpdatePageControl(ProjListAll); break; }
            }
            LabelTitle.Text = "WSS - 项目列表";
        }
        private void ShowPanelContacts()
        {
            PGuideS_BtnPageUp.Visible = false;
            PGuideS_BtnPageDown.Visible = false;
            PGuideS_LabelPage.Visible = false;
            FocusP = PanelContacts;
            LabelTitle.Text = "WSS - 通讯录";
        }
        private void ShowPanelMessages()
        {
            PGuideS_BtnPageUp.Visible = false;
            PGuideS_BtnPageDown.Visible = false;
            PGuideS_LabelPage.Visible = false;
            FocusP = PanelMessages;
            LabelTitle.Text = "WSS - 通知中心";
        }
        private void ShowPanelSettings()
        {
            PGuideS_BtnPageUp.Visible = false;
            PGuideS_BtnPageDown.Visible = false;
            PGuideS_LabelPage.Visible = false;
            FocusP = PSettings;
            LabelTitle.Text = "WSS - 设置中心";
        }
        private void ShowPanelTaskProfile()
        {
            PGuideS_BtnPageUp.Visible = false;
            PGuideS_BtnPageDown.Visible = false;
            PGuideS_LabelPage.Visible = false;
            FocusP = PanelTaskProfile;
            LabelTitle.Text = "WSS - 任务详情";
        }

        private void SelectPanel(int index)
        {
            PanelUser_Fold();
            switch (index)
            {
                case 1: { ShowPanelTask(); break; }
                case 2: { ShowPanelProj(); break; }
                case 3: { ShowPanelContacts(); break; }
                case 4: { ShowPanelMessages(); break; }
                case 5: { ShowPanelSettings(); break; }
                case 6: { ShowPanelTaskProfile(); break; }
            }
            ChangePanelVision(index);
            RenewBtnStyle(index);
        }

        private void ChangePanelVision(int index)
        {
            if (index == 1) PanelTask.Show(); else PanelTask.Hide();
            if (index == 2) PanelProj.Show(); else PanelProj.Hide();
            if (index == 3) PanelContacts.Show(); else PanelContacts.Hide();
            if (index == 4) PanelMessages.Show(); else PanelMessages.Hide();
            if (index == 5) PSettings.Show(); else PSettings.Hide();
            if (index == 6) PanelTaskProfile.Show(); else PanelTaskProfile.Hide();
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
                case 1: { FocusBtn = BtnTask; FocusBtnS = PGuideS_BtnTask; break; }
                case 2: { FocusBtn = BtnProject; FocusBtnS = PGuideS_BtnProject; break; }
                case 3: { FocusBtn = BtnContact; FocusBtnS = PGuideS_BtnContact; break; }
                case 4: { FocusBtn = BtnMessage; FocusBtnS = PGuideS_BtnMessage; break; }
                case 5: { FocusBtn = BtnSettings; FocusBtnS = BtnSettings; break; }
            }
            if (index > 0 && index < 6)
            {
                FocusBtn.BackColor = Theme.MOC;
                FocusBtn.FlatAppearance.MouseOverBackColor = Theme.MOC;
                FocusBtn.FlatAppearance.MouseDownBackColor = Theme.MOC;
                FocusBtnS.BackColor = Theme.MOC;
                FocusBtnS.FlatAppearance.MouseOverBackColor = Theme.MOC;
                FocusBtnS.FlatAppearance.MouseDownBackColor = Theme.MOC;
            }
        }

        public void SetProfilePanel(int uid)
        {
            MyUser tu = new MyUser();
            tu = DataBase.GetUser(uid);
            PanelUser.SetProfileInfo(tu, (tu == NowUser || NowUser.Rank == 5) ? 1 : 0);
        }

        public void SetPanelTP(MyTask Task)
        {
            PanelTaskProfile.SetNewTask(Task);
            SelectPanel(6);
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

        #region 列表窗格切换控制

        private void PTaskBtnS_Click(object sender, EventArgs e)
        {
            Button A = sender as Button;
            if (A.Name == "PTaskBtnSMy") SwitchTaskPage(1);
            else if (A.Name == "PTaskBtnSPub") SwitchTaskPage(2);
            else SwitchTaskPage(3);
        }

        private void PProjBtnS_Click(object sender, EventArgs e)
        {
            Button A = sender as Button;
            if (A.Name == "PProjBtnSMy") SwitchProjPage(1);
            else SwitchProjPage(2);
        }

        private void SwitchTaskPage(int newPgNum)
        {
            if (CurrentTaskPage == newPgNum) return;
            TaskListMy.Visible = (newPgNum == 1) ? true : false;
            TaskListPub.Visible = (newPgNum == 2) ? true : false;
            TaskListAll.Visible = (newPgNum == 3) ? true : false;
            Button OldBtn, NewBtn;
            if (CurrentTaskPage == 1) OldBtn = PTaskBtnSMy;
            else if (CurrentTaskPage == 2) OldBtn = PTaskBtnSPub;
            else OldBtn = PTaskBtnSAll;
            OldBtn.BackColor = Color.Gainsboro;
            OldBtn.FlatAppearance.MouseDownBackColor
                = OldBtn.FlatAppearance.MouseOverBackColor
                = Theme.MainColor;
            OldBtn.ForeColor = Color.Black;
            if (newPgNum == 1)
            {
                NewBtn = PTaskBtnSMy;
                UpdatePageControl(TaskListMy);
            }
            else if (newPgNum == 2)
            {
                NewBtn = PTaskBtnSPub;
                UpdatePageControl(TaskListPub);
            }
            else
            {
                NewBtn = PTaskBtnSAll;
                UpdatePageControl(TaskListAll);
            }
            NewBtn.BackColor
                = NewBtn.FlatAppearance.MouseDownBackColor
                = NewBtn.FlatAppearance.MouseOverBackColor
                = Theme.MainColor;
            NewBtn.ForeColor = Color.White;
            CurrentTaskPage = newPgNum;
        }

        private void SwitchProjPage(int newPgNum)
        {
            if (CurrentProjPage == newPgNum) return;
            ProjListMy.Visible = (newPgNum == 1) ? true : false;
            ProjListAll.Visible = (newPgNum == 2) ? true : false;
            Button OldBtn, NewBtn;
            if (CurrentProjPage == 1) OldBtn = PProjBtnSMy;
            else OldBtn = PProjBtnSAll;
            OldBtn.BackColor = Color.Gainsboro;
            OldBtn.FlatAppearance.MouseDownBackColor
                = OldBtn.FlatAppearance.MouseOverBackColor
                = Theme.MainColor;
            OldBtn.ForeColor = Color.Black;
            if (newPgNum == 1)
            {
                NewBtn = PProjBtnSMy;
                UpdatePageControl(ProjListMy);
            }
            else
            {
                NewBtn = PProjBtnSAll;
                UpdatePageControl(ProjListAll);
            }
            NewBtn.BackColor
                = NewBtn.FlatAppearance.MouseDownBackColor
                = NewBtn.FlatAppearance.MouseOverBackColor
                = Theme.MainColor;
            NewBtn.ForeColor = Color.White;
            CurrentProjPage = newPgNum;
        }

        #endregion



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
        
        private void BtnCall_Click(object sender, EventArgs e)
        {
            if (PanelGuide.Visible)
                AsHideToLeft(PanelGuide);
            else
                AsShowFromLeft(PanelGuide);
        }
        private void BtnProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AsHideToLeft(PanelGuide);
            PanelUser.SetProfileInfo(NowUser, 1);
            PanelUser_Show();
        }
        private void BtnTask_Click(object sender, EventArgs e)
        {
            SelectPanel(1);
            AsHideToLeft(PanelGuide);
        }
        private void BtnProject_Click(object sender, EventArgs e)
        {
            SelectPanel(2);
            AsHideToLeft(PanelGuide);
        }

        private void BtnContact_Click(object sender, EventArgs e)
        {
            SelectPanel(3);
            AsHideToLeft(PanelGuide);
        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
            SelectPanel(4);
            AsHideToLeft(PanelGuide);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SelectPanel(5);
            AsHideToLeft(PanelGuide);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            AsHideToLeft(PanelGuide);
            Logout();
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

            if (LoginStat == 1 && PLogin_TextUID.State == 0) PLogin_TextUID.Text = DefaultLoginUserName;
            NowUser = DataBase.GetUser(PLogin_TextUID.Text);
            //MessageBox.Show(NowUser.Name);
            BtnProfile.Text = NowUser.Name.Replace(' ', '\n');


            AddTaskList(DataBase.GetTaskList(NowUser.UID, 0), 0);
            AddTaskList(DataBase.GetTaskList(NowUser.UID, 1), 1);
            AddProjList(DataBase.GetProjList(NowUser.UID), 0);
            AddMessList(DataBase.GetMessList(NowUser.UID));

            TaskListAll.RenewTaskPage(0);
            UpdatePageControl(TaskListMy);

            FocusBtnS = PGuideS_BtnTask;
            FocusBtnS.BackColor = Theme.MOC;
            FocusBtnS.FlatAppearance.MouseOverBackColor = Theme.MOC;
            FocusBtnS.FlatAppearance.MouseDownBackColor = Theme.MOC;

            FocusBtn = BtnTask;
            FocusBtn.BackColor = Theme.MOC;
            FocusBtn.FlatAppearance.MouseOverBackColor = Theme.MOC;
            FocusBtn.FlatAppearance.MouseDownBackColor = Theme.MOC;

            SelectPanel(1);

            LabelTitle.Text = "WSS - 任务列表";
            AsHideToBottom(PanelLogin);
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
            
            InitLoginBox("");
            LabelTitle.Text = "WSS - 登录";
            AsShowFromBottom(PanelLogin);
            TaskListMy.ClearTask();
            TaskListPub.ClearTask();
            ProjListMy.ClearProj();
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
            PanelUser_Show();
        }

        private void MessList_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem target = MessList.SelectedItems[0];
            MessageBox.Show(target.SubItems[1].Text);
            
        }


        #region 翻页控制
        private void BtnPageUp_Click(object sender, EventArgs e)
        {
            if (NowFocus.GetType().ToString() == "MYTask.TaskPanelContainer")
            {
                TaskPanelContainer Target = (TaskPanelContainer)NowFocus;
                Target.PageUp();
                if (Target.NowIndex <= 0)
                    PGuideS_BtnPageUp.Visible = false;
                if (!PGuideS_BtnPageDown.Visible)
                    PGuideS_BtnPageDown.Visible = true;
                PGuideS_LabelPage.Text = string.Format("{0}/{1}",
                (Target.NowIndex / 4 + 1).ToString(),
                (Target.TaskNum % 4 == 0) ? (Target.TaskNum / 4).ToString() : (Target.TaskNum / 4 + 1).ToString());
            }
            else if (NowFocus.GetType().ToString() == "MYTask.ProjPanelContainer")
            {
                ProjPanelContainer Target = (ProjPanelContainer)NowFocus;
                Target.PageUp();
                if (Target.NowIndex <= 0)
                    PGuideS_BtnPageUp.Visible = false;
                if (!PGuideS_BtnPageDown.Visible)
                    PGuideS_BtnPageDown.Visible = true;
                PGuideS_LabelPage.Text = string.Format("{0}/{1}",
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
                    PGuideS_BtnPageDown.Visible = false;
                if (!PGuideS_BtnPageUp.Visible)
                    PGuideS_BtnPageUp.Visible = true;
                PGuideS_LabelPage.Text = string.Format("{0}/{1}",
                (Target.NowIndex / 4 + 1).ToString(),
                (Target.TaskNum % 4 == 0) ? (Target.TaskNum / 4).ToString() : (Target.TaskNum / 4 + 1).ToString());
            }
            else if (NowFocus.GetType().ToString() == "MYTask.ProjPanelContainer")
            {
                ProjPanelContainer Target = (ProjPanelContainer)NowFocus;
                Target.PageDown();
                if (Target.NowIndex + 12 > Target.ProjNum - 1)
                    PGuideS_BtnPageDown.Visible = false;
                if (!PGuideS_BtnPageUp.Visible)
                    PGuideS_BtnPageUp.Visible = true;
                PGuideS_LabelPage.Text = string.Format("{0}/{1}",
                (Target.NowIndex / 12 + 1).ToString(),
                (Target.ProjNum % 12 == 0) ? (Target.ProjNum / 12).ToString() : (Target.ProjNum / 12 + 1).ToString());
            }
        }
        
        private void UpdatePageControl(TaskPanelContainer Target)
        {
            NowFocus = Target;
            PGuideS_BtnPageUp.Visible = (Target.NowIndex <= 0) ? false : true;
            PGuideS_BtnPageDown.Visible = (Target.NowIndex + 4 > Target.TaskNum - 1) ? false : true;
            PGuideS_LabelPage.Text = string.Format("{0}/{1}",
                (Target.NowIndex / 4 + 1).ToString(),
                (Target.TaskNum % 4 == 0) ? (Target.TaskNum / 4).ToString() : (Target.TaskNum / 4 + 1).ToString());
            PGuideS_LabelPage.Visible = true;
        }

        private void UpdatePageControl(ProjPanelContainer Target)
        {
            NowFocus = Target;
            PGuideS_BtnPageUp.Visible = (Target.NowIndex <= 0) ? false : true;
            PGuideS_BtnPageDown.Visible = (Target.NowIndex + 12 > Target.ProjNum - 1) ? false : true;
            PGuideS_LabelPage.Text = string.Format("{0}/{1}",
                (Target.NowIndex / 12 + 1).ToString(),
                (Target.ProjNum % 12 == 0) ? (Target.ProjNum / 12).ToString() : (Target.ProjNum / 12 + 1).ToString());
            PGuideS_LabelPage.Visible = true;
        }




        #endregion


        #region 设置面板
        private void PSet_BtnClr_Click(object sender, EventArgs e)
        {
            Button Res = (Button)sender;
            if (Res.Name == "PSet_BtnClr1") UIColor_Update(1);
            else if (Res.Name == "PSet_BtnClr2") UIColor_Update(2);
            else if (Res.Name == "PSet_BtnClr3") UIColor_Update(3);
            else if (Res.Name == "PSet_BtnClr4") UIColor_Update(4);
            else if (Res.Name == "PSet_BtnClr5") UIColor_Update(5);
            else if (Res.Name == "PSet_BtnClr6") UIColor_Update(6);
        }
        #endregion

    }
}