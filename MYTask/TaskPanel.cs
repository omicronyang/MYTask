using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MYTask
{
class TaskPanel: Panel
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
            LabelUserName.Init(MyTaskInf.TaskU);
            LabelFromUserName.Init(MyTaskInf.TaskFU); 

            LabelEndTime_Update(MyTaskInf.TaskEndTime);
            LabelUpdateTime_Update(MyTaskInf.TaskUpdateTime);

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
            if (time < DateTime.Now)
            {
                /*if (MyTaskInf.TaskStat == 2)
                {
                    me.BackColor = Color.LightSkyBlue;
                    me.ForeColor = Color.Black;
                }
                else*/ 
                if (MyTaskInf.TaskStat == 25)
                {
                    me.BackColor = Color.Gainsboro;
                    me.ForeColor = Color.Black;
                }
                else
                {
                    me.BackColor = Color.Red;
                    me.ForeColor = Color.White;
                }
            }
        }

        private void LabelUpdateTime_Update(DateTime time)
        {
            Label me = LabelUpdateTime;
            me.Text = "最后更改：" + time.ToString("yyyy/MM/dd HH:mm:ss") ;
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
}
