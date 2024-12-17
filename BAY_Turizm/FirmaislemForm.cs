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
    public partial class FirmaislemForm : Form
    {
        public FirmaislemForm()
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

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            //kontrol yap firma ekle
        }

        private void btnFirmaSil_Click(object sender, EventArgs e)
        {
            //seçili yoksa uyar varsa cb de seçili olan firmayı sil
        }       
    }
}