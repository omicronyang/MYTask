using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MYTask
{
    class LinkUserLabel : LinkLabel
    {
        public MyUser user = new MyUser();
        private FormMain mainfrm;

        public LinkUserLabel()
        {
            LinkBehavior = LinkBehavior.HoverUnderline;
            LinkColor = Color.Black;
            VisitedLinkColor = Color.Black;
            ActiveLinkColor = Color.RoyalBlue;
            user.UID = 5;
        }

        public void SetUser(MyUser U)
        {
            user = U;
            Text = user.Name;
        }

        public void SetMainForm(FormMain frm)
        {
            mainfrm = frm;
        }

        protected override void OnClick(EventArgs e)
        {
            mainfrm.SetProfilePanel(user.UID);
            mainfrm.PanelUser_Show();
            base.OnClick(e);
        }
    }

    class LinkTaskLabel : LinkLabel
    {
    }
}
