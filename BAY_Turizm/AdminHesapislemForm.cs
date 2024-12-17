using System;
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
    public partial class AdminHesapislemForm : Form
    {
        public AdminHesapislemForm()
        {
            InitializeComponent();
        }

        private void AdminHesapislemForm_Load(object sender, EventArgs e)
        {

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

        private void sifreGosterSifreDegistirCheckAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (sifreGosterSifreDegistirCheckAdmin.Checked) //Checkbox işaretliyse şifreyi normal göster,değilse char'ları "*" olarak göster.
            {
                DegistirilecekSifreTb.UseSystemPasswordChar = false;
                AdminYeniSifre1Tb.UseSystemPasswordChar = false;
                AdminYeniSifre2Tb.UseSystemPasswordChar = false;
            }
            else
            {
                DegistirilecekSifreTb.UseSystemPasswordChar = true;
                AdminYeniSifre1Tb.UseSystemPasswordChar = true;
                AdminYeniSifre2Tb.UseSystemPasswordChar = true;
            }
        }
    }
}
