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
            this.TView = new System.Windows.Forms.TreeView();
            this.LblCaption = new System.Windows.Forms.Label();
            this.UI_Side = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TView
            // 
            this.TView.Location = new System.Drawing.Point(1, 45);
            this.TView.Name = "TView";
            this.TView.Size = new System.Drawing.Size(327, 336);
            this.TView.TabIndex = 0;
            // 
            // LblCaption
            // 
            this.LblCaption.AutoSize = true;
            this.LblCaption.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblCaption.Location = new System.Drawing.Point(3, 5);
            this.LblCaption.Name = "LblCaption";
            this.LblCaption.Size = new System.Drawing.Size(184, 26);
            this.LblCaption.TabIndex = 1;
            this.LblCaption.Text = "工程分解结构(WBS)";
            // 
            // UI_Side
            // 
            this.UI_Side.BackColor = System.Drawing.Color.RoyalBlue;
            this.UI_Side.Location = new System.Drawing.Point(0, 0);
            this.UI_Side.Name = "UI_Side";
            this.UI_Side.Size = new System.Drawing.Size(1, 381);
            this.UI_Side.TabIndex = 2;
            // 
            // UserControl1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.UI_Side);
            this.Controls.Add(this.LblCaption);
            this.Controls.Add(this.TView);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(328, 381);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TView;
        private System.Windows.Forms.Label LblCaption;
        private System.Windows.Forms.Label UI_Side;
    }
}
