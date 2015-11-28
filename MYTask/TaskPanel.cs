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
	Task MyTaskInf = new Task();
	public TaskPanel(int y, int width, Task Taskinf)
	{
		Size = new Size(width, 85);
		Location = new Point(3, y);
		Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
		BackColor = Color.Gainsboro;

		Label LabelPT = new Label();
		LabelPT.Location = new Point(3, 3);
		LabelPT.Size = new Size(24, 24);
		LabelPT.BackColor = Color.LightCoral;
		LabelPT.Text = "中";

		Label LabelPI = new Label();
		LabelPI.Location = new Point(27, 3);
		LabelPI.Size = new Size(24, 24);
		LabelPI.BackColor = Color.SandyBrown;
		LabelPI.Text = "高";

		LinkLabel LabelTaskName = new LinkLabel();
		LabelTaskName.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
		LabelTaskName.LinkBehavior = LinkBehavior.HoverUnderline;
		LabelTaskName.LinkColor = Color.Black;
		LabelTaskName.VisitedLinkColor = Color.Black;
		LabelTaskName.ActiveLinkColor = Color.RoyalBlue;
		LabelTaskName.Location = new Point(51, 3);
		LabelTaskName.Size = new Size(341, 24);
		LabelTaskName.TabStop = true;
		LabelTaskName.Text = "任务名称";

        Label Label3 = new Label();
        Label3.Location = new Point(395,3);
        Label3.Size = new Size(58,24);
        Label3.Text = "从属于";

        LinkLabel LabelProjName = new LinkLabel();
        LabelProjName.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
        LabelProjName.LinkBehavior = LinkBehavior.HoverUnderline;
        LabelProjName.LinkColor = Color.Black;
        LabelProjName.VisitedLinkColor = Color.Black;
        LabelProjName.ActiveLinkColor = Color.RoyalBlue;
        LabelProjName.Location = new Point(459, 3);
        LabelProjName.Size = new Size(155,20);
        LabelProjName.TabStop = true;
        LabelProjName.Text = "项目名称";


        Label Label1 = new Label();
		Label1.Location = new Point(3, 30);
		Label1.Size = new Size(74, 21);
		Label1.Text = "指派给：";

		LinkLabel LabelUserName = new LinkLabel();
		LabelUserName.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
		LabelUserName.LinkBehavior = LinkBehavior.HoverUnderline;
		LabelUserName.LinkColor = Color.Black;
		LabelUserName.VisitedLinkColor = Color.Black;
		LabelUserName.ActiveLinkColor = Color.RoyalBlue;
		LabelUserName.Location = new Point(80, 30);
		LabelUserName.Size = new Size(230, 24);
		LabelUserName.TabStop = true;
		LabelUserName.Text = "学生会信息部 开发人员";

		Label Label2 = new Label();
		Label2.Location = new Point(322, 30);
		Label2.Size = new Size(42, 21);
		Label2.Text = "进度";

		ProgressBar BarStat = new ProgressBar();
		BarStat.Location = new Point(370, 33);
		BarStat.Size = new Size(135, 18);
		BarStat.Value = 50;

		Label LabelStat = new Label();
		LabelStat.Location = new Point(511, 30);
		LabelStat.Size = new Size(103, 21);
		LabelStat.TextAlign = ContentAlignment.MiddleCenter;
		LabelStat.Text = "50%";

		Label LabelEndTime = new Label();
		LabelEndTime.Location = new Point(3, 57);
		LabelEndTime.Size = new Size(208, 21);
		LabelEndTime.AutoSize = true;
		LabelEndTime.Text = "预期完成日期：9999/99/99";

		Label LabelUpdateTime = new Label();
		LabelUpdateTime.Location = new Point(322, 57);
		LabelUpdateTime.Size = new Size(243, 21);
		LabelUpdateTime.AutoSize = true;
		LabelUpdateTime.Text = "最后更改：9999/99/99 99:99:99";

		Controls.Add(LabelPT);
		Controls.Add(LabelPI);
		Controls.Add(LabelTaskName);
        Controls.Add(Label3);
        Controls.Add(LabelProjName);
		Controls.Add(Label1);
		Controls.Add(LabelUserName);
		Controls.Add(Label2);
		Controls.Add(BarStat);
		Controls.Add(LabelStat);
		Controls.Add(LabelEndTime);
		Controls.Add(LabelUpdateTime);
            

		//UpdateTask(Taskinf);
	}

	public void UpdateTask(Task Source)
	{
		MyTaskInf = Source;
	}

}
}
