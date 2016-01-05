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
        MyProj MyProjInf = new MyProj();
        LinkLabel LabelProjName = new LinkLabel();
        Label LabelStat = new Label();
        LinkUserLabel LabelUserName = new LinkUserLabel();

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
            }
        }

    }

    class ProjPanelContainer : Panel
    {
        public int ProjNum = 0;
        public int NowIndex = -1;
        public ProjPanel[] Pp = new ProjPanel[12];
        public List<MyProj> ProjList = new List<MyProj>();
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
                Pp[i] = new ProjPanel(3 + i % 4 * 160, 3 + i / 4 * 148);
                Pp[i].Visible = false;
                Controls.Add(Pp[i]);
                Controls.SetChildIndex(Pp[i], 0);
            }
        }


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

        public void AddProj(MyProj[] NewProjList)
        {
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
        private FormMain formmain;

        public UserProfilePanel()
        {
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

            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.Image = global::MYTask.Properties.Resources.Back_right_32;
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

            ProfileEmailLabel.AutoSize = true;
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
            ProfileEmail.Enabled = false;

            ProfileTelLabel.AutoSize = true;
            ProfileTelLabel.Font = new Font("微软雅黑", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            ProfileTelLabel.Location = new Point(3, 89);
            ProfileTelLabel.Name = "ProfileTELLabel";
            ProfileTelLabel.Size = new Size(54, 30);
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
            ProfileTel.Enabled = false;

            ProfileRemark.BackColor = Color.Gainsboro;
            ProfileRemark.BorderColor = Color.Gainsboro;
            ProfileRemark.BorderStyle = BorderStyle.FixedSingle;
            ProfileRemark.Location = new Point(3, 140);
            ProfileRemark.Multiline = true;
            ProfileRemark.Name = "ProfileRemark";
            ProfileRemark.ReadOnly = true;
            ProfileRemark.Size = new Size(379, 123);
            ProfileRemark.Enabled = false;
            ProfileRemark.ScrollBars = ScrollBars.Vertical;

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
            formmain.FoldPanelUser();
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
            BtnClose.FlatAppearance.MouseOverBackColor = NewTheme.MouseOverColor;
            BtnClose.FlatAppearance.MouseDownBackColor = NewTheme.MouseDownColor;

            BtnOK.BackColor = NewTheme.MainColor;
            BtnOK.FlatAppearance.MouseOverBackColor = NewTheme.MouseOverColor;
            BtnOK.FlatAppearance.MouseDownBackColor = NewTheme.MouseDownColor;

            BtnEdit.BackColor = NewTheme.MainColor;
            BtnEdit.FlatAppearance.MouseOverBackColor = NewTheme.MouseOverColor;
            BtnEdit.FlatAppearance.MouseDownBackColor = NewTheme.MouseDownColor;

            BtnCancel.BackColor = NewTheme.MainColor;
            BtnCancel.FlatAppearance.MouseOverBackColor = NewTheme.MouseOverColor;
            BtnCancel.FlatAppearance.MouseDownBackColor = NewTheme.MouseDownColor;

            ProfileUserName.BackColor = NewTheme.MainColor;

        }

    }

    class TaskPanel : Panel
    {
        MyTask MyTaskInf = new MyTask();
        Label LabelPP = new Label();
        Label LabelPI = new Label();
        LinkLabel LabelTaskName = new LinkLabel();
        Label Label1 = new Label();
        LinkLabel LabelProjName = new LinkLabel();
        Label LabelStat = new Label();
        Label Label2 = new Label();
        Label Label3 = new Label();
        LinkUserLabel LabelUserName = new LinkUserLabel();
        LinkUserLabel LabelFromUserName = new LinkUserLabel();
        Label LabelEndTime = new Label();
        Label LabelUpdateTime = new Label();
        Label LabelUsedTime = new Label();
        BorderLabel LabelPlanTime = new BorderLabel();


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
                case 4: { me.Text = "计划"; me.BackColor = Color.FromArgb(153, 102, 153); break; }
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


    }

    class TaskPanelContainer : Panel
    {
        public int TaskNum = 0;
        public int NowIndex = -1;
        public TaskPanel[] Tp = new TaskPanel[4];
        public List<MyTask> TaskList = new List<MyTask>();

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

        public void AddTask(MyTask[] NewTaskList)
        {
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

}
