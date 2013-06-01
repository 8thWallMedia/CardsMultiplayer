using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardsMultiplayer
{
    public partial class MainGameForm : Form
    {
        ExitGameConfirmation EGC = new ExitGameConfirmation();
        Timer t = new Timer();
        private string username;
        private string password;
        public static bool allowClose = false;
        Game LoginScreen;
        public MainGameForm(String user, String MD5pass, Game LoginWindow)
        {
            EGC.FormClosed += new FormClosedEventHandler(ConfirmationClosed);
            EGC.TopMost = true;
            username = user;
            password = MD5pass;
            LoginScreen = LoginWindow;
            InitializeComponent();
        }

        private void MainGameForm_Load(object sender, EventArgs e)
        {
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            t.Stop();
            Close();
        }

        private void ConfirmationClosed(object sender, FormClosedEventArgs e)
        {
            if (EGC.AllowFormToClose)
            {
                t.Tick += new EventHandler(CloseTimer_Tick);
                t.Interval = 500;
                t.Start();
            }
        }

        private void MainGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!EGC.AllowFormToClose)
            {
                e.Cancel = true;
                EGC.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            allowClose = true;
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
