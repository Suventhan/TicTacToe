﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void play_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form1.setPlayerNames(name1.Text, name2.Text);
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void name1_TextChanged(object sender, EventArgs e)
        {

        }

        private void name2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
