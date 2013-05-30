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
        private string username;
        private string password;
        public MainGameForm(String user, String MD5pass)
        {
            username = user;
            password = MD5pass;
            InitializeComponent();
        }

        private void MainGameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
