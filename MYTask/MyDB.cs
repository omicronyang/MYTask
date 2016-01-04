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
        private string[] TabelList = new string[4] { "tk_user", "tk_task", "tk_task_byday", "tk_project" };
        
            
            
        public MyDB()
        {
            string server = "qdm183517592.my3w.com";
            string uid = "qdm183517592";
            string upw = "sssuittest";
            string dbname = "qdm183517592_db";
            string localdbname = Application.StartupPath + @"\offlinedata.sqlite";
            OnlineConnectCommand = String.Format("server = {0}; user id = {1}; password ={2}; database = {3}; pooling = false",
                server, uid, upw, dbname);
            OfflineConnectCommand = String.Format("Data Source={0};Version=3;",
                localdbname);
            for (int i = 0; i < 4; i++)
                DataBase.Tables.Add(TabelList[i]);

        }

        public bool Connect()
        {
            if (OfflineOnly == 1) return ConnectOffline();
            try
            {
                OnlineDBase = new MySqlConnection(OnlineConnectCommand);
                OnlineDBase.Open();
                Online = 1;
                for (int i = 0; i < 4; i++)
                    GetTabel(TabelList[i]);
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
                for (int i = 0; i < 4; i++)
                    GetTabel(TabelList[i]);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 获取数据表
        /// </summary>
        /// <param name="DTName">连接数据库的名称</param>
        private void GetTabel(string DTName)
        {
            string sql = "Select * From " + DTName;
            if (Online == 0)
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, LocalDBase);
                SQLiteDataReader reader = cmd.ExecuteReader();
                DataBase.Tables[DTName].Load(reader);
                reader.Close();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand(sql, OnlineDBase);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataBase.Tables[DTName].Load(reader);
                reader.Close();
            }
        }

        #region UserControl
        /// <summary>
        /// 从数据源获取用户信息
        /// </summary>
        /// <param name="Source">数据源</param>
        /// <returns>用户信息</returns>
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

        /// <summary>
        /// 获取所有用户列表
        /// </summary>
        /// <returns></returns>
        public MyUser[] GetUserList()
        {
            DataRow[] Matches = DataBase.Tables["tk_user"].Select();
            int Cnt = Matches.Count();
            MyUser[] Result = new MyUser[Cnt];
            for (int i = 0; i < Cnt; i++)
            {
                Result[i] = new MyUser();
                Result[i] = GetUserFromRow(Matches[i]);
            }
            return Result;
        }

        /// <summary>
        /// 获取单个用户信息
        /// </summary>
        /// <param name="Uid">用户ID</param>
        /// <returns></returns>
        public MyUser GetUser(int Uid)
        {
            MyUser Result = new MyUser();
            DataRow[] Matches = DataBase.Tables["tk_user"].Select("uid='" + Uid.ToString() + "'");
            if (Matches.Length == 0)
            {
                Result.InitSystem();
                return Result;
            }
            Result = GetUserFromRow(Matches[0]);
            return Result;
        }

        /// <summary>
        /// 获取单个用户信息
        /// </summary>
        /// <param name="user_login">用户登录名</param>
        /// <returns></returns>
        public MyUser GetUser(string user_login)
        {
            MyUser Result = new MyUser();
            DataRow[] Matches = DataBase.Tables["tk_user"].Select("tk_user_login='" + user_login + "'");
            if (Matches.Length == 0)
            {
                Result.InitSystem();
                return Result;
            }
            Result = GetUserFromRow(Matches[0]);
            return Result;
        }

        /// <summary>
        /// 获取指定用户的密码
        /// </summary>
        /// <param name="user_login">用户登录名</param>
        /// <returns></returns>
        public string GetUserPsw(string user_login)
        {
            string psw = "";
            DataRow[] Matches = DataBase.Tables["tk_user"].Select("tk_user_login='" + user_login + "'");
            if (Matches.Length == 0)
                return psw;
            psw = Convert.ToString(Matches[0]["tk_user_pass"]);
            return psw;
        }
        #endregion

        #region TaskControl
        /// <summary>
        /// 从数据源获取任务信息
        /// </summary>
        /// <param name="Source">数据源</param>
        /// <returns>任务信息</returns>
        private MyTask GetTaskFromRow(DataRow Source)
        {
            MyTask Result = new MyTask();
            Result.TID = Convert.ToInt32(Source["tid"]);
            Result.TaskName = Convert.ToString(Source["csa_text"]);
            Result.TaskPriority = Convert.ToInt32(Source["csa_priority"]);
            Result.TaskImportance = Convert.ToInt32(Source["csa_temp"]);
            Result.TaskEndTime = Convert.ToDateTime(Source["csa_plan_et"]);
            Result.TaskUpdateTime = Convert.ToDateTime(Source["csa_last_update"]);
            Result.TaskU = GetUser(Convert.ToInt32(Source["csa_to_user"]));
            Result.TaskFU = GetUser(Convert.ToInt32(Source["csa_from_user"]));
            Result.TaskType = Convert.ToInt32(Source["csa_type"]);
            Result.TaskStat = Convert.ToInt32(Source["csa_status"]);
            Result.TaskPlanTime = Convert.ToDouble(Source["csa_plan_hour"]);

            Result.AddTBDList(GetTBDList(Result.TID));



            Result.TaskProject = "测试项目";
            //Result.TaskUsedTime = 0.5;
            return Result;
        }
        
        /// <summary>
        /// 从数据源获取任务日历
        /// </summary>
        /// <param name="Source">数据源</param>
        /// <returns></returns>
        private MyTaskByDay GetTBDFromRow(DataRow Source)
        {
            MyTaskByDay Result = new MyTaskByDay();
            Result.TBTaskID = Convert.ToInt32(Source["csa_tb_backup1"]);
            Result.TBUserID = Convert.ToInt32(Source["csa_tb_backup2"]);
            Result.TBProjID = Convert.ToInt32(Source["csa_tb_backup3"]);
            Result.TBTaskType = Convert.ToInt32(Source["csa_tb_backup4"]);
            Result.TBStatus = Convert.ToInt32(Source["csa_tb_status"]);
            Result.TBComment = Convert.ToInt32(Source["csa_tb_comment"]);
            Result.TBManhour = Convert.ToDouble(Source["csa_tb_manhour"]);
            Result.TBText = Convert.ToString(Source["csa_tb_text"]);
            Result.TBUpdateTime = Convert.ToDateTime(Source["csa_tb_lastupdate"]);
            return Result;
        }

        /// <summary>
        /// 获取所有任务列表
        /// </summary>
        /// <returns></returns>
        public MyTask[] GetTaskList()
        {
            DataRow[] Matches = DataBase.Tables["tk_task"].Select();
            int Cnt = Matches.Count();
            MyTask[] Result = new MyTask[Cnt];
            for (int i = 0; i < Cnt; i++)
            {
                Result[i] = new MyTask();
                Result[i] = GetTaskFromRow(Matches[i]);
            }
            return Result;
        }

        /// <summary>
        /// 获取用户相关的任务列表
        /// </summary>
        /// <param name="Uid">用户ID</param>
        /// <param name="Mode">模式，0返回指定给用户的任务，1返回用户发出的任务</param>
        /// <returns></returns>
        public MyTask[] GetTaskList(int Uid,int Mode)
        {
            string FilterStr;
            if (Mode == 0)
                FilterStr = "csa_to_user='" + Uid.ToString() + "'";
            else
                FilterStr = "csa_from_user='" + Uid.ToString() + "'";
            DataRow[] Matches = DataBase.Tables["tk_task"].Select(FilterStr);
            int Cnt = Matches.Count();
            MyTask[] Result = new MyTask[Cnt];
            for (int i = 0; i < Cnt; i++)
            {
                Result[i] = new MyTask();
                Result[i] = GetTaskFromRow(Matches[i]);
            }
            return Result;
        }

        /// <summary>
        /// 获取任务相关的日历信息
        /// </summary>
        /// <param name="TaskID">任务ID</param>
        /// <returns></returns>
        public MyTaskByDay[] GetTBDList(int TaskID)
        {
            string FilterStr = "csa_tb_backup1='" + TaskID.ToString() + "'";
            DataRow[] Matches = DataBase.Tables["tk_task_byday"].Select(FilterStr);
            int Cnt = Matches.Count();
            MyTaskByDay[] Result = new MyTaskByDay[Cnt];
            for (int i = 0; i < Cnt; i++)
            {
                Result[i] = new MyTaskByDay();
                Result[i] = GetTBDFromRow(Matches[i]);
            }
            return Result;
        }
        #endregion

        #region ProjectControl
        /// <summary>
        /// 从数据源获取项目
        /// </summary>
        /// <param name="Source">数据源</param>
        /// <returns></returns>
        public MyProj GetProjFromRow(DataRow Source)
        {
            MyProj Result = new MyProj();
            Result.PID = Convert.ToInt32(Source["id"]);
            Result.ProjName = Convert.ToString(Source["project_name"]);
            Result.ProjCode = Convert.ToString(Source["project_code"]);
            Result.ProjRemark = Convert.ToString(Source["project_text"]);
            Result.ProjType = Convert.ToInt32(Source["project_type"]);
            //Result.ProjStartTime = Convert.ToDateTime(Source["project_start"]);
            //Result.ProjEndTime = Convert.ToDateTime(Source["project_end"]);
            Result.ProjToUser = GetUser(Convert.ToInt32(Source["project_to_user"]));
            Result.ProjStat = Convert.ToInt32(Source["project_status"]);
            Result.ProjUpdateTime = Convert.ToDateTime(Source["project_lastupdate"]);
            return Result;
        }

        /// <summary>
        /// 获取所有项目列表
        /// </summary>
        /// <returns></returns>
        public MyProj[] GetProjList()
        {
            DataRow[] Matches = DataBase.Tables["tk_project"].Select();
            int Cnt = Matches.Count();
            MyProj[] Result = new MyProj[Cnt];
            for (int i = 0; i < Cnt; i++)
            {
                Result[i] = new MyProj();
                Result[i] = GetProjFromRow(Matches[i]);
            }
            return Result;
        }

        /// <summary>
        /// 获取用户负责的项目列表
        /// </summary>
        /// <param name="Uid">用户ID</param>
        /// <returns></returns>
        public MyProj[] GetProjList(int Uid)
        {
            string FilterStr;
            FilterStr = "project_to_user='" + Uid.ToString() + "'";
            DataRow[] Matches = DataBase.Tables["tk_project"].Select(FilterStr);
            int Cnt = Matches.Count();
            MyProj[] Result = new MyProj[Cnt];
            for (int i = 0; i < Cnt; i++)
            {
                Result[i] = new MyProj();
                Result[i] = GetProjFromRow(Matches[i]);
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
