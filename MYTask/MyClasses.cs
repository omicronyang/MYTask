using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace MYTask
{
    public class MyTask
    {
        public int TID;
        public string TaskName;
        public int TaskPriority;
        public int TaskImportance;
        public string TaskRemark;
        public int TaskPID;
        public DateTime TaskEndTime;
        public DateTime UpdateTime;
        public MyUser TaskU;
        public MyUser TaskFU;
        public int TaskStat;
        public int TaskType;
        public double TaskPlanTime;
        public double TaskUsedTime;
        public List<MyTask> Childlist = new List<MyTask>();
        public List<MyTaskByDay> Daylist = new List<MyTaskByDay>();

        public string TEndString()
        {
            return TaskEndTime.ToShortDateString();
        }

        public string TUpdateString()
        {
            return UpdateTime.ToShortDateString() + " " + UpdateTime.ToLongTimeString();
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

        public void AddChildList(MyTask[] CList)
        {
            foreach (MyTask i in CList) Childlist.Add(i);
        }

    }
    public class MyTaskByDay
    {
        public int TBStat;
        public double TBManhour;
        public string TBText;
        public int TBComment;
        public DateTime UpdateTime;
        public DateTime DayTime;
        public int TBUserID;
        public int TBTaskID;
        public int TBProjID;
        public int TBTaskType;

        public MyTaskByDay()
        {
            TBTaskID = 0;
            TBStat = 0;
        }

    }
    public class MyProj
    {
        public int PID;
        public string ProjName;
        public string ProjCode;
        public string ProjRemark;
        public int ProjType;
        public DateTime ProjStartTime;
        public DateTime ProjEndTime;
        public MyUser ProjToUser;
        public int ProjStat;
        public DateTime UpdateTime;
        public List<MyTask> Childlist = new List<MyTask>();

        public void AddChildList(MyTask[] CList)
        {
            foreach (MyTask i in CList) Childlist.Add(i);
        }

    }
    public class MyUser
    {
        public int UID;
        public string Name;
        public int Rank;
        public string Telephone;
        public string Email;
        public int Message;
        public string Remark;

        public void InitSystem()
        {
            UID = 1;
            Name = "系统用户";
            Rank = 5;
            Telephone = "";
            Email = "";
            Message = 0;
            Remark = "";
        }

    }
    public class MyAnnounce
    {
        public int AID;
        public string Title;
        public string Text;
        public int Type;
        public MyUser FromUser;
        public DateTime UpdateTime;

    }
    public class MyMessage
    {
        public int MID;
        public MyUser FromUser;
        public MyUser ToUser;
        public string Text;
        public string ShowText;
        public int Stat;
        public MyTask MessageTask;
        public DateTime UpdateTime;

        public void UpdateText(FormMain Form, string Origin)
        {
            string tmp, inttmp;
            int l, r;
            inttmp = tmp = Text = Origin;
            l = inttmp.IndexOf("editID=") + 7;
            r = inttmp.IndexOf("&");
            inttmp = inttmp.Remove(r);
            inttmp = inttmp.Remove(0, l);
            MessageTask = Form.DataBase.GetTask(Convert.ToInt32(inttmp));
            while (tmp.IndexOf('<') != -1)
            {
                l = tmp.IndexOf('<');
                r = tmp.IndexOf('>');
                tmp = tmp.Remove(l, r - l + 1);
            }
            ShowText = tmp;
        }

    }

    public class MyConsts {

        public enum PProfileShowMode {
            Edit = 0x01,
            Read = 0x10
        }

        public enum UserRank {
            Banned = 0,
            ReadOnly = 1,
            Visitor = 2,
            Common = 3,
            Manager = 4,
            Admin = 5
        }

    }
}
