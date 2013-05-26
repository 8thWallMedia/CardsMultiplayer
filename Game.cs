/*  
 * Class: Game.cs
 * Purpose: The main Game class. Handle the creation of seperate sub windows to control game environment.
 * Author: Cameron 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CardsMultiplayer
{
    public partial class Game : Form
    {
        ClientCursors clientCursors = new ClientCursors();
        WindowsScreenInteract WinAPI = new WindowsScreenInteract();
        public string PasswordInputText = "";
        public Game()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x128) return;
            base.WndProc(ref m);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            panel1.Hide();
            WinAPI.Maximize(this);
            Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            textBox1.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            textBox2.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            pictureBox1.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            pictureBox2.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            pictureBox3.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            panel1.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            errorPanel.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            errorPanel.BackColor = Color.FromArgb(0, Color.Red);
            authenticationPanel.BackColor = Color.FromArgb(100, Color.Blue);

            Disclaimer D = new Disclaimer();
            D.TopMost = true;
            D.StartPosition = FormStartPosition.CenterScreen;
            D.FormClosing += new FormClosingEventHandler(Stage2);
            D.ShowDialog();
        }

        private void Stage2(object sender, FormClosingEventArgs e)
        {
            Cursor.Show();

            panel1.BackgroundImage = Properties.Resources.Space_space_584336_1600_1200_1_;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Show();
            //authenticationPanel.BackColor = Color.FromArgb(25, Color.Black);
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string password = Security.md5(textBox2.Text);
            developerOutput.AppendText("[INFO]Encrypt -> " + password + Environment.NewLine);
            ShowError(101);
        }

        private void ShowError(int errornumber)
        {
            label3.Text = ErrorHandler.GetErrorMessage(errornumber);
            developerOutput.AppendText("[ERROR PROMPT]Error " + errornumber + " Displayed." + Environment.NewLine);
            ErrorMessageInfo EMI = new ErrorMessageInfo(errornumber);
            ThreadPool.QueueUserWorkItem(showErrorThreadAccess, EMI);
        }

        private void showErrorThreadAccess(object state)
        {
            pictureBox1.Invoke(new MethodInvoker(() => pictureBox1.Enabled = false));
            try
            {
                ErrorMessageInfo EMI = (ErrorMessageInfo)state;
                errorPanel.Invoke(new MethodInvoker(() => errorPanel.BackColor = Color.FromArgb(0, Color.Red)));
                label3.Invoke(new MethodInvoker(() => label3.Hide()));
                do
                {
                    errorPanel.Invoke(new MethodInvoker(() => errorPanel.BackColor = Color.FromArgb((errorPanel.BackColor.A) + 15, Color.Red)));
                    Thread.Sleep(10);
                } while (errorPanel.BackColor.A < 255);
                label3.Invoke(new MethodInvoker(() => label3.Show()));
                Thread.Sleep(3000);
                label3.Invoke(new MethodInvoker(() => label3.Hide()));
                do
                {
                    errorPanel.Invoke(new MethodInvoker(() => errorPanel.BackColor = Color.FromArgb((errorPanel.BackColor.A) - 15, Color.Red)));
                    Thread.Sleep(10);
                } while (errorPanel.BackColor.A > 0);
                pictureBox1.Invoke(new MethodInvoker(() => pictureBox1.Enabled = true));
            }
            catch (ArgumentException)
            {
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.PlayButton;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.PlayButtonSelected;
        }
    }
    public class WindowsScreenInteract
    {
        [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
        public static extern int GetSystemMetrics(int which);
        [DllImport("user32.dll")]
        public static extern void SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter, int X, int Y, int width, int height, uint flags);
        private const int SM_CXSCREEN = 0;
        private const int SM_CYSCREEN = 1;
        private static IntPtr HWND_TOP = IntPtr.Zero;
        private const int SWP_SHOWWINDOW = 64;
        public static int ScreenX
        {
            get { return GetSystemMetrics(SM_CXSCREEN); }
        }
        public static int ScreenY
        {
            get { return GetSystemMetrics(SM_CYSCREEN); }
        }
        public static void SetWinFullScreen(IntPtr hwnd)
        {
            SetWindowPos(hwnd, HWND_TOP, 0, 0, ScreenX, ScreenY, SWP_SHOWWINDOW);
        }
        private FormWindowState winState;
        private FormBorderStyle brdStyle;
        private bool topMost;
        private Rectangle bounds;
        private bool IsMaximized = false;
        public void Maximize(Form targetForm)
        {
            if (!IsMaximized)
            {
                IsMaximized = true;
                Save(targetForm);
                targetForm.WindowState = FormWindowState.Maximized;
                targetForm.FormBorderStyle = FormBorderStyle.None;
                targetForm.TopMost = true;
                SetWinFullScreen(targetForm.Handle);
            }
        }
        public void Save(Form targetForm)
        {
            winState = targetForm.WindowState;
            brdStyle = targetForm.FormBorderStyle;
            topMost = targetForm.TopMost;
            bounds = targetForm.Bounds;
        }
        public void Restore(Form targetForm)
        {
            targetForm.WindowState = winState;
            targetForm.FormBorderStyle = brdStyle;
            targetForm.TopMost = topMost;
            targetForm.Bounds = bounds;
            IsMaximized = false;
        }
    }

    public class ErrorMessageInfo
    {
        public int ErrorNum;
        public ErrorMessageInfo(int error)
        {
            ErrorNum = error;
        }
    }
}
