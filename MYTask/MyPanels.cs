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

        public Button ProfileBtnOK = new Button();
        public Button ProfileBtnCancel = new Button();
        public Button ProfileBtnEdit = new Button();
        public ActiveTextbox ProfileUserName = new ActiveTextbox();
        public ActiveTextbox ProfileEmail = new ActiveTextbox();
        public ActiveTextbox ProfileTel = new ActiveTextbox();
        public ActiveTextbox ProfileRemark = new ActiveTextbox();
        private Label ProfileEmailLabel = new Label();
        private Label ProfileTelLabel = new Label();

        public UserProfilePanel()
        {
            ProfileBtnOK.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            ProfileBtnOK.FlatAppearance.BorderSize = 0;
            ProfileBtnOK.FlatAppearance.MouseDownBackColor = Color.Gray;
            ProfileBtnOK.FlatAppearance.MouseOverBackColor = Color.Silver;
            ProfileBtnOK.FlatStyle = FlatStyle.Flat;
            ProfileBtnOK.Image = global::MYTask.Properties.Resources.Tick_32;
            ProfileBtnOK.Location = new Point(547, 9);
            ProfileBtnOK.Margin = new Padding(0);
            ProfileBtnOK.Name = "ProfileBtnOK";
            ProfileBtnOK.Size = new Size(48, 48);
            ProfileBtnOK.TextAlign = ContentAlignment.MiddleLeft;
            ProfileBtnOK.UseVisualStyleBackColor = true;
            ProfileBtnOK.Visible = false;
            ProfileBtnOK.Click += new EventHandler(ProfileBtnOK_Click);

            ProfileBtnCancel.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            ProfileBtnCancel.FlatAppearance.BorderSize = 0;
            ProfileBtnCancel.FlatAppearance.MouseDownBackColor = Color.Gray;
            ProfileBtnCancel.FlatAppearance.MouseOverBackColor = Color.Silver;
            ProfileBtnCancel.FlatStyle = FlatStyle.Flat;
            ProfileBtnCancel.Image = global::MYTask.Properties.Resources.Cross_32;
            ProfileBtnCancel.Location = new Point(595, 9);
            ProfileBtnCancel.Margin = new Padding(0);
            ProfileBtnCancel.Name = "ProfileBtnCancel";
            ProfileBtnCancel.Size = new Size(48, 48);
            ProfileBtnCancel.TextAlign = ContentAlignment.MiddleLeft;
            ProfileBtnCancel.UseVisualStyleBackColor = true;
            ProfileBtnCancel.Visible = false;
            ProfileBtnCancel.Click += new EventHandler(ProfileBtnCancel_Click);

            ProfileBtnEdit.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            ProfileBtnEdit.FlatAppearance.BorderSize = 0;
            ProfileBtnEdit.FlatAppearance.MouseDownBackColor = Color.Gray;
            ProfileBtnEdit.FlatAppearance.MouseOverBackColor = Color.Silver;
            ProfileBtnEdit.FlatStyle = FlatStyle.Flat;
            ProfileBtnEdit.Image = global::MYTask.Properties.Resources.Edit_32;
            ProfileBtnEdit.Location = new Point(595, 9);
            ProfileBtnEdit.Margin = new Padding(0);
            ProfileBtnEdit.Name = "ProfileBtnEdit";
            ProfileBtnEdit.Size = new Size(48, 48);
            ProfileBtnEdit.TextAlign = ContentAlignment.MiddleLeft;
            ProfileBtnEdit.UseVisualStyleBackColor = true;
            ProfileBtnEdit.Visible = true;
            ProfileBtnEdit.Click += new EventHandler(ProfileBtnEdit_Click);

            ProfileUserName.BackColor = Color.Gainsboro;
            ProfileUserName.BorderColor = Color.Gainsboro;
            ProfileUserName.BorderStyle = BorderStyle.FixedSingle;
            ProfileUserName.Font = new Font("微软雅黑", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            ProfileUserName.Location = new Point(154, 16);
            ProfileUserName.Name = "ProfileUserName";
            ProfileUserName.ReadOnly = true;
            ProfileUserName.Size = new Size(376, 36);
            ProfileUserName.Text = "名称";
            ProfileUserName.Enabled = false;

            ProfileEmailLabel.AutoSize = true;
            ProfileEmailLabel.Font = new Font("微软雅黑", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            ProfileEmailLabel.Location = new Point(149, 57);
            ProfileEmailLabel.Name = "ProfileEmailLabel";
            ProfileEmailLabel.Size = new Size(75, 30);
            ProfileEmailLabel.Text = "Email:";

            ProfileEmail.BackColor = Color.Gainsboro;
            ProfileEmail.BorderColor = Color.Gainsboro;
            ProfileEmail.BorderStyle = BorderStyle.FixedSingle;
            ProfileEmail.Font = new Font("微软雅黑", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            ProfileEmail.Location = new Point(222, 55);
            ProfileEmail.Margin = new Padding(0);
            ProfileEmail.Name = "ProfileEmail";
            ProfileEmail.ReadOnly = true;
            ProfileEmail.Size = new Size(308, 36);
            ProfileEmail.Text = "a@a.com";
            ProfileEmail.Enabled = false;

            ProfileTelLabel.AutoSize = true;
            ProfileTelLabel.Font = new Font("微软雅黑", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            ProfileTelLabel.Location = new Point(170, 93);
            ProfileTelLabel.Name = "ProfileTELLabel";
            ProfileTelLabel.Size = new Size(54, 30);
            ProfileTelLabel.Text = "TEL:";

            ProfileTel.BackColor = Color.Gainsboro;
            ProfileTel.BorderColor = Color.Gainsboro;
            ProfileTel.BorderStyle = BorderStyle.FixedSingle;
            ProfileTel.Font = new Font("微软雅黑", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            ProfileTel.Location = new Point(222, 93);
            ProfileTel.Name = "ProfileTel";
            ProfileTel.ReadOnly = true;
            ProfileTel.Size = new Size(308, 36);
            ProfileTel.Text = "00000000000";
            ProfileTel.Enabled = false;

            ProfileRemark.BackColor = Color.Gainsboro;
            ProfileRemark.BorderColor = Color.Gainsboro;
            ProfileRemark.BorderStyle = BorderStyle.FixedSingle;
            ProfileRemark.Location = new Point(16, 144);
            ProfileRemark.Multiline = true;
            ProfileRemark.Name = "ProfileRemark";
            ProfileRemark.ReadOnly = true;
            ProfileRemark.Size = new Size(624, 123);
            ProfileRemark.Enabled = false;
            ProfileRemark.ScrollBars = ScrollBars.Vertical;

            Controls.Add(ProfileBtnOK);
            Controls.Add(ProfileBtnCancel);
            Controls.Add(ProfileBtnEdit);
            Controls.Add(ProfileUserName);
            Controls.Add(ProfileEmail);
            Controls.Add(ProfileEmailLabel);
            Controls.Add(ProfileTel);
            Controls.Add(ProfileTelLabel);
            Controls.Add(ProfileRemark);
        }

        private void ProfileBtnEdit_Click(object sender, EventArgs e)
        {
            ProfileBtnEdit.Visible = false;
            ProfileBtnOK.Visible = true;
            ProfileBtnCancel.Visible = true;
            ProfileUserName.SetActive();
            ProfileEmail.SetActive();
            ProfileTel.SetActive();
            ProfileRemark.SetActive();
        }

        private void ProfileBtnOK_Click(object sender, EventArgs e)
        {
            ProfileBtnEdit.Visible = true;
            ProfileBtnOK.Visible = false;
            ProfileBtnCancel.Visible = false;
            ProfileUserName.SetNonactive();
            ProfileEmail.SetNonactive();
            ProfileTel.SetNonactive();
            ProfileRemark.SetNonactive();
        }

        private void ProfileBtnCancel_Click(object sender, EventArgs e)
        {
            ProfileBtnEdit.Visible = true;
            ProfileBtnOK.Visible = false;
            ProfileBtnCancel.Visible = false;
            ProfileUserName.SetNonactive();
            ProfileEmail.SetNonactive();
            ProfileTel.SetNonactive();
            ProfileRemark.SetNonactive();
        }

        public void SetProfileInfo(MyUser U, int Mode)
        {
            ProfileBtnEdit.Visible = (Mode == 0) ? false : true;
            ProfileUserName.Text = U.Name;
            ProfileEmail.Text = U.Email;
            ProfileTel.Text = U.Telephone;
            ProfileRemark.Text = U.Remark;
        }

    }

}
