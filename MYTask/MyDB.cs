using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.s
using System.Windows.Forms;

namespace MYTask
{
    class MyDB
    {

        private MySqlConnection OnlineDBase;
        private SQLiteConnection LocalDBase;
        private string OnlineConnectCommand;
        private string OfflineCOnnectCommand;
        public int Online; //0 for offline, 1 for online

        public MyDB()
        {
            string server = "qdm183517592.my3w.com";
            string uid = "qdm183517592";
            string upw = "sssuittest";
            string dbname = "qdm183517592_db";
            string localdbname = "offlinedata.sqlite";
            string OnlineConnectCommand = String.Format("server = {0}; user id = {1}; password ={2}; database = {3}; pooling = false",
                server, uid, upw, dbname);
            string OfflineCOnnectCommand = String.Format("Data Source={0};Version=3;",
                localdbname);
        }

        public bool Connect()
        {
            if (OnlineDBase != null) OnlineDBase.Close();
            /*try
            {
                OnlineDBase = new MySqlConnection(OnlineConnectCommand);
                OnlineDBase.Open();
                Online = 1;
                return true;
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.ErrorCode + "Error connecting to the server: " + ex.Message);
                Online = 0;
                return false;
            }*/
            /*
            LocalDBase = new SQLiteConnection(OfflineCOnnectCommand);
            LocalDBase.Open();
            string sql = "select * from tk_user order by uid desc";
            SQLiteCommand command = new SQLiteCommand(sql, LocalDBase);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                MessageBox.Show("Name: " + reader["uid"] + "\tScore: " + reader["tk_user_login"]);
            */
            return true;
        }

        public void Close()
        {
            if (OnlineDBase != null) OnlineDBase.Close();
        }
    }
}
