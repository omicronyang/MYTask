using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MYTask
{
    class MyDB
    {

        private MySqlConnection OnlineDBase;
        private SQLiteConnection LocalDBase;
        private string OnlineConnectCommand;
        private string OfflineConnectCommand;
        public int Online; //0 for offline, 1 for online

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
            if (OnlineDBase != null) OnlineDBase.Close();
            try
            {
                OnlineDBase = new MySqlConnection(OnlineConnectCommand);
                OnlineDBase.Open();
                Online = 1;
                return true;
            }
            catch
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
            }
            else
            {
                MySqlCommand command = new MySqlCommand(sql, OnlineDBase);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) UID = reader.GetInt32(0);
            }
            return UID;
        }

        public void Close()
        {
            if (OnlineDBase != null) OnlineDBase.Close();
            if (LocalDBase != null) LocalDBase.Close();
        }
    }
}
