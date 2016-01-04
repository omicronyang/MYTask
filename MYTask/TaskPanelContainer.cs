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
        public int NowIndex = -1;
        public TaskPanel[] Tp = new TaskPanel[4];
        public List<MyTask> TaskList = new List<MyTask>();

        public TaskPanelContainer()
        {
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
            if (TaskNum-NowIndex >= 4)
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
