using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MYTask
{
    public partial class LoginTextbox : TextBox
    {
        public LoginTextbox()
        {
        }

        public int State = 0;// 0待输入;1已输入;2警告;3无效

        public void RenewState(int NewState)
        {
            State = NewState;
            switch (State)
            {
                case 0:
                    {
                        BackColor = Color.White;
                        ForeColor = Color.Gray;
                        Enabled = true;
                        if (Name == "TextLogin_Psw") UseSystemPasswordChar = false;
                        break;
                    }
                case 1:
                    {
                        BackColor = Color.White;
                        ForeColor = Color.Black;
                        if (Name == "TextLogin_Psw") UseSystemPasswordChar = true;
                        Enabled = true;
                        break;
                    }
                case 2:
                    {
                        BackColor = Color.LightCoral;
                        ForeColor = Color.Maroon;
                        if (Name == "TextLogin_Psw") UseSystemPasswordChar = false;
                        Enabled = true;
                        break;
                    }
                case 3:
                    {
                        BackColor = Color.Green;
                        ForeColor = Color.White;
                        if (Name == "TextLogin_Psw") UseSystemPasswordChar = false;
                        Enabled = false;
                        break;
                    }
            }
        }
    }
}
