using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CheatOverlay.Types;

namespace CheatOverlay
{
    public partial class Overlay : Form
    {
        //public struct RECT
        //{
        //    public int left, top, right, bottom;
        //}

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)] //This function changes the size, position, and z-order of a child, pop-up, or top-level window.
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);


        public const string WINDOW_NAME = "EdgeOfSpace";
        IntPtr handle = FindWindow(null, WINDOW_NAME);

        // Trying to follow window:
        //static readonly IntPtr HWND_TOPMOST = new IntPtr(-1); //Places the window above all non-topmost windows
        //static readonly IntPtr HWND_TOP = new IntPtr(0); // Places the window at the top of the Z order.

        //const UInt32 SWP_NOSIZE = 0x0001; //Retains current size
        //const UInt32 SWP_NOMOVE = 0x0002; // Retains the current position
        //const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        // Size :
        RECT rect;

        // For plotting :
        Graphics g;
        Pen myPen = new Pen(Color.Red);

        public Overlay()
        {
            InitializeComponent();
        }

        private void Overlay_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;

            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);

            this.refresh_position();

            Timer timer = new Timer();
            timer.Interval = 50; // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void refresh_position()
        {
            GetWindowRect(handle, out rect);
            this.Size = new Size(rect.Right - rect.Left, rect.Bottom - rect.Top);
            this.Top = rect.Top;
            this.Left = rect.Left;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.refresh_position();
        }

        private void Overlay_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawRectangle(myPen, 100, 100, 200, 200);
        }
    }
}
