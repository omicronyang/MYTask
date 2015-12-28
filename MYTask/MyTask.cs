using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MYTask
{
    public class MyTask
    {
        public int TID;
        public string TaskName;
        public int TaskPriority;
        public int TaskImportance;
        public string TaskProject;
        //public MyProj TaskProject;
        public DateTime TaskEndTime;
        public DateTime TaskUpdateTime;
        public MyUser TaskU;
        public MyUser TaskFU;
        public int TaskStat;
        public int TaskType;
        public double TaskPlanTime;
        public double TaskUsedTime;
        public List<MyTaskByDay> Daylist = new List<MyTaskByDay>();

        public string TEndString()
        {
            return TaskEndTime.ToShortDateString();
        }

        public string TUpdateString()
        {
            return TaskUpdateTime.ToShortDateString() + " " + TaskUpdateTime.ToLongTimeString();
        }

        public void InitTestInf(FormMain FF)
        {
            Random ran = new Random();
            TID = 1;
            TaskName = "体育节工作人员证件收集";
            TaskPriority = ran.Next(1,5);
            TaskImportance = ran.Next(1,5);
            TaskProject = "体育部";
            TaskEndTime = new DateTime(2015, 10, 28);
            TaskStat = 25;
            TaskType = 10;
            TaskUpdateTime = new DateTime(2015, 11, 18, 14, 14, 03);
            TaskU = FF.DataBase.GetUser(5);
            TaskFU = FF.DataBase.GetUser(34);

            TaskPlanTime = 35.5;
            TaskUsedTime = ran.NextDouble() * 35.5;
        }

        public void AddTBDList(MyTaskByDay[] TBDList)
        {
            TaskUsedTime = 0;    
            for (int i = 0; i < TBDList.Length; i++)
            {
                Daylist.Add(TBDList[i]);
                TaskUsedTime += TBDList[i].TBManhour;
            }
        }

    }
    public class MyTaskByDay
    {
        public int TBStatus;
        public double TBManhour;
        public string TBText;
        public int TBComment;
        public DateTime TBUpdateTime;
        public int TBUserID;
        public int TBTaskID;
        public int TBProjID;
        public int TBTaskType;
    }
}
