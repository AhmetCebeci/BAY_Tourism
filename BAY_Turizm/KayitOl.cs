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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {

        }
        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 anaMenu = new Form1();
            anaMenu.ShowDialog();
            this.Close();
        }

        private void sifreGosterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (sifreGosterCheck.Checked) //Checkbox işaretliyse şifreyi normal göster,değilse char'ları "*" olarak göster.
            {
                SifreTb.UseSystemPasswordChar = false;
                SifreTekrarTb.UseSystemPasswordChar = false;
            }
            else
            {
                SifreTb.UseSystemPasswordChar = true;
                SifreTekrarTb.UseSystemPasswordChar = true;
            }
        }







        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            // ad soyad vs hepsinin textbox'ı veritabanına uyacak şekilde kontrol edilecek.eğer bilgilerden biri örn:ad boş ise bütün alanlar dolmak zorundadır diye messagebox çıkacak.
            //girilen 2 şifre aynı mı diye kontrol edilecek
            //kontroller yapıldıktan sonra eğer öyle bir kullanıcı zaten varsa(tıpatıp aynı bilgiler mi diye kontrol edilecek) bu kullanıcı zaten var uyarısı çıkacak.
            //öyle bir kullanıcı yoksa veritabanında oluşturulacak,oluşturuldu bildirimi verilecek ve birkaç saniye örn:3-4 sonra kullanıcı menüsüne yönlendirilecek.yönlendiriliyorsunuz vs diye mesaj da çıkabilir.
            //şifreyi göster kodunu yazdım yukarıda var sadece bu kısım var kayıtol formunda.
            //kullanıcı menüsüne gitme kodu
            this.Hide();
            KullaniciMenuForm kullaniciMenu = new KullaniciMenuForm();
            kullaniciMenu.ShowDialog();
            this.Close();
        }
        private void lblSoyad_Click(object sender, EventArgs e)
        {

        }

        private void lblTelNo_Click(object sender, EventArgs e)
        {

        }

        private void lblTelUyari_Click(object sender, EventArgs e)
        {

        }

        private void SifreTekrarTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void TcMTb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
