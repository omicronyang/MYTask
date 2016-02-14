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
        private FormMain Form;
        private MySqlConnection OnlineDBase;
        private SQLiteConnection LocalDBase;
        private string OnlineConnectCommand;
        private string OfflineConnectCommand;
        private int OfflineOnly = 1; //0 尝试在线连接; 1 关闭在线尝试
        public int Online;           //0 表示离线;     1 表示在线
        private DataSet DataBase = new DataSet();
        private string[] TabelList = new string[6] { "tk_user", "tk_task", "tk_task_byday", "tk_project", "tk_announcement","tk_message" };
        
            
        /// <summary>
        /// 数据库配置
        /// </summary>
        public MyDB(FormMain frm)
        {
            Form = frm;
            string server = "qdm183517592.my3w.com";
            string uid = "qdm183517592";
            string upw = "sssuittest";
            string dbname = "qdm183517592_db";
            string localdbname = Application.StartupPath + @"\offlinedata.sqlite";
            OnlineConnectCommand = String.Format("server = {0}; user id = {1}; password ={2}; database = {3}; pooling = false",
                server, uid, upw, dbname);
            OfflineConnectCommand = String.Format("Data Source={0};Version=3;",
                localdbname);
            for (int i = 0; i < 6; i++)
                DataBase.Tables.Add(TabelList[i]);

        }
        

        #region DatabaseConnection
        public bool Connect()
        {
            if (OfflineOnly == 1) return ConnectOffline();
            try
            {
                OnlineDBase = new MySqlConnection(OnlineConnectCommand);
                OnlineDBase.Open();
                Online = 1;
                for (int i = 0; i < 6; i++)
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
                for (int i = 0; i < 6; i++)
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
        /// <param name="DTName">连接数据表的名称</param>
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
        #endregion

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
            Result.TaskRemark = Convert.ToString(Source["csa_remark1"]);
            Result.UpdateTime = Convert.ToDateTime(Source["csa_last_update"]);
            Result.TaskU = GetUser(Convert.ToInt32(Source["csa_to_user"]));
            Result.TaskFU = GetUser(Convert.ToInt32(Source["csa_from_user"]));
            Result.TaskType = Convert.ToInt32(Source["csa_type"]);
            Result.TaskStat = Convert.ToInt32(Source["csa_status"]);
            Result.TaskPlanTime = Convert.ToDouble(Source["csa_plan_hour"]);
            Result.TaskPID = Convert.ToInt32(Source["csa_project"]);

            Result.AddTBDList(GetTBDList(Result.TID));
            Result.AddChildList(GetChildList(Result.TID));
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
            Result.TBStat = Convert.ToInt32(Source["csa_tb_status"]);
            Result.TBComment = Convert.ToInt32(Source["csa_tb_comment"]);
            Result.TBManhour = Convert.ToDouble(Source["csa_tb_manhour"]);
            Result.TBText = Convert.ToString(Source["csa_tb_text"]);
            Result.UpdateTime = Convert.ToDateTime(Source["csa_tb_lastupdate"]);

            string yearstr = Convert.ToString(Source["csa_tb_year"]);
            int year = Convert.ToInt32(yearstr.Substring(0, 4));
            int month = Convert.ToInt32(yearstr.Substring(4, 2));
            int day = Convert.ToInt32(yearstr.Substring(6, 2));
            Result.DayTime = new DateTime(year, month, day);

            return Result;
        }
        /// <summary>
        /// 获取指定的任务
        /// </summary>
        /// <param name="TID">任务ID</param>
        /// <returns></returns>
        public MyTask GetTask(int TID)
        {
            MyTask Result = new MyTask();
            DataRow[] Matches = DataBase.Tables["tk_task"].Select("tid=" + TID.ToString());
            if (Matches.Length == 0) return Result;
            Result = GetTaskFromRow(Matches[0]);
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
        /// <param name="TID">任务ID</param>
        /// <returns></returns>
        public MyTaskByDay[] GetTBDList(int TID)
        {
            string FilterStr = "csa_tb_backup1='" + TID.ToString() + "'";
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
        /// <summary>
        /// 获取子任务列表
        /// </summary>
        /// <param name="TID">任务ID</param>
        /// <returns></returns>
        private MyTask[] GetChildList(int TID)
        {
            DataRow[] Matches = DataBase.Tables["tk_task"].Select("csa_father=" + TID.ToString());
            int Cnt = Matches.Count();
            MyTask[] Result = new MyTask[Cnt];
            for (int i=0;i< Cnt; i++)
            {
                Result[i] = new MyTask();
                Result[i] = GetTaskFromRow(Matches[i]);
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
            Result.ProjToUser = GetUser(Convert.ToInt32(Source["project_to_user"]));
            Result.ProjStat = Convert.ToInt32(Source["project_status"]);
            Result.UpdateTime = Convert.ToDateTime(Source["project_lastupdate"]);
            Result.AddChildList(GetPChildList(Result.PID));
            return Result;
        }

        public int GetProjNum(DataRow Source)
        {
            return Convert.ToInt32(Source["id"]);
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
            string FilterStr = "project_to_user=" + Uid.ToString();
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

        /// <summary>
        /// 获取单个项目
        /// </summary>
        /// <param name="Pid">项目ID</param>
        /// <returns></returns>
        public MyProj GetProj(int Pid)
        {
            MyProj Result = new MyProj();
            DataRow[] Matches = DataBase.Tables["tk_project"].Select("id=" + Pid.ToString());
            if (Matches.Length == 0)
            {
                return Result;
            }
            Result = GetProjFromRow(Matches[0]);
            return Result;
        }

        public MyTask[] GetPChildList(int PID)
        {
            DataRow[] Matches = DataBase.Tables["tk_task"].Select("csa_project='" + PID.ToString() + "' AND csa_father='-1'");
            int Cnt = Matches.Length;
            MyTask[] Result = new MyTask[Cnt];
            for (int i=0;i< Cnt;i++)
            {
                Result[i] = new MyTask();
                Result[i] = GetTaskFromRow(Matches[i]);
            }
            return Result;
        }

        #endregion

        #region MessageControl
        /// <summary>
        /// 从数据源获取公告
        /// </summary>
        /// <param name="Source">数据源</param>
        /// <returns></returns>
        private MyAnnounce GetAnnounceFromRow(DataRow Source)
        {
            MyAnnounce Result = new MyAnnounce();
            Result.AID = Convert.ToInt32(Source["aid"]);
            Result.Title = Convert.ToString(Source["tk_anc_title"]);
            Result.Text = Convert.ToString(Source["tk_anc_text"]);
            Result.FromUser = GetUser(Convert.ToInt32(Source["tk_anc_create"]));
            Result.UpdateTime = Convert.ToDateTime(Source["tk_anc_lastupdate"]);
            return Result;
        }

        /// <summary>
        /// 获取所有公告列表
        /// </summary>
        /// <returns></returns>
        public MyAnnounce[] GetAnnounceList()
        {
            DataRow[] Matches = DataBase.Tables["tk_announcement"].Select();
            int Cnt = Matches.Count();
            MyAnnounce[] Result = new MyAnnounce[Cnt];
            for (int i = 0; i < Cnt; i++)
            {
                Result[i] = new MyAnnounce();
                Result[i] = GetAnnounceFromRow(Matches[i]);
            }
            return Result;
        }

        /// <summary>
        /// 获取单个公告
        /// </summary>
        /// <param name="Aid">公告ID</param>
        /// <returns></returns>
        public MyAnnounce GetAnnounce(int Aid)
        {
            MyAnnounce Result = new MyAnnounce();
            DataRow[] Matches = DataBase.Tables["tk_announcement"].Select("aid='" + Aid.ToString() + "'");
            if (Matches.Length == 0)
            {
                return Result;
            }
            Result = GetAnnounceFromRow(Matches[0]);
            return Result;
        }

        /// <summary>
        /// 从数据源获取消息
        /// </summary>
        /// <param name="Source">数据源</param>
        /// <returns></returns>
        private MyMessage GetMessFromRow(DataRow Source)
        {
            MyMessage Result = new MyMessage();
            Result.MID = Convert.ToInt32(Source["meid"]);
            Result.ToUser = GetUser(Convert.ToInt32(Source["tk_mess_touser"]));
            Result.FromUser = GetUser(Convert.ToInt32(Source["tk_mess_fromuser"]));
            Result.UpdateText(Form,Convert.ToString(Source["tk_mess_title"]));
            Result.Stat = Convert.ToInt32(Source["tk_mess_status"]);
            Result.UpdateTime = Convert.ToDateTime(Source["tk_mess_time"]);
            return Result;
        }

        /// <summary>
        /// 获取用户的通知
        /// </summary>
        /// <param name="Uid">用户ID</param>
        /// <returns></returns>
        public MyMessage[] GetMessList(int Uid)
        {
            DataRow[] Matches = DataBase.Tables["tk_message"].Select("tk_mess_touser='" + Uid.ToString() + "'");
            int Cnt = Matches.Count();
            MyMessage[] Result = new MyMessage[Cnt];
            for (int i=0;i< Cnt; i++)
            {
                Result[i] = new MyMessage();
                Result[i] = GetMessFromRow(Matches[i]);
            }
            return Result;
        }

        /// <summary>
        /// 获取单个通知
        /// </summary>
        /// <param name="Mid">通知ID</param>
        /// <returns></returns>
        public MyMessage GetMess(int Mid)
        {
            MyMessage Result = new MyMessage();
            DataRow[] Matches = DataBase.Tables["tk_message"].Select("meid='" + Mid.ToString() + "'");
            if (Matches.Length == 0)
            {
                return Result;
            }
            Result = GetMessFromRow(Matches[0]);
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
