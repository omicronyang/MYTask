namespace MYTask
{
    partial class FormAudit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAudit));
            this.AuditText = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDeny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AuditText
            // 
            this.AuditText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AuditText.Location = new System.Drawing.Point(9, 96);
            this.AuditText.Margin = new System.Windows.Forms.Padding(0);
            this.AuditText.Multiline = true;
            this.AuditText.Name = "AuditText";
            this.AuditText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuditText.Size = new System.Drawing.Size(300, 170);
            this.AuditText.TabIndex = 11;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.Black;
            this.BtnCancel.Location = new System.Drawing.Point(159, 266);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(150, 30);
            this.BtnCancel.TabIndex = 20;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 48);
            this.label1.TabIndex = 18;
            this.label1.Text = "审核意见：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.BtnAccept.FlatAppearance.BorderSize = 0;
            this.BtnAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccept.Location = new System.Drawing.Point(99, 48);
            this.BtnAccept.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(105, 48);
            this.BtnAccept.TabIndex = 16;
            this.BtnAccept.Text = "通过";
            this.BtnAccept.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.DarkGray;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.ForeColor = System.Drawing.Color.Black;
            this.BtnSave.Location = new System.Drawing.Point(9, 266);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 30);
            this.BtnSave.TabIndex = 19;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // BtnDeny
            // 
            this.BtnDeny.BackColor = System.Drawing.Color.DarkRed;
            this.BtnDeny.FlatAppearance.BorderSize = 0;
            this.BtnDeny.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnDeny.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnDeny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeny.ForeColor = System.Drawing.Color.White;
            this.BtnDeny.Location = new System.Drawing.Point(204, 48);
            this.BtnDeny.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDeny.Name = "BtnDeny";
            this.BtnDeny.Size = new System.Drawing.Size(105, 48);
            this.BtnDeny.TabIndex = 17;
            this.BtnDeny.Text = "驳回";
            this.BtnDeny.UseVisualStyleBackColor = false;
            // 
            // FormAudit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(577, 393);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDeny);
            this.Controls.Add(this.AuditText);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAudit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WSS - 审核任务";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AuditText;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDeny;
    }
}