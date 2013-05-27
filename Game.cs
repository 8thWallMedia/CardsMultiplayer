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
        public bool ACTION_REGISTER = false;
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
            registerPanel.Width = 490;
            registerPanel.Height = 529;
            authenticationPanel.Width = 504;
            authenticationPanel.Height = 394;
            Cursor.Hide();
            panel1.Hide();
            registerPanel.Hide();
            WinAPI.Maximize(this);
            Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            textBox1.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            textBox2.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            pictureBox1.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Hand);
            pictureBox2.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            pictureBox3.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            pictureBox5.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Hand);
            pictureBox6.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            pictureBox7.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            pictureBox9.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            pictureBox8.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Hand);
            pictureBox11.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Hand);
            panel1.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            errorPanel.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            Register_USERNAME.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            REGISTER_Email.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            REGISTER_Password.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            REGISTER_Password2.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            REGISTER_MessagePanel.BackColor = Color.FromArgb(200, Color.Black);
            errorPanel.BackColor = Color.FromArgb(0, Color.Red);
            authenticationPanel.BackColor = Color.FromArgb(100, Color.Black);
            authenticationPanel.Location = new Point(this.ClientSize.Width / 2 - authenticationPanel.Size.Width / 2, this.ClientSize.Height / 2 - authenticationPanel.Size.Height / 2);
            authenticationPanel.Anchor = AnchorStyles.None;
            registerPanel.BackColor = Color.FromArgb(100, Color.Black);
            registerPanel.Location = new Point(this.ClientSize.Width / 2 - registerPanel.Size.Width / 2, this.ClientSize.Height / 2 - registerPanel.Size.Height / 2);
            registerPanel.Anchor = AnchorStyles.None; 

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
            authenticationPanel.Hide();
            registerPanel.Show();
        }

        private void ShowError(int errornumber)
        {
            label3.Invoke(new MethodInvoker(() => label3.Text = "[" + errornumber + "] " + ErrorHandler.GetErrorMessage(errornumber)));
            developerOutput.Invoke(new MethodInvoker(() => developerOutput.AppendText("[ERROR PROMPT]Error " + errornumber + " Displayed." + Environment.NewLine)));
            ErrorMessageInfo EMI = new ErrorMessageInfo(errornumber);
            showErrorThreadAccess(EMI);
        }

        private void showErrorThreadAccess(object state)
        {
            pictureBox1.Invoke(new MethodInvoker(() => pictureBox1.Enabled = false));
            pictureBox5.Invoke(new MethodInvoker(() => pictureBox5.Enabled = false));
            try
            {
                ErrorMessageInfo EMI = (ErrorMessageInfo)state;
                errorPanel.Invoke(new MethodInvoker(() => errorPanel.BackColor = Color.FromArgb(0, Color.Red)));
                label3.Invoke(new MethodInvoker(() => label3.Hide()));
                do
                {
                    errorPanel.Invoke(new MethodInvoker(() => errorPanel.BackColor = Color.FromArgb((errorPanel.BackColor.A) + 50, Color.Red)));
                    Thread.Sleep(10);
                } while (errorPanel.BackColor.A < 200);
                label3.Invoke(new MethodInvoker(() => label3.Show()));
                Thread.Sleep(3000);
                label3.Invoke(new MethodInvoker(() => label3.Hide()));
                do
                {
                    errorPanel.Invoke(new MethodInvoker(() => errorPanel.BackColor = Color.FromArgb((errorPanel.BackColor.A) - 50, Color.Red)));
                    Thread.Sleep(10);
                } while (errorPanel.BackColor.A > 0);
                pictureBox1.Invoke(new MethodInvoker(() => pictureBox1.Enabled = true));
                pictureBox5.Invoke(new MethodInvoker(() => pictureBox5.Enabled = true));
                textBox1.Invoke(new MethodInvoker(() => textBox1.Enabled = true));
                textBox2.Invoke(new MethodInvoker(() => textBox2.Enabled = true));
            }
            catch (ArgumentException)
            {
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.RegisterButton;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.RegisterButtonSelected;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.LoginButtonSelected;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.LoginButton;
        }

        private void DoLogin(object state)
        {

            textBox1.Invoke(new MethodInvoker(() => textBox1.Enabled = false));
            textBox2.Invoke(new MethodInvoker(() => textBox2.Enabled = false));
            ConnectionManager CM = new ConnectionManager("vbproject.redirectme.net");
            string password = "";
            string username = "";
            textBox2.Invoke(new MethodInvoker(() => password = Security.md5(textBox2.Text)));
            textBox1.Invoke(new MethodInvoker(() => username = textBox1.Text));
            int ResponseCode = 0;
            if (ACTION_REGISTER)
            {
                ResponseCode = Convert.ToInt32(CM.sendSignal("command=regauth;username=" + textBox1.Text + ";password=" + textBox2.Text, true));
                if (ResponseCode == 600)
                {
                    textBox2.Invoke(new MethodInvoker(() => textBox2.Text = ""));
                    label2.Invoke(new MethodInvoker(() => label2.Text = "Password"));
                    ACTION_REGISTER = false;
                }
                else
                {
                    ShowError(ResponseCode);
                }
            }
            else
            {
                ResponseCode = Convert.ToInt32(CM.sendSignal("command=auth;username=" + username + ";password=" + password, true));
                developerOutput.Invoke(new MethodInvoker(() => developerOutput.AppendText("[INFO]Encrypt -> " + password + Environment.NewLine)));
                if (ResponseCode == ErrorHandler.LOGIN_OK)
                {
                    MessageBox.Show("LOGIN OK");
                }
                else if (ResponseCode == ErrorHandler.NOERROR_REGISTRATION_VALIDATION)
                {
                    label2.Invoke(new MethodInvoker(() => label2.Text = "Registration Code (from validation email)"));
                    textBox2.Invoke(new MethodInvoker(() => textBox2.Text = ""));
                    textBox1.Invoke(new MethodInvoker(() => textBox1.Enabled = false));
                    ShowError(ResponseCode);
                    ACTION_REGISTER = true;
                }
                else
                    ShowError(ResponseCode);
            }
            authenticationPanel.Invoke(new MethodInvoker(() => authenticationPanel.Cursor = clientCursors.CreateCursor(Properties.Resources.CursorImage, 0, 0)));
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            authenticationPanel.Cursor = clientCursors.CreateCursor(Properties.Resources.Sword_icon_animated, 0, 0);
            ThreadPool.QueueUserWorkItem(DoLogin);            
        }

        private void authenticationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            registerPanel.Hide();
            authenticationPanel.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Register_USERNAME.Focus();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            REGISTER_Password.Focus();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            REGISTER_Password2.Focus();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            REGISTER_Email.Focus();
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.BackButtonSelected;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.BackButton;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            REGISTER_Label.Text = "Please wait, processing your request..";
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.RegisterButtonSelected;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.RegisterButton;
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
