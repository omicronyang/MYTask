using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MYTask
{
    public class UIColor
    {
        public Color MainColor;
        public Color MOC;
        public Color MDC;
        public int ColorType;

        public UIColor()
        {
            MainColor = Color.RoyalBlue;
            MOC = Color.CornflowerBlue;
            MDC = Color.MidnightBlue;
            ColorType = 1;
        }

        /// <summary>
        /// 设置颜色
        /// </summary>
        /// <param name="ColorType"></param>
        public void UpdateColor(int NewColorType)
        {
            ColorType = NewColorType;
            switch (ColorType)
            {
                case 1: { MainColor = Color.RoyalBlue; break; }
                case 2: { MainColor = Color.SeaGreen; break; }
                case 3: { MainColor = Color.DarkMagenta; break; }
                case 4: { MainColor = Color.Crimson; break; }
                case 5: { MainColor = Color.OrangeRed; break; }
                case 6: { MainColor = Color.DimGray; break; }
            }
            int R = MainColor.R;
            int G = MainColor.G;
            int B = MainColor.B;
            int oR = (R <= 204) ? R + 51 : R;
            int oG = (G <= 204) ? G + 51 : G;
            int oB = (B <= 204) ? B + 51 : B;
            int dR = (R >= 51) ? R - 51 : R;
            int dG = (G >= 51) ? G - 51 : G;
            int dB = (B >= 51) ? B - 51 : B;
            MOC = Color.FromArgb(oR, oG, oB);
            MDC = Color.FromArgb(dR, dG, dB);
        }

        public void UpdateColor(Color NewMainColor)
        {
            if (NewMainColor == Color.RoyalBlue) UpdateColor(1);
            else if (NewMainColor == Color.SeaGreen) UpdateColor(2);
            else if (NewMainColor == Color.DarkMagenta) UpdateColor(3);
            else if (NewMainColor == Color.Crimson) UpdateColor(4);
            else if (NewMainColor == Color.OrangeRed) UpdateColor(5);
            else if (NewMainColor == Color.DimGray) UpdateColor(6);
        }

    }

    public class CalendarClr
    {
        public Color MainColor;
        public Color MOC;
        public Color MDC;
        public int ColorType;

        public void UpdateColor(int NewClrType)
        {
            ColorType = NewClrType;
            switch (ColorType)
            {
                case 0: { MainColor = Color.DimGray; break; }
                case 4: { MainColor = Color.FromArgb(153, 102, 153); break; } //策划中
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: { MainColor = Color.FromArgb(153, 255, 0); break; }   //进行
                case 14: { MainColor = Color.FromArgb(0, 153, 0); break; }    //完成
                case 22: { MainColor = Color.Red; break; }                    //中断
                case 23: { MainColor = Color.FromArgb(255, 204, 0); break; }  //推迟
            }
            int R = MainColor.R;
            int G = MainColor.G;
            int B = MainColor.B;
            int oR = (R <= 204) ? R + 51 : R;
            int oG = (G <= 204) ? G + 51 : G;
            int oB = (B <= 204) ? B + 51 : B;
            int dR = (R >= 51) ? R - 51 : R;
            int dG = (G >= 51) ? G - 51 : G;
            int dB = (B >= 51) ? B - 51 : B;
            MOC = Color.FromArgb(oR, oG, oB);
            MDC = Color.FromArgb(dR, dG, dB);
        }

    }

}
