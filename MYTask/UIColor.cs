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
        public Color MouseOverColor;
        public Color MouseDownColor;
        public int ColorType;

        public UIColor()
        {
            MainColor = Color.RoyalBlue;
            MouseOverColor = Color.CornflowerBlue;
            MouseDownColor = Color.MidnightBlue;
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
                case 1:
                    {
                        MainColor = Color.RoyalBlue;
                        MouseOverColor = Color.CornflowerBlue;
                        MouseDownColor = Color.MidnightBlue;
                        break;
                    }
                case 2:
                    {
                        MainColor = Color.SeaGreen;
                        MouseOverColor = Color.MediumSeaGreen;
                        MouseDownColor = Color.DarkGreen;
                        break;
                    }
                case 3:
                    {
                        MainColor = Color.DarkMagenta;
                        MouseOverColor = Color.MediumOrchid;
                        MouseDownColor = Color.Purple;
                        break;
                    }
                case 4:
                    {
                        MainColor = Color.Crimson;
                        MouseOverColor = Color.LightCoral;
                        MouseDownColor = Color.Brown;
                        break;
                    }
                case 5:
                    {
                        MainColor = Color.OrangeRed;
                        MouseOverColor = Color.Coral;
                        MouseDownColor = Color.Brown;
                        break;
                    }
                case 6:
                    {
                        MainColor = Color.DimGray;
                        MouseOverColor = Color.Gray;
                        MouseDownColor = Color.Black;
                        break;
                    }
            }
        }

        public void UpdateColor(Color NewMainColor)
        {
            if (NewMainColor == Color.RoyalBlue) UpdateColor(1);
            else if (NewMainColor == Color.SeaGreen) UpdateColor(2);
            else if (NewMainColor == Color.DarkMagenta) UpdateColor(3);
            else if (NewMainColor == Color.Crimson) UpdateColor(4);
            else if (NewMainColor == Color.OrangeRed) UpdateColor(5);
        }

    }
}
