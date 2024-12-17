namespace BAY_Turizm
{
    partial class KayitOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitOl));
            pictureBox1 = new PictureBox();
            lblAd = new Label();
            AdTb = new TextBox();
            SoyadTb = new TextBox();
            lblSoyad = new Label();
            lblTc = new Label();
            TcMTb = new MaskedTextBox();
            TelNoMTb = new MaskedTextBox();
            lblTelNo = new Label();
            lblMail = new Label();
            EmailTb = new TextBox();
            lblSifreTekrar = new Label();
            lblSifre = new Label();
            SifreTb = new TextBox();
            SifreTekrarTb = new TextBox();
            lblTelUyari = new Label();
            kayitOlMenu = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            btnKayitOl = new Button();
            sifreGosterCheck = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            kayitOlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(432, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 532);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAd.ForeColor = Color.FromArgb(33, 140, 116);
            lblAd.Location = new Point(15, 43);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(88, 35);
            lblAd.TabIndex = 1;
            lblAd.Text = "Adınız:";
            // 
            // AdTb
            // 
            AdTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdTb.ForeColor = Color.FromArgb(30, 39, 46);
            AdTb.Location = new Point(166, 45);
            AdTb.Name = "AdTb";
            AdTb.Size = new Size(251, 33);
            AdTb.TabIndex = 2;
            // 
            // SoyadTb
            // 
            SoyadTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SoyadTb.ForeColor = Color.FromArgb(30, 39, 46);
            SoyadTb.Location = new Point(166, 94);
            SoyadTb.Name = "SoyadTb";
            SoyadTb.Size = new Size(251, 33);
            SoyadTb.TabIndex = 3;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoyad.ForeColor = Color.FromArgb(33, 140, 116);
            lblSoyad.Location = new Point(14, 92);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(125, 35);
            lblSoyad.TabIndex = 4;
            lblSoyad.Text = "Soyadınız:";
            lblSoyad.Click += lblSoyad_Click;
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTc.ForeColor = Color.FromArgb(33, 140, 116);
            lblTc.Location = new Point(14, 152);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(95, 35);
            lblTc.TabIndex = 5;
            lblTc.Text = "TC  No:";
            // 
            // TcMTb
            // 
            TcMTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TcMTb.ForeColor = Color.FromArgb(30, 39, 46);
            TcMTb.Location = new Point(166, 152);
            TcMTb.Mask = "00000000000";
            TcMTb.Name = "TcMTb";
            TcMTb.Size = new Size(251, 33);
            TcMTb.TabIndex = 6;
            TcMTb.ValidatingType = typeof(int);
            TcMTb.MaskInputRejected += TcMTb_MaskInputRejected;
            // 
            // TelNoMTb
            // 
            TelNoMTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TelNoMTb.ForeColor = Color.FromArgb(30, 39, 46);
            TelNoMTb.Location = new Point(166, 203);
            TelNoMTb.Mask = "(999) 000-0000";
            TelNoMTb.Name = "TelNoMTb";
            TelNoMTb.Size = new Size(251, 33);
            TelNoMTb.TabIndex = 7;
            // 
            // lblTelNo
            // 
            lblTelNo.AutoSize = true;
            lblTelNo.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelNo.ForeColor = Color.FromArgb(33, 140, 116);
            lblTelNo.Location = new Point(14, 203);
            lblTelNo.Name = "lblTelNo";
            lblTelNo.Size = new Size(141, 35);
            lblTelNo.TabIndex = 8;
            lblTelNo.Text = "Telefon No:";
            lblTelNo.Click += lblTelNo_Click;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMail.ForeColor = Color.FromArgb(33, 140, 116);
            lblMail.Location = new Point(14, 288);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(90, 35);
            lblMail.TabIndex = 9;
            lblMail.Text = "E-Mail:";
            // 
            // EmailTb
            // 
            EmailTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTb.ForeColor = Color.FromArgb(30, 39, 46);
            EmailTb.Location = new Point(166, 294);
            EmailTb.Name = "EmailTb";
            EmailTb.Size = new Size(251, 29);
            EmailTb.TabIndex = 10;
            // 
            // lblSifreTekrar
            // 
            lblSifreTekrar.AutoSize = true;
            lblSifreTekrar.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSifreTekrar.ForeColor = Color.FromArgb(33, 140, 116);
            lblSifreTekrar.Location = new Point(14, 401);
            lblSifreTekrar.Name = "lblSifreTekrar";
            lblSifreTekrar.Size = new Size(140, 35);
            lblSifreTekrar.TabIndex = 11;
            lblSifreTekrar.Text = "Şifre tekrar:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSifre.ForeColor = Color.FromArgb(33, 140, 116);
            lblSifre.Location = new Point(15, 348);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(69, 35);
            lblSifre.TabIndex = 12;
            lblSifre.Text = "Şifre:";
            // 
            // SifreTb
            // 
            SifreTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SifreTb.ForeColor = Color.FromArgb(30, 39, 46);
            SifreTb.Location = new Point(166, 350);
            SifreTb.Name = "SifreTb";
            SifreTb.Size = new Size(251, 29);
            SifreTb.TabIndex = 13;
            SifreTb.UseSystemPasswordChar = true;
            // 
            // SifreTekrarTb
            // 
            SifreTekrarTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SifreTekrarTb.ForeColor = Color.FromArgb(30, 39, 46);
            SifreTekrarTb.Location = new Point(166, 403);
            SifreTekrarTb.Name = "SifreTekrarTb";
            SifreTekrarTb.Size = new Size(251, 29);
            SifreTekrarTb.TabIndex = 14;
            SifreTekrarTb.UseSystemPasswordChar = true;
            SifreTekrarTb.TextChanged += SifreTekrarTb_TextChanged;
            // 
            // lblTelUyari
            // 
            lblTelUyari.AutoSize = true;
            lblTelUyari.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelUyari.ForeColor = Color.FromArgb(179, 57, 57);
            lblTelUyari.Location = new Point(7, 238);
            lblTelUyari.Name = "lblTelUyari";
            lblTelUyari.Size = new Size(419, 19);
            lblTelUyari.TabIndex = 15;
            lblTelUyari.Text = "Numaranızın başında +90 olmadan yazınız Örn: (505) 225-2077";
            lblTelUyari.Click += lblTelUyari_Click;
            // 
            // kayitOlMenu
            // 
            kayitOlMenu.BackColor = Color.FromArgb(109, 33, 79);
            kayitOlMenu.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem });
            kayitOlMenu.Location = new Point(0, 0);
            kayitOlMenu.Name = "kayitOlMenu";
            kayitOlMenu.Size = new Size(884, 29);
            kayitOlMenu.TabIndex = 16;
            kayitOlMenu.Text = "menuStrip1";
            // 
            // anaMenüToolStripMenuItem
            // 
            anaMenüToolStripMenuItem.BackColor = Color.FromArgb(109, 33, 79);
            anaMenüToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            anaMenüToolStripMenuItem.ForeColor = Color.FromArgb(247, 241, 227);
            anaMenüToolStripMenuItem.Name = "anaMenüToolStripMenuItem";
            anaMenüToolStripMenuItem.Size = new Size(100, 25);
            anaMenüToolStripMenuItem.Text = "Ana Menü";
            anaMenüToolStripMenuItem.Click += anaMenüToolStripMenuItem_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKayitOl.ForeColor = Color.FromArgb(179, 57, 57);
            btnKayitOl.Location = new Point(43, 493);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(322, 56);
            btnKayitOl.TabIndex = 17;
            btnKayitOl.Text = "Kayıt Oluştur";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // sifreGosterCheck
            // 
            sifreGosterCheck.AutoSize = true;
            sifreGosterCheck.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sifreGosterCheck.ForeColor = Color.FromArgb(179, 57, 57);
            sifreGosterCheck.Location = new Point(295, 438);
            sifreGosterCheck.Name = "sifreGosterCheck";
            sifreGosterCheck.Size = new Size(122, 23);
            sifreGosterCheck.TabIndex = 18;
            sifreGosterCheck.Text = "Şifreyi Göster";
            sifreGosterCheck.UseVisualStyleBackColor = true;
            sifreGosterCheck.CheckedChanged += sifreGosterCheck_CheckedChanged;
            // 
            // KayitOl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(sifreGosterCheck);
            Controls.Add(btnKayitOl);
            Controls.Add(lblTelUyari);
            Controls.Add(SifreTekrarTb);
            Controls.Add(SifreTb);
            Controls.Add(lblSifre);
            Controls.Add(lblSifreTekrar);
            Controls.Add(EmailTb);
            Controls.Add(lblMail);
            Controls.Add(lblTelNo);
            Controls.Add(TelNoMTb);
            Controls.Add(TcMTb);
            Controls.Add(lblTc);
            Controls.Add(lblSoyad);
            Controls.Add(SoyadTb);
            Controls.Add(AdTb);
            Controls.Add(lblAd);
            Controls.Add(pictureBox1);
            Controls.Add(kayitOlMenu);
            MainMenuStrip = kayitOlMenu;
            Name = "KayitOl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt Oluşturma";
            Load += KayitOl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            kayitOlMenu.ResumeLayout(false);
            kayitOlMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblAd;
        private TextBox AdTb;
        private TextBox SoyadTb;
        private Label lblSoyad;
        private Label lblTc;
        private MaskedTextBox TcMTb;
        private MaskedTextBox TelNoMTb;
        private Label lblTelNo;
        private Label lblMail;
        private TextBox EmailTb;
        private Label lblSifreTekrar;
        private Label lblSifre;
        private TextBox SifreTb;
        private TextBox SifreTekrarTb;
        private Label lblTelUyari;
        private MenuStrip kayitOlMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private Button btnKayitOl;
        private CheckBox sifreGosterCheck;
    }
}