using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name1_TextChanged(object sender, EventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            Form5.setPlayerNames(name1.Text, "Computer");
            this.Hide();
            f5.ShowDialog();
            this.Close();
        }
    }
}
