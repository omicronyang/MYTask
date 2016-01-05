using System.Windows.Forms;
namespace MYTask
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelGuide = new System.Windows.Forms.Panel();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnCallback = new System.Windows.Forms.Button();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.BtnContact = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.LinkLabel();
            this.CloudStatus = new System.Windows.Forms.PictureBox();
            this.SnycProgress = new System.Windows.Forms.ProgressBar();
            this.BtnMessage = new System.Windows.Forms.Button();
            this.BtnProject = new System.Windows.Forms.Button();
            this.BtnTask = new System.Windows.Forms.Button();
            this.PanelGuideS = new System.Windows.Forms.Panel();
            this.LabelPage = new System.Windows.Forms.Label();
            this.BtnPageDown = new System.Windows.Forms.Button();
            this.BtnPageUp = new System.Windows.Forms.Button();
            this.BtnMessageS = new System.Windows.Forms.Button();
            this.CloudStatusS = new System.Windows.Forms.PictureBox();
            this.BtnCall = new System.Windows.Forms.Button();
            this.BtnContactS = new System.Windows.Forms.Button();
            this.BtnProjectS = new System.Windows.Forms.Button();
            this.BtnTaskS = new System.Windows.Forms.Button();
            this.TimerSidebar = new System.Windows.Forms.Timer(this.components);
            this.TabsTask = new System.Windows.Forms.TabControl();
            this.TaskMy = new System.Windows.Forms.TabPage();
            this.TaskPub = new System.Windows.Forms.TabPage();
            this.TaskAll = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelFromUserName = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelUpdateTime = new System.Windows.Forms.Label();
            this.LabelEndTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelStat = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelPI = new System.Windows.Forms.Label();
            this.LabelPT = new System.Windows.Forms.Label();
            this.LabelTaskName = new System.Windows.Forms.LinkLabel();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.PLogin_LabelBlock = new System.Windows.Forms.Label();
            this.PLogin_PicLogo = new System.Windows.Forms.PictureBox();
            this.PLogin_PicCloud = new System.Windows.Forms.PictureBox();
            this.PLogin_BarConnecting = new System.Windows.Forms.ProgressBar();
            this.PLogin_BtnFindPsw = new System.Windows.Forms.Button();
            this.PLogin_BtnLogin = new System.Windows.Forms.Button();
            this.TabsProject = new System.Windows.Forms.TabControl();
            this.ProjMy = new System.Windows.Forms.TabPage();
            this.ProjAll = new System.Windows.Forms.TabPage();
            this.PanelContacts = new System.Windows.Forms.Panel();
            this.PanelMessages = new System.Windows.Forms.Panel();
            this.LabelMessageLabel = new System.Windows.Forms.Label();
            this.TimerLogin = new System.Windows.Forms.Timer(this.components);
            this.UI_Caption = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TimerUser = new System.Windows.Forms.Timer(this.components);
            this.PLogin_TextPsw = new MYTask.LoginTextbox();
            this.PLogin_TextUID = new MYTask.LoginTextbox();
            this.PanelUser = new MYTask.UserProfilePanel();
            this.TaskListMy = new MYTask.TaskPanelContainer();
            this.TaskListPub = new MYTask.TaskPanelContainer();
            this.TaskListAll = new MYTask.TaskPanelContainer();
            this.ProjListMy = new MYTask.ProjPanelContainer();
            this.ProjListAll = new MYTask.ProjPanelContainer();
            this.ContactList = new MYTask.UserList();
            this.MessList = new MYTask.MessageList();
            this.AnnList = new MYTask.AnnounceList();
            this.PanelGuide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloudStatus)).BeginInit();
            this.PanelGuideS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloudStatusS)).BeginInit();
            this.TabsTask.SuspendLayout();
            this.TaskMy.SuspendLayout();
            this.TaskPub.SuspendLayout();
            this.TaskAll.SuspendLayout();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PLogin_PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLogin_PicCloud)).BeginInit();
            this.TabsProject.SuspendLayout();
            this.ProjMy.SuspendLayout();
            this.ProjAll.SuspendLayout();
            this.PanelContacts.SuspendLayout();
            this.PanelMessages.SuspendLayout();
            this.UI_Caption.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGuide
            // 
            this.PanelGuide.BackColor = System.Drawing.Color.LightGray;
            this.PanelGuide.Controls.Add(this.BtnSettings);
            this.PanelGuide.Controls.Add(this.BtnLogout);
            this.PanelGuide.Controls.Add(this.BtnCallback);
            this.PanelGuide.Controls.Add(this.LabelStatus);
            this.PanelGuide.Controls.Add(this.BtnContact);
            this.PanelGuide.Controls.Add(this.BtnProfile);
            this.PanelGuide.Controls.Add(this.CloudStatus);
            this.PanelGuide.Controls.Add(this.SnycProgress);
            this.PanelGuide.Controls.Add(this.BtnMessage);
            this.PanelGuide.Controls.Add(this.BtnProject);
            this.PanelGuide.Controls.Add(this.BtnTask);
            this.PanelGuide.Location = new System.Drawing.Point(-175, 32);
            this.PanelGuide.Margin = new System.Windows.Forms.Padding(0);
            this.PanelGuide.Name = "PanelGuide";
            this.PanelGuide.Size = new System.Drawing.Size(175, 478);
            this.PanelGuide.TabIndex = 0;
            // 
            // BtnSettings
            // 
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Image = global::MYTask.Properties.Resources.Setting_32;
            this.BtnSettings.Location = new System.Drawing.Point(0, 240);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(48, 48);
            this.BtnSettings.TabIndex = 12;
            this.BtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettings.UseVisualStyleBackColor = true;
            // 
            // BtnLogout
            // 
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Image = global::MYTask.Properties.Resources.Logout_32;
            this.BtnLogout.Location = new System.Drawing.Point(48, 240);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(48, 48);
            this.BtnLogout.TabIndex = 11;
            this.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnCallback
            // 
            this.BtnCallback.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCallback.FlatAppearance.BorderSize = 0;
            this.BtnCallback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnCallback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCallback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCallback.ForeColor = System.Drawing.Color.White;
            this.BtnCallback.Image = global::MYTask.Properties.Resources.Back_32;
            this.BtnCallback.Location = new System.Drawing.Point(0, 0);
            this.BtnCallback.Name = "BtnCallback";
            this.BtnCallback.Size = new System.Drawing.Size(48, 48);
            this.BtnCallback.TabIndex = 10;
            this.BtnCallback.UseVisualStyleBackColor = false;
            this.BtnCallback.Click += new System.EventHandler(this.BtnCall_Click);
            // 
            // LabelStatus
            // 
            this.LabelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelStatus.Location = new System.Drawing.Point(3, 430);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(117, 24);
            this.LabelStatus.TabIndex = 9;
            this.LabelStatus.Text = "同步完成";
            // 
            // BtnContact
            // 
            this.BtnContact.BackColor = System.Drawing.Color.LightGray;
            this.BtnContact.FlatAppearance.BorderSize = 0;
            this.BtnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContact.Location = new System.Drawing.Point(0, 144);
            this.BtnContact.Margin = new System.Windows.Forms.Padding(0);
            this.BtnContact.Name = "BtnContact";
            this.BtnContact.Size = new System.Drawing.Size(175, 48);
            this.BtnContact.TabIndex = 8;
            this.BtnContact.Text = "通讯录";
            this.BtnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContact.UseVisualStyleBackColor = false;
            this.BtnContact.Click += new System.EventHandler(this.BtnContact_Click);
            // 
            // BtnProfile
            // 
            this.BtnProfile.ActiveLinkColor = System.Drawing.Color.Navy;
            this.BtnProfile.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnProfile.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.BtnProfile.LinkColor = System.Drawing.Color.White;
            this.BtnProfile.Location = new System.Drawing.Point(48, 0);
            this.BtnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(127, 48);
            this.BtnProfile.TabIndex = 7;
            this.BtnProfile.TabStop = true;
            this.BtnProfile.Text = "学生会信息部\r\n开发人员";
            this.BtnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProfile.VisitedLinkColor = System.Drawing.Color.White;
            this.BtnProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnProfile_LinkClicked);
            // 
            // CloudStatus
            // 
            this.CloudStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloudStatus.Image = global::MYTask.Properties.Resources.Cloud_Sync_32;
            this.CloudStatus.Location = new System.Drawing.Point(127, 430);
            this.CloudStatus.Margin = new System.Windows.Forms.Padding(0);
            this.CloudStatus.Name = "CloudStatus";
            this.CloudStatus.Padding = new System.Windows.Forms.Padding(8);
            this.CloudStatus.Size = new System.Drawing.Size(48, 48);
            this.CloudStatus.TabIndex = 6;
            this.CloudStatus.TabStop = false;
            // 
            // SnycProgress
            // 
            this.SnycProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SnycProgress.Location = new System.Drawing.Point(7, 454);
            this.SnycProgress.MarqueeAnimationSpeed = 3;
            this.SnycProgress.Name = "SnycProgress";
            this.SnycProgress.Size = new System.Drawing.Size(113, 16);
            this.SnycProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.SnycProgress.TabIndex = 4;
            // 
            // BtnMessage
            // 
            this.BtnMessage.BackColor = System.Drawing.Color.LightGray;
            this.BtnMessage.FlatAppearance.BorderSize = 0;
            this.BtnMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMessage.Location = new System.Drawing.Point(0, 192);
            this.BtnMessage.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMessage.Name = "BtnMessage";
            this.BtnMessage.Size = new System.Drawing.Size(175, 48);
            this.BtnMessage.TabIndex = 3;
            this.BtnMessage.Text = "消息";
            this.BtnMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMessage.UseVisualStyleBackColor = false;
            this.BtnMessage.Click += new System.EventHandler(this.BtnMessage_Click);
            // 
            // BtnProject
            // 
            this.BtnProject.BackColor = System.Drawing.Color.LightGray;
            this.BtnProject.FlatAppearance.BorderSize = 0;
            this.BtnProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProject.Location = new System.Drawing.Point(0, 96);
            this.BtnProject.Margin = new System.Windows.Forms.Padding(0);
            this.BtnProject.Name = "BtnProject";
            this.BtnProject.Size = new System.Drawing.Size(175, 48);
            this.BtnProject.TabIndex = 2;
            this.BtnProject.Text = "我的项目";
            this.BtnProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProject.UseVisualStyleBackColor = false;
            this.BtnProject.Click += new System.EventHandler(this.BtnProject_Click);
            // 
            // BtnTask
            // 
            this.BtnTask.BackColor = System.Drawing.Color.LightGray;
            this.BtnTask.FlatAppearance.BorderSize = 0;
            this.BtnTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTask.Location = new System.Drawing.Point(0, 48);
            this.BtnTask.Margin = new System.Windows.Forms.Padding(0);
            this.BtnTask.Name = "BtnTask";
            this.BtnTask.Size = new System.Drawing.Size(175, 48);
            this.BtnTask.TabIndex = 1;
            this.BtnTask.Text = "我的任务";
            this.BtnTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTask.UseVisualStyleBackColor = false;
            this.BtnTask.Click += new System.EventHandler(this.BtnTask_Click);
            // 
            // PanelGuideS
            // 
            this.PanelGuideS.BackColor = System.Drawing.Color.LightGray;
            this.PanelGuideS.Controls.Add(this.LabelPage);
            this.PanelGuideS.Controls.Add(this.BtnPageDown);
            this.PanelGuideS.Controls.Add(this.BtnPageUp);
            this.PanelGuideS.Controls.Add(this.BtnMessageS);
            this.PanelGuideS.Controls.Add(this.CloudStatusS);
            this.PanelGuideS.Controls.Add(this.BtnCall);
            this.PanelGuideS.Controls.Add(this.BtnContactS);
            this.PanelGuideS.Controls.Add(this.BtnProjectS);
            this.PanelGuideS.Controls.Add(this.BtnTaskS);
            this.PanelGuideS.Location = new System.Drawing.Point(0, 32);
            this.PanelGuideS.Margin = new System.Windows.Forms.Padding(0);
            this.PanelGuideS.Name = "PanelGuideS";
            this.PanelGuideS.Size = new System.Drawing.Size(48, 478);
            this.PanelGuideS.TabIndex = 4;
            // 
            // LabelPage
            // 
            this.LabelPage.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPage.Location = new System.Drawing.Point(0, 361);
            this.LabelPage.Margin = new System.Windows.Forms.Padding(0);
            this.LabelPage.Name = "LabelPage";
            this.LabelPage.Size = new System.Drawing.Size(48, 21);
            this.LabelPage.TabIndex = 9;
            this.LabelPage.Text = "99/99";
            this.LabelPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPageDown
            // 
            this.BtnPageDown.BackColor = System.Drawing.Color.Transparent;
            this.BtnPageDown.FlatAppearance.BorderSize = 0;
            this.BtnPageDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnPageDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnPageDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPageDown.Image = global::MYTask.Properties.Resources.Pagedown_32;
            this.BtnPageDown.Location = new System.Drawing.Point(0, 382);
            this.BtnPageDown.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPageDown.Name = "BtnPageDown";
            this.BtnPageDown.Size = new System.Drawing.Size(48, 48);
            this.BtnPageDown.TabIndex = 8;
            this.BtnPageDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPageDown.UseVisualStyleBackColor = false;
            this.BtnPageDown.Click += new System.EventHandler(this.BtnPageDown_Click);
            // 
            // BtnPageUp
            // 
            this.BtnPageUp.BackColor = System.Drawing.Color.Transparent;
            this.BtnPageUp.FlatAppearance.BorderSize = 0;
            this.BtnPageUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnPageUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnPageUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPageUp.Image = global::MYTask.Properties.Resources.Pageup_32;
            this.BtnPageUp.Location = new System.Drawing.Point(0, 313);
            this.BtnPageUp.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPageUp.Name = "BtnPageUp";
            this.BtnPageUp.Size = new System.Drawing.Size(48, 48);
            this.BtnPageUp.TabIndex = 7;
            this.BtnPageUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPageUp.UseVisualStyleBackColor = false;
            this.BtnPageUp.Click += new System.EventHandler(this.BtnPageUp_Click);
            // 
            // BtnMessageS
            // 
            this.BtnMessageS.FlatAppearance.BorderSize = 0;
            this.BtnMessageS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnMessageS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnMessageS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMessageS.Image = global::MYTask.Properties.Resources.Message_32;
            this.BtnMessageS.Location = new System.Drawing.Point(0, 192);
            this.BtnMessageS.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMessageS.Name = "BtnMessageS";
            this.BtnMessageS.Size = new System.Drawing.Size(48, 48);
            this.BtnMessageS.TabIndex = 6;
            this.BtnMessageS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMessageS.UseVisualStyleBackColor = true;
            this.BtnMessageS.Click += new System.EventHandler(this.BtnMessage_Click);
            // 
            // CloudStatusS
            // 
            this.CloudStatusS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloudStatusS.Image = global::MYTask.Properties.Resources.Cloud_Sync_32;
            this.CloudStatusS.Location = new System.Drawing.Point(0, 430);
            this.CloudStatusS.Margin = new System.Windows.Forms.Padding(0);
            this.CloudStatusS.Name = "CloudStatusS";
            this.CloudStatusS.Padding = new System.Windows.Forms.Padding(8);
            this.CloudStatusS.Size = new System.Drawing.Size(48, 48);
            this.CloudStatusS.TabIndex = 5;
            this.CloudStatusS.TabStop = false;
            // 
            // BtnCall
            // 
            this.BtnCall.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCall.FlatAppearance.BorderSize = 0;
            this.BtnCall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnCall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCall.Image = global::MYTask.Properties.Resources.List_32;
            this.BtnCall.Location = new System.Drawing.Point(0, 0);
            this.BtnCall.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCall.Name = "BtnCall";
            this.BtnCall.Size = new System.Drawing.Size(48, 48);
            this.BtnCall.TabIndex = 4;
            this.BtnCall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCall.UseVisualStyleBackColor = false;
            this.BtnCall.Click += new System.EventHandler(this.BtnCall_Click);
            // 
            // BtnContactS
            // 
            this.BtnContactS.FlatAppearance.BorderSize = 0;
            this.BtnContactS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnContactS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnContactS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContactS.Image = global::MYTask.Properties.Resources.Contacts_32;
            this.BtnContactS.Location = new System.Drawing.Point(0, 144);
            this.BtnContactS.Margin = new System.Windows.Forms.Padding(0);
            this.BtnContactS.Name = "BtnContactS";
            this.BtnContactS.Size = new System.Drawing.Size(48, 48);
            this.BtnContactS.TabIndex = 3;
            this.BtnContactS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContactS.UseVisualStyleBackColor = true;
            this.BtnContactS.Click += new System.EventHandler(this.BtnContact_Click);
            // 
            // BtnProjectS
            // 
            this.BtnProjectS.BackColor = System.Drawing.Color.LightGray;
            this.BtnProjectS.FlatAppearance.BorderSize = 0;
            this.BtnProjectS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnProjectS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnProjectS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProjectS.Image = global::MYTask.Properties.Resources.Project_32;
            this.BtnProjectS.Location = new System.Drawing.Point(0, 96);
            this.BtnProjectS.Margin = new System.Windows.Forms.Padding(0);
            this.BtnProjectS.Name = "BtnProjectS";
            this.BtnProjectS.Size = new System.Drawing.Size(48, 48);
            this.BtnProjectS.TabIndex = 2;
            this.BtnProjectS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProjectS.UseVisualStyleBackColor = false;
            this.BtnProjectS.Click += new System.EventHandler(this.BtnProject_Click);
            // 
            // BtnTaskS
            // 
            this.BtnTaskS.FlatAppearance.BorderSize = 0;
            this.BtnTaskS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnTaskS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnTaskS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTaskS.Image = global::MYTask.Properties.Resources.Task_32;
            this.BtnTaskS.Location = new System.Drawing.Point(0, 48);
            this.BtnTaskS.Margin = new System.Windows.Forms.Padding(0);
            this.BtnTaskS.Name = "BtnTaskS";
            this.BtnTaskS.Size = new System.Drawing.Size(48, 48);
            this.BtnTaskS.TabIndex = 1;
            this.BtnTaskS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTaskS.UseVisualStyleBackColor = true;
            this.BtnTaskS.Click += new System.EventHandler(this.BtnTask_Click);
            // 
            // TimerSidebar
            // 
            this.TimerSidebar.Interval = 15;
            this.TimerSidebar.Tick += new System.EventHandler(this.TimerSidebar_Tick);
            // 
            // TabsTask
            // 
            this.TabsTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabsTask.Controls.Add(this.TaskMy);
            this.TabsTask.Controls.Add(this.TaskPub);
            this.TabsTask.Controls.Add(this.TaskAll);
            this.TabsTask.Location = new System.Drawing.Point(48, 532);
            this.TabsTask.Name = "TabsTask";
            this.TabsTask.SelectedIndex = 0;
            this.TabsTask.Size = new System.Drawing.Size(652, 510);
            this.TabsTask.TabIndex = 5;
            this.TabsTask.Visible = false;
            this.TabsTask.SelectedIndexChanged += new System.EventHandler(this.TabsTask_SelectedIndexChanged);
            // 
            // TaskMy
            // 
            this.TaskMy.Controls.Add(this.TaskListMy);
            this.TaskMy.Location = new System.Drawing.Point(4, 30);
            this.TaskMy.Name = "TaskMy";
            this.TaskMy.Padding = new System.Windows.Forms.Padding(3);
            this.TaskMy.Size = new System.Drawing.Size(644, 476);
            this.TaskMy.TabIndex = 0;
            this.TaskMy.Text = "负责的任务";
            this.TaskMy.UseVisualStyleBackColor = true;
            // 
            // TaskPub
            // 
            this.TaskPub.Controls.Add(this.TaskListPub);
            this.TaskPub.Location = new System.Drawing.Point(4, 30);
            this.TaskPub.Name = "TaskPub";
            this.TaskPub.Padding = new System.Windows.Forms.Padding(3);
            this.TaskPub.Size = new System.Drawing.Size(644, 476);
            this.TaskPub.TabIndex = 1;
            this.TaskPub.Text = "发布的任务";
            this.TaskPub.UseVisualStyleBackColor = true;
            // 
            // TaskAll
            // 
            this.TaskAll.Controls.Add(this.TaskListAll);
            this.TaskAll.Location = new System.Drawing.Point(4, 30);
            this.TaskAll.Name = "TaskAll";
            this.TaskAll.Size = new System.Drawing.Size(644, 476);
            this.TaskAll.TabIndex = 2;
            this.TaskAll.Text = "所有任务";
            this.TaskAll.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // LabelFromUserName
            // 
            this.LabelFromUserName.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.LabelFromUserName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelFromUserName.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LabelFromUserName.LinkColor = System.Drawing.Color.Black;
            this.LabelFromUserName.Location = new System.Drawing.Point(183, 57);
            this.LabelFromUserName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelFromUserName.Name = "LabelFromUserName";
            this.LabelFromUserName.Size = new System.Drawing.Size(182, 24);
            this.LabelFromUserName.TabIndex = 12;
            this.LabelFromUserName.TabStop = true;
            this.LabelFromUserName.Text = "学生会信息部 开发人员";
            this.LabelFromUserName.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(432, 3);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(182, 24);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "label2";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(371, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "从属于";
            // 
            // LabelUpdateTime
            // 
            this.LabelUpdateTime.AutoSize = true;
            this.LabelUpdateTime.Location = new System.Drawing.Point(371, 57);
            this.LabelUpdateTime.Name = "LabelUpdateTime";
            this.LabelUpdateTime.Size = new System.Drawing.Size(243, 21);
            this.LabelUpdateTime.TabIndex = 9;
            this.LabelUpdateTime.Text = "最后更改：9999/99/99 99:99:99";
            // 
            // LabelEndTime
            // 
            this.LabelEndTime.AutoSize = true;
            this.LabelEndTime.Location = new System.Drawing.Point(371, 30);
            this.LabelEndTime.Name = "LabelEndTime";
            this.LabelEndTime.Size = new System.Drawing.Size(208, 21);
            this.LabelEndTime.TabIndex = 8;
            this.LabelEndTime.Text = "预期完成日期：9999/99/99";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "来自于：";
            // 
            // LabelStat
            // 
            this.LabelStat.BackColor = System.Drawing.Color.BlueViolet;
            this.LabelStat.Location = new System.Drawing.Point(3, 57);
            this.LabelStat.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LabelStat.Name = "LabelStat";
            this.LabelStat.Size = new System.Drawing.Size(100, 21);
            this.LabelStat.TabIndex = 6;
            this.LabelStat.Text = "50%";
            this.LabelStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUserName
            // 
            this.LabelUserName.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.LabelUserName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelUserName.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LabelUserName.LinkColor = System.Drawing.Color.Black;
            this.LabelUserName.Location = new System.Drawing.Point(183, 30);
            this.LabelUserName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(182, 24);
            this.LabelUserName.TabIndex = 5;
            this.LabelUserName.TabStop = true;
            this.LabelUserName.Text = "学生会信息部 开发人员";
            this.LabelUserName.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "指派给：";
            // 
            // LabelPI
            // 
            this.LabelPI.BackColor = System.Drawing.Color.OliveDrab;
            this.LabelPI.Location = new System.Drawing.Point(53, 30);
            this.LabelPI.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LabelPI.Name = "LabelPI";
            this.LabelPI.Size = new System.Drawing.Size(50, 24);
            this.LabelPI.TabIndex = 2;
            this.LabelPI.Text = "高";
            this.LabelPI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPT
            // 
            this.LabelPT.BackColor = System.Drawing.Color.GreenYellow;
            this.LabelPT.Location = new System.Drawing.Point(3, 30);
            this.LabelPT.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.LabelPT.Name = "LabelPT";
            this.LabelPT.Size = new System.Drawing.Size(50, 24);
            this.LabelPT.TabIndex = 1;
            this.LabelPT.Text = "中";
            this.LabelPT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTaskName
            // 
            this.LabelTaskName.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.LabelTaskName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTaskName.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LabelTaskName.LinkColor = System.Drawing.Color.Black;
            this.LabelTaskName.Location = new System.Drawing.Point(3, 3);
            this.LabelTaskName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTaskName.Name = "LabelTaskName";
            this.LabelTaskName.Size = new System.Drawing.Size(365, 24);
            this.LabelTaskName.TabIndex = 0;
            this.LabelTaskName.TabStop = true;
            this.LabelTaskName.Text = "label2";
            this.LabelTaskName.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelLogin.Controls.Add(this.PLogin_LabelBlock);
            this.PanelLogin.Controls.Add(this.PLogin_PicLogo);
            this.PanelLogin.Controls.Add(this.PLogin_TextPsw);
            this.PanelLogin.Controls.Add(this.PLogin_TextUID);
            this.PanelLogin.Controls.Add(this.PLogin_PicCloud);
            this.PanelLogin.Controls.Add(this.PLogin_BarConnecting);
            this.PanelLogin.Controls.Add(this.PLogin_BtnFindPsw);
            this.PanelLogin.Controls.Add(this.PLogin_BtnLogin);
            this.PanelLogin.Location = new System.Drawing.Point(0, 510);
            this.PanelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(700, 478);
            this.PanelLogin.TabIndex = 6;
            this.PanelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UI_Caption_MouseDown);
            // 
            // PLogin_LabelBlock
            // 
            this.PLogin_LabelBlock.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PLogin_LabelBlock.ForeColor = System.Drawing.Color.White;
            this.PLogin_LabelBlock.Location = new System.Drawing.Point(350, 124);
            this.PLogin_LabelBlock.Name = "PLogin_LabelBlock";
            this.PLogin_LabelBlock.Size = new System.Drawing.Size(308, 225);
            this.PLogin_LabelBlock.TabIndex = 11;
            this.PLogin_LabelBlock.Text = "正在加载任务列表，请稍候…";
            this.PLogin_LabelBlock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PLogin_PicLogo
            // 
            this.PLogin_PicLogo.Location = new System.Drawing.Point(52, 108);
            this.PLogin_PicLogo.Name = "PLogin_PicLogo";
            this.PLogin_PicLogo.Size = new System.Drawing.Size(223, 205);
            this.PLogin_PicLogo.TabIndex = 12;
            this.PLogin_PicLogo.TabStop = false;
            this.PLogin_PicLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UI_Caption_MouseDown);
            // 
            // PLogin_PicCloud
            // 
            this.PLogin_PicCloud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PLogin_PicCloud.Image = global::MYTask.Properties.Resources.Cloud_Connecting_32;
            this.PLogin_PicCloud.Location = new System.Drawing.Point(665, 443);
            this.PLogin_PicCloud.Name = "PLogin_PicCloud";
            this.PLogin_PicCloud.Size = new System.Drawing.Size(32, 32);
            this.PLogin_PicCloud.TabIndex = 8;
            this.PLogin_PicCloud.TabStop = false;
            // 
            // PLogin_BarConnecting
            // 
            this.PLogin_BarConnecting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PLogin_BarConnecting.Location = new System.Drawing.Point(7, 456);
            this.PLogin_BarConnecting.MarqueeAnimationSpeed = 0;
            this.PLogin_BarConnecting.Name = "PLogin_BarConnecting";
            this.PLogin_BarConnecting.Size = new System.Drawing.Size(652, 15);
            this.PLogin_BarConnecting.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.PLogin_BarConnecting.TabIndex = 7;
            // 
            // PLogin_BtnFindPsw
            // 
            this.PLogin_BtnFindPsw.Image = global::MYTask.Properties.Resources.FindPsw_32;
            this.PLogin_BtnFindPsw.Location = new System.Drawing.Point(451, 254);
            this.PLogin_BtnFindPsw.Name = "PLogin_BtnFindPsw";
            this.PLogin_BtnFindPsw.Size = new System.Drawing.Size(48, 48);
            this.PLogin_BtnFindPsw.TabIndex = 6;
            this.PLogin_BtnFindPsw.UseVisualStyleBackColor = true;
            this.PLogin_BtnFindPsw.Visible = false;
            this.PLogin_BtnFindPsw.Click += new System.EventHandler(this.BtnFindPsw_Click);
            // 
            // PLogin_BtnLogin
            // 
            this.PLogin_BtnLogin.BackColor = System.Drawing.Color.LightGray;
            this.PLogin_BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PLogin_BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PLogin_BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PLogin_BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PLogin_BtnLogin.Image = global::MYTask.Properties.Resources.Login_32;
            this.PLogin_BtnLogin.Location = new System.Drawing.Point(400, 254);
            this.PLogin_BtnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.PLogin_BtnLogin.Name = "PLogin_BtnLogin";
            this.PLogin_BtnLogin.Size = new System.Drawing.Size(48, 48);
            this.PLogin_BtnLogin.TabIndex = 5;
            this.PLogin_BtnLogin.UseVisualStyleBackColor = false;
            this.PLogin_BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TabsProject
            // 
            this.TabsProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabsProject.Controls.Add(this.ProjMy);
            this.TabsProject.Controls.Add(this.ProjAll);
            this.TabsProject.Location = new System.Drawing.Point(48, 510);
            this.TabsProject.Name = "TabsProject";
            this.TabsProject.SelectedIndex = 0;
            this.TabsProject.Size = new System.Drawing.Size(652, 510);
            this.TabsProject.TabIndex = 8;
            this.TabsProject.Visible = false;
            this.TabsProject.SelectedIndexChanged += new System.EventHandler(this.TabsProject_SelectedIndexChanged);
            // 
            // ProjMy
            // 
            this.ProjMy.Controls.Add(this.ProjListMy);
            this.ProjMy.Location = new System.Drawing.Point(4, 30);
            this.ProjMy.Name = "ProjMy";
            this.ProjMy.Padding = new System.Windows.Forms.Padding(3);
            this.ProjMy.Size = new System.Drawing.Size(644, 476);
            this.ProjMy.TabIndex = 0;
            this.ProjMy.Text = "负责的项目";
            this.ProjMy.UseVisualStyleBackColor = true;
            // 
            // ProjAll
            // 
            this.ProjAll.Controls.Add(this.ProjListAll);
            this.ProjAll.Location = new System.Drawing.Point(4, 30);
            this.ProjAll.Name = "ProjAll";
            this.ProjAll.Size = new System.Drawing.Size(644, 476);
            this.ProjAll.TabIndex = 2;
            this.ProjAll.Text = "所有项目";
            this.ProjAll.UseVisualStyleBackColor = true;
            // 
            // PanelContacts
            // 
            this.PanelContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContacts.BackColor = System.Drawing.Color.Green;
            this.PanelContacts.Controls.Add(this.ContactList);
            this.PanelContacts.Location = new System.Drawing.Point(48, 510);
            this.PanelContacts.Name = "PanelContacts";
            this.PanelContacts.Size = new System.Drawing.Size(652, 478);
            this.PanelContacts.TabIndex = 9;
            // 
            // PanelMessages
            // 
            this.PanelMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMessages.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelMessages.Controls.Add(this.LabelMessageLabel);
            this.PanelMessages.Controls.Add(this.MessList);
            this.PanelMessages.Controls.Add(this.AnnList);
            this.PanelMessages.Location = new System.Drawing.Point(48, 510);
            this.PanelMessages.Name = "PanelMessages";
            this.PanelMessages.Size = new System.Drawing.Size(652, 478);
            this.PanelMessages.TabIndex = 10;
            // 
            // LabelMessageLabel
            // 
            this.LabelMessageLabel.AutoSize = true;
            this.LabelMessageLabel.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelMessageLabel.ForeColor = System.Drawing.Color.Black;
            this.LabelMessageLabel.Location = new System.Drawing.Point(3, 135);
            this.LabelMessageLabel.Name = "LabelMessageLabel";
            this.LabelMessageLabel.Size = new System.Drawing.Size(50, 26);
            this.LabelMessageLabel.TabIndex = 2;
            this.LabelMessageLabel.Text = "消息";
            // 
            // TimerLogin
            // 
            this.TimerLogin.Interval = 15;
            this.TimerLogin.Tick += new System.EventHandler(this.TimerLogin_Tick);
            // 
            // UI_Caption
            // 
            this.UI_Caption.BackColor = System.Drawing.Color.RoyalBlue;
            this.UI_Caption.Controls.Add(this.LabelTitle);
            this.UI_Caption.Controls.Add(this.BtnMin);
            this.UI_Caption.Controls.Add(this.BtnClose);
            this.UI_Caption.Location = new System.Drawing.Point(0, 0);
            this.UI_Caption.Margin = new System.Windows.Forms.Padding(0);
            this.UI_Caption.Name = "UI_Caption";
            this.UI_Caption.Size = new System.Drawing.Size(700, 32);
            this.UI_Caption.TabIndex = 11;
            this.UI_Caption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UI_Caption_MouseDown);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(3, 6);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(93, 21);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "WSS - 登录";
            this.LabelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UI_Caption_MouseDown);
            // 
            // BtnMin
            // 
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Image = global::MYTask.Properties.Resources.min_24;
            this.BtnMin.Location = new System.Drawing.Point(636, 0);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(32, 32);
            this.BtnMin.TabIndex = 1;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Image = global::MYTask.Properties.Resources.close_24;
            this.BtnClose.Location = new System.Drawing.Point(668, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(32, 32);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TimerUser
            // 
            this.TimerUser.Interval = 15;
            this.TimerUser.Tick += new System.EventHandler(this.TimerUser_Tick);
            // 
            // PLogin_TextPsw
            // 
            this.PLogin_TextPsw.Location = new System.Drawing.Point(400, 211);
            this.PLogin_TextPsw.Name = "PLogin_TextPsw";
            this.PLogin_TextPsw.Size = new System.Drawing.Size(215, 29);
            this.PLogin_TextPsw.TabIndex = 10;
            this.PLogin_TextPsw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextLogin_Psw_Keypress);
            // 
            // PLogin_TextUID
            // 
            this.PLogin_TextUID.Location = new System.Drawing.Point(400, 176);
            this.PLogin_TextUID.Name = "PLogin_TextUID";
            this.PLogin_TextUID.Size = new System.Drawing.Size(215, 29);
            this.PLogin_TextUID.TabIndex = 9;
            // 
            // PanelUser
            // 
            this.PanelUser.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelUser.Location = new System.Drawing.Point(315, 32);
            this.PanelUser.Margin = new System.Windows.Forms.Padding(0);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(385, 478);
            this.PanelUser.TabIndex = 7;
            // 
            // TaskListMy
            // 
            this.TaskListMy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskListMy.BackColor = System.Drawing.Color.RoyalBlue;
            this.TaskListMy.Location = new System.Drawing.Point(0, 0);
            this.TaskListMy.MaximumSize = new System.Drawing.Size(1304, 0);
            this.TaskListMy.Name = "TaskListMy";
            this.TaskListMy.Size = new System.Drawing.Size(644, 0);
            this.TaskListMy.TabIndex = 0;
            // 
            // TaskListPub
            // 
            this.TaskListPub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskListPub.BackColor = System.Drawing.Color.RoyalBlue;
            this.TaskListPub.Location = new System.Drawing.Point(0, 0);
            this.TaskListPub.MaximumSize = new System.Drawing.Size(1304, 0);
            this.TaskListPub.Name = "TaskListPub";
            this.TaskListPub.Size = new System.Drawing.Size(644, 0);
            this.TaskListPub.TabIndex = 0;
            // 
            // TaskListAll
            // 
            this.TaskListAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskListAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.TaskListAll.Location = new System.Drawing.Point(0, 0);
            this.TaskListAll.MaximumSize = new System.Drawing.Size(1304, 0);
            this.TaskListAll.Name = "TaskListAll";
            this.TaskListAll.Size = new System.Drawing.Size(644, 0);
            this.TaskListAll.TabIndex = 0;
            // 
            // ProjListMy
            // 
            this.ProjListMy.BackColor = System.Drawing.Color.RoyalBlue;
            this.ProjListMy.Location = new System.Drawing.Point(0, 0);
            this.ProjListMy.Name = "ProjListMy";
            this.ProjListMy.Size = new System.Drawing.Size(643, 447);
            this.ProjListMy.TabIndex = 0;
            // 
            // ProjListAll
            // 
            this.ProjListAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.ProjListAll.Location = new System.Drawing.Point(0, 0);
            this.ProjListAll.Name = "ProjListAll";
            this.ProjListAll.Size = new System.Drawing.Size(643, 447);
            this.ProjListAll.TabIndex = 1;
            // 
            // ContactList
            // 
            this.ContactList.BackColor = System.Drawing.Color.White;
            this.ContactList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactList.FullRowSelect = true;
            this.ContactList.GridLines = true;
            this.ContactList.Location = new System.Drawing.Point(0, 0);
            this.ContactList.Name = "ContactList";
            this.ContactList.Size = new System.Drawing.Size(652, 478);
            this.ContactList.TabIndex = 0;
            this.ContactList.UseCompatibleStateImageBehavior = false;
            this.ContactList.View = System.Windows.Forms.View.Details;
            this.ContactList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ContactList_ColumnClick);
            this.ContactList.DoubleClick += new System.EventHandler(this.ContactList_DoubleClick);
            // 
            // MessList
            // 
            this.MessList.BackColor = System.Drawing.Color.White;
            this.MessList.FullRowSelect = true;
            this.MessList.GridLines = true;
            this.MessList.Location = new System.Drawing.Point(3, 164);
            this.MessList.Name = "MessList";
            this.MessList.Size = new System.Drawing.Size(646, 309);
            this.MessList.TabIndex = 1;
            this.MessList.UseCompatibleStateImageBehavior = false;
            this.MessList.View = System.Windows.Forms.View.Details;
            // 
            // AnnList
            // 
            this.AnnList.BackColor = System.Drawing.Color.White;
            this.AnnList.FullRowSelect = true;
            this.AnnList.GridLines = true;
            this.AnnList.Location = new System.Drawing.Point(3, 3);
            this.AnnList.Name = "AnnList";
            this.AnnList.Size = new System.Drawing.Size(646, 129);
            this.AnnList.TabIndex = 0;
            this.AnnList.UseCompatibleStateImageBehavior = false;
            this.AnnList.View = System.Windows.Forms.View.Details;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(700, 510);
            this.Controls.Add(this.UI_Caption);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.PanelGuide);
            this.Controls.Add(this.PanelGuideS);
            this.Controls.Add(this.PanelUser);
            this.Controls.Add(this.TabsTask);
            this.Controls.Add(this.TabsProject);
            this.Controls.Add(this.PanelContacts);
            this.Controls.Add(this.PanelMessages);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormMain";
            this.Text = "SSERSay - Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_Unload);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelGuide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloudStatus)).EndInit();
            this.PanelGuideS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloudStatusS)).EndInit();
            this.TabsTask.ResumeLayout(false);
            this.TaskMy.ResumeLayout(false);
            this.TaskPub.ResumeLayout(false);
            this.TaskAll.ResumeLayout(false);
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PLogin_PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLogin_PicCloud)).EndInit();
            this.TabsProject.ResumeLayout(false);
            this.ProjMy.ResumeLayout(false);
            this.ProjAll.ResumeLayout(false);
            this.PanelContacts.ResumeLayout(false);
            this.PanelMessages.ResumeLayout(false);
            this.PanelMessages.PerformLayout();
            this.UI_Caption.ResumeLayout(false);
            this.UI_Caption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelLogin;
        private Button PLogin_BtnLogin;
        private Button PLogin_BtnFindPsw;

        private Panel PanelGuide;
        private LinkLabel BtnProfile;
        private Button BtnCallback;
        private Button BtnTask;
        private Button BtnProject;
        private Button BtnContact;
        private Button BtnMessage;
        private PictureBox CloudStatus;
        private Label LabelStatus;
        private ProgressBar SnycProgress;

        private Panel PanelGuideS;
        private Button BtnCall;
        private Button BtnTaskS;
        private Button BtnProjectS;
        private Button BtnContactS;
        private Button BtnMessageS;
        private PictureBox CloudStatusS;

        private TabControl TabsTask;
        private TabPage TaskMy;
        private TabPage TaskPub;
        private TabPage TaskAll;

        private TabControl TabsProject;
        private TabPage ProjMy;
        private TabPage ProjAll;

        private Panel PanelContacts;

        private Panel PanelMessages;

        private Timer TimerSidebar;
        private ProgressBar PLogin_BarConnecting;
        private PictureBox PLogin_PicCloud;
        private Panel panel1;
        private Label LabelPI;
        private Label LabelPT;
        private LinkLabel LabelTaskName;
        private Label label5;
        private Label LabelStat;
        private Label label7;
        private LinkLabel LabelUserName;
        private Label LabelUpdateTime;
        private Label LabelEndTime;
        private TaskPanelContainer TaskListMy;
        private Label label2;
        private LoginTextbox PLogin_TextPsw;
        private LoginTextbox PLogin_TextUID;
        private LinkLabel linkLabel1;
        private LinkLabel LabelFromUserName;
        private UserProfilePanel PanelUser;
        private TaskPanelContainer TaskListPub;
        private TaskPanelContainer TaskListAll;
        private Button BtnLogout;
        private Timer TimerLogin;
        private UserList ContactList;
        private Label PLogin_LabelBlock;
        private Panel UI_Caption;
        private Button BtnClose;
        private Button BtnMin;
        private Button BtnPageDown;
        private Button BtnPageUp;
        private Label LabelPage;
        private Button BtnSettings;
        private ProjPanelContainer ProjListMy;
        private ProjPanelContainer ProjListAll;
        private Label LabelTitle;
        private AnnounceList AnnList;
        private MessageList MessList;
        private Label LabelMessageLabel;
        private PictureBox PLogin_PicLogo;
        private Timer TimerUser;
    }
}