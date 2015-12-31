using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MYTask
{
    class ProjPanel:Panel
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
        public ProjPanel(int x,int y)
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
            LabelProjName.Text = "信息部体育节成绩及其他信息公众号实时发布";
            LabelProjName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelUserName
            // 
            LabelUserName.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            LabelUserName.Location = new Point(0, 80);
            LabelUserName.Name = "LabelUserName";
            LabelUserName.Size = new Size(157, 44);
            LabelUserName.Text = "学生会信息部\r\n测试人员";
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
}
