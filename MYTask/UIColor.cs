using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MYTask
{
    class UIColor
    {
        public Color MainColor;
        public Color MouseOverColor;
        public Color MouseDownColor;

        public UIColor()
        {
            MainColor = Color.RoyalBlue;
            MouseOverColor = Color.CornflowerBlue;
            MouseDownColor = Color.MidnightBlue;
        }

        /// <summary>
        /// 设置颜色
        /// </summary>
        /// <param name="ColorType"></param>
        public void UpdateColor(int ColorType)
        {
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
            }
        }
    }
}
