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
    public partial class KullaniciMenuForm : Form
    {
        public KullaniciMenuForm()
        {
            InitializeComponent();
        }

        private void KullaniciMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 anaMenu = new Form1();
            anaMenu.ShowDialog();
            this.Close();
        }

        private void btnSeferAra_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeferAraForm seferAraMenu = new SeferAraForm();
            seferAraMenu.ShowDialog();
            this.Close();
        }

        private void btnYolcularim_Click(object sender, EventArgs e)
        {
            this.Hide();
            YolcularimForm yolcularim=new YolcularimForm();
            yolcularim.ShowDialog();
            this.Close();
        }
    }
}
