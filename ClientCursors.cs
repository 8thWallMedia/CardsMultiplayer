using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace CardsMultiplayer
{
    class ClientCursors
    {
        public struct IconInfo
        {
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);

        [DllImport("user32.dll")]
        public static extern IntPtr CreateIconIndirect(ref IconInfo icon);

        public int Cursor_Launcher_Normal = 1;


        public Cursor getCursor(int CursorValue)
        {
            if (CursorValue == Cursor_Launcher_Normal)
                return CreateCursor(Properties.Resources.Sword_icon, 0, 0);
            return null;
        }

        public Cursor CreateCursor(Bitmap bmp, int xHotSpot, int yHotSpot)
        {
            IntPtr ptr = bmp.GetHicon();
            IconInfo tmp = new IconInfo();
            GetIconInfo(ptr, ref tmp);
            tmp.xHotspot = xHotSpot;
            tmp.yHotspot = yHotSpot;
            tmp.fIcon = false;
            ptr = CreateIconIndirect(ref tmp);
            return new Cursor(ptr);
        }
    }
}
