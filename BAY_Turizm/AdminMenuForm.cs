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
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 anaMenu = new Form1();
            anaMenu.ShowDialog();
            this.Close();
        }

        private void btnSeferislem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeferislemForm seferislem = new SeferislemForm();
            seferislem.ShowDialog();
            this.Close();
        }

        private void btnFirmaislem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirmaislemForm firmaislem = new FirmaislemForm();
            firmaislem.ShowDialog();
            this.Close();
        }

        private void btnOtobusislem_Click(object sender, EventArgs e)
        {
            this.Hide();
            OtobusislemForm otobusislem = new OtobusislemForm();
            otobusislem.ShowDialog();
            this.Close();
        }

        private void btnTerminalislem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TerminalislemForm terminalislem = new TerminalislemForm();
            terminalislem.ShowDialog();
            this.Close();
        }

        private void btnYorumislem_Click(object sender, EventArgs e)
        {
            this.Hide();
            YorumislemForm yorumislem = new YorumislemForm();
            yorumislem.ShowDialog();
            this.Close();
        }

        private void btnFaturaislem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FaturaislemForm faturaislem = new FaturaislemForm();
            faturaislem.ShowDialog();
            this.Close();
        }

        private void btnKampanyaIslem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KampaynaislemForm kampanyaislem = new KampaynaislemForm();
            kampanyaislem.ShowDialog();
            this.Close();
        }

        private void btnAdminHesapIslem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHesapislemForm adminhesapislem= new AdminHesapislemForm();
            adminhesapislem.ShowDialog();
            this.Close();
        }
    }
}
