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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnMessageS = new System.Windows.Forms.Button();
            this.CloudStatusS = new System.Windows.Forms.PictureBox();
            this.BtnCall = new System.Windows.Forms.Button();
            this.BtnContactS = new System.Windows.Forms.Button();
            this.BtnProjectS = new System.Windows.Forms.Button();
            this.BtnTaskS = new System.Windows.Forms.Button();
            this.PanelProfile = new MYTask.ProfilePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimerCom = new System.Windows.Forms.Timer(this.components);
            this.TabsTask = new System.Windows.Forms.TabControl();
            this.TaskMy = new System.Windows.Forms.TabPage();
            this.label3 = new MYTask.BorderLabel();
            this.TaskPanelFlow = new MYTask.TaskPanelContainer();
            this.TaskPub = new System.Windows.Forms.TabPage();
            this.TaskAll = new System.Windows.Forms.TabPage();
            this.TaskNew = new System.Windows.Forms.TabPage();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
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
            this.TextLogin_Psw = new MYTask.LoginTextbox();
            this.TextLogin_UID = new MYTask.LoginTextbox();
            this.CloudStatusLogin = new System.Windows.Forms.PictureBox();
            this.BarConnecting = new System.Windows.Forms.ProgressBar();
            this.BtnFindPsw = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TabsProject = new System.Windows.Forms.TabControl();
            this.ProjMy = new System.Windows.Forms.TabPage();
            this.ProjPub = new System.Windows.Forms.TabPage();
            this.ProjAll = new System.Windows.Forms.TabPage();
            this.ProjNew = new System.Windows.Forms.TabPage();
            this.PanelContacts = new System.Windows.Forms.Panel();
            this.PanelMessages = new System.Windows.Forms.Panel();
            this.PanelGuide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloudStatus)).BeginInit();
            this.PanelGuideS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloudStatusS)).BeginInit();
            this.PanelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabsTask.SuspendLayout();
            this.TaskMy.SuspendLayout();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloudStatusLogin)).BeginInit();
            this.TabsProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGuide
            // 
            this.PanelGuide.BackColor = System.Drawing.Color.LightGray;
            this.PanelGuide.Controls.Add(this.BtnCallback);
            this.PanelGuide.Controls.Add(this.LabelStatus);
            this.PanelGuide.Controls.Add(this.BtnContact);
            this.PanelGuide.Controls.Add(this.BtnProfile);
            this.PanelGuide.Controls.Add(this.CloudStatus);
            this.PanelGuide.Controls.Add(this.SnycProgress);
            this.PanelGuide.Controls.Add(this.BtnMessage);
            this.PanelGuide.Controls.Add(this.BtnProject);
            this.PanelGuide.Controls.Add(this.BtnTask);
            this.PanelGuide.Location = new System.Drawing.Point(-175, 0);
            this.PanelGuide.Margin = new System.Windows.Forms.Padding(0);
            this.PanelGuide.Name = "PanelGuide";
            this.PanelGuide.Size = new System.Drawing.Size(175, 500);
            this.PanelGuide.TabIndex = 0;
            // 
            // BtnCallback
            // 
            this.BtnCallback.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCallback.FlatAppearance.BorderSize = 0;
            this.BtnCallback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.BtnCallback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
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
            this.LabelStatus.Location = new System.Drawing.Point(3, 452);
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
            this.BtnProfile.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.BtnProfile.LinkColor = System.Drawing.Color.White;
            this.BtnProfile.Location = new System.Drawing.Point(48, 0);
            this.BtnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(126, 48);
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
            this.CloudStatus.Location = new System.Drawing.Point(126, 452);
            this.CloudStatus.Name = "CloudStatus";
            this.CloudStatus.Padding = new System.Windows.Forms.Padding(8);
            this.CloudStatus.Size = new System.Drawing.Size(48, 48);
            this.CloudStatus.TabIndex = 6;
            this.CloudStatus.TabStop = false;
            // 
            // SnycProgress
            // 
            this.SnycProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SnycProgress.Location = new System.Drawing.Point(7, 476);
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
            this.PanelGuideS.Controls.Add(this.button2);
            this.PanelGuideS.Controls.Add(this.button1);
            this.PanelGuideS.Controls.Add(this.BtnMessageS);
            this.PanelGuideS.Controls.Add(this.CloudStatusS);
            this.PanelGuideS.Controls.Add(this.BtnCall);
            this.PanelGuideS.Controls.Add(this.BtnContactS);
            this.PanelGuideS.Controls.Add(this.BtnProjectS);
            this.PanelGuideS.Controls.Add(this.BtnTaskS);
            this.PanelGuideS.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelGuideS.Location = new System.Drawing.Point(0, 0);
            this.PanelGuideS.Margin = new System.Windows.Forms.Padding(0);
            this.PanelGuideS.Name = "PanelGuideS";
            this.PanelGuideS.Size = new System.Drawing.Size(48, 500);
            this.PanelGuideS.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 77);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.CloudStatusS.Location = new System.Drawing.Point(0, 452);
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
            this.BtnCall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.BtnCall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
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
            this.BtnProjectS.FlatAppearance.BorderSize = 0;
            this.BtnProjectS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnProjectS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnProjectS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProjectS.Image = ((System.Drawing.Image)(resources.GetObject("BtnProjectS.Image")));
            this.BtnProjectS.Location = new System.Drawing.Point(0, 96);
            this.BtnProjectS.Margin = new System.Windows.Forms.Padding(0);
            this.BtnProjectS.Name = "BtnProjectS";
            this.BtnProjectS.Size = new System.Drawing.Size(48, 48);
            this.BtnProjectS.TabIndex = 2;
            this.BtnProjectS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProjectS.UseVisualStyleBackColor = true;
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
            // PanelProfile
            // 
            this.PanelProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PanelProfile.Controls.Add(this.label1);
            this.PanelProfile.Controls.Add(this.pictureBox1);
            this.PanelProfile.Location = new System.Drawing.Point(80, 32);
            this.PanelProfile.Margin = new System.Windows.Forms.Padding(0);
            this.PanelProfile.Name = "PanelProfile";
            this.PanelProfile.Size = new System.Drawing.Size(652, 500);
            this.PanelProfile.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "个人信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MYTask.Properties.Resources.Profile_120;
            this.pictureBox1.Location = new System.Drawing.Point(18, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TimerCom
            // 
            this.TimerCom.Interval = 15;
            this.TimerCom.Tick += new System.EventHandler(this.TimerCom_Tick);
            // 
            // TabsTask
            // 
            this.TabsTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabsTask.Controls.Add(this.TaskMy);
            this.TabsTask.Controls.Add(this.TaskPub);
            this.TabsTask.Controls.Add(this.TaskAll);
            this.TabsTask.Controls.Add(this.TaskNew);
            this.TabsTask.Location = new System.Drawing.Point(48, 0);
            this.TabsTask.Name = "TabsTask";
            this.TabsTask.SelectedIndex = 0;
            this.TabsTask.Size = new System.Drawing.Size(652, 500);
            this.TabsTask.TabIndex = 5;
            this.TabsTask.Visible = false;
            // 
            // TaskMy
            // 
            this.TaskMy.Controls.Add(this.label3);
            this.TaskMy.Controls.Add(this.TaskPanelFlow);
            this.TaskMy.Location = new System.Drawing.Point(4, 30);
            this.TaskMy.Name = "TaskMy";
            this.TaskMy.Padding = new System.Windows.Forms.Padding(3);
            this.TaskMy.Size = new System.Drawing.Size(644, 466);
            this.TaskMy.TabIndex = 0;
            this.TaskMy.Text = "负责的任务";
            this.TaskMy.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderColor = System.Drawing.Color.Green;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(121, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "学生";
            // 
            // TaskPanelFlow
            // 
            this.TaskPanelFlow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskPanelFlow.BackColor = System.Drawing.Color.RoyalBlue;
            this.TaskPanelFlow.Location = new System.Drawing.Point(0, 0);
            this.TaskPanelFlow.MaximumSize = new System.Drawing.Size(1304, 0);
            this.TaskPanelFlow.Name = "TaskPanelFlow";
            this.TaskPanelFlow.Size = new System.Drawing.Size(621, 0);
            this.TaskPanelFlow.TabIndex = 0;
            // 
            // TaskPub
            // 
            this.TaskPub.Location = new System.Drawing.Point(4, 30);
            this.TaskPub.Name = "TaskPub";
            this.TaskPub.Padding = new System.Windows.Forms.Padding(3);
            this.TaskPub.Size = new System.Drawing.Size(644, 466);
            this.TaskPub.TabIndex = 1;
            this.TaskPub.Text = "发布的任务";
            this.TaskPub.UseVisualStyleBackColor = true;
            // 
            // TaskAll
            // 
            this.TaskAll.Location = new System.Drawing.Point(4, 30);
            this.TaskAll.Name = "TaskAll";
            this.TaskAll.Size = new System.Drawing.Size(644, 466);
            this.TaskAll.TabIndex = 2;
            this.TaskAll.Text = "所有任务";
            this.TaskAll.UseVisualStyleBackColor = true;
            // 
            // TaskNew
            // 
            this.TaskNew.Location = new System.Drawing.Point(4, 30);
            this.TaskNew.Name = "TaskNew";
            this.TaskNew.Size = new System.Drawing.Size(644, 466);
            this.TaskNew.TabIndex = 3;
            this.TaskNew.Text = "新建任务";
            this.TaskNew.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(624, 3);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 460);
            this.vScrollBar1.TabIndex = 2;
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
            this.PanelLogin.Controls.Add(this.TextLogin_Psw);
            this.PanelLogin.Controls.Add(this.TextLogin_UID);
            this.PanelLogin.Controls.Add(this.CloudStatusLogin);
            this.PanelLogin.Controls.Add(this.BarConnecting);
            this.PanelLogin.Controls.Add(this.BtnFindPsw);
            this.PanelLogin.Controls.Add(this.BtnLogin);
            this.PanelLogin.Location = new System.Drawing.Point(0, 500);
            this.PanelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(700, 500);
            this.PanelLogin.TabIndex = 6;
            // 
            // TextLogin_Psw
            // 
            this.TextLogin_Psw.Location = new System.Drawing.Point(400, 211);
            this.TextLogin_Psw.Name = "TextLogin_Psw";
            this.TextLogin_Psw.Size = new System.Drawing.Size(215, 29);
            this.TextLogin_Psw.TabIndex = 10;
            this.TextLogin_Psw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextLogin_Psw_Keypress);
            // 
            // TextLogin_UID
            // 
            this.TextLogin_UID.Location = new System.Drawing.Point(400, 176);
            this.TextLogin_UID.Name = "TextLogin_UID";
            this.TextLogin_UID.Size = new System.Drawing.Size(215, 29);
            this.TextLogin_UID.TabIndex = 9;
            // 
            // CloudStatusLogin
            // 
            this.CloudStatusLogin.Image = global::MYTask.Properties.Resources.Cloud_Connecting_32;
            this.CloudStatusLogin.Location = new System.Drawing.Point(665, 465);
            this.CloudStatusLogin.Name = "CloudStatusLogin";
            this.CloudStatusLogin.Size = new System.Drawing.Size(32, 32);
            this.CloudStatusLogin.TabIndex = 8;
            this.CloudStatusLogin.TabStop = false;
            // 
            // BarConnecting
            // 
            this.BarConnecting.Location = new System.Drawing.Point(7, 479);
            this.BarConnecting.MarqueeAnimationSpeed = 0;
            this.BarConnecting.Name = "BarConnecting";
            this.BarConnecting.Size = new System.Drawing.Size(652, 15);
            this.BarConnecting.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.BarConnecting.TabIndex = 7;
            // 
            // BtnFindPsw
            // 
            this.BtnFindPsw.Image = global::MYTask.Properties.Resources.FindPsw_32;
            this.BtnFindPsw.Location = new System.Drawing.Point(451, 254);
            this.BtnFindPsw.Name = "BtnFindPsw";
            this.BtnFindPsw.Size = new System.Drawing.Size(48, 48);
            this.BtnFindPsw.TabIndex = 6;
            this.BtnFindPsw.UseVisualStyleBackColor = true;
            this.BtnFindPsw.Visible = false;
            this.BtnFindPsw.Click += new System.EventHandler(this.BtnFindPsw_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Image = global::MYTask.Properties.Resources.Login_32;
            this.BtnLogin.Location = new System.Drawing.Point(400, 254);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(48, 48);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TabsProject
            // 
            this.TabsProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabsProject.Controls.Add(this.ProjMy);
            this.TabsProject.Controls.Add(this.ProjPub);
            this.TabsProject.Controls.Add(this.ProjAll);
            this.TabsProject.Controls.Add(this.ProjNew);
            this.TabsProject.Location = new System.Drawing.Point(96, 48);
            this.TabsProject.Name = "TabsProject";
            this.TabsProject.SelectedIndex = 0;
            this.TabsProject.Size = new System.Drawing.Size(652, 500);
            this.TabsProject.TabIndex = 8;
            this.TabsProject.Visible = false;
            // 
            // ProjMy
            // 
            this.ProjMy.Location = new System.Drawing.Point(4, 30);
            this.ProjMy.Name = "ProjMy";
            this.ProjMy.Padding = new System.Windows.Forms.Padding(3);
            this.ProjMy.Size = new System.Drawing.Size(644, 466);
            this.ProjMy.TabIndex = 0;
            this.ProjMy.Text = "负责的项目";
            this.ProjMy.UseVisualStyleBackColor = true;
            // 
            // ProjPub
            // 
            this.ProjPub.Location = new System.Drawing.Point(4, 30);
            this.ProjPub.Name = "ProjPub";
            this.ProjPub.Padding = new System.Windows.Forms.Padding(3);
            this.ProjPub.Size = new System.Drawing.Size(644, 466);
            this.ProjPub.TabIndex = 1;
            this.ProjPub.Text = "发布的项目";
            this.ProjPub.UseVisualStyleBackColor = true;
            // 
            // ProjAll
            // 
            this.ProjAll.Location = new System.Drawing.Point(4, 30);
            this.ProjAll.Name = "ProjAll";
            this.ProjAll.Size = new System.Drawing.Size(644, 466);
            this.ProjAll.TabIndex = 2;
            this.ProjAll.Text = "所有项目";
            this.ProjAll.UseVisualStyleBackColor = true;
            // 
            // ProjNew
            // 
            this.ProjNew.Location = new System.Drawing.Point(4, 30);
            this.ProjNew.Name = "ProjNew";
            this.ProjNew.Size = new System.Drawing.Size(644, 466);
            this.ProjNew.TabIndex = 3;
            this.ProjNew.Text = "新建项目";
            this.ProjNew.UseVisualStyleBackColor = true;
            // 
            // PanelContacts
            // 
            this.PanelContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContacts.BackColor = System.Drawing.Color.Green;
            this.PanelContacts.Location = new System.Drawing.Point(64, 16);
            this.PanelContacts.Name = "PanelContacts";
            this.PanelContacts.Size = new System.Drawing.Size(652, 500);
            this.PanelContacts.TabIndex = 9;
            // 
            // PanelMessages
            // 
            this.PanelMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMessages.BackColor = System.Drawing.Color.Purple;
            this.PanelMessages.Location = new System.Drawing.Point(48, 0);
            this.PanelMessages.Name = "PanelMessages";
            this.PanelMessages.Size = new System.Drawing.Size(652, 500);
            this.PanelMessages.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.PanelGuide);
            this.Controls.Add(this.PanelGuideS);
            this.Controls.Add(this.TabsTask);
            this.Controls.Add(this.TabsProject);
            this.Controls.Add(this.PanelProfile);
            this.Controls.Add(this.PanelContacts);
            this.Controls.Add(this.PanelMessages);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormMain";
            this.Text = "SSERSay - Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_Unload);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.PanelGuide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloudStatus)).EndInit();
            this.PanelGuideS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloudStatusS)).EndInit();
            this.PanelProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TabsTask.ResumeLayout(false);
            this.TaskMy.ResumeLayout(false);
            this.TaskMy.PerformLayout();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloudStatusLogin)).EndInit();
            this.TabsProject.ResumeLayout(false);
            this.ResumeLayout(false);

	}

        #endregion

        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnFindPsw;

        private System.Windows.Forms.Panel PanelGuide;
        private System.Windows.Forms.LinkLabel BtnProfile;
        private System.Windows.Forms.Button BtnCallback;
        private System.Windows.Forms.Button BtnTask;
        private System.Windows.Forms.Button BtnProject;
        private System.Windows.Forms.Button BtnContact;
        private System.Windows.Forms.Button BtnMessage;
        private System.Windows.Forms.PictureBox CloudStatus;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.ProgressBar SnycProgress;

        private System.Windows.Forms.Panel PanelGuideS;
        private System.Windows.Forms.Button BtnCall;
        private System.Windows.Forms.Button BtnTaskS;
        private System.Windows.Forms.Button BtnProjectS;
        private System.Windows.Forms.Button BtnContactS;
        private System.Windows.Forms.Button BtnMessageS;
        private System.Windows.Forms.PictureBox CloudStatusS;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TabControl TabsTask;
        private System.Windows.Forms.TabPage TaskMy;
        private System.Windows.Forms.TabPage TaskPub;
        private System.Windows.Forms.TabPage TaskAll;
        private System.Windows.Forms.TabPage TaskNew;

        private System.Windows.Forms.TabControl TabsProject;
        private System.Windows.Forms.TabPage ProjMy;
        private System.Windows.Forms.TabPage ProjPub;
        private System.Windows.Forms.TabPage ProjAll;
        private System.Windows.Forms.TabPage ProjNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel PanelContacts;

        private System.Windows.Forms.Panel PanelMessages;

        private System.Windows.Forms.Timer TimerCom;
        private System.Windows.Forms.ProgressBar BarConnecting;
        private System.Windows.Forms.PictureBox CloudStatusLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label LabelPI;
        private System.Windows.Forms.Label LabelPT;
        private System.Windows.Forms.LinkLabel LabelTaskName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelStat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel LabelUserName;
        private System.Windows.Forms.Label LabelUpdateTime;
        private System.Windows.Forms.Label LabelEndTime;
        private TaskPanelContainer TaskPanelFlow;
        private System.Windows.Forms.Label label2;
        private LoginTextbox TextLogin_Psw;
        private LoginTextbox TextLogin_UID;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel LabelFromUserName;
        private System.Windows.Forms.Button button2;
        private ProfilePanel PanelProfile;
        //private System.Windows.Forms.Label label3;
        private BorderLabel label3;
    }
}