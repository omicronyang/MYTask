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
        private string ConnectCommand;
        public int Online; //0 for offline, 1 for online

        public MyDB()
        {
            string server = "qdm183517592.my3w.com";
            string uid = "qdm183517592";
            string upw = "sssuittest";
            string dbname = "qdm183517592_db";
            ConnectCommand = String.Format("server = {0}; user id = {1}; password ={2}; database = {3}; pooling = false",
                server, uid, upw, dbname);
        }

        public bool Connect()
        {
            if (OnlineDBase != null) OnlineDBase.Close();
            try
            {
                OnlineDBase = new MySqlConnection(ConnectCommand);
                OnlineDBase.Open();
                Online = 1;
                return true;
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.ErrorCode + "Error connecting to the server: " + ex.Message);
                Online = 0;
                return false;
            }
        }

        public void Close()
        {
            if (OnlineDBase != null) OnlineDBase.Close();
        }
    }
}
