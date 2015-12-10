using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MYTask
{
    public class MyDB
    {

        private MySqlConnection OnlineDBase;
        private SQLiteConnection LocalDBase;
        private string OnlineConnectCommand;
        private string OfflineConnectCommand;
        private int OfflineOnly = 1; //0 尝试在线连接; 1 关闭在线尝试
        public int Online;           //0 表示离线;     1 表示在线
        private DataSet DataBase = new DataSet();

        public MyDB()
        {
            string server = "qdm183517592.my3w.com";
            string uid = "qdm183517592";
            string upw = "sssuittest";
            string dbname = "qdm183517592_db";
            string localdbname = "offlinedata.sqlite";
            OnlineConnectCommand = String.Format("server = {0}; user id = {1}; password ={2}; database = {3}; pooling = false",
                server, uid, upw, dbname);
            OfflineConnectCommand = String.Format("Data Source={0};Version=3;",
                localdbname);
            DataBase.Tables.Add("User");
            DataBase.Tables.Add("Task");

        }

        public bool Connect()
        {
            if (OfflineOnly == 1) return ConnectOffline();
            try
            {
                OnlineDBase = new MySqlConnection(OnlineConnectCommand);
                OnlineDBase.Open();
                Online = 1;
                GetUserTabel();
                GetTaskTabel();
                return true;
            }
            catch
            {
                return ConnectOffline();
            }
        }

        private bool ConnectOffline()
        {
            try
            {
                LocalDBase = new SQLiteConnection(OfflineConnectCommand);
                LocalDBase.Open();
                Online = 0;
                GetUserTabel();
                GetTaskTabel();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void GetUserTabel()
        {
            string sql = "Select * From tk_user";
            if (Online == 0)
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, LocalDBase);
                SQLiteDataReader reader = cmd.ExecuteReader();
                DataBase.Tables["User"].Load(reader);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand(sql, OnlineDBase);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataBase.Tables["User"].Load(reader);
            }
        }

        private void GetTaskTabel()
        {
            string sql = "Select * From tk_task";
            if (Online == 0)
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, LocalDBase);
                SQLiteDataReader reader = cmd.ExecuteReader();
                DataBase.Tables["Task"].Load(reader);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand(sql, OnlineDBase);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataBase.Tables["Task"].Load(reader);
            }
        }
        
        private MyTask GetTaskFromRow(DataRow Source)
        {
            MyTask Result = new MyTask();
            Result.TID = Convert.ToInt32(Source["TID"]);
            Result.TaskName = Convert.ToString(Source["csa_text"]);
            Result.TaskPriority = Convert.ToInt32(Source["csa_priority"]);
            Result.TaskImportance = Convert.ToInt32(Source["csa_temp"]);
            Result.TaskEndTime = Convert.ToDateTime(Source["csa_plan_et"]);
            Result.TaskUpdateTime = Convert.ToDateTime(Source["csa_last_update"]);
            Result.TaskU = GetUser(Convert.ToInt32(Source["csa_to_user"]));
            Result.TaskFU = GetUser(Convert.ToInt32(Source["csa_from_user"]));
            Result.TaskType = Convert.ToInt32(Source["csa_type"]);
            Result.TaskStat = Convert.ToInt32(Source["csa_remark2"]);
            Result.TaskPlanTime = Convert.ToDouble(Source["csa_plan_hour"]);
            Result.TaskProject = "测试项目";
            Result.TaskUsedTime = 0.5;
            return Result;
        }

        #region UserControl
        private MyUser GetUserFromRow(DataRow Source)
        {
            MyUser Result = new MyUser();
            Result.UID = Convert.ToInt32(Source["uid"]);
            Result.Name = Convert.ToString(Source["tk_display_name"]);
            Result.Rank = Convert.ToInt32(Source["tk_user_rank"]);
            Result.Message = Convert.ToInt32(Source["tk_user_message"]);
            Result.Telephone = Convert.ToString(Source["tk_user_contact"]);
            Result.Email = Convert.ToString(Source["tk_user_email"]);
            Result.Remark = Convert.ToString(Source["tk_user_remark"]);
            return Result;
        }

        public MyUser[] GetUserList()
        {
            DataRow[] Matches = DataBase.Tables["User"].Select();
            int Cnt = Matches.Count();
            MyUser[] Result = new MyUser[Cnt];
            for (int i = 0; i < Cnt; i++)
            {
                Result[i] = new MyUser();
                Result[i] = GetUserFromRow(Matches[i]);
            }
            return Result;
        }

        public MyUser GetUser(int Uid)
        {
            MyUser Result = new MyUser();
            DataRow[] Matches = DataBase.Tables["User"].Select("uid='" + Uid.ToString() + "'");
            if (Matches.Length == 0)
            {
                Result.InitSystem();
                return Result;
            }
            Result = GetUserFromRow(Matches[0]);
            return Result;
        }

        public MyUser GetUser(string user_login)
        {
            MyUser Result = new MyUser();
            DataRow[] Matches = DataBase.Tables["User"].Select("tk_user_login='" + user_login + "'");
            if (Matches.Length == 0)
            {
                Result.InitSystem();
                return Result;
            }
            Result = GetUserFromRow(Matches[0]);
            return Result;
        }

        public string GetUserPsw(string UserName)
        {
            string psw = "";
            DataRow[] Matches = DataBase.Tables["User"].Select("tk_user_login='" + UserName + "'");
            if (Matches.Length == 0)
                return psw;
            psw = Convert.ToString(Matches[0]["tk_user_pass"]);
            return psw;
        }
        #endregion

        #region TaskControl
        public MyTask GetTask(int Tid)
        {
            MyTask Result = new MyTask();
            DataRow[] Matches = DataBase.Tables["Task"].Select("TID='" + Tid.ToString() + "'");
            Result = GetTaskFromRow(Matches[0]);
            return Result;
        }

        public MyTask[] GetTaskList()
        {
            DataRow[] Matches = DataBase.Tables["Task"].Select();
            int Cnt = Matches.Count();
            MyTask[] Result = new MyTask[Cnt];
            for (int i = 0; i < Cnt; i++)
            {
                Result[i] = new MyTask();
                Result[i] = GetTaskFromRow(Matches[i]);
            }
            return Result;
        }

        public MyTask[] GetTaskList(int Uid,int Mode)
        {
            string FilterStr;
            if (Mode == 0)
                FilterStr = "csa_to_user='" + Uid.ToString() + "'";
            else
                FilterStr = "csa_from_user='" + Uid.ToString() + "'";
            DataRow[] Matches = DataBase.Tables["Task"].Select(FilterStr);
            int Cnt = Matches.Count();
            MyTask[] Result = new MyTask[Cnt];
            for (int i = 0; i < Cnt; i++)
            {
                Result[i] = new MyTask();
                Result[i] = GetTaskFromRow(Matches[i]);
            }
            return Result;
        }
        #endregion

        public void Close()
        {
            if (OnlineDBase != null) OnlineDBase.Close();
            if (LocalDBase != null) LocalDBase.Close();
        }
    }
}
