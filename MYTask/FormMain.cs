using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Runtime.InteropServices;

namespace MYTask
{
    public partial class FormMain : Form
    {
        private int TimerSideStat;
        private int TimerLogStat;
        private int dHeight;
        private int dWidth;
        private int LoginStat = 1;  // 0 正常登陆, 1 跳过验证
        private int DBaseStat = -1; // 0 离线数据, 1 在线数据
        private MyUser NowUser = new MyUser();
        private BackgroundWorker m_worker = new BackgroundWorker();
        private ListViewColumnSorter lvwColumnSorter;
        public MyDB DataBase = new MyDB();
        private object NowFocus;

        private delegate void BGAddTaskList(MyTask[] Tlist, int Mode);
        private delegate void BGAddUserList(MyUser[] Ulist);
        private delegate void BGWorkComplete(object sender, DoWorkEventArgs e);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        //常数
        public const int WM_SYSCOMMAND = 0x0112;
        //窗体移动
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        //窗体最小化
        public const int SC_MINIMIZE = 0xF020;
        public FormMain()
        {
            InitializeComponent();
            PanelGuide.Location = new Point(-175, 32);
            PanelGuideS.Location = new Point(0, 32);
            PanelLogin.Location = new Point(0, 32);
            PanelProfile.Location = new Point(48, 32);
            TabsTask.Location = new Point(48, 32);
            TabsProject.Location = new Point(48, 32);
            PanelContacts.Location = new Point(48, 32);
            PanelContacts.BackColor = Color.Gainsboro;
            PanelMessages.Location = new Point(48, 32);

            dHeight = Height - PanelGuideS.Height;
            dWidth = Width - PanelProfile.Width - 48;

            //跳过登陆面板
            TextLogin_UID.RenewState(3);
            TextLogin_UID.Enter += new EventHandler(LoginBoxGetFocus);
            TextLogin_UID.Leave += new EventHandler(LoginBoxLostFocus);

            TextLogin_Psw.RenewState(3);
            TextLogin_Psw.Enter += new EventHandler(LoginBoxGetFocus);
            TextLogin_Psw.Leave += new EventHandler(LoginBoxLostFocus);

            lvwColumnSorter = new ListViewColumnSorter();
            ContactList.ListViewItemSorter = lvwColumnSorter;

            m_worker.WorkerReportsProgress = true;
            m_worker.WorkerSupportsCancellation = true;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Form_Lock();
            //MinimumSize = Size;
            TextLogin_UID.RenewState(3);
            TextLogin_Psw.RenewState(3);
            CloudStatus.Image = Properties.Resources.Cloud_Connecting_32;
            CloudStatusS.Image = Properties.Resources.Cloud_Connecting_32;
            CloudStatusLogin.Image = Properties.Resources.Cloud_Connecting_32;
            BarConnecting.MarqueeAnimationSpeed = 5;
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

        private void FormMain_Resize(object sender, EventArgs e)
        {
            //dHeight = Height - PanelGuideS.Height;
            PanelGuide.Height = PanelGuideS.Height;
        }

        private void TestConnect(object sender, DoWorkEventArgs e)
        {
            Action aDelegate = delegate { this.BarConnecting.MarqueeAnimationSpeed = 5; };
            this.BarConnecting.Invoke(aDelegate);
            //BarConnecting.MarqueeAnimationSpeed = 5;

            if (DataBase.Connect())
            {
                DBaseStat = DataBase.Online;
            }
            else MessageBox.Show("无法连接到数据库：请检查文件是否完整");
        }

        private void RenewDBStat(object sender, RunWorkerCompletedEventArgs e)
        {
            BarConnecting.MarqueeAnimationSpeed = 0;
            BarConnecting.Visible = false;
            m_worker.DoWork -= new DoWorkEventHandler(TestConnect);
            m_worker.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(RenewDBStat);
            m_worker.DoWork += new DoWorkEventHandler(InitList);
            m_worker.RunWorkerAsync();
            if (DBaseStat == 1)
            {
                CloudStatus.Image = Properties.Resources.Cloud_Online_32;
                CloudStatusS.Image = Properties.Resources.Cloud_Online_32;
                CloudStatusLogin.Image = Properties.Resources.Cloud_Online_32;
                LabelStatus.Text = "同步完成";
                LabelStatus.Location = new Point(3, CloudStatus.Location.Y + 12);
                SnycProgress.Visible = false;
                BtnFindPsw.Visible = true;
            }
            else if (DBaseStat == 0)
            {
                CloudStatus.Image = Properties.Resources.Cloud_Offline_32;
                CloudStatusS.Image = Properties.Resources.Cloud_Offline_32;
                CloudStatusLogin.Image = Properties.Resources.Cloud_Offline_32;
                LabelStatus.Text = "离线模式";
                LabelStatus.Location = new Point(3, CloudStatus.Location.Y + 12);
                SnycProgress.Visible = false;
            }
            else
            {
                CloudStatus.Image = Properties.Resources.Cloud_Sync_32;
                CloudStatusS.Image = Properties.Resources.Cloud_Sync_32;
                CloudStatusLogin.Image = Properties.Resources.Cloud_Sync_32;
                LabelStatus.Text = "正在同步";
                LabelStatus.Location = new Point(3, CloudStatus.Location.Y);
                SnycProgress.Visible = true;
                SnycProgress.Style = ProgressBarStyle.Marquee;
                SnycProgress.MarqueeAnimationSpeed = 3;
            }

        }

        private void InitList(object sender, DoWorkEventArgs e)
        {
            if (ContactList.InvokeRequired)
            {
                BGWorkComplete BGWC = new BGWorkComplete(InitList);
                Invoke(BGWC, sender, e);
                return;
            }


            AddTaskList(DataBase.GetTaskList(), 2);
            //MessageBox.Show("TasklistDone");
            AddUserList(DataBase.GetUserList());
            LabelBlock.Visible = false;
        }


        //<Panel Functions>

        private void TimerSidebar_Tick(object sender, EventArgs e)
        {
            switch (TimerSideStat)
            {
                case 0:
                    {
                        //PanelGuide shows from left
                        int x = PanelGuide.Location.X;
                        PanelGuide.Location = new Point(x + 25, 32);
                        if (PanelGuide.Location.X == 0) TimerSidebar.Stop();
                        break;
                    }
                case 1:
                    {
                        //PanelGuide exit to left
                        int x = PanelGuide.Location.X;
                        PanelGuide.Location = new Point(x - 25, 32);
                        if (PanelGuide.Location.X == -175) TimerSidebar.Stop();
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
                        PanelLogin.Location = new Point(0, y - 25);
                        if (PanelLogin.Location.Y <= 32)
                        {
                            TimerLogin.Stop();
                            PanelLogin.Location = new Point(0, 32);
                        }
                        break;
                    }
                case 1:
                    {
                        //PanelLogin exit to bottom
                        int y = PanelLogin.Location.Y;
                        PanelLogin.Location = new Point(0, y + 25);
                        if (PanelLogin.Location.Y >= this.Height)
                        {
                            TimerLogin.Stop();
                            PanelLogin.Location = new Point(0, this.Height);
                            PanelLogin.Visible = false;
                            //Form_Unlock();
                        }
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

        public void SetProfilePanel(int uid)
        {
            MyUser tu = new MyUser();
            tu = DataBase.GetUser(uid);
            PanelProfile.SetProfileInfo(tu, (tu == NowUser || NowUser.Rank == 5) ? 1 : 0);
        }

        public void ShowPanelProfile()
        {
            Panel me = PanelProfile;

            me.Visible = true;
            TabsTask.Visible = false;
            TabsProject.Visible = false;
            PanelContacts.Visible = false;
            PanelMessages.Visible = false;

        }

        private void ShowTabsTask()
        {
            TabControl me = TabsTask;
            TabPage met = TaskMy;

            me.Visible = true;
            TabsProject.Visible = false;
            PanelProfile.Visible = false;
            PanelContacts.Visible = false;
            PanelMessages.Visible = false;
        }

        private void ShowTabsProject()
        {
            TabControl me = TabsProject;

            me.Visible = true;
            TabsTask.Visible = false;
            PanelProfile.Visible = false;
            PanelContacts.Visible = false;
            PanelMessages.Visible = false;
        }

        private void ShowPanelContacts()
        {
            Panel me = PanelContacts;

            me.Visible = true;
            TabsTask.Visible = false;
            TabsProject.Visible = false;
            PanelProfile.Visible = false;
            PanelMessages.Visible = false;
        }

        private void ShowPanelMessages()
        {
            Panel me = PanelMessages;

            me.Visible = true;
            TabsTask.Visible = false;
            TabsProject.Visible = false;
            PanelContacts.Visible = false;
            PanelProfile.Visible = false;
        }

        private void SelectPanel(int index)
        {
            switch (index)
            {
                case 0: { ShowPanelProfile(); break; }
                case 1: { ShowTabsTask(); break; }
                case 2: { ShowTabsProject(); break; }
                case 3: { ShowPanelContacts(); break; }
                case 4: { ShowPanelMessages(); break; }
            }
        }

        private void BtnCall_Click(object sender, EventArgs e)
        {
            if (PanelGuide.Location.X < 0) TimerSideStat = 0;
            else TimerSideStat = 1;
            TimerSidebar.Start();
        }

        //<LoginBox Operations>

        public void InitLoginBox(string uid)
        {
            TextLogin_UID.RenewState(0);
            TextLogin_Psw.RenewState(0);
            if (uid == "") TextLogin_UID.Text = "用户名";
            else TextLogin_UID.Text = uid;
            TextLogin_Psw.UseSystemPasswordChar = false;
            TextLogin_Psw.Text = "密码";
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

        //</LoginBox Operations>

        private void BtnTask_Click(object sender, EventArgs e)
        {
            FoldSideBar();
            SelectPanel(1);
        }

        private void BtnProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FoldSideBar();
            PanelProfile.SetProfileInfo(NowUser,1);
            SelectPanel(0);
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

        public void Login()
        {
            if (LoginStat == 1) goto Success;

            //检测用户是否输入完整信息
            bool flag = true;
            if (TextLogin_UID.State != 1)
            {
                TextLogin_UID.RenewState(2);
                TextLogin_UID.Text = "请输入用户名";
                flag = false;
            }
            if (TextLogin_Psw.State != 1)
            {
                TextLogin_Psw.RenewState(2);
                TextLogin_Psw.Text = "请输入密码";
                flag = false;
            }
            if (!flag) return;

            //获取字符串值进行比对
            string UserID = TextLogin_UID.Text;
            string UserP = TextLogin_Psw.Text;
            PswString Psw = new PswString(UserP);
            string DBPsw = DataBase.GetUserPsw(UserID);
            //MessageBox.Show(DBPsw + "\n" + Psw.MD64);

            //数据库无用户名记录
            if (DBPsw == "@@@@")
            {
                BtnLogin.Focus();
                TextLogin_UID.RenewState(2);
                TextLogin_UID.Text = "用户不存在";
                TextLogin_Psw.RenewState(0);
                TextLogin_Psw.Text = "密码";
                return;
            }

            //密码不匹配
            if (DBPsw != Psw.MD64)
            {
                BtnLogin.Focus();
                TextLogin_Psw.RenewState(2);
                TextLogin_Psw.Text = "密码错误";
                return;
            }

        Success:  //成功登陆
            ShowTabsTask();
            if (LoginStat == 1 && TextLogin_UID.State == 0) TextLogin_UID.Text = "zxt_lyd";
            NowUser = DataBase.GetUser(TextLogin_UID.Text);
            //MessageBox.Show(NowUser.Name);
            BtnProfile.Text = NowUser.Name.Replace(' ', '\n');


            AddTaskList(DataBase.GetTaskList(NowUser.UID, 0), 0);
            AddTaskList(DataBase.GetTaskList(NowUser.UID, 1), 1);
            //MessageBox.Show(NowUser.Name);
            TimerLogStat = 1;
            TimerLogin.Start();
            NowFocus = TaskMy;
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
            //Form_Lock();
            PanelLogin.Location = new Point(0, this.Height);
            PanelLogin.Visible = true;
            InitLoginBox("");
            TaskListMy.ClearTask();
            TaskListPub.ClearTask();
            TimerLogStat = 0;
            TimerLogin.Start();

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FoldSideBar();
            Logout();
        }

        private void BtnFindPsw_Click(object sender, EventArgs e)
        {

        }

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
            ShowPanelProfile();
        }

        private void UI_Caption_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MINIMIZE, 0);
        }

        private void BtnPageUp_Click(object sender, EventArgs e)
        {
            TaskListAll.TaskPageUp();
        }

        private void BtnPageDown_Click(object sender, EventArgs e)
        {
            TaskListAll.TaskPageDown();
        }
       
    }
}