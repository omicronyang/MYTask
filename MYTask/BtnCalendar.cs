using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MYTask
{
    class BtnCalendar:Button
    {
        private CalendarClr Theme = new CalendarClr();
        private MyTaskByDay TBInfo;

        public void UpdateBtn(MyTaskByDay TB)
        {
            TBInfo = TB;
            UpdateBtnTheme(TBInfo.TBStat);
        }

        private void UpdateBtnTheme(int ClrIndex)
        {
            Theme.UpdateColor(ClrIndex);
            this.BackColor = Theme.MainColor;
            this.FlatAppearance.MouseOverBackColor = Theme.MOC;
            this.FlatAppearance.MouseDownBackColor = Theme.MDC;
        }
    }
}
