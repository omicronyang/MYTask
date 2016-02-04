using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MYTask
{
    class ProjPanel : Panel
    {
        private MyProj MyProjInf = new MyProj();
        private LinkLabel LabelProjName = new LinkLabel();
        private Label LabelStat = new Label();
        private LinkUserLabel LabelUserName = new LinkUserLabel();

        private FormMain mainfrm;

        public ProjPanel()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            InitCompenent();
        }

        /// <summary>
        /// 初始化控件并指定左上角坐标
        /// </summary>
        /// <param name="x">左上角X坐标</param>
        /// <param name="y">左上角Y坐标</param>
        public ProjPanel(int x, int y)
        {
            Location = new Point(x, y);
            InitCompenent();
        }

        /// <summary>
        /// 初始化组件
        /// </summary>
        private void InitCompenent()
        {
            Size = new Size(157, 145);
            BackColor = Color.Gainsboro;
            // 
            // LabelStat
            // 
            LabelStat.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LabelStat.Location = new Point(0, 124);
            LabelStat.Name = "LabelStat";
            LabelStat.Size = new Size(157, 21);
            LabelStat.Text = "项目状态";
            LabelStat.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelProjName
            // 
            LabelProjName.Font = new Font("微软雅黑", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            LabelProjName.Location = new Point(0, 0);
            LabelProjName.Name = "LabelProjName";
            LabelProjName.Size = new Size(157, 80);
            LabelProjName.Text = "项目名称";
            LabelProjName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelUserName
            // 
            LabelUserName.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            LabelUserName.Location = new Point(0, 80);
            LabelUserName.Name = "LabelUserName";
            LabelUserName.Size = new Size(157, 44);
            LabelUserName.Text = "项目负责人";
            //LabelUserName.Init(MyProjInf.ProjToUser);
            LabelUserName.TextAlign = ContentAlignment.MiddleCenter;

            Controls.Add(LabelProjName);
            Controls.Add(LabelUserName);
            Controls.Add(LabelStat);
        }

        public void UpdateProj(MyProj Source)
        {
            MyProjInf = Source;

            LabelProjName.Text = MyProjInf.ProjName;
            LabelUserName.SetUser(MyProjInf.ProjToUser);
            LabelUserName.Text = LabelUserName.Text.Replace(' ', '\n');
            LabelStat_Update(MyProjInf.ProjStat);
        }

        private void LabelStat_Update(int Stat)
        {
            Label me = LabelStat;
            switch (Stat)
            {
                case 2: { me.Text = "前期策划"; me.BackColor = Color.FromArgb(153, 102, 153); break; }
                case 8: { me.Text = "准备阶段"; me.BackColor = Color.FromArgb(0, 153, 0); break; }
                case 9: { me.Text = "已结束"; me.BackColor = Color.FromArgb(204, 204, 204); break; }
                case 14: { me.Text = "中断"; me.BackColor = Color.FromArgb(255, 0, 0); break; }
                case 22: { me.Text = "推迟"; me.BackColor = Color.FromArgb(255, 204, 0); break; }
                case 24: { me.Text = "执行"; me.BackColor = Color.FromArgb(51, 102, 153); break; }
                case 25: { me.Text = "后期整理"; me.BackColor = Color.FromArgb(153, 255, 0); break; }
                default: { me.Text = "";me.BackColor = Color.Gainsboro;break; }
            }
        }

        public void SetMainForm(FormMain frm)
        {
            mainfrm = frm;
            LabelUserName.SetMainForm(frm);
        }

    }

    class ProjPanelContainer : Panel
    {
        public int ProjNum = 0;
        public int NowIndex = -1;
        public ProjPanel[] Pp = new ProjPanel[12];
        public List<MyProj> ProjList = new List<MyProj>();
        private FormMain mainfrm;
        // ProjPanel size = 157,145


        public ProjPanelContainer()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.RoyalBlue;
            Location = new Point(0, 0);
            Height = 0;
            Visible = true;
            for (int i = 0; i < 12; i++)
            {
                Pp[i] = new ProjPanel(6 + i % 4 * 160, 3 + i / 4 * 148);
                Pp[i].Visible = false;
                Controls.Add(Pp[i]);
                Controls.SetChildIndex(Pp[i], 0);
            }
        }

        public void SetMainForm(FormMain frm)
        {
            mainfrm = frm;
            for (int i=0;i<12;i++)
                Pp[i].SetMainForm(mainfrm);
        }
        /*
        public void AddProj(MyProj NewProj)
        {
            ProjList.Add(NewProj);
            if (ProjNum < 12)
            {
                ProjNum++;
                Pp[ProjNum - 1].UpdateProj(NewProj);
                Pp[ProjNum - 1].Visible = true;
            }
            else ProjNum++;
        }
        */
        public void AddProj(MyProj[] NewProjList)
        {
            if (NewProjList.Length == 0) return;
            int oldnum = ProjNum;
            ProjNum += NewProjList.Length;
            ProjList.AddRange(NewProjList);

            if (ProjNum <= 12)
            {
                Height = 3 + ((ProjNum % 4 == 0) ? ProjNum / 4 : ProjNum / 4 + 1) * 148;
                for (int i = 0; i < ProjNum; i++)
                {
                    Pp[i].UpdateProj(ProjList[i]);
                    Pp[i].Visible = true;
                }
            }
            else
            {
                Height = 447;
                if (oldnum < 12)
                    for (int i = oldnum; i < 12; i++)
                    {
                        Pp[i].UpdateProj(ProjList[i]);
                        Pp[i].Visible = true;
                    }
            }
            if (NowIndex < 0) NowIndex = 0;
        }

        public void ClearProj()
        {
            for (int i = 0; i < 12; i++)
                Pp[i].Visible = false;
            Height = 0;
            ProjNum = 0;
            ProjList.Clear();
            NowIndex = -1;
        }

        public void PageDown()
        {
            if (NowIndex + 12 > ProjNum - 1) return;
            NowIndex += 12;
            RenewProjPage();
        }
        public void PageUp()
        {
            if (NowIndex < 12) return;
            NowIndex -= 12;
            RenewProjPage();
        }

        private void RenewProjPage()
        {
            
            if (ProjNum - NowIndex >= 12)
            {
                for (int i = NowIndex; i < NowIndex + 12; i++)
                {
                    Pp[i - NowIndex].UpdateProj(ProjList[i]);
                    Pp[i - NowIndex].Visible = true;
                }
                Height = 447;
            }
            else
            {
                for (int i = NowIndex; i < ProjNum; i++)
                    Pp[i - NowIndex].UpdateProj(ProjList[i]);
                for (int i = 12 - ProjNum; i < 12; i++)
                    Pp[i].Visible = false;

                int HeightNum = ProjNum - NowIndex;
                Height = 3 + ((HeightNum % 4 == 0) ? HeightNum / 4 : HeightNum / 4 + 1) * 148;
            }
        }

        public void RenewProjPage(int Index)
        {
            NowIndex = Index;
            RenewProjPage();
        }
    }

    class UserProfilePanel : Panel
    {

        public Button BtnOK = new Button();
        public Button BtnCancel = new Button();
        public Button BtnEdit = new Button();
        public Button BtnClose = new Button();
        public Label ProfileUserName = new Label();
        public ActiveTextbox ProfileEmail = new ActiveTextbox();
        public ActiveTextbox ProfileTel = new ActiveTextbox();
        public ActiveTextbox ProfileRemark = new ActiveTextbox();
        private Label ProfileEmailLabel = new Label();
        private Label ProfileTelLabel = new Label();
        private Label ProfileRemarkLabel = new Label();
        private Label SideColor = new Label();
        private FormMain formmain;
        public bool Hidden = true;
        public int TargetX;

        public UserProfilePanel()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);

            BtnOK.BackColor = Color.RoyalBlue;
            BtnOK.FlatAppearance.BorderSize = 0;
            BtnOK.FlatStyle = FlatStyle.Flat;
            BtnOK.Image = global::MYTask.Properties.Resources.Tick_32;
            BtnOK.Location = new Point(337, 0);
            BtnOK.Margin = new Padding(0);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(48, 48);
            BtnOK.TextAlign = ContentAlignment.MiddleLeft;
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Visible = false;
            BtnOK.Click += new EventHandler(ProfileBtnOK_Click);

            BtnCancel.BackColor = Color.RoyalBlue;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Image = global::MYTask.Properties.Resources.Cross_32;
            BtnCancel.Location = new Point(289, 0);
            BtnCancel.Margin = new Padding(0);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(48, 48);
            BtnCancel.TextAlign = ContentAlignment.MiddleLeft;
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Visible = false;
            BtnCancel.Click += new EventHandler(ProfileBtnCancel_Click);

            BtnEdit.BackColor = Color.RoyalBlue;
            BtnEdit.FlatAppearance.BorderSize = 0;
            BtnEdit.FlatStyle = FlatStyle.Flat;
            BtnEdit.Image = global::MYTask.Properties.Resources.Edit_32;
            BtnEdit.Location = new Point(289, 0);
            BtnEdit.Margin = new Padding(0);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(48, 48);
            BtnEdit.TextAlign = ContentAlignment.MiddleLeft;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Visible = true;
            BtnEdit.Click += new EventHandler(ProfileBtnEdit_Click);

            BtnClose.BackColor = Color.RoyalBlue;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.Image = global::MYTask.Properties.Resources.ArrowRight_White_32;
            BtnClose.Location = new Point(337, 0);
            BtnClose.Margin = new Padding(0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(48, 48);
            BtnClose.TextAlign = ContentAlignment.MiddleLeft;
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Visible = true;
            BtnClose.Click += new EventHandler(ProfileBtnClose_Click);

            ProfileUserName.BackColor = Color.RoyalBlue;
            ProfileUserName.ForeColor = Color.White;
            ProfileUserName.Font = new Font("微软雅黑", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            ProfileUserName.Location = new Point(0,0);
            ProfileUserName.Name = "ProfileUserName";
            ProfileUserName.Size = new Size(385, 48);
            ProfileUserName.Text = "名称";
            ProfileUserName.TextAlign = ContentAlignment.MiddleLeft;
            
            ProfileEmailLabel.Font = new Font("微软雅黑", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            ProfileEmailLabel.Location = new Point(3, 53);
            ProfileEmailLabel.Name = "ProfileEmailLabel";
            ProfileEmailLabel.Size = new Size(75, 30);
            ProfileEmailLabel.Text = "Email:";

            ProfileEmail.BackColor = Color.Gainsboro;
            ProfileEmail.BorderColor = Color.Gainsboro;
            ProfileEmail.BorderStyle = BorderStyle.FixedSingle;
            ProfileEmail.Font = new Font("微软雅黑", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            ProfileEmail.Location = new Point(71, 51);
            ProfileEmail.Margin = new Padding(0);
            ProfileEmail.Name = "ProfileEmail";
            ProfileEmail.ReadOnly = true;
            ProfileEmail.Size = new Size(311, 36);
            ProfileEmail.Text = "a@a.com";
            ProfileEmail.Enter += new EventHandler(LockStyle);


            ProfileTelLabel.Font = new Font("微软雅黑", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            ProfileTelLabel.Location = new Point(3, 89);
            ProfileTelLabel.Name = "ProfileTELLabel";
            ProfileTelLabel.Size = new Size(75, 30);
            ProfileTelLabel.Text = "TEL:";

            ProfileTel.BackColor = Color.Gainsboro;
            ProfileTel.BorderColor = Color.Gainsboro;
            ProfileTel.BorderStyle = BorderStyle.FixedSingle;
            ProfileTel.Font = new Font("微软雅黑", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            ProfileTel.Location = new Point(71, 89);
            ProfileTel.Name = "ProfileTel";
            ProfileTel.ReadOnly = true;
            ProfileTel.Size = new Size(311, 36);
            ProfileTel.Text = "00000000000";
            ProfileTel.Enter += new EventHandler(LockStyle);

            ProfileRemark.BackColor = Color.Gainsboro;
            ProfileRemark.BorderColor = Color.Gainsboro;
            ProfileRemark.BorderStyle = BorderStyle.FixedSingle;
            ProfileRemark.Location = new Point(71, 140);
            ProfileRemark.Multiline = true;
            ProfileRemark.Name = "ProfileRemark";
            ProfileRemark.ReadOnly = true;
            ProfileRemark.Size = new Size(311, 123);
            ProfileRemark.Enter += new EventHandler(LockStyle);
            ProfileRemark.ScrollBars = ScrollBars.Vertical;
            
            ProfileRemarkLabel.Font = new Font("微软雅黑", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            ProfileRemarkLabel.Location = new Point(3, 140);
            ProfileRemarkLabel.Name = "ProfileRemarkLabel";
            ProfileRemarkLabel.Size = new Size(75, 30);
            ProfileRemarkLabel.Text = "简介:";

            SideColor.BackColor = Color.RoyalBlue;
            SideColor.Text = "";
            SideColor.Location = new Point(0, 48);
            SideColor.Size = new Size(1, 430);

            Controls.Add(BtnClose);
            Controls.Add(BtnOK);
            Controls.Add(BtnCancel);
            Controls.Add(BtnEdit);
            Controls.Add(ProfileUserName);
            Controls.Add(ProfileEmail);
            Controls.Add(ProfileEmailLabel);
            Controls.Add(ProfileTel);
            Controls.Add(ProfileTelLabel);
            Controls.Add(ProfileRemark);
            Controls.Add(ProfileRemarkLabel);
            Controls.Add(SideColor);
        }
        public void SetFatherForm(FormMain x)
        {
            formmain = x;
            UpdateColor(x.Theme);
        }

        private void ProfileBtnEdit_Click(object sender, EventArgs e)
        {
            BtnEdit.Visible = false;
            BtnOK.Visible = true;
            BtnCancel.Visible = true;
            BtnClose.Visible = false;
            ProfileEmail.SetActive();
            ProfileTel.SetActive();
            ProfileRemark.SetActive();
        }

        private void ProfileBtnOK_Click(object sender, EventArgs e)
        {
            BtnEdit.Visible = true;
            BtnOK.Visible = false;
            BtnCancel.Visible = false;
            BtnClose.Visible = true;
            ProfileEmail.SetNonactive();
            ProfileTel.SetNonactive();
            ProfileRemark.SetNonactive();
        }

        private void ProfileBtnCancel_Click(object sender, EventArgs e)
        {
            BtnEdit.Visible = true;
            BtnOK.Visible = false;
            BtnCancel.Visible = false;
            BtnClose.Visible = true;
            ProfileEmail.SetNonactive();
            ProfileTel.SetNonactive();
            ProfileRemark.SetNonactive();
        }

        private void ProfileBtnClose_Click(object sender,EventArgs e)
        {
            formmain.PanelUser_Fold();
        }

        public void SetProfileInfo(MyUser U, int Mode)
        {
            BtnEdit.Visible = (Mode == 0) ? false : true;
            ProfileUserName.Text = U.Name;
            ProfileEmail.Text = U.Email;
            ProfileTel.Text = U.Telephone;
            ProfileRemark.Text = U.Remark;
        }

        public void UpdateColor(UIColor NewTheme)
        {
            BtnClose.BackColor = NewTheme.MainColor;
            BtnClose.FlatAppearance.MouseOverBackColor = NewTheme.MOC;
            BtnClose.FlatAppearance.MouseDownBackColor = NewTheme.MDC;

            BtnOK.BackColor = NewTheme.MainColor;
            BtnOK.FlatAppearance.MouseOverBackColor = NewTheme.MOC;
            BtnOK.FlatAppearance.MouseDownBackColor = NewTheme.MDC;

            BtnEdit.BackColor = NewTheme.MainColor;
            BtnEdit.FlatAppearance.MouseOverBackColor = NewTheme.MOC;
            BtnEdit.FlatAppearance.MouseDownBackColor = NewTheme.MDC;

            BtnCancel.BackColor = NewTheme.MainColor;
            BtnCancel.FlatAppearance.MouseOverBackColor = NewTheme.MOC;
            BtnCancel.FlatAppearance.MouseDownBackColor = NewTheme.MDC;

            ProfileUserName.BackColor = NewTheme.MainColor;

            SideColor.BackColor = NewTheme.MainColor;

        }

        private void LockStyle(object sender, EventArgs e)
        {
            ActiveTextbox Obj = (ActiveTextbox)sender;
            if (Obj.ReadOnly) BtnEdit.Focus();
        }

        public void Expand()
        {
            Hidden = false;
            Visible = true;
            TargetX = Location.X - Width;
        }

        public void Fold()
        {
            Hidden = true;
            TargetX = Location.X + Width;
            Visible = false;
        }


    }

    class TaskPanel : Panel
    {
        private MyTask MyTaskInf = new MyTask();
        private Label LabelPP = new Label();
        private Label LabelPI = new Label();
        private LinkLabel LabelTaskName = new LinkLabel();
        private Label Label1 = new Label();
        private LinkLabel LabelProjName = new LinkLabel();
        private Label LabelStat = new Label();
        private Label Label2 = new Label();
        private Label Label3 = new Label();
        private LinkUserLabel LabelUserName = new LinkUserLabel();
        private LinkUserLabel LabelFromUserName = new LinkUserLabel();
        private Label LabelEndTime = new Label();
        private Label LabelUpdateTime = new Label();
        private Label LabelUsedTime = new Label();
        private BorderLabel LabelPlanTime = new BorderLabel();
        private FormMain mainfrm;

        public TaskPanel()
        {
            InitCompenent();
        }

        public TaskPanel(int y, int width)
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            Size = new Size(width, 108);
            Location = new Point(3, y);
            InitCompenent();
        }

        public void SetMainForm(FormMain frm)
        {
            mainfrm = frm;
            LabelUserName.SetMainForm(mainfrm);
            LabelFromUserName.SetMainForm(mainfrm);
        }

        private void InitCompenent()
        {
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            BackColor = Color.Gainsboro;

            LabelTaskName.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            LabelTaskName.LinkBehavior = LinkBehavior.HoverUnderline;
            LabelTaskName.LinkColor = Color.Black;
            LabelTaskName.VisitedLinkColor = Color.Black;
            LabelTaskName.ActiveLinkColor = Color.RoyalBlue;
            LabelTaskName.Location = new Point(3, 3);
            LabelTaskName.Size = new Size(609, 21);
            LabelTaskName.TabStop = true;
            LabelTaskName.Text = "任务名称";
            LabelTaskName.Click += new EventHandler(LabelTaskName_Clicked);

            Label1.Location = new Point(361, 30);
            Label1.Size = new Size(58, 21);
            Label1.Text = "项目:";

            LabelProjName.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            LabelProjName.LinkBehavior = LinkBehavior.HoverUnderline;
            LabelProjName.LinkColor = Color.Black;
            LabelProjName.VisitedLinkColor = Color.Black;
            LabelProjName.ActiveLinkColor = Color.RoyalBlue;
            LabelProjName.Location = new Point(409, 30);
            LabelProjName.Size = new Size(203, 21);
            LabelProjName.TabStop = true;
            LabelProjName.Text = "项目名称";
            LabelProjName.Click += new EventHandler(LabelProjName_Clicked);

            LabelPP.Location = new Point(3, 30);
            LabelPP.Size = new Size(50, 21);
            LabelPP.BackColor = Color.Gold;
            LabelPP.TextAlign = ContentAlignment.MiddleCenter;
            LabelPP.Text = "中";

            LabelPI.Location = new Point(53, 30);
            LabelPI.Size = new Size(50, 21);
            LabelPI.BackColor = Color.SandyBrown;
            LabelPI.TextAlign = ContentAlignment.MiddleCenter;
            LabelPI.Text = "高";

            LabelStat.Location = new Point(3, 57);
            LabelStat.Size = new Size(100, 21);
            LabelStat.TextAlign = ContentAlignment.MiddleCenter;
            LabelStat.Text = "完成100%";
            LabelStat.BackColor = Color.GreenYellow;

            Label2.Location = new Point(107, 30);
            Label2.Size = new Size(74, 21);
            Label2.Text = "指派给：";

            Label3.Location = new Point(107, 57);
            Label3.Size = new Size(74, 21);
            Label3.Text = "来自于：";

            LabelUserName.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            LabelUserName.Location = new Point(183, 30);
            LabelUserName.Size = new Size(175, 21);
            LabelUserName.TabStop = true;

            LabelFromUserName.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            LabelFromUserName.Location = new Point(183, 57);
            LabelFromUserName.Size = new Size(175, 21);
            LabelFromUserName.TabStop = true;

            LabelEndTime.Location = new Point(361, 57);
            LabelEndTime.Size = new Size(208, 21);
            LabelEndTime.AutoSize = true;
            LabelEndTime.Text = "预期完成日期：9999/99/99";

            LabelUpdateTime.Location = new Point(361, 84);
            LabelUpdateTime.Size = new Size(243, 21);
            LabelUpdateTime.AutoSize = true;
            LabelUpdateTime.Text = "最后更改：9999/99/99 99:99:99";

            LabelUsedTime.Location = new Point(3, 84);
            LabelUsedTime.Size = new Size(200, 21);
            LabelUsedTime.Text = "5.5";
            LabelUsedTime.ForeColor = Color.White;
            LabelUsedTime.BackColor = Color.Green;

            LabelPlanTime.Location = new Point(203, 84);
            LabelPlanTime.Size = new Size(155, 21);
            LabelPlanTime.Text = "5.5";
            LabelPlanTime.TextAlign = ContentAlignment.TopRight;
            LabelPlanTime.BorderStyle = BorderStyle.FixedSingle;
            LabelPlanTime.BorderColor = Color.Green;

            Controls.Add(LabelPP);
            Controls.Add(LabelPI);
            Controls.Add(LabelTaskName);
            Controls.Add(LabelProjName);
            Controls.Add(Label1);
            Controls.Add(LabelStat);
            Controls.Add(Label2);
            Controls.Add(Label3);
            Controls.Add(LabelUserName);
            Controls.Add(LabelFromUserName);
            Controls.Add(LabelEndTime);
            Controls.Add(LabelUpdateTime);
            Controls.Add(LabelUsedTime);
            Controls.Add(LabelPlanTime);
        }

        public void UpdateTask(MyTask Source)
        {
            MyTaskInf = Source;

            Type_Update(MyTaskInf.TaskType);
            LabelPP_Update(MyTaskInf.TaskPriority);
            LabelPI_Update(MyTaskInf.TaskImportance);
            LabelStat_Update(MyTaskInf.TaskStat);

            LabelTaskName.Text += MyTaskInf.TaskName;
            LabelProjName.Text = MyTaskInf.TaskProject;
            LabelUserName.SetUser(MyTaskInf.TaskU);
            LabelFromUserName.SetUser(MyTaskInf.TaskFU);

            LabelEndTime_Update(MyTaskInf.TaskEndTime);
            LabelUpdateTime_Update(MyTaskInf.UpdateTime);

            LabelWorkTime_Update(MyTaskInf.TaskPlanTime, MyTaskInf.TaskUsedTime);
        }

        private void LabelPP_Update(int priority)
        {
            Label me = LabelPP;
            switch (priority)
            {
                case 5: { me.Text = "极低"; me.BackColor = Color.OliveDrab; break; }
                case 4: { me.Text = "低"; me.BackColor = Color.GreenYellow; break; }
                case 3: { me.Text = "中"; me.BackColor = Color.Gold; break; }
                case 2: { me.Text = "高"; me.BackColor = Color.DarkOrange; break; }
                case 1: { me.Text = "紧急"; me.BackColor = Color.Red; break; }
            }
        }

        private void LabelPI_Update(int importance)
        {
            Label me = LabelPI;
            switch (importance)
            {
                case 5: { me.Text = "极低"; me.BackColor = Color.OliveDrab; break; }
                case 4: { me.Text = "低"; me.BackColor = Color.GreenYellow; break; }
                case 3: { me.Text = "中"; me.BackColor = Color.Gold; break; }
                case 2: { me.Text = "高"; me.BackColor = Color.DarkOrange; break; }
                case 1: { me.Text = "严重"; me.BackColor = Color.Red; break; }
            }
        }

        private void LabelStat_Update(int stat)
        {
            Label me = LabelStat;
            switch (stat)
            {
                case 2: { me.Text = "未开始"; me.BackColor = Color.FromArgb(153, 102, 153); break; }
                case 4: { me.Text = "策划中"; me.BackColor = Color.FromArgb(153, 102, 153); break; }
                case 5: { me.Text = "进行  0%"; me.BackColor = Color.FromArgb(153, 255, 0); break; }
                case 6: { me.Text = "进行 20%"; me.BackColor = Color.FromArgb(153, 255, 0); break; }
                case 7: { me.Text = "进行 40%"; me.BackColor = Color.FromArgb(153, 255, 0); break; }
                case 8: { me.Text = "进行 60%"; me.BackColor = Color.FromArgb(153, 255, 0); break; }
                case 9: { me.Text = "进行 80%"; me.BackColor = Color.FromArgb(153, 255, 0); break; }
                case 14: { me.Text = "完成100%"; me.BackColor = Color.FromArgb(0, 153, 0); break; }
                case 22: { me.Text = "中断"; me.BackColor = Color.FromArgb(0, 0, 0); break; }
                case 23: { me.Text = "推迟"; me.BackColor = Color.FromArgb(255, 204, 0); break; }
                case 24: { me.Text = "请假"; me.BackColor = Color.FromArgb(255, 255, 0); break; }
                case 25: { me.Text = "完成验收"; me.BackColor = Color.FromArgb(51, 102, 153); break; }
                case 26: { me.Text = "驳回"; me.BackColor = Color.FromArgb(0, 0, 0); break; }
            }
        }

        private void Type_Update(int type)
        {
            Label me = LabelTaskName;
            switch (type)
            {
                case 1: { me.Text = "[设计流程]"; break; }
                case 2: { me.Text = "[人员分工]"; break; }
                case 3: { me.Text = "[执行]"; break; }
                case 7: { me.Text = "[申请]"; break; }
                case 8: { me.Text = "[求援]"; break; }
                case 9: { me.Text = "[撰写文档]"; break; }
                case 10: { me.Text = "[沟通]"; break; }
                case 12: { me.Text = "[会议]"; break; }
                case 14: { me.Text = "[请假]"; break; }
                case 15: { me.Text = "[加班]"; break; }
                case 16: { me.Text = "[其他]"; break; }
                case 19: { me.Text = "[提出设想]"; break; }
                case 20: { me.Text = "[子项目]"; break; }
            }
        }

        private void LabelEndTime_Update(DateTime time)
        {
            Label me = LabelEndTime;
            me.Text = "预期完成日期：" + time.ToString("yyyy/MM/dd");
            if (time < DateTime.Now && MyTaskInf.TaskStat == 2)
            {
                me.BackColor = Color.LightSkyBlue;
                me.ForeColor = Color.Black;
            }
            else if (time < DateTime.Now && MyTaskInf.TaskStat != 25)
            {
                me.BackColor = Color.Red;
                me.ForeColor = Color.White;
            }
            else
            {
                me.BackColor = Color.Gainsboro;
                me.ForeColor = Color.Black;
            }
        }

        private void LabelUpdateTime_Update(DateTime time)
        {
            Label me = LabelUpdateTime;
            me.Text = "最后更改：" + time.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void LabelWorkTime_Update(double PlanTime, double UsedTime)
        {
            if (PlanTime > 0)
            {
                LabelUsedTime.Location = new Point(3, 84);
                LabelUsedTime.Text = UsedTime.ToString();
                if (UsedTime > PlanTime)
                {
                    LabelUsedTime.BackColor = Color.Goldenrod;
                    LabelUsedTime.Width = 355;
                    LabelPlanTime.Width = 0;
                }
                else
                {
                    LabelUsedTime.BackColor = Color.Green;
                    LabelUsedTime.Width = Convert.ToInt32(UsedTime / PlanTime * 355);
                    LabelPlanTime.Location = new Point(LabelUsedTime.Width + 3, 84);
                    LabelPlanTime.Width = 355 - LabelUsedTime.Width;
                    LabelPlanTime.Text = PlanTime.ToString();
                }
            }
            else
            {
                LabelUsedTime.Width = 0;
                LabelPlanTime.Location = new Point(3, 84);
                LabelPlanTime.Width = 355;
                LabelPlanTime.Text = "";
            }
        }

        private void LabelProjName_Clicked(object sender, EventArgs e)
        {

        }

        private void LabelTaskName_Clicked(object sender, EventArgs e)
        {
            mainfrm.SetPanelTP(this.MyTaskInf);
        }


    }

    class TaskPanelContainer : Panel
    {
        public int TaskNum = 0;
        public int NowIndex = -1;
        public TaskPanel[] Tp = new TaskPanel[4];
        public List<MyTask> TaskList = new List<MyTask>();
        private FormMain mainfrm;

        public TaskPanelContainer()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.RoyalBlue;
            Location = new Point(0, 0);
            Visible = true;
            for (int i = 0; i < 4; i++)
            {
                Tp[i] = new TaskPanel(3 + 111 * i, Width - 6);
                Controls.Add(Tp[i]);
                Controls.SetChildIndex(Tp[i], 0);
            }
        }

        public void SetMainForm(FormMain frm)
        {
            for (int i = 0; i < 4; i++)
                Tp[i].SetMainForm(frm);
        }

        /*
        public void AddTask(MyTask Newtask)
        {
            TaskList.Add(Newtask);
            if (TaskNum < 4)
            {
                TaskNum++;
                Tp[TaskNum - 1].UpdateTask(Newtask);
                Tp[TaskNum - 1].Visible = true;
            }
            else TaskNum++;
        }
        */
        public void AddTask(MyTask[] NewTaskList)
        {
            if (NewTaskList.Length == 0) return;
            int oldnum = TaskNum;
            TaskNum += NewTaskList.Length;
            TaskList.AddRange(NewTaskList);
            if (TaskNum <= 4)
            {
                Height = 3 + TaskNum * 111;
                for (int i = 0; i < TaskNum; i++)
                {
                    Tp[i].UpdateTask(TaskList[i]);
                    Tp[i].Visible = true;
                }
            }
            else
            {
                Height = 447;
                if (oldnum < 4)
                    for (int i = oldnum; i < 4; i++)
                    {
                        Tp[i].UpdateTask(TaskList[i]);
                        Tp[i].Visible = true;
                    }
            }
            if (NowIndex < 0) NowIndex = 0;
        }

        public void ClearTask()
        {
            for (int i = 0; i < 4; i++)
                Tp[i].Visible = false;
            Height = 0;
            TaskNum = 0;
            TaskList.Clear();
            NowIndex = -1;
        }

        public void PageDown()
        {
            if (NowIndex + 4 > TaskNum - 1) return;
            NowIndex += 4;
            RenewTaskPage();
        }

        public void PageUp()
        {
            if (NowIndex < 4) return;
            NowIndex -= 4;
            RenewTaskPage();
        }

        private void RenewTaskPage()
        {
            if (TaskNum - NowIndex >= 4)
            {
                for (int i = NowIndex; i < NowIndex + 4; i++)
                    Tp[i - NowIndex].UpdateTask(TaskList[i]);
                Height = 447;
            }
            else
            {
                for (int i = NowIndex; i < TaskNum; i++)
                    Tp[i - NowIndex].UpdateTask(TaskList[i]);
                Height = 3 + (TaskNum - NowIndex) * 111;
            }
        }

        public void RenewTaskPage(int Index)
        {
            NowIndex = Index;
            RenewTaskPage();
        }

    }

    class TaskProfilePanel : Panel
    {
        public MyTask TaskInf;
        private int Calendar_StBtn;
        private int Calendar_EdBtn;
        private DateTime Calendar_Date;
        private FormMain mainfrm;
        private UIColor Theme;
        private MyTaskByDay MTBD = new MyTaskByDay();

        #region 控件声明初始化

        private Label LblTaskName = new Label();
        private Button BtnSplit = new Button();
        private Button BtnAudit = new Button();
        private Button BtnComment = new Button();
        private Button BtnEdit = new Button();
        private Button BtnDelete = new Button();
        private Button BtnTreeView = new Button();
        //private Button BtnOK = new Button();
        ///private Button BtnCancel = new Button();
        private Label LblPri = new Label();
        private Label LblImp = new Label();
        private Label LblStat = new Label();
        private Label LblUsedTime = new Label();
        private BorderLabel LblPlanTime = new BorderLabel();
        private Label labeltext1 = new Label();
        private Label labeltext2 = new Label();
        private LinkUserLabel LblFromUser = new LinkUserLabel();
        private LinkUserLabel LblToUser = new LinkUserLabel();
        private Label LblEndTime = new Label();
        private Label labeltext3 = new Label();
        public WebBrowser TbxRemark = new WebBrowser();
        private Label labeltext4 = new Label();
        private Button BtnPrev = new Button();
        private Button BtnNext = new Button();
        private DateTimePicker DTP = new DateTimePicker();
        private BtnCalendar[] BtnDays = new BtnCalendar[37];

        public TaskProfilePanel()
        {
            SetStyle(ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor, true);
            InitComponent();
        }
        private void InitComponent()
        {
            this.BackColor = Color.Gainsboro;
            this.Size = new Size(652, 478);

            this.LblTaskName.BackColor = Color.RoyalBlue;
            this.LblTaskName.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.LblTaskName.ForeColor = Color.White;
            this.LblTaskName.Location = new Point(0, 0);
            this.LblTaskName.Name = "LblTaskName";
            this.LblTaskName.Size = new Size(364, 48);
            this.LblTaskName.Text = "[执行]UI界面设计";
            this.LblTaskName.TextAlign = ContentAlignment.MiddleLeft;

            this.LblPri.BackColor = Color.Gold;
            this.LblPri.ForeColor = Color.Black;
            this.LblPri.Location = new Point(0, 48);
            this.LblPri.Name = "LblPri";
            this.LblPri.Size = new Size(80, 21);
            this.LblPri.Text = "中度优先";
            this.LblPri.TextAlign = ContentAlignment.TopCenter;

            this.LblImp.BackColor = Color.SandyBrown;
            this.LblImp.ForeColor = Color.Black;
            this.LblImp.Location = new Point(80, 48);
            this.LblImp.Name = "LblImp";
            this.LblImp.Size = new Size(80, 21);
            this.LblImp.Text = "中度严重";
            this.LblImp.TextAlign = ContentAlignment.TopCenter;

            this.LblStat.BackColor = Color.GreenYellow;
            this.LblStat.ForeColor = Color.Black;
            this.LblStat.Location = new Point(160, 48);
            this.LblStat.Name = "LblStat";
            this.LblStat.Size = new Size(100, 21);
            this.LblStat.Text = "完成100%";
            this.LblStat.TextAlign = ContentAlignment.TopCenter;

            this.LblUsedTime.BackColor = Color.Green;
            this.LblUsedTime.ForeColor = Color.Black;
            this.LblUsedTime.Location = new Point(260, 48);
            this.LblUsedTime.Name = "LblUsedTime";
            this.LblUsedTime.Size = new Size(100, 21);
            this.LblUsedTime.Text = "0.5";

            this.labeltext1.BackColor = Color.RoyalBlue;
            this.labeltext1.ForeColor = Color.White;
            this.labeltext1.Location = new Point(0, 69);
            this.labeltext1.Name = "labeltext1";
            this.labeltext1.Size = new Size(26, 27);
            this.labeltext1.Text = "由";
            this.labeltext1.TextAlign = ContentAlignment.MiddleLeft;

            this.labeltext2.BackColor = Color.RoyalBlue;
            this.labeltext2.ForeColor = Color.White;
            this.labeltext2.Location = new Point(201, 69);
            this.labeltext2.Name = "labeltext2";
            this.labeltext2.Size = new Size(59, 27);
            this.labeltext2.Text = "指派给";
            this.labeltext2.TextAlign = ContentAlignment.MiddleLeft;

            this.LblEndTime.BackColor = Color.RoyalBlue;
            this.LblEndTime.ForeColor = Color.White;
            this.LblEndTime.Location = new Point(435, 69);
            this.LblEndTime.Name = "LblEndTime";
            this.LblEndTime.Size = new Size(217, 27);
            this.LblEndTime.Text = "计划完成于 9999/99/99";
            this.LblEndTime.TextAlign = ContentAlignment.MiddleLeft;

            this.labeltext3.AutoSize = true;
            this.labeltext3.Font = new Font("微软雅黑", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            this.labeltext3.ForeColor = Color.Black;
            this.labeltext3.Location = new Point(1, 101);
            this.labeltext3.Name = "labeltext3";
            this.labeltext3.Size = new Size(88, 26);
            this.labeltext3.Text = "任务描述";

            this.TbxRemark.Location = new Point(6, 130);
            this.TbxRemark.Name = "TbxRemark";
            this.TbxRemark.Size = new Size(308, 337);

            this.labeltext4.AutoSize = true;
            this.labeltext4.Font = new Font("微软雅黑", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            this.labeltext4.ForeColor = Color.Black;
            this.labeltext4.Location = new Point(324, 101);
            this.labeltext4.Name = "labeltext4";
            this.labeltext4.Size = new Size(88, 26);
            this.labeltext4.Text = "工作日志";

            this.BtnTreeView.BackColor = Color.RoyalBlue;
            this.BtnTreeView.FlatAppearance.BorderSize = 0;
            this.BtnTreeView.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            this.BtnTreeView.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            this.BtnTreeView.FlatStyle = FlatStyle.Flat;
            this.BtnTreeView.Image = global::MYTask.Properties.Resources.TreeView_32;
            this.BtnTreeView.Location = new Point(604, 0);
            this.BtnTreeView.Name = "BtnTreeView";
            this.BtnTreeView.Size = new Size(48, 48);
            this.BtnTreeView.TextAlign = ContentAlignment.MiddleLeft;
            this.BtnTreeView.UseVisualStyleBackColor = false;

            this.BtnDelete.BackColor = Color.RoyalBlue;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            this.BtnDelete.FlatStyle = FlatStyle.Flat;
            this.BtnDelete.Image = global::MYTask.Properties.Resources.Delete_32;
            this.BtnDelete.Location = new Point(556, 0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new Size(48, 48);
            this.BtnDelete.TextAlign = ContentAlignment.MiddleLeft;
            this.BtnDelete.UseVisualStyleBackColor = false;

            this.BtnEdit.BackColor = Color.RoyalBlue;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            this.BtnEdit.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            this.BtnEdit.FlatStyle = FlatStyle.Flat;
            this.BtnEdit.Image = global::MYTask.Properties.Resources.Edit_32;
            this.BtnEdit.Location = new Point(508, 0);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new Size(48, 48);
            this.BtnEdit.TextAlign = ContentAlignment.MiddleLeft;
            this.BtnEdit.UseVisualStyleBackColor = false;

            this.BtnComment.BackColor = Color.RoyalBlue;
            this.BtnComment.FlatAppearance.BorderSize = 0;
            this.BtnComment.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            this.BtnComment.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            this.BtnComment.FlatStyle = FlatStyle.Flat;
            this.BtnComment.Image = global::MYTask.Properties.Resources.Comment_32;
            this.BtnComment.Location = new Point(460, 0);
            this.BtnComment.Name = "BtnComment";
            this.BtnComment.Size = new Size(48, 48);
            this.BtnComment.TextAlign = ContentAlignment.MiddleLeft;
            this.BtnComment.UseVisualStyleBackColor = false;

            this.BtnAudit.BackColor = Color.RoyalBlue;
            this.BtnAudit.FlatAppearance.BorderSize = 0;
            this.BtnAudit.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            this.BtnAudit.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            this.BtnAudit.FlatStyle = FlatStyle.Flat;
            this.BtnAudit.Image = global::MYTask.Properties.Resources.Audit_32;
            this.BtnAudit.Location = new Point(412, 0);
            this.BtnAudit.Name = "BtnAudit";
            this.BtnAudit.Size = new Size(48, 48);
            this.BtnAudit.TextAlign = ContentAlignment.MiddleLeft;
            this.BtnAudit.UseVisualStyleBackColor = false;
            this.BtnAudit.Click += new EventHandler(BtnAudit_Click);

            this.BtnSplit.BackColor = Color.RoyalBlue;
            this.BtnSplit.FlatAppearance.BorderSize = 0;
            this.BtnSplit.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            this.BtnSplit.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            this.BtnSplit.FlatStyle = FlatStyle.Flat;
            this.BtnSplit.Image = global::MYTask.Properties.Resources.Split_32;
            this.BtnSplit.Location = new Point(364, 0);
            this.BtnSplit.Name = "BtnSplit";
            this.BtnSplit.Size = new Size(48, 48);
            this.BtnSplit.TextAlign = ContentAlignment.MiddleLeft;
            this.BtnSplit.UseVisualStyleBackColor = false;

            this.LblToUser.ActiveLinkColor = Color.Gray;
            this.LblToUser.BackColor = Color.RoyalBlue;
            this.LblToUser.ForeColor = Color.White;
            this.LblToUser.LinkBehavior = LinkBehavior.HoverUnderline;
            this.LblToUser.LinkColor = Color.White;
            this.LblToUser.Location = new Point(260, 69);
            this.LblToUser.Name = "LblToUser";
            this.LblToUser.Size = new Size(175, 27);
            this.LblToUser.TabStop = true;
            this.LblToUser.Text = "学生会信息部 工作人员";
            this.LblToUser.TextAlign = ContentAlignment.MiddleLeft;
            this.LblToUser.VisitedLinkColor = Color.White;

            this.LblFromUser.ActiveLinkColor = Color.Gray;
            this.LblFromUser.BackColor = Color.RoyalBlue;
            this.LblFromUser.ForeColor = Color.White;
            this.LblFromUser.LinkBehavior = LinkBehavior.HoverUnderline;
            this.LblFromUser.LinkColor = Color.White;
            this.LblFromUser.Location = new Point(26, 69);
            this.LblFromUser.Name = "LblFromUser";
            this.LblFromUser.Size = new Size(175, 27);
            this.LblFromUser.TabStop = true;
            this.LblFromUser.Text = "学生会信息部 工作人员";
            this.LblFromUser.TextAlign = ContentAlignment.MiddleLeft;
            this.LblFromUser.VisitedLinkColor = Color.White;

            this.LblPlanTime.BorderColor = Color.Green;
            this.LblPlanTime.BorderStyle = BorderStyle.FixedSingle;
            this.LblPlanTime.HotTrack = false;
            this.LblPlanTime.Location = new Point(360, 48);
            this.LblPlanTime.Name = "LblPlanTime";
            this.LblPlanTime.Size = new Size(292, 21);
            this.LblPlanTime.Text = "4";
            this.LblPlanTime.TextAlign = ContentAlignment.TopRight;

            this.BtnPrev.BackColor = Color.Transparent;
            this.BtnPrev.FlatAppearance.BorderSize = 0;
            this.BtnPrev.FlatAppearance.MouseDownBackColor = Color.Gray;
            this.BtnPrev.FlatAppearance.MouseOverBackColor = Color.Silver;
            this.BtnPrev.FlatStyle = FlatStyle.Flat;
            this.BtnPrev.Image = global::MYTask.Properties.Resources.ArrowLeft_32;
            this.BtnPrev.Location = new Point(390, 156);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new Size(32, 32);
            this.BtnPrev.TextAlign = ContentAlignment.MiddleLeft;
            this.BtnPrev.UseVisualStyleBackColor = false;
            this.BtnPrev.Click += new EventHandler(BtnPrev_Click);

            this.BtnNext.BackColor = Color.Transparent;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatAppearance.MouseDownBackColor = Color.Gray;
            this.BtnNext.FlatAppearance.MouseOverBackColor = Color.Silver;
            this.BtnNext.FlatStyle = FlatStyle.Flat;
            this.BtnNext.Image = global::MYTask.Properties.Resources.ArrowRight_32;
            this.BtnNext.Location = new Point(554, 156);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new Size(32, 32);
            this.BtnNext.TextAlign = ContentAlignment.MiddleLeft;
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new EventHandler(BtnNext_Click);

            this.DTP.CustomFormat = "yyyy年 MM月";
            this.DTP.Format = DateTimePickerFormat.Custom;
            this.DTP.Location = new Point(425, 158);
            this.DTP.MinDate = new DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.DTP.Name = "DTP";
            this.DTP.Size = new Size(126, 29);
            this.DTP.ValueChanged += new EventHandler(DTP_ValueChange);

            for (int i = 0; i < 37; i++)
            {
                BtnDays[i] = new BtnCalendar();
                BtnDays[i].BackColor = Color.DimGray;
                BtnDays[i].FlatAppearance.BorderSize = 0;
                BtnDays[i].FlatAppearance.MouseOverBackColor = Color.Gray;
                BtnDays[i].FlatAppearance.MouseDownBackColor = Color.FromArgb(57, 57, 57);
                BtnDays[i].FlatStyle = FlatStyle.Flat;
                BtnDays[i].Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                BtnDays[i].Size = new Size(32, 32);
                BtnDays[i].UseVisualStyleBackColor = false;

                int x = 367 + i % 7 * 35;
                int y = 198 + i / 7 * 35;
                BtnDays[i].Location = new Point(x, y);

                Controls.Add(BtnDays[i]);
            }

            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.labeltext4);
            this.Controls.Add(this.TbxRemark);
            this.Controls.Add(this.labeltext3);
            this.Controls.Add(this.BtnTreeView);
            this.Controls.Add(this.LblEndTime);
            this.Controls.Add(this.LblToUser);
            this.Controls.Add(this.labeltext2);
            this.Controls.Add(this.LblFromUser);
            this.Controls.Add(this.labeltext1);
            this.Controls.Add(this.LblPlanTime);
            this.Controls.Add(this.LblUsedTime);
            this.Controls.Add(this.LblStat);
            this.Controls.Add(this.LblImp);
            this.Controls.Add(this.LblPri);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnComment);
            this.Controls.Add(this.BtnAudit);
            this.Controls.Add(this.BtnSplit);
            this.Controls.Add(this.LblTaskName);
            this.Controls.Add(this.DTP);


        }


        #endregion

        #region 带参数初始化

        public void SetMainForm(FormMain frm)
        {
            mainfrm = frm;
            LblFromUser.SetMainForm(mainfrm);
            LblToUser.SetMainForm(mainfrm);
        }
        public void SetNewTask(MyTask Source)
        {
            TaskInf = Source;
            Calendar_Date = DateTime.Now;
            UpdateBaseInfo();
        }

        private void UpdateBaseInfo()
        {
            this.SuspendLayout();
            LblTaskName_Update(TaskInf.TaskType);
            LblPri_Update(TaskInf.TaskPriority);
            LblImp_Update(TaskInf.TaskImportance);
            LblStat_Update(TaskInf.TaskStat);
            LblFromUser.SetUser(TaskInf.TaskU);
            LblToUser.SetUser(TaskInf.TaskFU);
            LblEndTime_Update(TaskInf.TaskEndTime);
            LblWorkTime_Update(TaskInf.TaskPlanTime, TaskInf.TaskUsedTime);
            TbxRemark_Update();
            DTP.Value = DateTime.Now;
            this.ResumeLayout(false);
        }

        private void LblTaskName_Update(int type)
        {
            Label me = LblTaskName;
            switch (type)
            {
                case 1: { me.Text = "[设计流程]"; break; }
                case 2: { me.Text = "[人员分工]"; break; }
                case 3: { me.Text = "[执行]"; break; }
                case 7: { me.Text = "[申请]"; break; }
                case 8: { me.Text = "[求援]"; break; }
                case 9: { me.Text = "[撰写文档]"; break; }
                case 10: { me.Text = "[沟通]"; break; }
                case 12: { me.Text = "[会议]"; break; }
                case 14: { me.Text = "[请假]"; break; }
                case 15: { me.Text = "[加班]"; break; }
                case 16: { me.Text = "[其他]"; break; }
                case 19: { me.Text = "[提出设想]"; break; }
                case 20: { me.Text = "[子项目]"; break; }
            }
            me.Text += TaskInf.TaskName;
        }

        private void LblPri_Update(int priority)
        {
            Label me = LblPri;
            switch (priority)
            {
                case 5: { me.Text = "极低优先"; me.BackColor = Color.OliveDrab; break; }
                case 4: { me.Text = "低度优先"; me.BackColor = Color.GreenYellow; break; }
                case 3: { me.Text = "中度优先"; me.BackColor = Color.Gold; break; }
                case 2: { me.Text = "高度优先"; me.BackColor = Color.DarkOrange; break; }
                case 1: { me.Text = "紧急优先"; me.BackColor = Color.Red; break; }
            }
        }

        private void LblImp_Update(int importance)
        {
            Label me = LblImp;
            switch (importance)
            {
                case 5: { me.Text = "极低重要"; me.BackColor = Color.OliveDrab; break; }
                case 4: { me.Text = "低度重要"; me.BackColor = Color.GreenYellow; break; }
                case 3: { me.Text = "中度重要"; me.BackColor = Color.Gold; break; }
                case 2: { me.Text = "高度重要"; me.BackColor = Color.DarkOrange; break; }
                case 1: { me.Text = "极为重要"; me.BackColor = Color.Red; break; }
            }
        }

        private void LblStat_Update(int stat)
        {
            Label me = LblStat;
            switch (stat)
            {
                case 2: { me.Text = "未开始"; me.BackColor = Color.FromArgb(153, 102, 153); break; }
                case 4: { me.Text = "策划中"; me.BackColor = Color.FromArgb(153, 102, 153); break; }
                case 5: { me.Text = "进行  0%"; me.BackColor = Color.FromArgb(153, 255, 0); break; }
                case 6: { me.Text = "进行 20%"; me.BackColor = Color.FromArgb(153, 255, 0); break; }
                case 7: { me.Text = "进行 40%"; me.BackColor = Color.FromArgb(153, 255, 0); break; }
                case 8: { me.Text = "进行 60%"; me.BackColor = Color.FromArgb(153, 255, 0); break; }
                case 9: { me.Text = "进行 80%"; me.BackColor = Color.FromArgb(153, 255, 0); break; }
                case 14: { me.Text = "完成100%"; me.BackColor = Color.FromArgb(0, 153, 0); break; }
                case 22: { me.Text = "中断"; me.BackColor = Color.Red; break; }
                case 23: { me.Text = "推迟"; me.BackColor = Color.FromArgb(255, 204, 0); break; }
                case 24: { me.Text = "请假"; me.BackColor = Color.FromArgb(255, 255, 0); break; }
                case 25: { me.Text = "完成验收"; me.BackColor = Color.FromArgb(51, 102, 153); break; }
                case 26: { me.Text = "驳回"; me.BackColor = Color.Red; break; }
            }
        }

        private void LblEndTime_Update(DateTime time)
        {
            Label me = LblEndTime;
            me.Text = "预期完成日期：" + time.ToString("yyyy/MM/dd");
            if (time < DateTime.Now && TaskInf.TaskStat == 2)
            {
                me.BackColor = Color.LightSkyBlue;
                me.ForeColor = Color.Black;
            }
            else if (time < DateTime.Now && TaskInf.TaskStat != 25)
            {
                me.BackColor = Color.Red;
                me.ForeColor = Color.White;
            }
            else
            {
                me.BackColor = Theme.MainColor;
                me.ForeColor = Color.White;
            }
        }

        private void LblWorkTime_Update(double PlanTime, double UsedTime)
        {
            if (PlanTime > 0)
            {
                LblUsedTime.Location = new Point(260, 48);
                LblUsedTime.Text = UsedTime.ToString();
                if (UsedTime > PlanTime)
                {
                    LblUsedTime.BackColor = Color.Goldenrod;
                    LblUsedTime.Width = 391;
                    LblPlanTime.Width = 0;
                }
                else
                {
                    LblUsedTime.BackColor = Color.Green;
                    LblUsedTime.Width = Convert.ToInt32(UsedTime / PlanTime * 391);
                    LblPlanTime.Location = new Point(LblUsedTime.Width + 260, 48);
                    LblPlanTime.Width = 391 - LblUsedTime.Width;
                    LblPlanTime.Text = PlanTime.ToString();
                }
            }
            else
            {
                LblUsedTime.Width = 0;
                LblPlanTime.Location = new Point(260, 48);
                LblPlanTime.Width = 391;
                LblPlanTime.Text = "";
            }
        }

        private void TbxRemark_Update()
        {
            TbxRemark.DocumentText = TaskInf.TaskRemark;
        }

        #endregion

        #region 颜色设置
        public void UpdateColor(UIColor NewTheme)
        {
            Theme = NewTheme;
            Color bgc = NewTheme.MainColor;

            LblTaskName.BackColor = bgc;
            labeltext1.BackColor = bgc;
            labeltext2.BackColor = bgc;

            UpdateBtnColor(BtnSplit);
            UpdateBtnColor(BtnAudit);
            UpdateBtnColor(BtnComment);
            UpdateBtnColor(BtnEdit);
            UpdateBtnColor(BtnDelete);
            UpdateBtnColor(BtnTreeView);

            UpdateLinkULblColor(LblFromUser);
            UpdateLinkULblColor(LblToUser);
        }

        private void UpdateBtnColor(Button Btn)
        {
            Btn.BackColor = Theme.MainColor;
            Btn.FlatAppearance.MouseDownBackColor = Theme.MDC;
            Btn.FlatAppearance.MouseOverBackColor = Theme.MOC;
        }

        private void UpdateLinkULblColor(LinkUserLabel Btn)
        {
            Btn.BackColor = Theme.MainColor;
            Btn.ActiveLinkColor = Theme.MDC;
        }

        #endregion

        #region 日历按钮
        private void BtnDays_Update(DateTime Tm)
        {
            Calendar_Date = Tm;
            DayOfWeek S1 = new DateTime(Tm.Year, Tm.Month, 1).DayOfWeek;
            switch (S1)
            {
                case DayOfWeek.Sunday: { Calendar_StBtn = 0; break; }
                case DayOfWeek.Monday: { Calendar_StBtn = 1; break; }
                case DayOfWeek.Tuesday: { Calendar_StBtn = 2; break; }
                case DayOfWeek.Wednesday: { Calendar_StBtn = 3; break; }
                case DayOfWeek.Thursday: { Calendar_StBtn = 4; break; }
                case DayOfWeek.Friday: { Calendar_StBtn = 5; break; }
                case DayOfWeek.Saturday: { Calendar_StBtn = 6; break; }
            }
            int days = DateTime.DaysInMonth(Tm.Year, Tm.Month);
            Calendar_EdBtn = Calendar_StBtn + days;

            for (int i = 0; i < Calendar_StBtn; i++)
                BtnDays[i].Visible = false;
            for (int i = Calendar_EdBtn; i < 37; i++)
                BtnDays[i].Visible = false;
            for (int i = Calendar_StBtn; i < Calendar_EdBtn; i++)
            {
                BtnDays[i].Visible = true;
                BtnDays[i].Text = string.Format("{0:00}", i - Calendar_StBtn + 1);
                BtnDays[i].UpdateBtn(MTBD);
            }
            List<MyTaskByDay> Mtb = new List<MyTaskByDay>();
            Mtb = TaskInf.Daylist.FindAll((MyTaskByDay TB) => TB.DayTime.Month == Tm.Month);
            foreach (MyTaskByDay tbi in Mtb)
            {
                int td = tbi.DayTime.Day;
                BtnDays[Calendar_StBtn + td - 1].UpdateBtn(tbi);
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            DTP.Value = Calendar_Date.AddMonths(-1);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            DTP.Value = Calendar_Date.AddMonths(1);
        }

        private void DTP_ValueChange(object sender, EventArgs e)
        {
            Calendar_Date = DTP.Value;
            BtnDays_Update(Calendar_Date);
        }

        private void SetBtnDaysStyle(int BtnIndex, int CalendarClr)
        {

        }

        #endregion

        #region 顶部导航
        private void BtnAudit_Click(object sender,EventArgs e)
        {
            FormAudit f = new FormAudit();
            f.Show();
        }

        #endregion
    }

    class AuditPanel : Panel
    {
        private TextBox Browser = new TextBox();
        private Button BtnAccept = new Button();
        private Button BtnDeny = new Button();
        private Label label1 = new Label();
        public bool Accepted = false;

        public AuditPanel()
        {
            InitComponent();
            Btn_Init();
        }
        private void InitComponent()
        {
            Browser.Location = new Point(0, 48);
            Browser.Name = "Browser";
            Browser.Size = new Size(651, 333);
            Browser.Multiline = true;
            Browser.ScrollBars = ScrollBars.Vertical;

            BtnAccept.BackColor = Color.FromArgb(51, 102, 153);
            BtnAccept.FlatAppearance.BorderSize = 0;
            BtnAccept.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            BtnAccept.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            BtnAccept.FlatStyle = FlatStyle.Flat;
            BtnAccept.Location = new Point(152, 0);
            BtnAccept.Name = "BtnAccept";
            BtnAccept.Size = new Size(250, 48);
            BtnAccept.Text = "通过";
            BtnAccept.UseVisualStyleBackColor = false;
            BtnAccept.TextAlign = ContentAlignment.MiddleCenter;
            BtnAccept.Click += new EventHandler(BtnAccept_Click);
            
            BtnDeny.BackColor = Color.DarkRed;
            BtnDeny.FlatAppearance.BorderSize = 0;
            BtnDeny.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            BtnDeny.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            BtnDeny.FlatStyle = FlatStyle.Flat;
            BtnDeny.ForeColor = Color.White;
            BtnDeny.Location = new Point(402, 0);
            BtnDeny.Name = "BtnDeny";
            BtnDeny.Size = new Size(250, 48);
            BtnDeny.Text = "驳回";
            BtnDeny.UseVisualStyleBackColor = false;
            BtnAccept.TextAlign = ContentAlignment.MiddleCenter;
            BtnDeny.Click += new EventHandler(BtnDeny_Click);

            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(152,48);
            label1.Text = "审核意见：";
            label1.TextAlign = ContentAlignment.MiddleCenter;

            BackColor = Color.Gainsboro;
            Controls.Add(this.BtnDeny);
            Controls.Add(this.BtnAccept);
            Controls.Add(this.Browser);
            Controls.Add(this.label1);
            Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Size = new Size(652, 382);
        }

        #region 评价按钮

        private void BtnA_SetStyle(bool Active)
        {
            if (Active)
            {
                BtnAccept.BackColor = Color.FromArgb(51, 102, 153);
                BtnAccept.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 102, 153);
                BtnAccept.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 102, 153);
            }
            else
            {
                BtnAccept.BackColor = Color.Gainsboro;
                BtnAccept.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 102, 153);
                BtnAccept.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 153, 204);
            }
        }

        private void BtnB_SetStyle(bool Active)
        {
            if (Active)
            {
                BtnDeny.ForeColor = Color.White;
                BtnDeny.BackColor = Color.DarkRed;
                BtnDeny.FlatAppearance.MouseDownBackColor = Color.DarkRed;
                BtnDeny.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            }
            else
            {
                BtnDeny.ForeColor = Color.Black;
                BtnDeny.BackColor = Color.Gainsboro;
                BtnDeny.FlatAppearance.MouseDownBackColor = Color.DarkRed;
                BtnDeny.FlatAppearance.MouseOverBackColor = Color.FromArgb(139, 51, 51);
            }
        }


        public void Btn_Init()
        {
            BtnA_SetStyle(false);
            BtnB_SetStyle(false);
        }

        private void BtnAccept_Click(object sender,EventArgs e)
        {
            Accepted = true;
            BtnA_SetStyle(true);
            BtnB_SetStyle(false);
        }

        private void BtnDeny_Click(object sender,EventArgs e)
        {
            Accepted = false;
            BtnA_SetStyle(false);
            BtnB_SetStyle(true);
        }

        #endregion
        
        public string AuditContent
        {
            get
            {
                return Browser.Text;
            }
            set
            {
                Browser.Text = value;
            }
            
        }

    }

}
