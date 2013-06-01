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
    public partial class ExitGameConfirmation : Form
    {
        public bool AllowFormToClose = false;
        public ExitGameConfirmation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllowFormToClose = true;
            Close();
        }
    }
}
