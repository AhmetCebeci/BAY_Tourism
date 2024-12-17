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
    public partial class AdminGirisForm : Form
    {
        public AdminGirisForm()
        {
            InitializeComponent();
        }

        private void AdminGirisForm_Load(object sender, EventArgs e)
        {

        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 anaMenu = new Form1();
            anaMenu.ShowDialog();
            this.Close();
        }

        private void sifreGosterCheckAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (sifreGosterCheckAdmin.Checked) //Checkbox işaretliyse şifreyi normal göster,değilse char'ları "*" olarak göster.
            {
                AdminSifreTb.UseSystemPasswordChar = false;
            }
            else
            {
                AdminSifreTb.UseSystemPasswordChar = true;
            }
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            //adminin kullanıcı adı veya şifresi girilmemişse boşsa tüm alanlar doldurulmalı diye uyarı vericek önce.sonra kullanıcı adı şifre kontrolü yapılacak.
            //doğruysa admin menüsüne yollanıcak mesaj çıkartmaya gerek yok.
            //admin menüsüne gitme kodu:
            this.Hide();
            AdminMenuForm adminMenu = new AdminMenuForm();
            adminMenu.ShowDialog();
            this.Close();
        }
    }
}
