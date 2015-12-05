using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;

namespace MYTask
{
public partial class FormMain : Form
    {

        private VScrollBar[] ScrollTask = new VScrollBar[3];

        private int TimerSideStat;
        private int TimerLogStat;
        private int dHeight;
        private int dWidth;
        private int LoginStat = 1;  // 0 正常登陆, 1 跳过验证
        private int DBaseStat = -1; // 0 离线数据, 1 在线数据
        private MyUser NowUser = new MyUser();
        private BackgroundWorker m_worker = new BackgroundWorker();
        public MyDB DataBase = new MyDB();
        

        public FormMain()
        {
            InitializeComponent();
            PanelGuide.Location = new Point(-175, 0);
            PanelGuideS.Location = new Point(0, 0);
            PanelLogin.Location = new Point(0, 0);
            PanelProfile.Location = new Point(48, 0);
            TabsTask.Location = new Point(48, 0);
            TabsProject.Location = new Point(48, 0);
            PanelContacts.Location = new Point(48, 0);
            PanelMessages.Location = new Point(48, 0);

            dHeight = Height - PanelGuideS.Height;
            dWidth = Width - PanelProfile.Width - 48;
             
            //跳过登陆面板
            TextLogin_UID.RenewState(3);
            TextLogin_UID.Enter += new EventHandler(LoginBoxGetFocus);
            TextLogin_UID.Leave += new EventHandler(LoginBoxLostFocus);
           
            TextLogin_Psw.RenewState(3);
            TextLogin_Psw.Enter += new EventHandler(LoginBoxGetFocus);
            TextLogin_Psw.Leave += new EventHandler(LoginBoxLostFocus);

            for (int i = 0; i < 3; ++i)
            {
                ScrollTask[i] = new VScrollBar();
                ScrollTask[i].Location = new Point(625, 3);
                ScrollTask[i].Size = new Size(14, 460);
                ScrollTask[i].Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                ScrollTask[i].Maximum = 3;
                ScrollTask[i].Scroll += new ScrollEventHandler(vScroll_Scroll);
                //ScrollTask[i].Resize += new EventHandler(vScroll_Resize);
                ScrollTask[i].Name = "ScrollTask" + i.ToString();

                //ScrollTask[i].Visible = false;
            }

            TaskMy.Controls.Add(ScrollTask[0]);
            TaskPub.Controls.Add(ScrollTask[1]);
            TaskAll.Controls.Add(ScrollTask[2]);


            m_worker.WorkerReportsProgress = true;
            m_worker.WorkerSupportsCancellation = true;
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Form_Lock();
            MinimumSize = Size;
            TextLogin_UID.RenewState(3);
            TextLogin_Psw.RenewState(3);
            CloudStatus.Image = Properties.Resources.Cloud_Connecting_32;
            CloudStatusS.Image = Properties.Resources.Cloud_Connecting_32;
            CloudStatusLogin.Image = Properties.Resources.Cloud_Connecting_32;
            BarConnecting.MarqueeAnimationSpeed = 5;
            SnycProgress.Style = ProgressBarStyle.Marquee;
            SnycProgress.MarqueeAnimationSpeed = 10;
            LabelStatus.Text = "正在连接";

            ScrollTask[0].Resize += new EventHandler(vScroll_Resize);
            ScrollTask[1].Resize += new EventHandler(vScroll_Resize);
            ScrollTask[2].Resize += new EventHandler(vScroll_Resize);

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

        private void Form_Lock()
        {

            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Size = new Size(700 + dWidth, 500 + dHeight);
            MaximizeBox = false;
        }

        private void Form_Unlock()
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            Size = new Size(700 + dWidth, 500 + dHeight);
            MaximizeBox = true;
        }

        private void TestConnect(object sender, DoWorkEventArgs e)
        {
            Action aDelegate = delegate { this.BarConnecting.MarqueeAnimationSpeed = 5; };
            this.BarConnecting.Invoke(aDelegate);
            //BarConnecting.MarqueeAnimationSpeed = 5;

            if (DataBase.Connect()) DBaseStat = DataBase.Online;
            else MessageBox.Show("Error");
        }

        private void RenewDBStat(object sender, RunWorkerCompletedEventArgs e)
        {
            BarConnecting.MarqueeAnimationSpeed = 0;
            BarConnecting.Visible = false;
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

        //<Panel Functions>

        private void TimerSidebar_Tick(object sender, EventArgs e)
        {
            switch (TimerSideStat)
            {
                case 0:
                    {
                        //PanelGuide shows from left
                        int x = PanelGuide.Location.X;
                        PanelGuide.Location = new Point(x + 25, 0);
                        if (PanelGuide.Location.X == 0) TimerSidebar.Stop();
                        break;
                    }
                case 1:
                    {
                        //PanelGuide exit to left
                        int x = PanelGuide.Location.X;
                        PanelGuide.Location = new Point(x - 25, 0);
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
                        if (PanelLogin.Location.Y <= 0)
                        {
                            TimerLogin.Stop();
                            PanelLogin.Location = new Point(0, 0);
                        }
                        break;
                    }
                case 1:
                    {
                        //PanelLogin exit to bottom
                        int y = PanelLogin.Location.Y;
                        PanelLogin.Location = new Point(0, y + 25);
                        if (PanelLogin.Location.Y >= 500)
                        {
                            TimerLogin.Stop();
                            PanelLogin.Location = new Point(0, 500);
                            PanelLogin.Visible = false;
                            Form_Unlock();
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
            GetProfileInfo(tu);
        }

        private void GetProfileInfo(MyUser user)
        {
            ProfileUserName.Text = user.Name;
            ProfileEmail.Text = user.Email;
            ProfileTel.Text = user.Telephone;
        }

        public void InitPanelProfile()
        {
            Panel me = PanelProfile;

            me.Visible = true;
            TabsTask.Visible = false;
            TabsProject.Visible = false;
            PanelContacts.Visible = false;
            PanelMessages.Visible = false;

        }

        private void InitTabsTask()
        {
            TabControl me = TabsTask;
            TabPage met = TaskMy;

            me.Visible = true;
            TabsProject.Visible = false;
            PanelProfile.Visible = false;
            PanelContacts.Visible = false;
            PanelMessages.Visible = false;
        }

        private void InitTabsProject()
        {
            TabControl me = TabsProject;

            me.Visible = true;
            TabsTask.Visible = false;
            PanelProfile.Visible = false;
            PanelContacts.Visible = false;
            PanelMessages.Visible = false;
        }

        private void InitPanelContacts()
        {
            Panel me = PanelContacts;

            me.Visible = true;
            TabsTask.Visible = false;
            TabsProject.Visible = false;
            PanelProfile.Visible = false;
            PanelMessages.Visible = false;
        }

        private void InitPanelMessages()
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
            case 0: {InitPanelProfile(); break;}
            case 1: {InitTabsTask(); break;}
            case 2: {InitTabsProject(); break;}
            case 3: {InitPanelContacts(); break;}
            case 4: {InitPanelMessages(); break;}
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
            GetProfileInfo(NowUser);
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
            InitTabsTask();
            if (LoginStat == 1 && TextLogin_UID.State == 0) TextLogin_UID.Text = "zxt_lyd";
            NowUser = DataBase.GetUser(TextLogin_UID.Text);
            //MessageBox.Show(NowUser.Name);
            BtnProfile.Text = NowUser.Name.Replace(' ', '\n');
            

            AddTaskList(DataBase.GetTaskList(NowUser.UID, 0), 0);
            AddTaskList(DataBase.GetTaskList(NowUser.UID, 1), 1);
            AddTaskList(DataBase.GetTaskList(NowUser.UID, 2), 2);
            //MessageBox.Show(NowUser.Name);
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
            Form_Lock();
            PanelLogin.Location = new Point(0, 500);
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

        private void button2_Click(object sender, EventArgs e)
        {
            AddTaskPanel();
        }
        
        private void AddTaskPanel()
        {
            MyTask t1 = new MyTask();
            t1.InitTestInf();
            TaskListMy.AddTask(t1);
        }

        private void AddTaskList(int[] TidList,int Mode)
        {
            TaskPanelContainer Target;

            if (Mode == 0) Target = TaskListMy;
            else if (Mode == 1) Target = TaskListPub;
            else Target = TaskListAll;

            MyTask Tt = new MyTask();
            for (int i = 0; i < TidList.Length; ++i)
            {
                Tt = DataBase.GetTask(TidList[i]);
                Target.AddTask(Tt);
                ScrollTask[Mode].Maximum = Target.Height > TaskPub.Height ? Target.Height+10 - TaskPub.Height : 0;
                if (Target.Height > TaskPub.Height) ScrollTask[Mode].Visible = true;
            }
        }

        private void vScroll_Scroll(object sender, ScrollEventArgs e)
        {
            VScrollBar Bar = (VScrollBar)sender;
            TaskPanelContainer Target;
            if (Bar.Name == "ScrollTask0") Target = TaskListMy;
            else if (Bar.Name == "ScrollTask1") Target = TaskListPub;
            else Target = TaskListAll;

            Target.Location = new Point(Target.Location.X, 0 - Bar.Value);
        }

        private void vScroll_Resize(object sender, EventArgs e)
        {
            VScrollBar Bar = (VScrollBar)sender;
            TaskPanelContainer Target;
            TabPage Container;
            if (Bar.Name == "ScrollTask0")
            {
                Target = TaskListMy;
                Container = TaskMy;
            }
            else if (Bar.Name == "ScrollTask1")
            {
                Target = TaskListPub;
                Container = TaskPub; 
            }
            else
            {
                Target = TaskListAll;
                Container = TaskAll;
            }

            Bar.Maximum = Target.Height > Container.Height ? Target.Height + 10 - Container.Height : 0;

        }

    }
}
