namespace BAY_Turizm
{
    partial class KullaniciGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGirisForm));
            KullaniciGirisMenu = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            KullaniciAdiGirisTb = new TextBox();
            lblKullaniciAdiGiris = new Label();
            btnKullaniciGiris = new Button();
            sifreGosterCheckKullanici = new CheckBox();
            KullaniciGirisSifreTb = new TextBox();
            lblKullaniciSifreGiris = new Label();
            KullaniciGirisMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // KullaniciGirisMenu
            // 
            KullaniciGirisMenu.BackColor = Color.FromArgb(109, 33, 79);
            KullaniciGirisMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KullaniciGirisMenu.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem });
            KullaniciGirisMenu.Location = new Point(0, 0);
            KullaniciGirisMenu.Name = "KullaniciGirisMenu";
            KullaniciGirisMenu.Size = new Size(884, 29);
            KullaniciGirisMenu.TabIndex = 0;
            KullaniciGirisMenu.Text = "menuStrip1";
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
            pictureBox1.Location = new Point(507, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 402);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // KullaniciAdiGirisTb
            // 
            KullaniciAdiGirisTb.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KullaniciAdiGirisTb.ForeColor = Color.FromArgb(30, 39, 46);
            KullaniciAdiGirisTb.Location = new Point(223, 115);
            KullaniciAdiGirisTb.Name = "KullaniciAdiGirisTb";
            KullaniciAdiGirisTb.Size = new Size(264, 51);
            KullaniciAdiGirisTb.TabIndex = 4;
            KullaniciAdiGirisTb.TextChanged += KullaniciGAdTb_TextChanged;
            // 
            // lblKullaniciAdiGiris
            // 
            lblKullaniciAdiGiris.AutoSize = true;
            lblKullaniciAdiGiris.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKullaniciAdiGiris.ForeColor = Color.FromArgb(33, 140, 116);
            lblKullaniciAdiGiris.Location = new Point(12, 121);
            lblKullaniciAdiGiris.Name = "lblKullaniciAdiGiris";
            lblKullaniciAdiGiris.Size = new Size(205, 45);
            lblKullaniciAdiGiris.TabIndex = 7;
            lblKullaniciAdiGiris.Text = "Kullanıcı Adı:";
            lblKullaniciAdiGiris.Click += lblKullaniciAdiGiris_Click;
            // 
            // btnKullaniciGiris
            // 
            btnKullaniciGiris.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKullaniciGiris.ForeColor = Color.FromArgb(179, 57, 57);
            btnKullaniciGiris.Location = new Point(48, 423);
            btnKullaniciGiris.Name = "btnKullaniciGiris";
            btnKullaniciGiris.Size = new Size(367, 73);
            btnKullaniciGiris.TabIndex = 21;
            btnKullaniciGiris.Text = "Kullanıcı Girişi Yap";
            btnKullaniciGiris.UseVisualStyleBackColor = true;
            btnKullaniciGiris.Click += btnKullaniciGiris_Click;
            // 
            // sifreGosterCheckKullanici
            // 
            sifreGosterCheckKullanici.AutoSize = true;
            sifreGosterCheckKullanici.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sifreGosterCheckKullanici.ForeColor = Color.FromArgb(179, 57, 57);
            sifreGosterCheckKullanici.Location = new Point(336, 287);
            sifreGosterCheckKullanici.Name = "sifreGosterCheckKullanici";
            sifreGosterCheckKullanici.Size = new Size(151, 28);
            sifreGosterCheckKullanici.TabIndex = 22;
            sifreGosterCheckKullanici.Text = "Şifreyi Göster";
            sifreGosterCheckKullanici.UseVisualStyleBackColor = true;
            sifreGosterCheckKullanici.CheckedChanged += sifreGosterCheckKullanici_CheckedChanged;
            // 
            // KullaniciGirisSifreTb
            // 
            KullaniciGirisSifreTb.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KullaniciGirisSifreTb.ForeColor = Color.FromArgb(30, 39, 46);
            KullaniciGirisSifreTb.Location = new Point(223, 230);
            KullaniciGirisSifreTb.Name = "KullaniciGirisSifreTb";
            KullaniciGirisSifreTb.Size = new Size(264, 51);
            KullaniciGirisSifreTb.TabIndex = 23;
            KullaniciGirisSifreTb.UseSystemPasswordChar = true;
            // 
            // lblKullaniciSifreGiris
            // 
            lblKullaniciSifreGiris.AutoSize = true;
            lblKullaniciSifreGiris.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKullaniciSifreGiris.ForeColor = Color.FromArgb(33, 140, 116);
            lblKullaniciSifreGiris.Location = new Point(12, 236);
            lblKullaniciSifreGiris.Name = "lblKullaniciSifreGiris";
            lblKullaniciSifreGiris.Size = new Size(91, 45);
            lblKullaniciSifreGiris.TabIndex = 24;
            lblKullaniciSifreGiris.Text = "Şifre:";
            // 
            // KullaniciGirisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(lblKullaniciSifreGiris);
            Controls.Add(KullaniciGirisSifreTb);
            Controls.Add(sifreGosterCheckKullanici);
            Controls.Add(btnKullaniciGiris);
            Controls.Add(lblKullaniciAdiGiris);
            Controls.Add(KullaniciAdiGirisTb);
            Controls.Add(pictureBox1);
            Controls.Add(KullaniciGirisMenu);
            MainMenuStrip = KullaniciGirisMenu;
            Name = "KullaniciGirisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Girişi";
            Load += KullaniciGirisForm_Load;
            KullaniciGirisMenu.ResumeLayout(false);
            KullaniciGirisMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip KullaniciGirisMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private PictureBox pictureBox1;
        private TextBox KullaniciAdiGirisTb;
        private Label lblKullaniciAdiGiris;
        private Button btnKullaniciGiris;
        private CheckBox sifreGosterCheckKullanici;
        private TextBox KullaniciGirisSifreTb;
        private Label lblKullaniciSifreGiris;
    }
}