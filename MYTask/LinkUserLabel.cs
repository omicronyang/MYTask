using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MYTask
{
    class LinkUserLabel:LinkLabel
    {
        public MyUser user = new MyUser();
        private FormMain formmain = (FormMain)Form.ActiveForm;

        public LinkUserLabel()
        {
            LinkBehavior = LinkBehavior.HoverUnderline;
            LinkColor = Color.Black;
            VisitedLinkColor = Color.Black;
            ActiveLinkColor = Color.RoyalBlue;
            user.UID = 5;
        }

        public void Init(MyUser U)
        {
            user = U;
            Text = user.Name;
        }


        protected override void OnClick(EventArgs e)
        {
            formmain.SetProfilePanel(user.UID);
            formmain.InitPanelProfile();
            base.OnClick(e);
            //MessageBox.Show(a.ToString());
        }
        
    }
}
