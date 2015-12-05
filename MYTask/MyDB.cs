using System;
using System.Collections;
using System.Linq;
using System.Text;
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
        }

        public bool Connect()
        {
            if (OfflineOnly == 1) return ConnectOffline();
            try
            {
                OnlineDBase = new MySqlConnection(OnlineConnectCommand);
                OnlineDBase.Open();
                Online = 1;
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
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GetUserPsw(string UserName)
        {
            string psw = "";
            string sql = string.Format( "select tk_user_pass from tk_user where tk_user_login like '{0}'",
                UserName);
            if (Online == 0)
            {
                SQLiteCommand command = new SQLiteCommand(sql, LocalDBase);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    psw = reader["tk_user_pass"].ToString();
                    reader.Close();
                }
                else return "@@@@";
            }
            else
            {
                MySqlCommand command = new MySqlCommand(sql,OnlineDBase);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    psw = reader.GetString(0);
                    reader.Close();
                }
                else return "@@@@";
            }
            return psw;
        }

        public int GetUserID(string UserName)
        {
            int UID = 0;
            string sql = string.Format("select uid from tk_user where tk_user_login like '{0}'",
                UserName);
            if (Online == 0)
            {
                SQLiteCommand command = new SQLiteCommand(sql, LocalDBase);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read()) UID = Convert.ToInt32(reader[0]);
                reader.Close();
            }
            else
            {
                MySqlCommand command = new MySqlCommand(sql, OnlineDBase);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) UID = reader.GetInt32(0);
                reader.Close();
            }
            return UID;
        }

        public MyUser GetUser(int Uid)
        {
            MyUser Result = new MyUser();
            string sql = string.Format("select * from tk_user where uid like {0}",
                Uid.ToString());
            if (Online == 0)
            {
                SQLiteCommand command = new SQLiteCommand(sql, LocalDBase);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Result.UID = Uid;
                    Result.Name = reader["tk_display_name"].ToString();
                    Result.Rank = Convert.ToInt32(reader["tk_user_rank"]);
                    Result.Message = Convert.ToInt32(reader["tk_user_message"]);
                    Result.Telephone = reader["tk_user_contact"].ToString();
                    Result.Email = reader["tk_user_email"].ToString();
                }
                reader.Close();
            }
            else
            {
                MySqlCommand command = new MySqlCommand(sql, OnlineDBase);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Result.UID = Uid;
                    Result.Name = reader["tk_display_name"].ToString();
                    Result.Rank = Convert.ToInt32(reader["tk_user_rank"]);
                    Result.Message = Convert.ToInt32(reader["tk_user_message"]);
                    Result.Telephone = reader["tk_user_contact"].ToString();
                    Result.Email = reader["tk_user_email"].ToString();
                }
                reader.Close();
            }
            return Result;
        }

        public MyUser GetUser(string user_login)
        {
            MyUser Result = new MyUser();
            string sql = string.Format("select * from tk_user where tk_user_login like '{0}'",
                user_login);
            if (Online == 0)
            {
                SQLiteCommand command = new SQLiteCommand(sql, LocalDBase);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Result.UID = Convert.ToInt32(reader["uid"]);
                    Result.Name = reader["tk_display_name"].ToString();
                    Result.Rank = Convert.ToInt32(reader["tk_user_rank"]);
                    Result.Message = Convert.ToInt32(reader["tk_user_message"]);
                    Result.Telephone = reader["tk_user_contact"].ToString();
                    Result.Email = reader["tk_user_email"].ToString();
                }
                reader.Close();
            }
            else
            {
                MySqlCommand command = new MySqlCommand(sql, OnlineDBase);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Result.UID = Convert.ToInt32(reader["uid"]);
                    Result.Name = reader["tk_display_name"].ToString();
                    Result.Rank = Convert.ToInt32(reader["tk_user_rank"]);
                    Result.Message = Convert.ToInt32(reader["tk_user_message"]);
                    Result.Telephone = reader["tk_user_contact"].ToString();
                    Result.Email = reader["tk_user_email"].ToString();
                }
                reader.Close();
            }
            return Result;
        }

        public MyTask GetTask(int Tid)
        {
            MyTask Result = new MyTask();
            string sql = string.Format("select * from tk_task where TID like {0}",
                Tid.ToString());
            if (Online == 0)
            {
                SQLiteCommand command = new SQLiteCommand(sql, LocalDBase);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Result.TID = Tid;
                    Result.TaskName = reader["csa_text"].ToString();
                    Result.TaskPriority = Convert.ToInt32(reader["csa_priority"]);
                    Result.TaskImportance = Convert.ToInt32(reader["csa_temp"]);
                    Result.TaskEndTime = Convert.ToDateTime(reader["csa_plan_et"]);
                    Result.TaskUpdateTime = Convert.ToDateTime(reader["csa_last_update"]);
                    Result.TaskU = GetUser(Convert.ToInt32(reader["csa_to_user"]));
                    Result.TaskFU = GetUser(Convert.ToInt32(reader["csa_from_user"]));
                    Result.TaskType = Convert.ToInt32(reader["csa_type"]);
                    Result.TaskStat = Convert.ToInt32(reader["csa_remark2"]);
                    Result.TaskPlanTime = Convert.ToDouble(reader["csa_plan_hour"]);
                    Result.TaskProject = "测试项目";
                    Result.TaskUsedTime = 0.5;
                }
                reader.Close();
            }
            else
            {
                MySqlCommand command = new MySqlCommand(sql, OnlineDBase);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Result.TID = Tid;
                    Result.TaskName = reader["csa_text"].ToString();
                    Result.TaskPriority = Convert.ToInt32(reader["csa_priority"]);
                    Result.TaskImportance = Convert.ToInt32(reader["csa_temp"]);
                    Result.TaskEndTime = Convert.ToDateTime(reader["csa_plan_et"]);
                    Result.TaskUpdateTime = Convert.ToDateTime(reader["csa_last_update"]);
                    Result.TaskU = GetUser(Convert.ToInt32(reader["csa_to_user"]));
                    Result.TaskFU = GetUser(Convert.ToInt32(reader["csa_from_user"]));
                    Result.TaskType = Convert.ToInt32(reader["csa_type"]);
                    Result.TaskStat = Convert.ToInt32(reader["csa_remark2"]);
                    Result.TaskPlanTime = Convert.ToDouble(reader["csa_plan_hour"]);
                    Result.TaskProject = "测试项目";
                    Result.TaskUsedTime = 0.5;
                }
                reader.Close();
            }
            return Result;
        }

        public int[] GetTaskList(int Uid,int Mode)
        {
            ArrayList res = new ArrayList();
            string sql;
            if (Mode == 0)
                sql = string.Format("select * from tk_task where csa_to_user like {0}", Uid.ToString());
            else if (Mode == 1)
                sql = string.Format("select * from tk_task where csa_from_user like {0}", Uid.ToString());
            else
                sql = "select * from tk_task";

            if (Online == 0)
            {
                SQLiteCommand command = new SQLiteCommand(sql, LocalDBase);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    res.Add(Convert.ToInt32(reader["TID"]));
                }
                reader.Close();
            }
            else
            {
                MySqlCommand command = new MySqlCommand(sql, OnlineDBase);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    res.Add(Convert.ToInt32(reader["TID"]));
                }
                reader.Close();
            }

            res.TrimToSize();
            int[] Result = new int[res.Count];
            for (int i = 0; i < res.Count; ++i)
            {
                Result[i] = Convert.ToInt32(res[i]);
            }
            return Result;
        }

        public void Close()
        {
            if (OnlineDBase != null) OnlineDBase.Close();
            if (LocalDBase != null) LocalDBase.Close();
        }
    }
}
