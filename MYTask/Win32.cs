using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MYTask
{
    class Win32
    {
        //常数
        public const int WM_SYSCOMMAND = 0x0112;
        //窗体移动
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        //窗体最小化
        public const int SC_MINIMIZE = 0xF020;
        public const int WS_MINIMIZEBOX = 0x00020000;
        //动画参数
        public const int AW_HIDE = 0x00010000;   //隐藏
        public const int AW_BLEND = 0x00080000;  //淡入淡出
        public const int WS_SYSMENU = 0x00080000;


        public const int GWL_EXSTYLE = -20;
        public const int WS_EX_TRANSPARENT = 0x00000020;
        public const int WS_EX_LAYERED = 0x00080000;

        public const byte AC_SRC_OVER = 0;
        public const Int32 ULW_ALPHA = 2;
        public const byte AC_SRC_ALPHA = 1;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);

        [DllImport("user32")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("gdi32.dll")]
        public static extern int CreateRoundRectRgn(int x1, int y1, int x2, int y2, int x3, int y3);

        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr hwnd, int hRgn, Boolean bRedraw);

        [DllImport("user32", EntryPoint = "GetWindowLong")]
        public static extern int GetWindowLong(
            IntPtr hwnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(
            IntPtr hwnd, int nIndex, int dwNewLong);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll", ExactSpelling = true)]
        public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObj);

        [DllImport("user32.dll", ExactSpelling = true)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern int DeleteDC(IntPtr hDC);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern int DeleteObject(IntPtr hObj);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern int UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pptSrc, Int32 crKey, ref BLENDFUNCTION pblend, Int32 dwFlags);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr ExtCreateRegion(IntPtr lpXform, uint nCount, IntPtr rgnData);

        [StructLayout(LayoutKind.Sequential)]
        public struct Size
        {
            public Int32 cx;
            public Int32 cy;

            public Size(Int32 x, Int32 y)
            {
                cx = x;
                cy = y;
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BLENDFUNCTION
        {
            public byte BlendOp;
            public byte BlendFlags;
            public byte SourceConstantAlpha;
            public byte AlphaFormat;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Point
        {
            public Int32 x;
            public Int32 y;

            public Point(Int32 x, Int32 y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }

    class Animate
    {
        #region 常量申明
        /// <summary>
        /// 自左向右显示控件.当使用AW_CENTER标志时,该标志将被忽略.
        /// </summary>
        public const Int32 AW_HOR_POSITIVE = 0x00000001;

        /// <summary>
        /// 自右向左显示控件.当使用AW_CENTER标志时,该标志将被忽略.
        /// </summary>
        public const Int32 AW_HOR_NEGATIVE = 0x00000002;

        /// <summary>
        /// 自顶向下显示控件.该标志可以在滚动动画和滑动动画中使用.当使用AW_CENTER标志时,该标志将被忽略.
        /// </summary>
        public const Int32 AW_VER_POSITIVE = 0x00000004;

        /// <summary>
        /// 自下向上显示控件.该标志可以在滚动动画和滑动动画中使用.当使用AW_CENTER标志时,该标志将被忽略.
        /// </summary>
        public const Int32 AW_VER_NEGATIVE = 0x00000008;

        /// <summary>
        /// 若使用AW_HIDE标志,则使控件向内重叠;若未使用AW_HIDE标志,则使控件向外扩展.
        /// </summary>
        public const Int32 AW_CENTER = 0x00000010;

        /// <summary>
        /// 隐藏控件.默认则显示控件.
        /// </summary>
        public const Int32 AW_HIDE = 0x00010000;

        /// <summary>
        /// 激活控件.在使用AW_HIDE标志后不要使用这个标志.
        /// </summary>
        public const Int32 AW_ACTIVATE = 0x00020000;

        /// <summary>
        /// 使用滑动类型.默认则为滚动动画类型.当使用AW_CENTER标志时,这个标志就被忽略.
        /// </summary>
        public const Int32 AW_SLIDE = 0x00040000;

        /// <summary>
        /// 使用淡入效果.只有当hWnd为顶层控件时才可以使用此标志.
        /// </summary>
        public const Int32 AW_BLEND = 0x00080000;
        #endregion

        [DllImportAttribute("user32.dll")]
        public static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);
    }

}
