namespace MYTask
{
    partial class UserControl1
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnDeny = new System.Windows.Forms.Button();
            this.AuditText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.BtnAccept.FlatAppearance.BorderSize = 0;
            this.BtnAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccept.Location = new System.Drawing.Point(91, 0);
            this.BtnAccept.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(96, 48);
            this.BtnAccept.TabIndex = 5;
            this.BtnAccept.Text = "通过";
            this.BtnAccept.UseVisualStyleBackColor = false;
            // 
            // BtnDeny
            // 
            this.BtnDeny.BackColor = System.Drawing.Color.DarkRed;
            this.BtnDeny.FlatAppearance.BorderSize = 0;
            this.BtnDeny.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnDeny.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnDeny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeny.ForeColor = System.Drawing.Color.White;
            this.BtnDeny.Location = new System.Drawing.Point(187, 0);
            this.BtnDeny.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDeny.Name = "BtnDeny";
            this.BtnDeny.Size = new System.Drawing.Size(80, 48);
            this.BtnDeny.TabIndex = 6;
            this.BtnDeny.Text = "驳回";
            this.BtnDeny.UseVisualStyleBackColor = false;
            // 
            // AuditText
            // 
            this.AuditText.Location = new System.Drawing.Point(0, 48);
            this.AuditText.Margin = new System.Windows.Forms.Padding(0);
            this.AuditText.Multiline = true;
            this.AuditText.Name = "AuditText";
            this.AuditText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuditText.Size = new System.Drawing.Size(267, 150);
            this.AuditText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "审核意见：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuditText);
            this.Controls.Add(this.BtnDeny);
            this.Controls.Add(this.BtnAccept);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(652, 382);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnDeny;
        private System.Windows.Forms.TextBox AuditText;
        private System.Windows.Forms.Label label1;
    }
}
