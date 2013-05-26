/*  
 * Class: Form1.cs
 * Purpose: Launcher Application
 * Author: Cameron 
*/
using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Runtime.InteropServices;

namespace CardsMultiplayer
{
    public partial class Launcher : Form
    {
        String ResourcePath = String.Empty;
        SoundPlayer SPSelection = null;
        SoundPlayer SPExplosion = null;
        Boolean SPClicked = false;
        ClientCursors clientCursors = new ClientCursors();
        Game G = new Game();
        public Launcher()
        {
            InitializeComponent();
            InitializeResource();
            InitializeCursor();
        }

        private void InitializeCursor()
        {
            Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            pictureBox2.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            richTextBox1.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
            panel1.Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
        }

        private void InitializeResource()
        {
            if (Directory.Exists(@"c:\Program Files (x86)\"))
                ResourcePath = Assembly.GetExecutingAssembly().Location + @"\resources\";
            else
                ResourcePath = @"c:\Program Files\MagicOnline\resources\";
            SPSelection = new SoundPlayer(ResourcePath + @"\wav\mns1.wav");
            SPExplosion = new SoundPlayer(ResourcePath + @"\wav\exp1.wav");
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.PlayButtonSelected;
            SPSelection.Play();
            Cursor = clientCursors.getCursor(clientCursors.Cursor_Launcher_Normal);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, Color.Blue);
            panel2.BackColor = Color.FromArgb(25, Color.Black);
            this.BackColor = Color.FromArgb(25, Color.Black);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (!SPClicked)
                pictureBox2.Image = Properties.Resources.PlayButton;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SPExplosion.Play();
            SPClicked = true;
            Hide();
            System.Threading.Thread.Sleep(1000);
            G.Show();
            G.TopMost = true;
        }
    }
}
