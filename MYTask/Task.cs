using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MYTask
{
    class Task
    {
        public int TaskID;
        public string TaskName;
        public int TaskPriority;
        public int TaskImportance;
        public string TaskProject;
        public DateTime TaskEndTime;
        public string TaskU;
        public string TaskFU;
        public int TaskStat;
        public int TaskType;
        public DateTime TaskUpdateTime;
        public double TaskPlanTime;
        public double TaskUsedTime;

        private int TaskProjectID;
        private int TaskUID;
        private int TaskFUID;

        public string TEndString()
        {
            return TaskEndTime.ToShortDateString();
        }

        public string TUpdateString()
        {
            return TaskUpdateTime.ToShortDateString() + " " + TaskUpdateTime.ToLongTimeString();
        }

        public void InitTestInf()
        {
            Random ran = new Random();
            TaskID = 1;
            TaskName = "体育节工作人员证件收集";
            TaskPriority = ran.Next(1,5);
            TaskImportance = ran.Next(1,5);
            TaskProjectID = 3;
            TaskProject = "体育部";
            TaskEndTime = new DateTime(2015, 10, 28);
            TaskUID = 3;
            TaskU = "学生会主席团 黄晓琪";
            TaskFUID = 5;
            TaskFU = "学生会主席团 曹雅俊";
            TaskStat = 25;
            TaskType = 10;
            TaskUpdateTime = new DateTime(2015, 11, 18, 14, 14, 03);

            TaskPlanTime = 35.5;
            TaskUsedTime = 12.3;
        }
    }
}
