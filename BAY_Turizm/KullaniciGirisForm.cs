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
    public partial class KullaniciGirisForm : Form
    {
        public KullaniciGirisForm()
        {
            InitializeComponent();
        }

        private void KullaniciGirisForm_Load(object sender, EventArgs e)
        {

        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 anaMenu = new Form1();
            anaMenu.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void KullaniciGAdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKullaniciAdiGiris_Click(object sender, EventArgs e)
        {

        }

        private void sifreGosterCheckKullanici_CheckedChanged(object sender, EventArgs e)
        {
            if (sifreGosterCheckKullanici.Checked) //Checkbox işaretliyse şifreyi normal göster,değilse char'ları "*" olarak göster.
            {
                KullaniciGirisSifreTb.UseSystemPasswordChar = false;
            }
            else
            {
                KullaniciGirisSifreTb.UseSystemPasswordChar = true;
            }
        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            //iki yer de dolu mu kontrolü.boş olan varsa doldur messagebox uyarısı.sonra kullanıcı adı şifre doğru mu doğruysa kullanıcı menüsüne yönlendir.message çıkarmana gerek yok direkt yönlendir.
            //kodu burda.
            this.Hide();
            KullaniciMenuForm kullaniciMenu= new KullaniciMenuForm();
            kullaniciMenu.ShowDialog();
            this.Close();
        }
    }
}
