﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAY_Turizm
{
    public partial class TerminalislemForm : Form
    {
        public TerminalislemForm()
        {
            InitializeComponent();
        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 anaMenu = new Form1();
            anaMenu.ShowDialog();
            this.Close();
        }

        private void adminMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm adminMenu = new AdminMenuForm();
            adminMenu.ShowDialog();
            this.Close();
        }

        private void btnTerminalEkle_Click(object sender, EventArgs e)
        {
            //boş mu diye kontrol,sonra terminali ekleme
        }

    }
}
