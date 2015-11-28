﻿using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;

namespace MYTask
{
    public partial class FormMain : Form
    {

        private int TimerComStat;
        private int dHeight;
        private int dWidth;
        private int LoginStat = 1;
        private int DBaseStat = -1; // 0 for offline, 1 for online
        private BackgroundWorker m_worker = new BackgroundWorker();
        MyDB DataBase = new MyDB();

        public FormMain()
        {
            InitializeComponent();
            PanelGuide.Location = new Point(-175, 0);
            PanelGuideS.Location = new Point(0, 0);
            PanelLogin.Location = new Point(0, 0);
            dHeight = Height - PanelGuideS.Height;
            dWidth = Width - PanelProfile.Width - 48;
            TextLogin_UID.RenewState(3);
            TextLogin_Psw.RenewState(3);
            m_worker.WorkerReportsProgress = true;
            m_worker.WorkerSupportsCancellation = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Form_Lock();
            MinimumSize = Size;
            TextLogin_UID.RenewState(3);
            TextLogin_Psw.RenewState(3);
            /*Thread ConTh = new Thread(new ThreadStart(TestConnect));
            ConTh.IsBackground = true;
            ConTh.Start();*/
            m_worker.DoWork += new DoWorkEventHandler(TestConnect);
            m_worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(RenewDBStat);
            m_worker.RunWorkerAsync();

            InitLoginBox("");
        }

        private void FormMain_Unload(object sender, EventArgs e)
        {
            if (DBaseStat == 1) DataBase.Close();
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
            if (!DataBase.Connect()) DBaseStat = 0;
            else DBaseStat = 1;
        }
        

        private void RenewDBStat(object sender, RunWorkerCompletedEventArgs e)
        {
            BarConnecting.MarqueeAnimationSpeed = 0;
            BarConnecting.Visible = false;
            if (DBaseStat == 1)
            {
                CloudStatus.Image = Properties.Resources.Cloud_Online;
                CloudStatusS.Image = Properties.Resources.Cloud_Online;
                CloudStatusLogin.Image = Properties.Resources.Cloud_Online;
                LabelStatus.Text = "同步完成";
                LabelStatus.Location = new Point(3, CloudStatus.Location.Y + 12);
                SnycProgress.Visible = false;
                BtnFindPsw.Visible = true;
            }
            else
            {
                CloudStatus.Image = Properties.Resources.Cloud_Offline;
                CloudStatusS.Image = Properties.Resources.Cloud_Offline;
                CloudStatusLogin.Image = Properties.Resources.Cloud_Offline;
                LabelStatus.Text = "离线模式";
                LabelStatus.Location = new Point(3, CloudStatus.Location.Y + 12);
                SnycProgress.Visible = false;
            }
        }

        //<Panel Functions>

        private void TimerCom_Tick(object sender, EventArgs e)
        {            
            switch (TimerComStat) {
                case 0: {
                        //PanelGuide shows from left
                        int x = PanelGuide.Location.X;
                        PanelGuide.Location = new Point(x + 25, 0);
                        if (PanelGuide.Location.X == 0) TimerCom.Stop();
                        break;
                    }
                case 1: {
                        //PanelGuide exit to left
                        int x = PanelGuide.Location.X;
                        PanelGuide.Location = new Point(x - 25, 0);
                        if (PanelGuide.Location.X == -175) TimerCom.Stop();
                        break;
                    }
                case 2:
                    {
                        //PanelLogin shows from bottom
                        int y = PanelLogin.Location.Y;
                        PanelLogin.Location = new Point(0, y - 25);
                        if (PanelLogin.Location.Y <=0){
                            TimerCom.Stop();
                            PanelLogin.Location = new Point(0, 0);
                        }
                        break;
                    }
                case 3:
                    {
                        //PanelLogin exit to bottom
                        int y = PanelLogin.Location.Y;
                        PanelLogin.Location = new Point(0, y + 25);
                        if (PanelLogin.Location.Y >= 500)
                        {
                            TimerCom.Stop();
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
                TimerComStat = 1;
                TimerCom.Start();
            }
        }

        private void InitPanelProfile()
        {
            Panel me = PanelProfile;

            me.Visible = true;
            TabsTask.Visible = false;
            TabsProject.Visible = false;
            PanelContacts.Visible = false;
            PanelMessages.Visible = false;

            me.Location = new Point(48, 0);

        }

        private void InitTabsTask()
        {
            TabControl me = TabsTask;

            me.Visible = true;
            TabsProject.Visible = false;
            PanelProfile.Visible = false;
            PanelContacts.Visible = false;
            PanelMessages.Visible = false;

            me.Location = new Point(48, 0);
        }

        private void InitTabsProject()
        {
            TabControl me = TabsProject;

            me.Visible = true;
            TabsTask.Visible = false;
            PanelProfile.Visible = false;
            PanelContacts.Visible = false;
            PanelMessages.Visible = false;

            me.Location = new Point(48, 0);
        }

        private void InitPanelContacts()
        {
            Panel me = PanelContacts;

            me.Visible = true;
            TabsTask.Visible = false;
            TabsProject.Visible = false;
            PanelProfile.Visible = false;
            PanelMessages.Visible = false;

            me.Location = new Point(48, 0);
        }

        private void InitPanelMessages()
        {
            Panel me = PanelMessages;

            me.Visible = true;
            TabsTask.Visible = false;
            TabsProject.Visible = false;
            PanelContacts.Visible = false;
            PanelProfile.Visible = false;

            me.Location = new Point(48, 0);
        }

        private void SelectPanel(int index)
        {
            switch (index)
            {
                case 0:{InitPanelProfile();break;}
                case 1:{InitTabsTask();break;}
                case 2:{InitTabsProject();break;}
                case 3:{InitPanelContacts();break;}
                case 4:{InitPanelMessages();break;}
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            //dHeight = Height - PanelGuideS.Height;
            PanelGuide.Height = PanelGuideS.Height;
        }

        private void BtnCall_Click(object sender, EventArgs e)
        {
            if (PanelGuide.Location.X < 0) TimerComStat = 0;
            else TimerComStat = 1;
            TimerCom.Start();
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
            tbx.RenewState(1);
            tbx.Text = "";
            if (tbx.Name == "TextLogin_Psw") tbx.UseSystemPasswordChar = true;
        }

        private void LoginBoxLostFocus(object sender, EventArgs e)
        {
            LoginTextbox tbx = (LoginTextbox)sender;
            if (tbx.Text != "") return;
            tbx.RenewState(0);
            if (tbx.Name == "TextLogin_UID") tbx.Text = "用户名";
            else {
                tbx.Text = "密码";
                tbx.UseSystemPasswordChar = false;
            }
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

            string UserID = TextLogin_UID.Text;
            string UserP = TextLogin_Psw.Text;
            PswString Psw = new PswString(UserP);

            
            

        //TODO: Add login codes.

        // if login successful::
        Success:
            InitTabsTask();
            TimerComStat = 3;
            TimerCom.Start();
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
            TimerComStat = 2;
            TimerCom.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logout();
        }

        



        

        private void BtnFindPsw_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task Ta = new Task();
            TaskPanel p1 = new TaskPanel(3, TaskPanelFlow.Width-12,Ta);
            TaskPanelFlow.Controls.Add(p1);
        }
        
    }
}