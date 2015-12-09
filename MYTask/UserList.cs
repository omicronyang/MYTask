using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MYTask
{
    class UserList : ListView
    {
        public int UserNum;

        public UserList()
        {
            View = View.Details;
            Dock = DockStyle.Fill;
            LabelEdit = false;
            Margin = new Padding(3);
            FullRowSelect = true;

            Columns.Add("用户名", 175, HorizontalAlignment.Left);
            Columns.Add("权限", 76, HorizontalAlignment.Left);
            Columns.Add("电话", 111, HorizontalAlignment.Left);
            Columns.Add("邮箱", 269, HorizontalAlignment.Left);
        }

        private string GetRank(int Rank)
        {
            switch (Rank)
            {
                case 0: { return "禁用"; }
                case 1: { return "只读"; }
                case 2: { return "访客";  }
                case 3: { return "普通用户"; }
                case 4: { return "项目经理"; }
                case 5: { return "管理员"; }
            }
            return "";
        }

        public void AddUserList(MyUser[] UList)
        {
            BeginUpdate();
            int len = UList.Length;
            for (int i=0;i< len; i++)
            {
                ListViewItem I = new ListViewItem();
                I.Text = UList[i].Name;
                I.SubItems.Add(GetRank(UList[i].Rank));
                I.SubItems.Add(UList[i].Telephone);
                I.SubItems.Add(UList[i].Email);
                I.SubItems.Add(UList[i].UID.ToString());
                Items.Add(I);
            }
            EndUpdate();
        }

    }
}
