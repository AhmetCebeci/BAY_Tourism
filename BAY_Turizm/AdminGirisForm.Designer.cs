namespace BAY_Turizm
{
    partial class AdminGirisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGirisForm));
            AdminGirisMenu = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            AdminKullaniciAdTb = new TextBox();
            AdminSifreTb = new TextBox();
            lblAdminSifre = new Label();
            lblAdminKullaniciAd = new Label();
            sifreGosterCheckAdmin = new CheckBox();
            btnAdminGiris = new Button();
            lblSeferSil = new Label();
            AdminGirisMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AdminGirisMenu
            // 
            AdminGirisMenu.BackColor = Color.FromArgb(109, 33, 79);
            AdminGirisMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminGirisMenu.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem });
            AdminGirisMenu.Location = new Point(0, 0);
            AdminGirisMenu.Name = "AdminGirisMenu";
            AdminGirisMenu.Size = new Size(884, 29);
            AdminGirisMenu.TabIndex = 0;
            AdminGirisMenu.Text = "menuStrip1";
            // 
            // anaMenüToolStripMenuItem
            // 
            anaMenüToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            anaMenüToolStripMenuItem.ForeColor = Color.FromArgb(247, 241, 227);
            anaMenüToolStripMenuItem.Name = "anaMenüToolStripMenuItem";
            anaMenüToolStripMenuItem.Size = new Size(100, 25);
            anaMenüToolStripMenuItem.Text = "Ana Menü";
            anaMenüToolStripMenuItem.Click += anaMenüToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(433, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 467);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // AdminKullaniciAdTb
            // 
            AdminKullaniciAdTb.Font = new Font("Segoe UI", 22F);
            AdminKullaniciAdTb.ForeColor = Color.FromArgb(30, 39, 46);
            AdminKullaniciAdTb.Location = new Point(194, 147);
            AdminKullaniciAdTb.Name = "AdminKullaniciAdTb";
            AdminKullaniciAdTb.Size = new Size(233, 47);
            AdminKullaniciAdTb.TabIndex = 3;
            // 
            // AdminSifreTb
            // 
            AdminSifreTb.Font = new Font("Segoe UI", 22F);
            AdminSifreTb.ForeColor = Color.FromArgb(30, 39, 46);
            AdminSifreTb.Location = new Point(92, 233);
            AdminSifreTb.Name = "AdminSifreTb";
            AdminSifreTb.Size = new Size(335, 47);
            AdminSifreTb.TabIndex = 4;
            AdminSifreTb.UseSystemPasswordChar = true;
            // 
            // lblAdminSifre
            // 
            lblAdminSifre.AutoSize = true;
            lblAdminSifre.Font = new Font("Segoe UI", 22F);
            lblAdminSifre.ForeColor = Color.FromArgb(33, 140, 116);
            lblAdminSifre.Location = new Point(3, 239);
            lblAdminSifre.Name = "lblAdminSifre";
            lblAdminSifre.Size = new Size(83, 41);
            lblAdminSifre.TabIndex = 5;
            lblAdminSifre.Text = "Şifre:";
            // 
            // lblAdminKullaniciAd
            // 
            lblAdminKullaniciAd.AutoSize = true;
            lblAdminKullaniciAd.Font = new Font("Segoe UI", 22F);
            lblAdminKullaniciAd.ForeColor = Color.FromArgb(33, 140, 116);
            lblAdminKullaniciAd.Location = new Point(3, 147);
            lblAdminKullaniciAd.Name = "lblAdminKullaniciAd";
            lblAdminKullaniciAd.Size = new Size(185, 41);
            lblAdminKullaniciAd.TabIndex = 6;
            lblAdminKullaniciAd.Text = "Kullanıcı Adı:";
            // 
            // sifreGosterCheckAdmin
            // 
            sifreGosterCheckAdmin.AutoSize = true;
            sifreGosterCheckAdmin.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            sifreGosterCheckAdmin.ForeColor = Color.FromArgb(179, 57, 57);
            sifreGosterCheckAdmin.Location = new Point(278, 300);
            sifreGosterCheckAdmin.Name = "sifreGosterCheckAdmin";
            sifreGosterCheckAdmin.Size = new Size(149, 27);
            sifreGosterCheckAdmin.TabIndex = 19;
            sifreGosterCheckAdmin.Text = "Şifreyi Göster";
            sifreGosterCheckAdmin.UseVisualStyleBackColor = true;
            sifreGosterCheckAdmin.CheckedChanged += sifreGosterCheckAdmin_CheckedChanged;
            // 
            // btnAdminGiris
            // 
            btnAdminGiris.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdminGiris.ForeColor = Color.FromArgb(179, 57, 57);
            btnAdminGiris.Location = new Point(23, 390);
            btnAdminGiris.Name = "btnAdminGiris";
            btnAdminGiris.Size = new Size(367, 73);
            btnAdminGiris.TabIndex = 20;
            btnAdminGiris.Text = "Admin Girişi Yap";
            btnAdminGiris.UseVisualStyleBackColor = true;
            btnAdminGiris.Click += btnAdminGiris_Click;
            // 
            // lblSeferSil
            // 
            lblSeferSil.AutoSize = true;
            lblSeferSil.Font = new Font("Segoe UI", 25F);
            lblSeferSil.ForeColor = Color.FromArgb(44, 44, 84);
            lblSeferSil.Location = new Point(81, 67);
            lblSeferSil.Name = "lblSeferSil";
            lblSeferSil.Size = new Size(200, 46);
            lblSeferSil.TabIndex = 29;
            lblSeferSil.Text = "Admin Girişi";
            // 
            // AdminGirisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(lblSeferSil);
            Controls.Add(btnAdminGiris);
            Controls.Add(sifreGosterCheckAdmin);
            Controls.Add(lblAdminKullaniciAd);
            Controls.Add(lblAdminSifre);
            Controls.Add(AdminSifreTb);
            Controls.Add(AdminKullaniciAdTb);
            Controls.Add(pictureBox1);
            Controls.Add(AdminGirisMenu);
            MainMenuStrip = AdminGirisMenu;
            Name = "AdminGirisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Girişi";
            Load += AdminGirisForm_Load;
            AdminGirisMenu.ResumeLayout(false);
            AdminGirisMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip AdminGirisMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private PictureBox pictureBox1;
        private TextBox AdminKullaniciAdTb;
        private TextBox AdminSifreTb;
        private Label lblAdminSifre;
        private Label lblAdminKullaniciAd;
        private CheckBox sifreGosterCheckAdmin;
        private Button btnAdminGiris;
        private Label lblSeferSil;
    }
}