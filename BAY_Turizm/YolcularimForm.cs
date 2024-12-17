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
    public partial class YolcularimForm : Form
    {
        public YolcularimForm()
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

        private void kullanıcıMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KullaniciMenuForm kullaniciMenu = new KullaniciMenuForm();
            kullaniciMenu.ShowDialog();
            this.Close();
        }
    }
}
