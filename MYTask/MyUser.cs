using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.SQLite;

namespace MYTask
{
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

}
