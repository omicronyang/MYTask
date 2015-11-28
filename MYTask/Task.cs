using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MYTask
{
    class Task
    {
        public int TaskID = 0;
        public string TaskName;
        public int TaskPriority;
        public int TaskProjectID;
        public string TaskProject;
        public DateTime TaskEndTime;
        public int TaskUID;
        public string TaskU;
        public int TaskStat;
        public DateTime TaskUpdateTime;

        public string TEndString()
        {
            return TaskEndTime.ToShortDateString();
        }

        public string TUpdateString()
        {
            return TaskUpdateTime.ToShortDateString() + " " + TaskUpdateTime.ToLongTimeString();
        }

    }
}
