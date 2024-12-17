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
    public partial class OtobusislemForm : Form
    {
        public OtobusislemForm()
        {
            InitializeComponent();
        }

        private void OtobusislemForm_Load(object sender, EventArgs e)
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

        private void btnOtobusSil_Click(object sender, EventArgs e)
        {
            //comboboxtan birşey seçilmediyse seçsin uyar.seçtiyse onu veritabanından sil,başarılı ise silme işlemi messagebox ile söyle
        }

        private void btnOtobusEkle_Click(object sender, EventArgs e)
        {
            //bütün alanlar doldu mu,dolduysa doğru dolduruldu mu kontrol et.sonra veritabanına ekle.
        }

        private void lblFirmaNo_Click(object sender, EventArgs e)
        {

        }        
    }
}
