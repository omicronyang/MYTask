using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MYTask
{
    class LoginTextbox:System.Windows.Forms.TextBox
    {
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
                        break;
                    }
                case 1:
                    {
                        BackColor = Color.White;
                        ForeColor = Color.Black;
                        Enabled = true;
                        break;
                    }
                case 2:
                    {
                        BackColor = Color.LightCoral;
                        ForeColor = Color.Maroon;
                        Enabled = true;
                        break;
                    }
                case 3:
                    {
                        BackColor = Color.Silver;
                        ForeColor = Color.Silver;
                        Enabled = false;
                        break;
                    }
            }
        }

    }
}
