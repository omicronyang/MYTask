using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MYTask
{
    public partial class FormAudit : Form
    {
        public int Accepted = 0;
        public FormAudit()
        {
            InitializeComponent();
        }


        public string AuditContent
        {
            get
            {
                return AuditText.Text;
            }
            set
            {
                AuditText.Text = value;
            }
        }

        private void BtnA_SetStyle(bool Active)
        {
            if (Active)
            {
                BtnAccept.ForeColor = Color.White;
                BtnAccept.BackColor = Color.FromArgb(51, 102, 153);
                BtnAccept.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 102, 153);
                BtnAccept.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 102, 153);
            }
            else
            {
                BtnAccept.ForeColor = Color.Black;
                BtnAccept.BackColor = Color.Gainsboro;
                BtnAccept.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 102, 153);
                BtnAccept.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 153, 204);
            }
        }

        private void BtnB_SetStyle(bool Active)
        {
            if (Active)
            {
                BtnDeny.ForeColor = Color.White;
                BtnDeny.BackColor = Color.DarkRed;
                BtnDeny.FlatAppearance.MouseDownBackColor = Color.DarkRed;
                BtnDeny.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            }
            else
            {
                BtnDeny.ForeColor = Color.Black;
                BtnDeny.BackColor = Color.Gainsboro;
                BtnDeny.FlatAppearance.MouseDownBackColor = Color.DarkRed;
                BtnDeny.FlatAppearance.MouseOverBackColor = Color.FromArgb(139, 51, 51);
            }
        }


        public void Btn_Init()
        {
            BtnA_SetStyle(false);
            BtnB_SetStyle(false);
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            Accepted = 1;
            BtnA_SetStyle(true);
            BtnB_SetStyle(false);
        }

        private void BtnDeny_Click(object sender, EventArgs e)
        {
            Accepted = 2;
            BtnA_SetStyle(false);
            BtnB_SetStyle(true);
        }

    }
}
