using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MYTask
{
    class TaskPanelContainer:Panel
    {
        public int TaskNum = 0;
        private int WW = SystemInformation.WorkingArea.Width;

        public TaskPanelContainer()
        {
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BackColor = Color.RoyalBlue;
            Location = new Point(0, 0);
            Size = new Size(621, 0);
            MaximumSize = new Size(WW, 0);
            Visible = true;
        }

        public void AddTask(Task Newtask)
        {
            if (TaskNum == 0)
            {
                MaximumSize = new Size(WW, 3);
                Height = 3;
            }
            TaskNum++;
            MaximumSize = new Size(WW, Height + 88);
            Height += 88; 
            TaskPanel Tp = new TaskPanel(Height - 88, Width - 6, Newtask);
            Controls.Add(Tp);
            Controls.SetChildIndex(Tp, TaskNum);
        }
    }
}
