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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PGuide_0Panel = new System.Windows.Forms.Panel();
            this.PGuide_PSync = new System.Windows.Forms.Panel();
            this.PGuide_BtnSync = new System.Windows.Forms.Button();
            this.PGuide_LblSync = new System.Windows.Forms.Label();
            this.PGuide_PGSnyc = new System.Windows.Forms.ProgressBar();
            this.PGuide_Side = new System.Windows.Forms.Label();
            this.PGuide_BtnSet = new System.Windows.Forms.Button();
            this.PGuide_BtnLogout = new System.Windows.Forms.Button();
            this.PGuide_BtnCall = new System.Windows.Forms.Button();
            this.PGuide_BtnContact = new System.Windows.Forms.Button();
            this.PGuide_BtnProfile = new System.Windows.Forms.LinkLabel();
            this.PGuide_BtnMess = new System.Windows.Forms.Button();
            this.PGuide_BtnProj = new System.Windows.Forms.Button();
            this.PGuide_BtnTask = new System.Windows.Forms.Button();
            this.PGuideS_0Panel = new System.Windows.Forms.Panel();
            this.PGuideS_BtnSync = new System.Windows.Forms.Button();
            this.PGuideS_BtnMess = new System.Windows.Forms.Button();
            this.PGuideS_BtnCall = new System.Windows.Forms.Button();
            this.PGuideS_BtnContact = new System.Windows.Forms.Button();
            this.PGuideS_BtnProj = new System.Windows.Forms.Button();
            this.PGuideS_BtnTask = new System.Windows.Forms.Button();
            this.PLogin_0Panel = new System.Windows.Forms.Panel();
            this.PLogin_LabelBlock = new System.Windows.Forms.Label();
            this.PLogin_PicLogo = new System.Windows.Forms.PictureBox();
            this.PLogin_TextPsw = new MYTask.LoginTextbox();
            this.PLogin_TextUID = new MYTask.LoginTextbox();
            this.PLogin_PicCloud = new System.Windows.Forms.PictureBox();
            this.PLogin_BarConnecting = new System.Windows.Forms.ProgressBar();
            this.PLogin_BtnFindPsw = new System.Windows.Forms.Button();
            this.PLogin_BtnLogin = new System.Windows.Forms.Button();
            this.PContacts = new System.Windows.Forms.Panel();
            this.ContactList = new MYTask.UserList();
            this.PMess_0Panel = new System.Windows.Forms.Panel();
            this.PMess_Label1 = new System.Windows.Forms.Label();
            this.PMess_Label2 = new System.Windows.Forms.Label();
            this.PMess_MessList = new MYTask.MessageList();
            this.PMess_AnnList = new MYTask.AnnounceList();
            this.UI_Caption = new System.Windows.Forms.Panel();
            this.UI_Title = new System.Windows.Forms.Label();
            this.UI_BtnMin = new System.Windows.Forms.Button();
            this.UI_BtnClose = new System.Windows.Forms.Button();
            this.PSet_0Panel = new System.Windows.Forms.Panel();
            this.PSet_Label2 = new System.Windows.Forms.Label();
            this.PSet_Ck1 = new System.Windows.Forms.CheckBox();
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
            this.PTask_BtnSMy = new System.Windows.Forms.Button();
            this.PTask_BtnSPub = new System.Windows.Forms.Button();
            this.PTask_BtnSAll = new System.Windows.Forms.Button();
            this.PProj_BtnSAll = new System.Windows.Forms.Button();
            this.PProj_BtnSMy = new System.Windows.Forms.Button();
            this.PTask_BtnPgDown = new System.Windows.Forms.Button();
            this.PTask_BtnPgUp = new System.Windows.Forms.Button();
            this.PProj_BtnPgDown = new System.Windows.Forms.Button();
            this.PProj_BtnPgUp = new System.Windows.Forms.Button();
            this.PTask_0Panel = new System.Windows.Forms.Panel();
            this.PTask_LblPage = new System.Windows.Forms.Label();
            this.PTask_TbxPage = new System.Windows.Forms.TextBox();
            this.PTask_ListMy = new MYTask.TaskPanelContainer();
            this.PTask_ListPub = new MYTask.TaskPanelContainer();
            this.PTask_ListAll = new MYTask.TaskPanelContainer();
            this.PProj_0Panel = new System.Windows.Forms.Panel();
            this.PProj_LblPage = new System.Windows.Forms.Label();
            this.PProj_TbxPage = new System.Windows.Forms.TextBox();
            this.PProj_ListMy = new MYTask.ProjPanelContainer();
            this.PProj_ListAll = new MYTask.ProjPanelContainer();
            this.PAudit_Anim = new System.Windows.Forms.Timer(this.components);
            this.PUserProfile = new MYTask.UserProfilePanel();
            this.PAudit = new MYTask.AuditPanel();
            this.PTaskProfile = new MYTask.TaskProfilePanel();
            this.PTView = new MYTask.TViewPanel();
            this.PGuide_0Panel.SuspendLayout();
            this.PGuide_PSync.SuspendLayout();
            this.PGuideS_0Panel.SuspendLayout();
            this.PLogin_0Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PLogin_PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLogin_PicCloud)).BeginInit();
            this.PContacts.SuspendLayout();
            this.PMess_0Panel.SuspendLayout();
            this.UI_Caption.SuspendLayout();
            this.PSet_0Panel.SuspendLayout();
            this.PTask_0Panel.SuspendLayout();
            this.PProj_0Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PGuide_0Panel
            // 
            this.PGuide_0Panel.BackColor = System.Drawing.Color.LightGray;
            this.PGuide_0Panel.Controls.Add(this.PGuide_PSync);
            this.PGuide_0Panel.Controls.Add(this.PGuide_Side);
            this.PGuide_0Panel.Controls.Add(this.PGuide_BtnSet);
            this.PGuide_0Panel.Controls.Add(this.PGuide_BtnLogout);
            this.PGuide_0Panel.Controls.Add(this.PGuide_BtnCall);
            this.PGuide_0Panel.Controls.Add(this.PGuide_BtnContact);
            this.PGuide_0Panel.Controls.Add(this.PGuide_BtnProfile);
            this.PGuide_0Panel.Controls.Add(this.PGuide_BtnMess);
            this.PGuide_0Panel.Controls.Add(this.PGuide_BtnProj);
            this.PGuide_0Panel.Controls.Add(this.PGuide_BtnTask);
            this.PGuide_0Panel.Location = new System.Drawing.Point(-175, 32);
            this.PGuide_0Panel.Margin = new System.Windows.Forms.Padding(0);
            this.PGuide_0Panel.Name = "PGuide_0Panel";
            this.PGuide_0Panel.Size = new System.Drawing.Size(175, 478);
            this.PGuide_0Panel.TabIndex = 0;
            // 
            // PGuide_PSync
            // 
            this.PGuide_PSync.BackColor = System.Drawing.Color.RoyalBlue;
            this.PGuide_PSync.Controls.Add(this.PGuide_BtnSync);
            this.PGuide_PSync.Controls.Add(this.PGuide_LblSync);
            this.PGuide_PSync.Controls.Add(this.PGuide_PGSnyc);
            this.PGuide_PSync.Location = new System.Drawing.Point(0, 430);
            this.PGuide_PSync.Name = "PGuide_PSync";
            this.PGuide_PSync.Size = new System.Drawing.Size(175, 48);
            this.PGuide_PSync.TabIndex = 14;
            // 
            // PGuide_BtnSync
            // 
            this.PGuide_BtnSync.BackColor = System.Drawing.Color.RoyalBlue;
            this.PGuide_BtnSync.FlatAppearance.BorderSize = 0;
            this.PGuide_BtnSync.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.PGuide_BtnSync.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.PGuide_BtnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuide_BtnSync.ForeColor = System.Drawing.Color.White;
            this.PGuide_BtnSync.Image = global::MYTask.Properties.Resources.Cloud_Sync_32;
            this.PGuide_BtnSync.Location = new System.Drawing.Point(127, 0);
            this.PGuide_BtnSync.Name = "PGuide_BtnSync";
            this.PGuide_BtnSync.Size = new System.Drawing.Size(48, 48);
            this.PGuide_BtnSync.TabIndex = 11;
            this.Tips.SetToolTip(this.PGuide_BtnSync, "同步");
            this.PGuide_BtnSync.UseVisualStyleBackColor = false;
            // 
            // PGuide_LblSync
            // 
            this.PGuide_LblSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PGuide_LblSync.BackColor = System.Drawing.Color.Transparent;
            this.PGuide_LblSync.ForeColor = System.Drawing.Color.White;
            this.PGuide_LblSync.Location = new System.Drawing.Point(0, 0);
            this.PGuide_LblSync.Margin = new System.Windows.Forms.Padding(0);
            this.PGuide_LblSync.Name = "PGuide_LblSync";
            this.PGuide_LblSync.Size = new System.Drawing.Size(96, 24);
            this.PGuide_LblSync.TabIndex = 9;
            this.PGuide_LblSync.Text = "同步完成";
            // 
            // PGuide_PGSnyc
            // 
            this.PGuide_PGSnyc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PGuide_PGSnyc.Location = new System.Drawing.Point(3, 26);
            this.PGuide_PGSnyc.MarqueeAnimationSpeed = 3;
            this.PGuide_PGSnyc.Name = "PGuide_PGSnyc";
            this.PGuide_PGSnyc.Size = new System.Drawing.Size(120, 16);
            this.PGuide_PGSnyc.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.PGuide_PGSnyc.TabIndex = 4;
            // 
            // PGuide_Side
            // 
            this.PGuide_Side.BackColor = System.Drawing.Color.RoyalBlue;
            this.PGuide_Side.Location = new System.Drawing.Point(174, 48);
            this.PGuide_Side.Name = "PGuide_Side";
            this.PGuide_Side.Size = new System.Drawing.Size(1, 430);
            this.PGuide_Side.TabIndex = 13;
            // 
            // PGuide_BtnSet
            // 
            this.PGuide_BtnSet.FlatAppearance.BorderSize = 0;
            this.PGuide_BtnSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PGuide_BtnSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PGuide_BtnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuide_BtnSet.Image = global::MYTask.Properties.Resources.Setting_32;
            this.PGuide_BtnSet.Location = new System.Drawing.Point(0, 240);
            this.PGuide_BtnSet.Margin = new System.Windows.Forms.Padding(0);
            this.PGuide_BtnSet.Name = "PGuide_BtnSet";
            this.PGuide_BtnSet.Size = new System.Drawing.Size(48, 48);
            this.PGuide_BtnSet.TabIndex = 12;
            this.PGuide_BtnSet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PGuide_BtnSet, "设置中心");
            this.PGuide_BtnSet.UseVisualStyleBackColor = true;
            this.PGuide_BtnSet.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // PGuide_BtnLogout
            // 
            this.PGuide_BtnLogout.FlatAppearance.BorderSize = 0;
            this.PGuide_BtnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PGuide_BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PGuide_BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuide_BtnLogout.Image = global::MYTask.Properties.Resources.Logout_32;
            this.PGuide_BtnLogout.Location = new System.Drawing.Point(48, 240);
            this.PGuide_BtnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.PGuide_BtnLogout.Name = "PGuide_BtnLogout";
            this.PGuide_BtnLogout.Size = new System.Drawing.Size(48, 48);
            this.PGuide_BtnLogout.TabIndex = 11;
            this.PGuide_BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PGuide_BtnLogout, "注销");
            this.PGuide_BtnLogout.UseVisualStyleBackColor = true;
            this.PGuide_BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // PGuide_BtnCall
            // 
            this.PGuide_BtnCall.BackColor = System.Drawing.Color.RoyalBlue;
            this.PGuide_BtnCall.FlatAppearance.BorderSize = 0;
            this.PGuide_BtnCall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.PGuide_BtnCall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.PGuide_BtnCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuide_BtnCall.ForeColor = System.Drawing.Color.White;
            this.PGuide_BtnCall.Image = global::MYTask.Properties.Resources.ArrowLeft_White_32;
            this.PGuide_BtnCall.Location = new System.Drawing.Point(0, 0);
            this.PGuide_BtnCall.Name = "PGuide_BtnCall";
            this.PGuide_BtnCall.Size = new System.Drawing.Size(48, 48);
            this.PGuide_BtnCall.TabIndex = 10;
            this.PGuide_BtnCall.UseVisualStyleBackColor = false;
            this.PGuide_BtnCall.Click += new System.EventHandler(this.BtnCall_Click);
            // 
            // PGuide_BtnContact
            // 
            this.PGuide_BtnContact.BackColor = System.Drawing.Color.LightGray;
            this.PGuide_BtnContact.FlatAppearance.BorderSize = 0;
            this.PGuide_BtnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PGuide_BtnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PGuide_BtnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuide_BtnContact.Location = new System.Drawing.Point(0, 144);
            this.PGuide_BtnContact.Margin = new System.Windows.Forms.Padding(0);
            this.PGuide_BtnContact.Name = "PGuide_BtnContact";
            this.PGuide_BtnContact.Size = new System.Drawing.Size(174, 48);
            this.PGuide_BtnContact.TabIndex = 8;
            this.PGuide_BtnContact.Text = "通讯录";
            this.PGuide_BtnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PGuide_BtnContact.UseVisualStyleBackColor = false;
            this.PGuide_BtnContact.Click += new System.EventHandler(this.BtnContact_Click);
            // 
            // PGuide_BtnProfile
            // 
            this.PGuide_BtnProfile.ActiveLinkColor = System.Drawing.Color.Navy;
            this.PGuide_BtnProfile.BackColor = System.Drawing.Color.RoyalBlue;
            this.PGuide_BtnProfile.DisabledLinkColor = System.Drawing.Color.DimGray;
            this.PGuide_BtnProfile.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.PGuide_BtnProfile.LinkColor = System.Drawing.Color.White;
            this.PGuide_BtnProfile.Location = new System.Drawing.Point(48, 0);
            this.PGuide_BtnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.PGuide_BtnProfile.Name = "PGuide_BtnProfile";
            this.PGuide_BtnProfile.Size = new System.Drawing.Size(127, 48);
            this.PGuide_BtnProfile.TabIndex = 7;
            this.PGuide_BtnProfile.TabStop = true;
            this.PGuide_BtnProfile.Text = "学生会信息部\r\n开发人员";
            this.PGuide_BtnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PGuide_BtnProfile, "用户信息");
            this.PGuide_BtnProfile.VisitedLinkColor = System.Drawing.Color.White;
            this.PGuide_BtnProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnProfile_LinkClicked);
            // 
            // PGuide_BtnMess
            // 
            this.PGuide_BtnMess.BackColor = System.Drawing.Color.LightGray;
            this.PGuide_BtnMess.FlatAppearance.BorderSize = 0;
            this.PGuide_BtnMess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PGuide_BtnMess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PGuide_BtnMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuide_BtnMess.Location = new System.Drawing.Point(0, 192);
            this.PGuide_BtnMess.Margin = new System.Windows.Forms.Padding(0);
            this.PGuide_BtnMess.Name = "PGuide_BtnMess";
            this.PGuide_BtnMess.Size = new System.Drawing.Size(174, 48);
            this.PGuide_BtnMess.TabIndex = 3;
            this.PGuide_BtnMess.Text = "消息";
            this.PGuide_BtnMess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PGuide_BtnMess.UseVisualStyleBackColor = false;
            this.PGuide_BtnMess.Click += new System.EventHandler(this.BtnMessage_Click);
            // 
            // PGuide_BtnProj
            // 
            this.PGuide_BtnProj.BackColor = System.Drawing.Color.LightGray;
            this.PGuide_BtnProj.FlatAppearance.BorderSize = 0;
            this.PGuide_BtnProj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PGuide_BtnProj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PGuide_BtnProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuide_BtnProj.Location = new System.Drawing.Point(0, 96);
            this.PGuide_BtnProj.Margin = new System.Windows.Forms.Padding(0);
            this.PGuide_BtnProj.Name = "PGuide_BtnProj";
            this.PGuide_BtnProj.Size = new System.Drawing.Size(174, 48);
            this.PGuide_BtnProj.TabIndex = 2;
            this.PGuide_BtnProj.Text = "我的项目";
            this.PGuide_BtnProj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PGuide_BtnProj.UseVisualStyleBackColor = false;
            this.PGuide_BtnProj.Click += new System.EventHandler(this.BtnProject_Click);
            // 
            // PGuide_BtnTask
            // 
            this.PGuide_BtnTask.BackColor = System.Drawing.Color.LightGray;
            this.PGuide_BtnTask.FlatAppearance.BorderSize = 0;
            this.PGuide_BtnTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PGuide_BtnTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PGuide_BtnTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuide_BtnTask.Location = new System.Drawing.Point(0, 48);
            this.PGuide_BtnTask.Margin = new System.Windows.Forms.Padding(0);
            this.PGuide_BtnTask.Name = "PGuide_BtnTask";
            this.PGuide_BtnTask.Size = new System.Drawing.Size(174, 48);
            this.PGuide_BtnTask.TabIndex = 1;
            this.PGuide_BtnTask.Text = "我的任务";
            this.PGuide_BtnTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PGuide_BtnTask.UseVisualStyleBackColor = false;
            this.PGuide_BtnTask.Click += new System.EventHandler(this.BtnTask_Click);
            // 
            // PGuideS_0Panel
            // 
            this.PGuideS_0Panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.PGuideS_0Panel.Controls.Add(this.PGuideS_BtnSync);
            this.PGuideS_0Panel.Controls.Add(this.PGuideS_BtnMess);
            this.PGuideS_0Panel.Controls.Add(this.PGuideS_BtnCall);
            this.PGuideS_0Panel.Controls.Add(this.PGuideS_BtnContact);
            this.PGuideS_0Panel.Controls.Add(this.PGuideS_BtnProj);
            this.PGuideS_0Panel.Controls.Add(this.PGuideS_BtnTask);
            this.PGuideS_0Panel.Location = new System.Drawing.Point(0, 32);
            this.PGuideS_0Panel.Margin = new System.Windows.Forms.Padding(0);
            this.PGuideS_0Panel.Name = "PGuideS_0Panel";
            this.PGuideS_0Panel.Size = new System.Drawing.Size(48, 478);
            this.PGuideS_0Panel.TabIndex = 4;
            // 
            // PGuideS_BtnSync
            // 
            this.PGuideS_BtnSync.FlatAppearance.BorderSize = 0;
            this.PGuideS_BtnSync.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PGuideS_BtnSync.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PGuideS_BtnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuideS_BtnSync.Image = global::MYTask.Properties.Resources.Cloud_Sync_32;
            this.PGuideS_BtnSync.Location = new System.Drawing.Point(0, 430);
            this.PGuideS_BtnSync.Margin = new System.Windows.Forms.Padding(0);
            this.PGuideS_BtnSync.Name = "PGuideS_BtnSync";
            this.PGuideS_BtnSync.Size = new System.Drawing.Size(48, 48);
            this.PGuideS_BtnSync.TabIndex = 7;
            this.PGuideS_BtnSync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PGuideS_BtnSync, "同步");
            this.PGuideS_BtnSync.UseVisualStyleBackColor = true;
            // 
            // PGuideS_BtnMess
            // 
            this.PGuideS_BtnMess.FlatAppearance.BorderSize = 0;
            this.PGuideS_BtnMess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PGuideS_BtnMess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PGuideS_BtnMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuideS_BtnMess.Image = global::MYTask.Properties.Resources.Message_32;
            this.PGuideS_BtnMess.Location = new System.Drawing.Point(0, 192);
            this.PGuideS_BtnMess.Margin = new System.Windows.Forms.Padding(0);
            this.PGuideS_BtnMess.Name = "PGuideS_BtnMess";
            this.PGuideS_BtnMess.Size = new System.Drawing.Size(48, 48);
            this.PGuideS_BtnMess.TabIndex = 6;
            this.PGuideS_BtnMess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PGuideS_BtnMess, "通知中心");
            this.PGuideS_BtnMess.UseVisualStyleBackColor = true;
            this.PGuideS_BtnMess.Click += new System.EventHandler(this.BtnMessage_Click);
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
            // PGuideS_BtnProj
            // 
            this.PGuideS_BtnProj.BackColor = System.Drawing.Color.Transparent;
            this.PGuideS_BtnProj.FlatAppearance.BorderSize = 0;
            this.PGuideS_BtnProj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PGuideS_BtnProj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PGuideS_BtnProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGuideS_BtnProj.Image = global::MYTask.Properties.Resources.Project_32;
            this.PGuideS_BtnProj.Location = new System.Drawing.Point(0, 96);
            this.PGuideS_BtnProj.Margin = new System.Windows.Forms.Padding(0);
            this.PGuideS_BtnProj.Name = "PGuideS_BtnProj";
            this.PGuideS_BtnProj.Size = new System.Drawing.Size(48, 48);
            this.PGuideS_BtnProj.TabIndex = 2;
            this.PGuideS_BtnProj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PGuideS_BtnProj, "项目列表");
            this.PGuideS_BtnProj.UseVisualStyleBackColor = false;
            this.PGuideS_BtnProj.Click += new System.EventHandler(this.BtnProject_Click);
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
            // PLogin_0Panel
            // 
            this.PLogin_0Panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.PLogin_0Panel.Controls.Add(this.PLogin_LabelBlock);
            this.PLogin_0Panel.Controls.Add(this.PLogin_PicLogo);
            this.PLogin_0Panel.Controls.Add(this.PLogin_TextPsw);
            this.PLogin_0Panel.Controls.Add(this.PLogin_TextUID);
            this.PLogin_0Panel.Controls.Add(this.PLogin_PicCloud);
            this.PLogin_0Panel.Controls.Add(this.PLogin_BarConnecting);
            this.PLogin_0Panel.Controls.Add(this.PLogin_BtnFindPsw);
            this.PLogin_0Panel.Controls.Add(this.PLogin_BtnLogin);
            this.PLogin_0Panel.Location = new System.Drawing.Point(0, 510);
            this.PLogin_0Panel.Margin = new System.Windows.Forms.Padding(0);
            this.PLogin_0Panel.Name = "PLogin_0Panel";
            this.PLogin_0Panel.Size = new System.Drawing.Size(700, 478);
            this.PLogin_0Panel.TabIndex = 6;
            this.PLogin_0Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UI_Caption_MouseDown);
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
            this.PLogin_BtnFindPsw.FlatAppearance.BorderSize = 0;
            this.PLogin_BtnFindPsw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PLogin_BtnFindPsw.Image = global::MYTask.Properties.Resources.FindPsw_32;
            this.PLogin_BtnFindPsw.Location = new System.Drawing.Point(436, 254);
            this.PLogin_BtnFindPsw.Name = "PLogin_BtnFindPsw";
            this.PLogin_BtnFindPsw.Size = new System.Drawing.Size(33, 33);
            this.PLogin_BtnFindPsw.TabIndex = 6;
            this.PLogin_BtnFindPsw.UseVisualStyleBackColor = true;
            this.PLogin_BtnFindPsw.Visible = false;
            this.PLogin_BtnFindPsw.Click += new System.EventHandler(this.BtnFindPsw_Click);
            // 
            // PLogin_BtnLogin
            // 
            this.PLogin_BtnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.PLogin_BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PLogin_BtnLogin.FlatAppearance.BorderSize = 0;
            this.PLogin_BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PLogin_BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PLogin_BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PLogin_BtnLogin.Image = global::MYTask.Properties.Resources.Login_32;
            this.PLogin_BtnLogin.Location = new System.Drawing.Point(400, 254);
            this.PLogin_BtnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.PLogin_BtnLogin.Name = "PLogin_BtnLogin";
            this.PLogin_BtnLogin.Size = new System.Drawing.Size(33, 33);
            this.PLogin_BtnLogin.TabIndex = 5;
            this.PLogin_BtnLogin.UseVisualStyleBackColor = false;
            this.PLogin_BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // PContacts
            // 
            this.PContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PContacts.BackColor = System.Drawing.Color.Green;
            this.PContacts.Controls.Add(this.ContactList);
            this.PContacts.Location = new System.Drawing.Point(48, 510);
            this.PContacts.Name = "PContacts";
            this.PContacts.Size = new System.Drawing.Size(652, 478);
            this.PContacts.TabIndex = 9;
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
            // PMess_0Panel
            // 
            this.PMess_0Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PMess_0Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.PMess_0Panel.Controls.Add(this.PMess_Label1);
            this.PMess_0Panel.Controls.Add(this.PMess_Label2);
            this.PMess_0Panel.Controls.Add(this.PMess_MessList);
            this.PMess_0Panel.Controls.Add(this.PMess_AnnList);
            this.PMess_0Panel.Location = new System.Drawing.Point(48, 510);
            this.PMess_0Panel.Name = "PMess_0Panel";
            this.PMess_0Panel.Size = new System.Drawing.Size(651, 477);
            this.PMess_0Panel.TabIndex = 10;
            // 
            // PMess_Label1
            // 
            this.PMess_Label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.PMess_Label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PMess_Label1.ForeColor = System.Drawing.Color.White;
            this.PMess_Label1.Location = new System.Drawing.Point(0, 0);
            this.PMess_Label1.Margin = new System.Windows.Forms.Padding(0);
            this.PMess_Label1.Name = "PMess_Label1";
            this.PMess_Label1.Size = new System.Drawing.Size(651, 32);
            this.PMess_Label1.TabIndex = 3;
            this.PMess_Label1.Text = "公告";
            this.PMess_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PMess_Label2
            // 
            this.PMess_Label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.PMess_Label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PMess_Label2.ForeColor = System.Drawing.Color.White;
            this.PMess_Label2.Location = new System.Drawing.Point(0, 134);
            this.PMess_Label2.Name = "PMess_Label2";
            this.PMess_Label2.Size = new System.Drawing.Size(651, 32);
            this.PMess_Label2.TabIndex = 2;
            this.PMess_Label2.Text = "消息";
            this.PMess_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PMess_MessList
            // 
            this.PMess_MessList.BackColor = System.Drawing.Color.White;
            this.PMess_MessList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PMess_MessList.FullRowSelect = true;
            this.PMess_MessList.GridLines = true;
            this.PMess_MessList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.PMess_MessList.Location = new System.Drawing.Point(0, 166);
            this.PMess_MessList.Name = "PMess_MessList";
            this.PMess_MessList.Size = new System.Drawing.Size(651, 311);
            this.PMess_MessList.TabIndex = 1;
            this.PMess_MessList.UseCompatibleStateImageBehavior = false;
            this.PMess_MessList.View = System.Windows.Forms.View.Details;
            this.PMess_MessList.DoubleClick += new System.EventHandler(this.MessList_DoubleClick);
            // 
            // PMess_AnnList
            // 
            this.PMess_AnnList.BackColor = System.Drawing.Color.White;
            this.PMess_AnnList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PMess_AnnList.FullRowSelect = true;
            this.PMess_AnnList.GridLines = true;
            this.PMess_AnnList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.PMess_AnnList.Location = new System.Drawing.Point(0, 32);
            this.PMess_AnnList.Name = "PMess_AnnList";
            this.PMess_AnnList.Size = new System.Drawing.Size(651, 102);
            this.PMess_AnnList.TabIndex = 0;
            this.PMess_AnnList.UseCompatibleStateImageBehavior = false;
            this.PMess_AnnList.View = System.Windows.Forms.View.Details;
            // 
            // UI_Caption
            // 
            this.UI_Caption.BackColor = System.Drawing.Color.RoyalBlue;
            this.UI_Caption.Controls.Add(this.UI_Title);
            this.UI_Caption.Controls.Add(this.UI_BtnMin);
            this.UI_Caption.Controls.Add(this.UI_BtnClose);
            this.UI_Caption.Location = new System.Drawing.Point(0, 0);
            this.UI_Caption.Margin = new System.Windows.Forms.Padding(0);
            this.UI_Caption.Name = "UI_Caption";
            this.UI_Caption.Size = new System.Drawing.Size(700, 32);
            this.UI_Caption.TabIndex = 11;
            this.UI_Caption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UI_Caption_MouseDown);
            // 
            // UI_Title
            // 
            this.UI_Title.AutoSize = true;
            this.UI_Title.ForeColor = System.Drawing.Color.White;
            this.UI_Title.Location = new System.Drawing.Point(3, 6);
            this.UI_Title.Name = "UI_Title";
            this.UI_Title.Size = new System.Drawing.Size(93, 21);
            this.UI_Title.TabIndex = 2;
            this.UI_Title.Text = "WSS - 登录";
            this.UI_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UI_Caption_MouseDown);
            // 
            // UI_BtnMin
            // 
            this.UI_BtnMin.FlatAppearance.BorderSize = 0;
            this.UI_BtnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.UI_BtnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.UI_BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UI_BtnMin.Image = global::MYTask.Properties.Resources.min_24;
            this.UI_BtnMin.Location = new System.Drawing.Point(636, 0);
            this.UI_BtnMin.Margin = new System.Windows.Forms.Padding(0);
            this.UI_BtnMin.Name = "UI_BtnMin";
            this.UI_BtnMin.Size = new System.Drawing.Size(32, 32);
            this.UI_BtnMin.TabIndex = 1;
            this.Tips.SetToolTip(this.UI_BtnMin, "最小化");
            this.UI_BtnMin.UseVisualStyleBackColor = true;
            this.UI_BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // UI_BtnClose
            // 
            this.UI_BtnClose.FlatAppearance.BorderSize = 0;
            this.UI_BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.UI_BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UI_BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UI_BtnClose.Image = global::MYTask.Properties.Resources.close_24;
            this.UI_BtnClose.Location = new System.Drawing.Point(668, 0);
            this.UI_BtnClose.Name = "UI_BtnClose";
            this.UI_BtnClose.Size = new System.Drawing.Size(32, 32);
            this.UI_BtnClose.TabIndex = 0;
            this.Tips.SetToolTip(this.UI_BtnClose, "退出");
            this.UI_BtnClose.UseVisualStyleBackColor = true;
            this.UI_BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PSet_0Panel
            // 
            this.PSet_0Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.PSet_0Panel.Controls.Add(this.PSet_Label2);
            this.PSet_0Panel.Controls.Add(this.PSet_Ck1);
            this.PSet_0Panel.Controls.Add(this.PSet_BtnClr6);
            this.PSet_0Panel.Controls.Add(this.PSet_BtnClr5);
            this.PSet_0Panel.Controls.Add(this.PSet_BtnClr4);
            this.PSet_0Panel.Controls.Add(this.PSet_BtnClr3);
            this.PSet_0Panel.Controls.Add(this.PSet_BtnClr2);
            this.PSet_0Panel.Controls.Add(this.PSet_BtnClr1);
            this.PSet_0Panel.Controls.Add(this.PSet_Label1);
            this.PSet_0Panel.Location = new System.Drawing.Point(48, 510);
            this.PSet_0Panel.Margin = new System.Windows.Forms.Padding(0);
            this.PSet_0Panel.Name = "PSet_0Panel";
            this.PSet_0Panel.Size = new System.Drawing.Size(652, 478);
            this.PSet_0Panel.TabIndex = 12;
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
            // PSet_Ck1
            // 
            this.PSet_Ck1.AutoSize = true;
            this.PSet_Ck1.Location = new System.Drawing.Point(10, 97);
            this.PSet_Ck1.Name = "PSet_Ck1";
            this.PSet_Ck1.Size = new System.Drawing.Size(173, 25);
            this.PSet_Ck1.TabIndex = 8;
            this.PSet_Ck1.Text = "隐藏完成验收的任务";
            this.PSet_Ck1.UseVisualStyleBackColor = true;
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
            // PTask_BtnSMy
            // 
            this.PTask_BtnSMy.AutoSize = true;
            this.PTask_BtnSMy.BackColor = System.Drawing.Color.RoyalBlue;
            this.PTask_BtnSMy.FlatAppearance.BorderSize = 0;
            this.PTask_BtnSMy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.PTask_BtnSMy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.PTask_BtnSMy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PTask_BtnSMy.ForeColor = System.Drawing.Color.White;
            this.PTask_BtnSMy.Location = new System.Drawing.Point(0, 0);
            this.PTask_BtnSMy.Margin = new System.Windows.Forms.Padding(0);
            this.PTask_BtnSMy.Name = "PTask_BtnSMy";
            this.PTask_BtnSMy.Size = new System.Drawing.Size(100, 32);
            this.PTask_BtnSMy.TabIndex = 5;
            this.PTask_BtnSMy.Text = "负责的任务";
            this.PTask_BtnSMy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PTask_BtnSMy, "指派给我的任务");
            this.PTask_BtnSMy.UseVisualStyleBackColor = false;
            this.PTask_BtnSMy.Click += new System.EventHandler(this.PTaskBtnS_Click);
            // 
            // PTask_BtnSPub
            // 
            this.PTask_BtnSPub.AutoSize = true;
            this.PTask_BtnSPub.BackColor = System.Drawing.Color.Gainsboro;
            this.PTask_BtnSPub.FlatAppearance.BorderSize = 0;
            this.PTask_BtnSPub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.PTask_BtnSPub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.PTask_BtnSPub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PTask_BtnSPub.ForeColor = System.Drawing.Color.Black;
            this.PTask_BtnSPub.Location = new System.Drawing.Point(100, 0);
            this.PTask_BtnSPub.Margin = new System.Windows.Forms.Padding(0);
            this.PTask_BtnSPub.Name = "PTask_BtnSPub";
            this.PTask_BtnSPub.Size = new System.Drawing.Size(100, 32);
            this.PTask_BtnSPub.TabIndex = 6;
            this.PTask_BtnSPub.Text = "发布的任务";
            this.PTask_BtnSPub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PTask_BtnSPub, "我发布的任务");
            this.PTask_BtnSPub.UseVisualStyleBackColor = false;
            this.PTask_BtnSPub.Click += new System.EventHandler(this.PTaskBtnS_Click);
            // 
            // PTask_BtnSAll
            // 
            this.PTask_BtnSAll.AutoSize = true;
            this.PTask_BtnSAll.BackColor = System.Drawing.Color.Gainsboro;
            this.PTask_BtnSAll.FlatAppearance.BorderSize = 0;
            this.PTask_BtnSAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.PTask_BtnSAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.PTask_BtnSAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PTask_BtnSAll.ForeColor = System.Drawing.Color.Black;
            this.PTask_BtnSAll.Location = new System.Drawing.Point(200, 0);
            this.PTask_BtnSAll.Margin = new System.Windows.Forms.Padding(0);
            this.PTask_BtnSAll.Name = "PTask_BtnSAll";
            this.PTask_BtnSAll.Size = new System.Drawing.Size(84, 32);
            this.PTask_BtnSAll.TabIndex = 7;
            this.PTask_BtnSAll.Text = "所有任务";
            this.PTask_BtnSAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PTask_BtnSAll, "当前系统中的全部任务");
            this.PTask_BtnSAll.UseVisualStyleBackColor = false;
            this.PTask_BtnSAll.Click += new System.EventHandler(this.PTaskBtnS_Click);
            // 
            // PProj_BtnSAll
            // 
            this.PProj_BtnSAll.AutoSize = true;
            this.PProj_BtnSAll.BackColor = System.Drawing.Color.Gainsboro;
            this.PProj_BtnSAll.FlatAppearance.BorderSize = 0;
            this.PProj_BtnSAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.PProj_BtnSAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.PProj_BtnSAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PProj_BtnSAll.ForeColor = System.Drawing.Color.Black;
            this.PProj_BtnSAll.Location = new System.Drawing.Point(100, 0);
            this.PProj_BtnSAll.Margin = new System.Windows.Forms.Padding(0);
            this.PProj_BtnSAll.Name = "PProj_BtnSAll";
            this.PProj_BtnSAll.Size = new System.Drawing.Size(84, 32);
            this.PProj_BtnSAll.TabIndex = 6;
            this.PProj_BtnSAll.Text = "所有项目";
            this.PProj_BtnSAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PProj_BtnSAll, "当前系统中的全部项目");
            this.PProj_BtnSAll.UseVisualStyleBackColor = false;
            this.PProj_BtnSAll.Click += new System.EventHandler(this.PProjBtnS_Click);
            // 
            // PProj_BtnSMy
            // 
            this.PProj_BtnSMy.AutoSize = true;
            this.PProj_BtnSMy.BackColor = System.Drawing.Color.RoyalBlue;
            this.PProj_BtnSMy.FlatAppearance.BorderSize = 0;
            this.PProj_BtnSMy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.PProj_BtnSMy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.PProj_BtnSMy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PProj_BtnSMy.ForeColor = System.Drawing.Color.White;
            this.PProj_BtnSMy.Location = new System.Drawing.Point(0, 0);
            this.PProj_BtnSMy.Margin = new System.Windows.Forms.Padding(0);
            this.PProj_BtnSMy.Name = "PProj_BtnSMy";
            this.PProj_BtnSMy.Size = new System.Drawing.Size(100, 32);
            this.PProj_BtnSMy.TabIndex = 5;
            this.PProj_BtnSMy.Text = "负责的项目";
            this.PProj_BtnSMy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PProj_BtnSMy, "我负责的项目");
            this.PProj_BtnSMy.UseVisualStyleBackColor = false;
            this.PProj_BtnSMy.Click += new System.EventHandler(this.PProjBtnS_Click);
            // 
            // PTask_BtnPgDown
            // 
            this.PTask_BtnPgDown.BackColor = System.Drawing.Color.Transparent;
            this.PTask_BtnPgDown.FlatAppearance.BorderSize = 0;
            this.PTask_BtnPgDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PTask_BtnPgDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PTask_BtnPgDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PTask_BtnPgDown.Image = global::MYTask.Properties.Resources.ArrowRight_32;
            this.PTask_BtnPgDown.Location = new System.Drawing.Point(619, 0);
            this.PTask_BtnPgDown.Margin = new System.Windows.Forms.Padding(0);
            this.PTask_BtnPgDown.Name = "PTask_BtnPgDown";
            this.PTask_BtnPgDown.Size = new System.Drawing.Size(32, 32);
            this.PTask_BtnPgDown.TabIndex = 9;
            this.PTask_BtnPgDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PTask_BtnPgDown, "上一页");
            this.PTask_BtnPgDown.UseVisualStyleBackColor = false;
            this.PTask_BtnPgDown.Click += new System.EventHandler(this.BtnPageDown_Click);
            // 
            // PTask_BtnPgUp
            // 
            this.PTask_BtnPgUp.BackColor = System.Drawing.Color.Transparent;
            this.PTask_BtnPgUp.FlatAppearance.BorderSize = 0;
            this.PTask_BtnPgUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PTask_BtnPgUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PTask_BtnPgUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PTask_BtnPgUp.Image = global::MYTask.Properties.Resources.ArrowLeft_32;
            this.PTask_BtnPgUp.Location = new System.Drawing.Point(526, 0);
            this.PTask_BtnPgUp.Margin = new System.Windows.Forms.Padding(0);
            this.PTask_BtnPgUp.Name = "PTask_BtnPgUp";
            this.PTask_BtnPgUp.Size = new System.Drawing.Size(32, 32);
            this.PTask_BtnPgUp.TabIndex = 8;
            this.PTask_BtnPgUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PTask_BtnPgUp, "上一页");
            this.PTask_BtnPgUp.UseVisualStyleBackColor = false;
            this.PTask_BtnPgUp.Click += new System.EventHandler(this.BtnPageUp_Click);
            // 
            // PProj_BtnPgDown
            // 
            this.PProj_BtnPgDown.BackColor = System.Drawing.Color.Transparent;
            this.PProj_BtnPgDown.FlatAppearance.BorderSize = 0;
            this.PProj_BtnPgDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PProj_BtnPgDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PProj_BtnPgDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PProj_BtnPgDown.Image = global::MYTask.Properties.Resources.ArrowRight_32;
            this.PProj_BtnPgDown.Location = new System.Drawing.Point(619, 0);
            this.PProj_BtnPgDown.Margin = new System.Windows.Forms.Padding(0);
            this.PProj_BtnPgDown.Name = "PProj_BtnPgDown";
            this.PProj_BtnPgDown.Size = new System.Drawing.Size(32, 32);
            this.PProj_BtnPgDown.TabIndex = 13;
            this.PProj_BtnPgDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PProj_BtnPgDown, "上一页");
            this.PProj_BtnPgDown.UseVisualStyleBackColor = false;
            this.PProj_BtnPgDown.Click += new System.EventHandler(this.BtnPageDown_Click);
            // 
            // PProj_BtnPgUp
            // 
            this.PProj_BtnPgUp.BackColor = System.Drawing.Color.Transparent;
            this.PProj_BtnPgUp.FlatAppearance.BorderSize = 0;
            this.PProj_BtnPgUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PProj_BtnPgUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PProj_BtnPgUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PProj_BtnPgUp.Image = global::MYTask.Properties.Resources.ArrowLeft_32;
            this.PProj_BtnPgUp.Location = new System.Drawing.Point(526, 0);
            this.PProj_BtnPgUp.Margin = new System.Windows.Forms.Padding(0);
            this.PProj_BtnPgUp.Name = "PProj_BtnPgUp";
            this.PProj_BtnPgUp.Size = new System.Drawing.Size(32, 32);
            this.PProj_BtnPgUp.TabIndex = 12;
            this.PProj_BtnPgUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tips.SetToolTip(this.PProj_BtnPgUp, "上一页");
            this.PProj_BtnPgUp.UseVisualStyleBackColor = false;
            this.PProj_BtnPgUp.Click += new System.EventHandler(this.BtnPageUp_Click);
            // 
            // PTask_0Panel
            // 
            this.PTask_0Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.PTask_0Panel.Controls.Add(this.PTask_LblPage);
            this.PTask_0Panel.Controls.Add(this.PTask_TbxPage);
            this.PTask_0Panel.Controls.Add(this.PTask_BtnPgDown);
            this.PTask_0Panel.Controls.Add(this.PTask_BtnPgUp);
            this.PTask_0Panel.Controls.Add(this.PTask_BtnSAll);
            this.PTask_0Panel.Controls.Add(this.PTask_BtnSPub);
            this.PTask_0Panel.Controls.Add(this.PTask_BtnSMy);
            this.PTask_0Panel.Controls.Add(this.PTask_ListMy);
            this.PTask_0Panel.Controls.Add(this.PTask_ListPub);
            this.PTask_0Panel.Controls.Add(this.PTask_ListAll);
            this.PTask_0Panel.Location = new System.Drawing.Point(48, 510);
            this.PTask_0Panel.Margin = new System.Windows.Forms.Padding(0);
            this.PTask_0Panel.Name = "PTask_0Panel";
            this.PTask_0Panel.Size = new System.Drawing.Size(651, 477);
            this.PTask_0Panel.TabIndex = 17;
            // 
            // PTask_LblPage
            // 
            this.PTask_LblPage.AutoSize = true;
            this.PTask_LblPage.Location = new System.Drawing.Point(584, 6);
            this.PTask_LblPage.Margin = new System.Windows.Forms.Padding(0);
            this.PTask_LblPage.Name = "PTask_LblPage";
            this.PTask_LblPage.Size = new System.Drawing.Size(35, 21);
            this.PTask_LblPage.TabIndex = 11;
            this.PTask_LblPage.Text = "/99";
            // 
            // PTask_TbxPage
            // 
            this.PTask_TbxPage.Location = new System.Drawing.Point(558, 3);
            this.PTask_TbxPage.Margin = new System.Windows.Forms.Padding(0);
            this.PTask_TbxPage.Name = "PTask_TbxPage";
            this.PTask_TbxPage.Size = new System.Drawing.Size(25, 29);
            this.PTask_TbxPage.TabIndex = 10;
            this.PTask_TbxPage.Text = "99";
            this.PTask_TbxPage.TextChanged += new System.EventHandler(this.TbxPage_TextChange);
            // 
            // PTask_ListMy
            // 
            this.PTask_ListMy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PTask_ListMy.BackColor = System.Drawing.Color.RoyalBlue;
            this.PTask_ListMy.Location = new System.Drawing.Point(0, 32);
            this.PTask_ListMy.MaximumSize = new System.Drawing.Size(1304, 0);
            this.PTask_ListMy.Name = "PTask_ListMy";
            this.PTask_ListMy.Size = new System.Drawing.Size(651, 0);
            this.PTask_ListMy.TabIndex = 0;
            // 
            // PTask_ListPub
            // 
            this.PTask_ListPub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PTask_ListPub.BackColor = System.Drawing.Color.RoyalBlue;
            this.PTask_ListPub.Location = new System.Drawing.Point(0, 32);
            this.PTask_ListPub.MaximumSize = new System.Drawing.Size(1304, 0);
            this.PTask_ListPub.Name = "PTask_ListPub";
            this.PTask_ListPub.Size = new System.Drawing.Size(651, 0);
            this.PTask_ListPub.TabIndex = 0;
            // 
            // PTask_ListAll
            // 
            this.PTask_ListAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PTask_ListAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.PTask_ListAll.Location = new System.Drawing.Point(0, 32);
            this.PTask_ListAll.MaximumSize = new System.Drawing.Size(1304, 0);
            this.PTask_ListAll.Name = "PTask_ListAll";
            this.PTask_ListAll.Size = new System.Drawing.Size(651, 0);
            this.PTask_ListAll.TabIndex = 0;
            // 
            // PProj_0Panel
            // 
            this.PProj_0Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.PProj_0Panel.Controls.Add(this.PProj_LblPage);
            this.PProj_0Panel.Controls.Add(this.PProj_TbxPage);
            this.PProj_0Panel.Controls.Add(this.PProj_BtnPgDown);
            this.PProj_0Panel.Controls.Add(this.PProj_BtnPgUp);
            this.PProj_0Panel.Controls.Add(this.PProj_BtnSAll);
            this.PProj_0Panel.Controls.Add(this.PProj_BtnSMy);
            this.PProj_0Panel.Controls.Add(this.PProj_ListMy);
            this.PProj_0Panel.Controls.Add(this.PProj_ListAll);
            this.PProj_0Panel.Location = new System.Drawing.Point(48, 510);
            this.PProj_0Panel.Margin = new System.Windows.Forms.Padding(0);
            this.PProj_0Panel.Name = "PProj_0Panel";
            this.PProj_0Panel.Size = new System.Drawing.Size(651, 477);
            this.PProj_0Panel.TabIndex = 18;
            // 
            // PProj_LblPage
            // 
            this.PProj_LblPage.AutoSize = true;
            this.PProj_LblPage.Location = new System.Drawing.Point(584, 6);
            this.PProj_LblPage.Margin = new System.Windows.Forms.Padding(0);
            this.PProj_LblPage.Name = "PProj_LblPage";
            this.PProj_LblPage.Size = new System.Drawing.Size(35, 21);
            this.PProj_LblPage.TabIndex = 15;
            this.PProj_LblPage.Text = "/99";
            // 
            // PProj_TbxPage
            // 
            this.PProj_TbxPage.Location = new System.Drawing.Point(558, 3);
            this.PProj_TbxPage.Margin = new System.Windows.Forms.Padding(0);
            this.PProj_TbxPage.Name = "PProj_TbxPage";
            this.PProj_TbxPage.Size = new System.Drawing.Size(25, 29);
            this.PProj_TbxPage.TabIndex = 14;
            this.PProj_TbxPage.Text = "99";
            this.PProj_TbxPage.TextChanged += new System.EventHandler(this.TbxPage_TextChange);
            // 
            // PProj_ListMy
            // 
            this.PProj_ListMy.BackColor = System.Drawing.Color.RoyalBlue;
            this.PProj_ListMy.Location = new System.Drawing.Point(0, 32);
            this.PProj_ListMy.Name = "PProj_ListMy";
            this.PProj_ListMy.Size = new System.Drawing.Size(651, 0);
            this.PProj_ListMy.TabIndex = 0;
            // 
            // PProj_ListAll
            // 
            this.PProj_ListAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.PProj_ListAll.Location = new System.Drawing.Point(0, 32);
            this.PProj_ListAll.Name = "PProj_ListAll";
            this.PProj_ListAll.Size = new System.Drawing.Size(651, 0);
            this.PProj_ListAll.TabIndex = 1;
            // 
            // PAudit_Anim
            // 
            this.PAudit_Anim.Interval = 15;
            this.PAudit_Anim.Tick += new System.EventHandler(this.PAudit_Anim_Tick);
            // 
            // PUserProfile
            // 
            this.PUserProfile.BackColor = System.Drawing.Color.Gainsboro;
            this.PUserProfile.Location = new System.Drawing.Point(700, 32);
            this.PUserProfile.Margin = new System.Windows.Forms.Padding(0);
            this.PUserProfile.Name = "PUserProfile";
            this.PUserProfile.Size = new System.Drawing.Size(385, 478);
            this.PUserProfile.TabIndex = 7;
            // 
            // PAudit
            // 
            this.PAudit.AuditContent = "";
            this.PAudit.BackColor = System.Drawing.Color.Gainsboro;
            this.PAudit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PAudit.Location = new System.Drawing.Point(371, 510);
            this.PAudit.Name = "PAudit";
            this.PAudit.Size = new System.Drawing.Size(328, 381);
            this.PAudit.TabIndex = 19;
            // 
            // PTaskProfile
            // 
            this.PTaskProfile.BackColor = System.Drawing.Color.Gainsboro;
            this.PTaskProfile.Location = new System.Drawing.Point(48, 510);
            this.PTaskProfile.Name = "PTaskProfile";
            this.PTaskProfile.Size = new System.Drawing.Size(652, 478);
            this.PTaskProfile.TabIndex = 16;
            // 
            // PTView
            // 
            this.PTView.BackColor = System.Drawing.Color.Gainsboro;
            this.PTView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PTView.Location = new System.Drawing.Point(371, 510);
            this.PTView.Name = "PTView";
            this.PTView.Size = new System.Drawing.Size(328, 381);
            this.PTView.TabIndex = 20;
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
            this.Controls.Add(this.PUserProfile);
            this.Controls.Add(this.PAudit);
            this.Controls.Add(this.PTView);
            this.Controls.Add(this.UI_Caption);
            this.Controls.Add(this.PLogin_0Panel);
            this.Controls.Add(this.PGuide_0Panel);
            this.Controls.Add(this.PGuideS_0Panel);
            this.Controls.Add(this.PSet_0Panel);
            this.Controls.Add(this.PContacts);
            this.Controls.Add(this.PMess_0Panel);
            this.Controls.Add(this.PTaskProfile);
            this.Controls.Add(this.PTask_0Panel);
            this.Controls.Add(this.PProj_0Panel);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PGuide_0Panel.ResumeLayout(false);
            this.PGuide_PSync.ResumeLayout(false);
            this.PGuideS_0Panel.ResumeLayout(false);
            this.PLogin_0Panel.ResumeLayout(false);
            this.PLogin_0Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PLogin_PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLogin_PicCloud)).EndInit();
            this.PContacts.ResumeLayout(false);
            this.PMess_0Panel.ResumeLayout(false);
            this.UI_Caption.ResumeLayout(false);
            this.UI_Caption.PerformLayout();
            this.PSet_0Panel.ResumeLayout(false);
            this.PSet_0Panel.PerformLayout();
            this.PTask_0Panel.ResumeLayout(false);
            this.PTask_0Panel.PerformLayout();
            this.PProj_0Panel.ResumeLayout(false);
            this.PProj_0Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PLogin_0Panel;
        private Button PLogin_BtnLogin;
        private Button PLogin_BtnFindPsw;

        private Panel PGuide_0Panel;
        private LinkLabel PGuide_BtnProfile;
        private Button PGuide_BtnCall;
        private Button PGuide_BtnTask;
        private Button PGuide_BtnProj;
        private Button PGuide_BtnContact;
        private Button PGuide_BtnMess;
        private Label PGuide_LblSync;
        private ProgressBar PGuide_PGSnyc;

        private Panel PGuideS_0Panel;
        private Button PGuideS_BtnCall;
        private Button PGuideS_BtnTask;
        private Button PGuideS_BtnProj;
        private Button PGuideS_BtnContact;
        private Button PGuideS_BtnMess;

        private Panel PContacts;

        private Panel PMess_0Panel;
        private ProgressBar PLogin_BarConnecting;
        private PictureBox PLogin_PicCloud;
        private TaskPanelContainer PTask_ListMy;
        private LoginTextbox PLogin_TextPsw;
        private LoginTextbox PLogin_TextUID;
        private UserProfilePanel PUserProfile;
        private TaskPanelContainer PTask_ListPub;
        private TaskPanelContainer PTask_ListAll;
        private Button PGuide_BtnLogout;
        private UserList ContactList;
        private Label PLogin_LabelBlock;
        private Panel UI_Caption;
        private Button UI_BtnClose;
        private Button UI_BtnMin;
        private Button PGuide_BtnSet;
        private ProjPanelContainer PProj_ListMy;
        private ProjPanelContainer PProj_ListAll;
        private Label UI_Title;
        private AnnounceList PMess_AnnList;
        private MessageList PMess_MessList;
        private Label PMess_Label2;
        private PictureBox PLogin_PicLogo;
        private Panel PSet_0Panel;
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
        private ToolTip Tips;
        private Label PSet_Label2;
        private CheckBox PSet_Ck1;
        private TaskProfilePanel PTaskProfile;
        private Panel PTask_0Panel;
        private Button PTask_BtnSMy;
        private Button PTask_BtnSAll;
        private Button PTask_BtnSPub;
        private Panel PProj_0Panel;
        private Button PProj_BtnSAll;
        private Button PProj_BtnSMy;
        private Label PTask_LblPage;
        private TextBox PTask_TbxPage;
        private Button PTask_BtnPgDown;
        private Button PTask_BtnPgUp;
        private Label PProj_LblPage;
        private TextBox PProj_TbxPage;
        private Button PProj_BtnPgDown;
        private Button PProj_BtnPgUp;
        private Panel PGuide_PSync;
        private Button PGuide_BtnSync;
        private Button PGuideS_BtnSync;
        private AuditPanel PAudit;
        private Timer PAudit_Anim;
        private TViewPanel PTView;
    }
}