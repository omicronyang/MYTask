﻿using System.Windows.Forms;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PanelGuide = new System.Windows.Forms.Panel();
            this.PGuide_Side = new System.Windows.Forms.Label();
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
            this.PGuideS_SideRight = new System.Windows.Forms.Label();
            this.PGuideS_LabelPage = new System.Windows.Forms.Label();
            this.PGuideS_BtnPageDown = new System.Windows.Forms.Button();
            this.PGuideS_BtnPageUp = new System.Windows.Forms.Button();
            this.PGuideS_BtnMessage = new System.Windows.Forms.Button();
            this.PGuideS_CloudStat = new System.Windows.Forms.PictureBox();
            this.PGuideS_BtnCall = new System.Windows.Forms.Button();
            this.PGuideS_BtnContact = new System.Windows.Forms.Button();
            this.PGuideS_BtnProject = new System.Windows.Forms.Button();
            this.PGuideS_BtnTask = new System.Windows.Forms.Button();
            this.LabelFromUserName = new System.Windows.Forms.LinkLabel();
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
            this.ProjMy = new System.Windows.Forms.TabPage();
            this.ProjAll = new System.Windows.Forms.TabPage();
            this.PanelContacts = new System.Windows.Forms.Panel();
            this.PanelMessages = new System.Windows.Forms.Panel();
            this.PMess_Label1 = new System.Windows.Forms.Label();
            this.PMess_Label2 = new System.Windows.Forms.Label();
            this.UI_Caption = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PSettings = new System.Windows.Forms.Panel();
            this.PSet_Label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PSet_BtnClr6 = new System.Windows.Forms.Button();
            this.PSet_BtnClr5 = new System.Windows.Forms.Button();
            this.PSet_BtnClr4 = new System.Windows.Forms.Button();
            this.PSet_BtnClr3 = new System.Windows.Forms.Button();
            this.PSet_BtnClr2 = new System.Windows.Forms.Button();
            this.PSet_BtnClr1 = new System.Windows.Forms.Button();
            this.PSet_Label1 = new System.Windows.Forms.Label();
            this.PUser_Anim = new System.Windows.Forms.Timer(this.components);
            this.UI_SideLeft = new System.Windows.Forms.Label();
            this.UI_SideRight = new System.Windows.Forms.Label();
            this.UI_SideBottom = new System.Windows.Forms.Label();
            this.Tips = new System.Windows.Forms.ToolTip(this.components);
            this.PTaskBtnSMy = new System.Windows.Forms.Button();
            this.PTaskBtnSPub = new System.Windows.Forms.Button();
            this.PTaskBtnSAll = new System.Windows.Forms.Button();
            this.PProjBtnSAll = new System.Windows.Forms.Button();
            this.PProjBtnSMy = new System.Windows.Forms.Button();
            this.PanelTask = new System.Windows.Forms.Panel();
            this.PanelProj = new System.Windows.Forms.Panel();
            this.PanelUser = new MYTask.UserProfilePanel();
            this.PLogin_TextPsw = new MYTask.LoginTextbox();
            this.PLogin_TextUID = new MYTask.LoginTextbox();
            this.ContactList = new MYTask.UserList();
            this.MessList = new MYTask.MessageList();
            this.AnnList = new MYTask.AnnounceList();
            this.PanelTaskProfile = new MYTask.TaskProfilePanel();
            this.TaskListMy = new MYTask.TaskPanelContainer();
            this.TaskListPub = new MYTask.TaskPanelContainer();
            this.TaskListAll = new MYTask.TaskPanelContainer();
            this.ProjListMy = new MYTask.ProjPanelContainer();
            this.ProjListAll = new MYTask.ProjPanelContainer();
            this.PanelGuide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloudStatus)).BeginInit();
            this.PanelGuideS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PGuideS_CloudStat)).BeginInit();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PLogin_PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLogin_PicCloud)).BeginInit();
            this.PanelContacts.SuspendLayout();
            this.PanelMessages.SuspendLayout();
            this.UI_Caption.SuspendLayout();
            this.PSettings.SuspendLayout();
            this.PanelTask.SuspendLayout();
            this.PanelProj.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGuide
            // 
            this.PanelGuide.BackColor = System.Drawing.Color.LightGray;
            this.PanelGuide.Controls.Add(this.PGuide_Side);
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
            // PGuide_Side
            // 
            this.PGuide_Side.BackColor = System.Drawing.Color.RoyalBlue;
            this.PGuide_Side.Location = new System.Drawing.Point(174, 48);
            this.PGuide_Side.Name = "PGuide_Side";
            this.PGuide_Side.Size = new System.Drawing.Size(1, 430);
            this.PGuide_Side.TabIndex = 13;
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
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
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
            this.BtnCallback.Image = global::MYTask.Properties.Resources.ArrowLeft_White_32;
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
            this.BtnContact.Size = new System.Drawing.Size(174, 48);
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
            this.BtnProfile.DisabledLinkColor = System.Drawing.Color.DimGray;
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
            this.CloudStatus.Location = new System.Drawing.Point(126, 430);
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
            this.BtnMessage.Size = new System.Drawing.Size(174, 48);
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
            this.BtnProject.Size = new System.Drawing.Size(174, 48);
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
            this.BtnTask.Size = new System.Drawing.Size(174, 48);
            this.BtnTask.TabIndex = 1;
            this.BtnTask.Text = "我的任务";
            this.BtnTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTask.UseVisualStyleBackColor = false;
            this.BtnTask.Click += new System.EventHandler(this.BtnTask_Click);
            // 
            // PanelGuideS
            // 
            this.PanelGuideS.BackColor = System.Drawing.Color.LightGray;
            this.PanelGuideS.Controls.Add(this.PGuideS_SideRight);
            this.PanelGuideS.Controls.Add(this.PGuideS_LabelPage);
            this.PanelGuideS.Controls.Add(this.PGuideS_BtnPageDown);
            this.PanelGuideS.Controls.Add(this.PGuideS_BtnPageUp);
            this.PanelGuideS.Controls.Add(this.PGuideS_BtnMessage);
            this.PanelGuideS.Controls.Add(this.PGuideS_CloudStat);
            this.PanelGuideS.Controls.Add(this.PGuideS_BtnCall);
            this.PanelGuideS.Controls.Add(this.PGuideS_BtnContact);
            this.PanelGuideS.Controls.Add(this.PGuideS_BtnProject);
            this.PanelGuideS.Controls.Add(this.PGuideS_BtnTask);
            this.PanelGuideS.Location = new System.Drawing.Point(0, 32);
            this.PanelGuideS.Margin = new System.Windows.Forms.Padding(0);
            this.PanelGuideS.Name = "PanelGuideS";
            this.PanelGuideS.Size = new System.Drawing.Size(48, 478);
            this.PanelGuideS.TabIndex = 4;
            // 
            // PGuideS_SideRight
            // 
            this.PGuideS_SideRight.BackColor = System.Drawing.Color.RoyalBlue;
            this.PGuideS_SideRight.Location = new System.Drawing.Point(47, 0);
            this.PGuideS_SideRight.Name = "PGuideS_SideRight";
            this.PGuideS_SideRight.Size = new System.Drawing.Size(1, 478);
            this.PGuideS_SideRight.TabIndex = 15;
            // 
            // PGuideS_LabelPage
            // 
            this.PGuideS_LabelPage.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PGuideS_LabelPage.Location = new System.Drawing.Point(0, 361);
            this.PGuideS_LabelPage.Margin = new System.Windows.Forms.Padding(0);
            this.PGuideS_LabelPage.Name = "PGuideS_LabelPage";
            this.PGuideS_LabelPage.Size = new System.Drawing.Size(48, 21);
            this.PGuideS_LabelPage.TabIndex = 9;
            this.PGuideS_LabelPage.Text = "99/99";
            this.PGuideS_LabelPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PGuideS_BtnPageDown
            // 
            this.PGuideS_BtnPageDown.BackColor = System.Drawing.Color.Transparent;
            this.PGuideS_BtnPageDown.FlatAppearance.BorderSize = 0;
            this.PGuideS_BtnPageDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PGuideS_BtnPageDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PGuideS_BtnPageDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuideS_BtnPageDown.Image = global::MYTask.Properties.Resources.ArrowDown_32;
            this.PGuideS_BtnPageDown.Location = new System.Drawing.Point(0, 382);
            this.PGuideS_BtnPageDown.Margin = new System.Windows.Forms.Padding(0);
            this.PGuideS_BtnPageDown.Name = "PGuideS_BtnPageDown";
            this.PGuideS_BtnPageDown.Size = new System.Drawing.Size(48, 48);
            this.PGuideS_BtnPageDown.TabIndex = 8;
            this.PGuideS_BtnPageDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PGuideS_BtnPageDown, "下一页");
            this.PGuideS_BtnPageDown.UseVisualStyleBackColor = false;
            this.PGuideS_BtnPageDown.Click += new System.EventHandler(this.BtnPageDown_Click);
            // 
            // PGuideS_BtnPageUp
            // 
            this.PGuideS_BtnPageUp.BackColor = System.Drawing.Color.Transparent;
            this.PGuideS_BtnPageUp.FlatAppearance.BorderSize = 0;
            this.PGuideS_BtnPageUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PGuideS_BtnPageUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PGuideS_BtnPageUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuideS_BtnPageUp.Image = global::MYTask.Properties.Resources.ArrowUp_32;
            this.PGuideS_BtnPageUp.Location = new System.Drawing.Point(0, 313);
            this.PGuideS_BtnPageUp.Margin = new System.Windows.Forms.Padding(0);
            this.PGuideS_BtnPageUp.Name = "PGuideS_BtnPageUp";
            this.PGuideS_BtnPageUp.Size = new System.Drawing.Size(48, 48);
            this.PGuideS_BtnPageUp.TabIndex = 7;
            this.PGuideS_BtnPageUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PGuideS_BtnPageUp, "上一页");
            this.PGuideS_BtnPageUp.UseVisualStyleBackColor = false;
            this.PGuideS_BtnPageUp.Click += new System.EventHandler(this.BtnPageUp_Click);
            // 
            // PGuideS_BtnMessage
            // 
            this.PGuideS_BtnMessage.FlatAppearance.BorderSize = 0;
            this.PGuideS_BtnMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PGuideS_BtnMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PGuideS_BtnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuideS_BtnMessage.Image = global::MYTask.Properties.Resources.Message_32;
            this.PGuideS_BtnMessage.Location = new System.Drawing.Point(0, 192);
            this.PGuideS_BtnMessage.Margin = new System.Windows.Forms.Padding(0);
            this.PGuideS_BtnMessage.Name = "PGuideS_BtnMessage";
            this.PGuideS_BtnMessage.Size = new System.Drawing.Size(48, 48);
            this.PGuideS_BtnMessage.TabIndex = 6;
            this.PGuideS_BtnMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PGuideS_BtnMessage, "通知中心");
            this.PGuideS_BtnMessage.UseVisualStyleBackColor = true;
            this.PGuideS_BtnMessage.Click += new System.EventHandler(this.BtnMessage_Click);
            // 
            // PGuideS_CloudStat
            // 
            this.PGuideS_CloudStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PGuideS_CloudStat.Image = global::MYTask.Properties.Resources.Cloud_Sync_32;
            this.PGuideS_CloudStat.Location = new System.Drawing.Point(0, 430);
            this.PGuideS_CloudStat.Margin = new System.Windows.Forms.Padding(0);
            this.PGuideS_CloudStat.Name = "PGuideS_CloudStat";
            this.PGuideS_CloudStat.Padding = new System.Windows.Forms.Padding(8);
            this.PGuideS_CloudStat.Size = new System.Drawing.Size(48, 48);
            this.PGuideS_CloudStat.TabIndex = 5;
            this.PGuideS_CloudStat.TabStop = false;
            // 
            // PGuideS_BtnCall
            // 
            this.PGuideS_BtnCall.BackColor = System.Drawing.Color.RoyalBlue;
            this.PGuideS_BtnCall.FlatAppearance.BorderSize = 0;
            this.PGuideS_BtnCall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.PGuideS_BtnCall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.PGuideS_BtnCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuideS_BtnCall.Image = global::MYTask.Properties.Resources.List_32;
            this.PGuideS_BtnCall.Location = new System.Drawing.Point(0, 0);
            this.PGuideS_BtnCall.Margin = new System.Windows.Forms.Padding(0);
            this.PGuideS_BtnCall.Name = "PGuideS_BtnCall";
            this.PGuideS_BtnCall.Size = new System.Drawing.Size(48, 48);
            this.PGuideS_BtnCall.TabIndex = 4;
            this.PGuideS_BtnCall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PGuideS_BtnCall, "菜单");
            this.PGuideS_BtnCall.UseVisualStyleBackColor = false;
            this.PGuideS_BtnCall.Click += new System.EventHandler(this.BtnCall_Click);
            // 
            // PGuideS_BtnContact
            // 
            this.PGuideS_BtnContact.FlatAppearance.BorderSize = 0;
            this.PGuideS_BtnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PGuideS_BtnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PGuideS_BtnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuideS_BtnContact.Image = global::MYTask.Properties.Resources.Contacts_32;
            this.PGuideS_BtnContact.Location = new System.Drawing.Point(0, 144);
            this.PGuideS_BtnContact.Margin = new System.Windows.Forms.Padding(0);
            this.PGuideS_BtnContact.Name = "PGuideS_BtnContact";
            this.PGuideS_BtnContact.Size = new System.Drawing.Size(48, 48);
            this.PGuideS_BtnContact.TabIndex = 3;
            this.PGuideS_BtnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PGuideS_BtnContact, "通讯录");
            this.PGuideS_BtnContact.UseVisualStyleBackColor = true;
            this.PGuideS_BtnContact.Click += new System.EventHandler(this.BtnContact_Click);
            // 
            // PGuideS_BtnProject
            // 
            this.PGuideS_BtnProject.BackColor = System.Drawing.Color.LightGray;
            this.PGuideS_BtnProject.FlatAppearance.BorderSize = 0;
            this.PGuideS_BtnProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PGuideS_BtnProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PGuideS_BtnProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuideS_BtnProject.Image = global::MYTask.Properties.Resources.Project_32;
            this.PGuideS_BtnProject.Location = new System.Drawing.Point(0, 96);
            this.PGuideS_BtnProject.Margin = new System.Windows.Forms.Padding(0);
            this.PGuideS_BtnProject.Name = "PGuideS_BtnProject";
            this.PGuideS_BtnProject.Size = new System.Drawing.Size(48, 48);
            this.PGuideS_BtnProject.TabIndex = 2;
            this.PGuideS_BtnProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PGuideS_BtnProject, "项目列表");
            this.PGuideS_BtnProject.UseVisualStyleBackColor = false;
            this.PGuideS_BtnProject.Click += new System.EventHandler(this.BtnProject_Click);
            // 
            // PGuideS_BtnTask
            // 
            this.PGuideS_BtnTask.FlatAppearance.BorderSize = 0;
            this.PGuideS_BtnTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PGuideS_BtnTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PGuideS_BtnTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuideS_BtnTask.Image = global::MYTask.Properties.Resources.Task_32;
            this.PGuideS_BtnTask.Location = new System.Drawing.Point(0, 48);
            this.PGuideS_BtnTask.Margin = new System.Windows.Forms.Padding(0);
            this.PGuideS_BtnTask.Name = "PGuideS_BtnTask";
            this.PGuideS_BtnTask.Size = new System.Drawing.Size(48, 48);
            this.PGuideS_BtnTask.TabIndex = 1;
            this.PGuideS_BtnTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PGuideS_BtnTask, "任务列表");
            this.PGuideS_BtnTask.UseVisualStyleBackColor = true;
            this.PGuideS_BtnTask.Click += new System.EventHandler(this.BtnTask_Click);
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
            // ProjMy
            // 
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
            this.PanelMessages.Controls.Add(this.PMess_Label1);
            this.PanelMessages.Controls.Add(this.PMess_Label2);
            this.PanelMessages.Controls.Add(this.MessList);
            this.PanelMessages.Controls.Add(this.AnnList);
            this.PanelMessages.Location = new System.Drawing.Point(48, 510);
            this.PanelMessages.Name = "PanelMessages";
            this.PanelMessages.Size = new System.Drawing.Size(652, 478);
            this.PanelMessages.TabIndex = 10;
            // 
            // PMess_Label1
            // 
            this.PMess_Label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PMess_Label1.ForeColor = System.Drawing.Color.Black;
            this.PMess_Label1.Location = new System.Drawing.Point(3, 22);
            this.PMess_Label1.Name = "PMess_Label1";
            this.PMess_Label1.Size = new System.Drawing.Size(76, 26);
            this.PMess_Label1.TabIndex = 3;
            this.PMess_Label1.Text = "公告";
            this.PMess_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PMess_Label2
            // 
            this.PMess_Label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PMess_Label2.ForeColor = System.Drawing.Color.Black;
            this.PMess_Label2.Location = new System.Drawing.Point(3, 165);
            this.PMess_Label2.Name = "PMess_Label2";
            this.PMess_Label2.Size = new System.Drawing.Size(76, 26);
            this.PMess_Label2.TabIndex = 2;
            this.PMess_Label2.Text = "消息";
            this.PMess_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // PSettings
            // 
            this.PSettings.BackColor = System.Drawing.Color.Gainsboro;
            this.PSettings.Controls.Add(this.PSet_Label2);
            this.PSettings.Controls.Add(this.checkBox1);
            this.PSettings.Controls.Add(this.PSet_BtnClr6);
            this.PSettings.Controls.Add(this.PSet_BtnClr5);
            this.PSettings.Controls.Add(this.PSet_BtnClr4);
            this.PSettings.Controls.Add(this.PSet_BtnClr3);
            this.PSettings.Controls.Add(this.PSet_BtnClr2);
            this.PSettings.Controls.Add(this.PSet_BtnClr1);
            this.PSettings.Controls.Add(this.PSet_Label1);
            this.PSettings.Location = new System.Drawing.Point(48, 510);
            this.PSettings.Margin = new System.Windows.Forms.Padding(0);
            this.PSettings.Name = "PSettings";
            this.PSettings.Size = new System.Drawing.Size(652, 478);
            this.PSettings.TabIndex = 12;
            // 
            // PSet_Label2
            // 
            this.PSet_Label2.AutoSize = true;
            this.PSet_Label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PSet_Label2.Location = new System.Drawing.Point(5, 68);
            this.PSet_Label2.Name = "PSet_Label2";
            this.PSet_Label2.Size = new System.Drawing.Size(88, 26);
            this.PSet_Label2.TabIndex = 9;
            this.PSet_Label2.Text = "任务列表";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 25);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "隐藏完成验收的任务";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // PSet_BtnClr6
            // 
            this.PSet_BtnClr6.BackColor = System.Drawing.Color.DimGray;
            this.PSet_BtnClr6.FlatAppearance.BorderSize = 0;
            this.PSet_BtnClr6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.PSet_BtnClr6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.PSet_BtnClr6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PSet_BtnClr6.Location = new System.Drawing.Point(385, 37);
            this.PSet_BtnClr6.Margin = new System.Windows.Forms.Padding(0);
            this.PSet_BtnClr6.Name = "PSet_BtnClr6";
            this.PSet_BtnClr6.Size = new System.Drawing.Size(75, 18);
            this.PSet_BtnClr6.TabIndex = 6;
            this.PSet_BtnClr6.UseVisualStyleBackColor = false;
            this.PSet_BtnClr6.Click += new System.EventHandler(this.PSet_BtnClr_Click);
            // 
            // PSet_BtnClr5
            // 
            this.PSet_BtnClr5.BackColor = System.Drawing.Color.OrangeRed;
            this.PSet_BtnClr5.FlatAppearance.BorderSize = 0;
            this.PSet_BtnClr5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.PSet_BtnClr5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.PSet_BtnClr5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PSet_BtnClr5.Location = new System.Drawing.Point(310, 37);
            this.PSet_BtnClr5.Margin = new System.Windows.Forms.Padding(0);
            this.PSet_BtnClr5.Name = "PSet_BtnClr5";
            this.PSet_BtnClr5.Size = new System.Drawing.Size(75, 18);
            this.PSet_BtnClr5.TabIndex = 5;
            this.PSet_BtnClr5.UseVisualStyleBackColor = false;
            this.PSet_BtnClr5.Click += new System.EventHandler(this.PSet_BtnClr_Click);
            // 
            // PSet_BtnClr4
            // 
            this.PSet_BtnClr4.BackColor = System.Drawing.Color.Crimson;
            this.PSet_BtnClr4.FlatAppearance.BorderSize = 0;
            this.PSet_BtnClr4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.PSet_BtnClr4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.PSet_BtnClr4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PSet_BtnClr4.Location = new System.Drawing.Point(235, 37);
            this.PSet_BtnClr4.Margin = new System.Windows.Forms.Padding(0);
            this.PSet_BtnClr4.Name = "PSet_BtnClr4";
            this.PSet_BtnClr4.Size = new System.Drawing.Size(75, 18);
            this.PSet_BtnClr4.TabIndex = 4;
            this.PSet_BtnClr4.UseVisualStyleBackColor = false;
            this.PSet_BtnClr4.Click += new System.EventHandler(this.PSet_BtnClr_Click);
            // 
            // PSet_BtnClr3
            // 
            this.PSet_BtnClr3.BackColor = System.Drawing.Color.DarkMagenta;
            this.PSet_BtnClr3.FlatAppearance.BorderSize = 0;
            this.PSet_BtnClr3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.PSet_BtnClr3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.PSet_BtnClr3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PSet_BtnClr3.Location = new System.Drawing.Point(160, 37);
            this.PSet_BtnClr3.Margin = new System.Windows.Forms.Padding(0);
            this.PSet_BtnClr3.Name = "PSet_BtnClr3";
            this.PSet_BtnClr3.Size = new System.Drawing.Size(75, 18);
            this.PSet_BtnClr3.TabIndex = 3;
            this.PSet_BtnClr3.UseVisualStyleBackColor = false;
            this.PSet_BtnClr3.Click += new System.EventHandler(this.PSet_BtnClr_Click);
            // 
            // PSet_BtnClr2
            // 
            this.PSet_BtnClr2.BackColor = System.Drawing.Color.SeaGreen;
            this.PSet_BtnClr2.FlatAppearance.BorderSize = 0;
            this.PSet_BtnClr2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.PSet_BtnClr2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.PSet_BtnClr2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PSet_BtnClr2.Location = new System.Drawing.Point(85, 37);
            this.PSet_BtnClr2.Margin = new System.Windows.Forms.Padding(0);
            this.PSet_BtnClr2.Name = "PSet_BtnClr2";
            this.PSet_BtnClr2.Size = new System.Drawing.Size(75, 18);
            this.PSet_BtnClr2.TabIndex = 2;
            this.PSet_BtnClr2.UseVisualStyleBackColor = false;
            this.PSet_BtnClr2.Click += new System.EventHandler(this.PSet_BtnClr_Click);
            // 
            // PSet_BtnClr1
            // 
            this.PSet_BtnClr1.BackColor = System.Drawing.Color.RoyalBlue;
            this.PSet_BtnClr1.FlatAppearance.BorderSize = 0;
            this.PSet_BtnClr1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.PSet_BtnClr1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.PSet_BtnClr1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PSet_BtnClr1.Location = new System.Drawing.Point(10, 37);
            this.PSet_BtnClr1.Margin = new System.Windows.Forms.Padding(0);
            this.PSet_BtnClr1.Name = "PSet_BtnClr1";
            this.PSet_BtnClr1.Size = new System.Drawing.Size(75, 18);
            this.PSet_BtnClr1.TabIndex = 1;
            this.PSet_BtnClr1.UseVisualStyleBackColor = false;
            this.PSet_BtnClr1.Click += new System.EventHandler(this.PSet_BtnClr_Click);
            // 
            // PSet_Label1
            // 
            this.PSet_Label1.AutoSize = true;
            this.PSet_Label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PSet_Label1.Location = new System.Drawing.Point(5, 6);
            this.PSet_Label1.Name = "PSet_Label1";
            this.PSet_Label1.Size = new System.Drawing.Size(88, 26);
            this.PSet_Label1.TabIndex = 0;
            this.PSet_Label1.Text = "主题颜色";
            // 
            // PUser_Anim
            // 
            this.PUser_Anim.Interval = 15;
            this.PUser_Anim.Tick += new System.EventHandler(this.PUser_Anim_Tick);
            // 
            // UI_SideLeft
            // 
            this.UI_SideLeft.BackColor = System.Drawing.Color.RoyalBlue;
            this.UI_SideLeft.Location = new System.Drawing.Point(0, 32);
            this.UI_SideLeft.Name = "UI_SideLeft";
            this.UI_SideLeft.Size = new System.Drawing.Size(1, 478);
            this.UI_SideLeft.TabIndex = 13;
            // 
            // UI_SideRight
            // 
            this.UI_SideRight.BackColor = System.Drawing.Color.RoyalBlue;
            this.UI_SideRight.Location = new System.Drawing.Point(699, 32);
            this.UI_SideRight.Name = "UI_SideRight";
            this.UI_SideRight.Size = new System.Drawing.Size(1, 478);
            this.UI_SideRight.TabIndex = 14;
            // 
            // UI_SideBottom
            // 
            this.UI_SideBottom.BackColor = System.Drawing.Color.RoyalBlue;
            this.UI_SideBottom.Location = new System.Drawing.Point(1, 509);
            this.UI_SideBottom.Name = "UI_SideBottom";
            this.UI_SideBottom.Size = new System.Drawing.Size(698, 1);
            this.UI_SideBottom.TabIndex = 15;
            // 
            // Tips
            // 
            this.Tips.ShowAlways = true;
            // 
            // PTaskBtnSMy
            // 
            this.PTaskBtnSMy.AutoSize = true;
            this.PTaskBtnSMy.BackColor = System.Drawing.Color.RoyalBlue;
            this.PTaskBtnSMy.FlatAppearance.BorderSize = 0;
            this.PTaskBtnSMy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.PTaskBtnSMy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.PTaskBtnSMy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PTaskBtnSMy.ForeColor = System.Drawing.Color.White;
            this.PTaskBtnSMy.Location = new System.Drawing.Point(0, 0);
            this.PTaskBtnSMy.Margin = new System.Windows.Forms.Padding(0);
            this.PTaskBtnSMy.Name = "PTaskBtnSMy";
            this.PTaskBtnSMy.Size = new System.Drawing.Size(100, 32);
            this.PTaskBtnSMy.TabIndex = 5;
            this.PTaskBtnSMy.Text = "负责的任务";
            this.PTaskBtnSMy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PTaskBtnSMy, "指派给我的任务");
            this.PTaskBtnSMy.UseVisualStyleBackColor = false;
            this.PTaskBtnSMy.Click += new System.EventHandler(this.PTaskBtnS_Click);
            // 
            // PTaskBtnSPub
            // 
            this.PTaskBtnSPub.AutoSize = true;
            this.PTaskBtnSPub.BackColor = System.Drawing.Color.Gainsboro;
            this.PTaskBtnSPub.FlatAppearance.BorderSize = 0;
            this.PTaskBtnSPub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.PTaskBtnSPub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.PTaskBtnSPub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PTaskBtnSPub.ForeColor = System.Drawing.Color.Black;
            this.PTaskBtnSPub.Location = new System.Drawing.Point(100, 0);
            this.PTaskBtnSPub.Margin = new System.Windows.Forms.Padding(0);
            this.PTaskBtnSPub.Name = "PTaskBtnSPub";
            this.PTaskBtnSPub.Size = new System.Drawing.Size(100, 32);
            this.PTaskBtnSPub.TabIndex = 6;
            this.PTaskBtnSPub.Text = "发布的任务";
            this.PTaskBtnSPub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PTaskBtnSPub, "我发布的任务");
            this.PTaskBtnSPub.UseVisualStyleBackColor = false;
            this.PTaskBtnSPub.Click += new System.EventHandler(this.PTaskBtnS_Click);
            // 
            // PTaskBtnSAll
            // 
            this.PTaskBtnSAll.AutoSize = true;
            this.PTaskBtnSAll.BackColor = System.Drawing.Color.Gainsboro;
            this.PTaskBtnSAll.FlatAppearance.BorderSize = 0;
            this.PTaskBtnSAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.PTaskBtnSAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.PTaskBtnSAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PTaskBtnSAll.ForeColor = System.Drawing.Color.Black;
            this.PTaskBtnSAll.Location = new System.Drawing.Point(200, 0);
            this.PTaskBtnSAll.Margin = new System.Windows.Forms.Padding(0);
            this.PTaskBtnSAll.Name = "PTaskBtnSAll";
            this.PTaskBtnSAll.Size = new System.Drawing.Size(84, 32);
            this.PTaskBtnSAll.TabIndex = 7;
            this.PTaskBtnSAll.Text = "所有任务";
            this.PTaskBtnSAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PTaskBtnSAll, "当前系统中的全部任务");
            this.PTaskBtnSAll.UseVisualStyleBackColor = false;
            this.PTaskBtnSAll.Click += new System.EventHandler(this.PTaskBtnS_Click);
            // 
            // PProjBtnSAll
            // 
            this.PProjBtnSAll.AutoSize = true;
            this.PProjBtnSAll.BackColor = System.Drawing.Color.Gainsboro;
            this.PProjBtnSAll.FlatAppearance.BorderSize = 0;
            this.PProjBtnSAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.PProjBtnSAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.PProjBtnSAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PProjBtnSAll.ForeColor = System.Drawing.Color.Black;
            this.PProjBtnSAll.Location = new System.Drawing.Point(100, 0);
            this.PProjBtnSAll.Margin = new System.Windows.Forms.Padding(0);
            this.PProjBtnSAll.Name = "PProjBtnSAll";
            this.PProjBtnSAll.Size = new System.Drawing.Size(84, 32);
            this.PProjBtnSAll.TabIndex = 6;
            this.PProjBtnSAll.Text = "所有项目";
            this.PProjBtnSAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PProjBtnSAll, "当前系统中的全部项目");
            this.PProjBtnSAll.UseVisualStyleBackColor = false;
            this.PProjBtnSAll.Click += new System.EventHandler(this.PProjBtnS_Click);
            // 
            // PProjBtnSMy
            // 
            this.PProjBtnSMy.AutoSize = true;
            this.PProjBtnSMy.BackColor = System.Drawing.Color.RoyalBlue;
            this.PProjBtnSMy.FlatAppearance.BorderSize = 0;
            this.PProjBtnSMy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.PProjBtnSMy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.PProjBtnSMy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PProjBtnSMy.ForeColor = System.Drawing.Color.White;
            this.PProjBtnSMy.Location = new System.Drawing.Point(0, 0);
            this.PProjBtnSMy.Margin = new System.Windows.Forms.Padding(0);
            this.PProjBtnSMy.Name = "PProjBtnSMy";
            this.PProjBtnSMy.Size = new System.Drawing.Size(100, 32);
            this.PProjBtnSMy.TabIndex = 5;
            this.PProjBtnSMy.Text = "负责的项目";
            this.PProjBtnSMy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PProjBtnSMy, "我负责的项目");
            this.PProjBtnSMy.UseVisualStyleBackColor = false;
            this.PProjBtnSMy.Click += new System.EventHandler(this.PProjBtnS_Click);
            // 
            // PanelTask
            // 
            this.PanelTask.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelTask.Controls.Add(this.PTaskBtnSAll);
            this.PanelTask.Controls.Add(this.PTaskBtnSPub);
            this.PanelTask.Controls.Add(this.PTaskBtnSMy);
            this.PanelTask.Controls.Add(this.TaskListMy);
            this.PanelTask.Controls.Add(this.TaskListPub);
            this.PanelTask.Controls.Add(this.TaskListAll);
            this.PanelTask.Location = new System.Drawing.Point(144, 257);
            this.PanelTask.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTask.Name = "PanelTask";
            this.PanelTask.Size = new System.Drawing.Size(651, 477);
            this.PanelTask.TabIndex = 17;
            // 
            // PanelProj
            // 
            this.PanelProj.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelProj.Controls.Add(this.PProjBtnSAll);
            this.PanelProj.Controls.Add(this.PProjBtnSMy);
            this.PanelProj.Controls.Add(this.ProjListMy);
            this.PanelProj.Controls.Add(this.ProjListAll);
            this.PanelProj.Location = new System.Drawing.Point(71, 55);
            this.PanelProj.Margin = new System.Windows.Forms.Padding(0);
            this.PanelProj.Name = "PanelProj";
            this.PanelProj.Size = new System.Drawing.Size(651, 477);
            this.PanelProj.TabIndex = 18;
            // 
            // PanelUser
            // 
            this.PanelUser.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelUser.Location = new System.Drawing.Point(700, 32);
            this.PanelUser.Margin = new System.Windows.Forms.Padding(0);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(385, 478);
            this.PanelUser.TabIndex = 7;
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
            this.MessList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessList.FullRowSelect = true;
            this.MessList.GridLines = true;
            this.MessList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.MessList.Location = new System.Drawing.Point(3, 194);
            this.MessList.Name = "MessList";
            this.MessList.Size = new System.Drawing.Size(646, 281);
            this.MessList.TabIndex = 1;
            this.MessList.UseCompatibleStateImageBehavior = false;
            this.MessList.View = System.Windows.Forms.View.Details;
            this.MessList.DoubleClick += new System.EventHandler(this.MessList_DoubleClick);
            // 
            // AnnList
            // 
            this.AnnList.BackColor = System.Drawing.Color.White;
            this.AnnList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnnList.FullRowSelect = true;
            this.AnnList.GridLines = true;
            this.AnnList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.AnnList.Location = new System.Drawing.Point(3, 51);
            this.AnnList.Name = "AnnList";
            this.AnnList.Size = new System.Drawing.Size(646, 102);
            this.AnnList.TabIndex = 0;
            this.AnnList.UseCompatibleStateImageBehavior = false;
            this.AnnList.View = System.Windows.Forms.View.Details;
            // 
            // PanelTaskProfile
            // 
            this.PanelTaskProfile.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelTaskProfile.Location = new System.Drawing.Point(48, 510);
            this.PanelTaskProfile.Name = "PanelTaskProfile";
            this.PanelTaskProfile.Size = new System.Drawing.Size(652, 478);
            this.PanelTaskProfile.TabIndex = 16;
            // 
            // TaskListMy
            // 
            this.TaskListMy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskListMy.BackColor = System.Drawing.Color.RoyalBlue;
            this.TaskListMy.Location = new System.Drawing.Point(0, 32);
            this.TaskListMy.MaximumSize = new System.Drawing.Size(1304, 0);
            this.TaskListMy.Name = "TaskListMy";
            this.TaskListMy.Size = new System.Drawing.Size(651, 0);
            this.TaskListMy.TabIndex = 0;
            // 
            // TaskListPub
            // 
            this.TaskListPub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskListPub.BackColor = System.Drawing.Color.RoyalBlue;
            this.TaskListPub.Location = new System.Drawing.Point(0, 32);
            this.TaskListPub.MaximumSize = new System.Drawing.Size(1304, 0);
            this.TaskListPub.Name = "TaskListPub";
            this.TaskListPub.Size = new System.Drawing.Size(651, 0);
            this.TaskListPub.TabIndex = 0;
            // 
            // TaskListAll
            // 
            this.TaskListAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskListAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.TaskListAll.Location = new System.Drawing.Point(0, 32);
            this.TaskListAll.MaximumSize = new System.Drawing.Size(1304, 0);
            this.TaskListAll.Name = "TaskListAll";
            this.TaskListAll.Size = new System.Drawing.Size(651, 0);
            this.TaskListAll.TabIndex = 0;
            // 
            // ProjListMy
            // 
            this.ProjListMy.BackColor = System.Drawing.Color.RoyalBlue;
            this.ProjListMy.Location = new System.Drawing.Point(0, 32);
            this.ProjListMy.Name = "ProjListMy";
            this.ProjListMy.Size = new System.Drawing.Size(651, 0);
            this.ProjListMy.TabIndex = 0;
            // 
            // ProjListAll
            // 
            this.ProjListAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.ProjListAll.Location = new System.Drawing.Point(0, 32);
            this.ProjListAll.Name = "ProjListAll";
            this.ProjListAll.Size = new System.Drawing.Size(651, 0);
            this.ProjListAll.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(700, 510);
            this.Controls.Add(this.UI_SideBottom);
            this.Controls.Add(this.UI_SideRight);
            this.Controls.Add(this.UI_SideLeft);
            this.Controls.Add(this.PanelUser);
            this.Controls.Add(this.UI_Caption);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.PanelGuide);
            this.Controls.Add(this.PanelGuideS);
            this.Controls.Add(this.PSettings);
            this.Controls.Add(this.PanelContacts);
            this.Controls.Add(this.PanelMessages);
            this.Controls.Add(this.PanelTaskProfile);
            this.Controls.Add(this.PanelTask);
            this.Controls.Add(this.PanelProj);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelGuide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloudStatus)).EndInit();
            this.PanelGuideS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PGuideS_CloudStat)).EndInit();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PLogin_PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLogin_PicCloud)).EndInit();
            this.PanelContacts.ResumeLayout(false);
            this.PanelMessages.ResumeLayout(false);
            this.UI_Caption.ResumeLayout(false);
            this.UI_Caption.PerformLayout();
            this.PSettings.ResumeLayout(false);
            this.PSettings.PerformLayout();
            this.PanelTask.ResumeLayout(false);
            this.PanelTask.PerformLayout();
            this.PanelProj.ResumeLayout(false);
            this.PanelProj.PerformLayout();
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
        private Button PGuideS_BtnCall;
        private Button PGuideS_BtnTask;
        private Button PGuideS_BtnProject;
        private Button PGuideS_BtnContact;
        private Button PGuideS_BtnMessage;
        private PictureBox PGuideS_CloudStat;
        private TabPage ProjMy;
        private TabPage ProjAll;

        private Panel PanelContacts;

        private Panel PanelMessages;
        private ProgressBar PLogin_BarConnecting;
        private PictureBox PLogin_PicCloud;
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
        private LinkLabel LabelFromUserName;
        private UserProfilePanel PanelUser;
        private TaskPanelContainer TaskListPub;
        private TaskPanelContainer TaskListAll;
        private Button BtnLogout;
        private UserList ContactList;
        private Label PLogin_LabelBlock;
        private Panel UI_Caption;
        private Button BtnClose;
        private Button BtnMin;
        private Button PGuideS_BtnPageDown;
        private Button PGuideS_BtnPageUp;
        private Label PGuideS_LabelPage;
        private Button BtnSettings;
        private ProjPanelContainer ProjListMy;
        private ProjPanelContainer ProjListAll;
        private Label LabelTitle;
        private AnnounceList AnnList;
        private MessageList MessList;
        private Label PMess_Label2;
        private PictureBox PLogin_PicLogo;
        private Panel PSettings;
        private Label PSet_Label1;
        private Button PSet_BtnClr1;
        private Button PSet_BtnClr5;
        private Button PSet_BtnClr4;
        private Button PSet_BtnClr3;
        private Button PSet_BtnClr2;
        private Timer PUser_Anim;
        private Label PGuide_Side;
        private Label PMess_Label1;
        private Button PSet_BtnClr6;
        private Label UI_SideLeft;
        private Label UI_SideRight;
        private Label UI_SideBottom;
        private Label PGuideS_SideRight;
        private ToolTip Tips;
        private Label PSet_Label2;
        private CheckBox checkBox1;
        private TaskProfilePanel PanelTaskProfile;
        private Panel PanelTask;
        private Button PTaskBtnSMy;
        private Button PTaskBtnSAll;
        private Button PTaskBtnSPub;
        private Panel PanelProj;
        private Button PProjBtnSAll;
        private Button PProjBtnSMy;
    }
}