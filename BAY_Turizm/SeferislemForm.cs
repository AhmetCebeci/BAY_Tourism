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
    public partial class SeferislemForm : Form
    {
        public SeferislemForm()
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

        private void btnSeferEkle_Click(object sender, EventArgs e)
        {
            //kontroller yapıldıktan sonra sefer eklenecek
        }

        private void btnSeferSil_Click(object sender, EventArgs e)
        {
            //kontroller yapıldıktan sonra sefer silinecek
        }

        private void SeferislemForm_Load(object sender, EventArgs e)
        {

        }
        
    }
}
