using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MYTask
{
    class UserProfilePanel:Panel
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

        public void SetProfileInfo(MyUser U,int Mode)
        {
            ProfileBtnEdit.Visible = (Mode == 0) ? false : true;
            ProfileUserName.Text = U.Name;
            ProfileEmail.Text = U.Email;
            ProfileTel.Text = U.Telephone;
            ProfileRemark.Text = U.Remark;
        }

    }
}
