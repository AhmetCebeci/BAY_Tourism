namespace BAY_Turizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AdminGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminGirisForm adminGiris = new AdminGirisForm();
            adminGiris.ShowDialog();
            this.Close();
        }

        private void KullaniciGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            KullaniciGirisForm kullaniciGiris = new KullaniciGirisForm();
            kullaniciGiris.ShowDialog();
            this.Close();
        }
        private void KayitOl_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayitOl kayitOl = new KayitOl();
            kayitOl.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
