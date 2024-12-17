namespace BAY_Turizm
{
    partial class AdminHesapislemForm
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
            AdminHesapislemMenu = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            adminMenüToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            btnAdminSifreDegistir = new Button();
            lblSifreDegistir = new Label();
            DegistirilecekSifreTb = new TextBox();
            AdminYeniSifre1Tb = new TextBox();
            AdminYeniSifre2Tb = new TextBox();
            lblAdminDegisilecekSifre = new Label();
            lblAdminYeniSifre1 = new Label();
            lblAdminYeniSifre2 = new Label();
            sifreGosterSifreDegistirCheckAdmin = new CheckBox();
            lblAdminHesapSilme = new Label();
            btnAdminHesapSil = new Button();
            AdminHesapislemMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AdminHesapislemMenu
            // 
            AdminHesapislemMenu.BackColor = Color.FromArgb(109, 33, 79);
            AdminHesapislemMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminHesapislemMenu.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem, adminMenüToolStripMenuItem });
            AdminHesapislemMenu.Location = new Point(0, 0);
            AdminHesapislemMenu.Name = "AdminHesapislemMenu";
            AdminHesapislemMenu.Size = new Size(884, 29);
            AdminHesapislemMenu.TabIndex = 4;
            AdminHesapislemMenu.Text = "menuStrip1";
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
            // adminMenüToolStripMenuItem
            // 
            adminMenüToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminMenüToolStripMenuItem.ForeColor = Color.FromArgb(247, 241, 227);
            adminMenüToolStripMenuItem.Name = "adminMenüToolStripMenuItem";
            adminMenüToolStripMenuItem.Size = new Size(121, 25);
            adminMenüToolStripMenuItem.Text = "Admin Menü";
            adminMenüToolStripMenuItem.Click += adminMenüToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(109, 33, 79);
            pictureBox1.Location = new Point(0, 308);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(884, 10);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // btnAdminSifreDegistir
            // 
            btnAdminSifreDegistir.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdminSifreDegistir.ForeColor = Color.FromArgb(179, 57, 57);
            btnAdminSifreDegistir.Location = new Point(22, 257);
            btnAdminSifreDegistir.Name = "btnAdminSifreDegistir";
            btnAdminSifreDegistir.Size = new Size(243, 45);
            btnAdminSifreDegistir.TabIndex = 26;
            btnAdminSifreDegistir.Text = "Şifre Değiştir";
            btnAdminSifreDegistir.UseVisualStyleBackColor = true;
            // 
            // lblSifreDegistir
            // 
            lblSifreDegistir.AutoSize = true;
            lblSifreDegistir.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSifreDegistir.ForeColor = Color.FromArgb(44, 44, 84);
            lblSifreDegistir.Location = new Point(252, 39);
            lblSifreDegistir.Name = "lblSifreDegistir";
            lblSifreDegistir.Size = new Size(301, 40);
            lblSifreDegistir.TabIndex = 29;
            lblSifreDegistir.Text = "Şifre Değiştirme İşlemi";
            // 
            // DegistirilecekSifreTb
            // 
            DegistirilecekSifreTb.Font = new Font("Segoe UI", 18F);
            DegistirilecekSifreTb.ForeColor = Color.FromArgb(30, 39, 46);
            DegistirilecekSifreTb.Location = new Point(240, 92);
            DegistirilecekSifreTb.Name = "DegistirilecekSifreTb";
            DegistirilecekSifreTb.Size = new Size(347, 39);
            DegistirilecekSifreTb.TabIndex = 30;
            DegistirilecekSifreTb.UseSystemPasswordChar = true;
            // 
            // AdminYeniSifre1Tb
            // 
            AdminYeniSifre1Tb.Font = new Font("Segoe UI", 18F);
            AdminYeniSifre1Tb.ForeColor = Color.FromArgb(30, 39, 46);
            AdminYeniSifre1Tb.Location = new Point(240, 144);
            AdminYeniSifre1Tb.Name = "AdminYeniSifre1Tb";
            AdminYeniSifre1Tb.Size = new Size(347, 39);
            AdminYeniSifre1Tb.TabIndex = 31;
            AdminYeniSifre1Tb.UseSystemPasswordChar = true;
            // 
            // AdminYeniSifre2Tb
            // 
            AdminYeniSifre2Tb.Font = new Font("Segoe UI", 18F);
            AdminYeniSifre2Tb.ForeColor = Color.FromArgb(30, 39, 46);
            AdminYeniSifre2Tb.Location = new Point(240, 192);
            AdminYeniSifre2Tb.Name = "AdminYeniSifre2Tb";
            AdminYeniSifre2Tb.Size = new Size(347, 39);
            AdminYeniSifre2Tb.TabIndex = 32;
            AdminYeniSifre2Tb.UseSystemPasswordChar = true;
            // 
            // lblAdminDegisilecekSifre
            // 
            lblAdminDegisilecekSifre.AutoSize = true;
            lblAdminDegisilecekSifre.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminDegisilecekSifre.ForeColor = Color.FromArgb(33, 140, 116);
            lblAdminDegisilecekSifre.Location = new Point(12, 92);
            lblAdminDegisilecekSifre.Name = "lblAdminDegisilecekSifre";
            lblAdminDegisilecekSifre.Size = new Size(206, 40);
            lblAdminDegisilecekSifre.TabIndex = 33;
            lblAdminDegisilecekSifre.Text = "Şuanki Şifreniz:";
            // 
            // lblAdminYeniSifre1
            // 
            lblAdminYeniSifre1.AutoSize = true;
            lblAdminYeniSifre1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminYeniSifre1.ForeColor = Color.FromArgb(33, 140, 116);
            lblAdminYeniSifre1.Location = new Point(12, 144);
            lblAdminYeniSifre1.Name = "lblAdminYeniSifre1";
            lblAdminYeniSifre1.Size = new Size(138, 40);
            lblAdminYeniSifre1.TabIndex = 34;
            lblAdminYeniSifre1.Text = "Yeni Şifre:";
            // 
            // lblAdminYeniSifre2
            // 
            lblAdminYeniSifre2.AutoSize = true;
            lblAdminYeniSifre2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminYeniSifre2.ForeColor = Color.FromArgb(33, 140, 116);
            lblAdminYeniSifre2.Location = new Point(12, 191);
            lblAdminYeniSifre2.Name = "lblAdminYeniSifre2";
            lblAdminYeniSifre2.Size = new Size(222, 40);
            lblAdminYeniSifre2.TabIndex = 35;
            lblAdminYeniSifre2.Text = "Yeni Şifre Tekrar:";
            // 
            // sifreGosterSifreDegistirCheckAdmin
            // 
            sifreGosterSifreDegistirCheckAdmin.AutoSize = true;
            sifreGosterSifreDegistirCheckAdmin.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            sifreGosterSifreDegistirCheckAdmin.ForeColor = Color.FromArgb(179, 57, 57);
            sifreGosterSifreDegistirCheckAdmin.Location = new Point(438, 237);
            sifreGosterSifreDegistirCheckAdmin.Name = "sifreGosterSifreDegistirCheckAdmin";
            sifreGosterSifreDegistirCheckAdmin.Size = new Size(149, 27);
            sifreGosterSifreDegistirCheckAdmin.TabIndex = 36;
            sifreGosterSifreDegistirCheckAdmin.Text = "Şifreyi Göster";
            sifreGosterSifreDegistirCheckAdmin.UseVisualStyleBackColor = true;
            sifreGosterSifreDegistirCheckAdmin.CheckedChanged += sifreGosterSifreDegistirCheckAdmin_CheckedChanged;
            // 
            // lblAdminHesapSilme
            // 
            lblAdminHesapSilme.AutoSize = true;
            lblAdminHesapSilme.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminHesapSilme.ForeColor = Color.FromArgb(44, 44, 84);
            lblAdminHesapSilme.Location = new Point(252, 332);
            lblAdminHesapSilme.Name = "lblAdminHesapSilme";
            lblAdminHesapSilme.Size = new Size(256, 40);
            lblAdminHesapSilme.TabIndex = 37;
            lblAdminHesapSilme.Text = "Hesap Silme İşlemi";
            // 
            // btnAdminHesapSil
            // 
            btnAdminHesapSil.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdminHesapSil.ForeColor = Color.FromArgb(179, 57, 57);
            btnAdminHesapSil.Location = new Point(22, 375);
            btnAdminHesapSil.Name = "btnAdminHesapSil";
            btnAdminHesapSil.Size = new Size(832, 152);
            btnAdminHesapSil.TabIndex = 38;
            btnAdminHesapSil.Text = "Admin Hesabını Sil";
            btnAdminHesapSil.UseVisualStyleBackColor = true;
            // 
            // AdminHesapislemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(btnAdminHesapSil);
            Controls.Add(lblAdminHesapSilme);
            Controls.Add(sifreGosterSifreDegistirCheckAdmin);
            Controls.Add(lblAdminYeniSifre2);
            Controls.Add(lblAdminYeniSifre1);
            Controls.Add(lblAdminDegisilecekSifre);
            Controls.Add(AdminYeniSifre2Tb);
            Controls.Add(AdminYeniSifre1Tb);
            Controls.Add(DegistirilecekSifreTb);
            Controls.Add(lblSifreDegistir);
            Controls.Add(btnAdminSifreDegistir);
            Controls.Add(pictureBox1);
            Controls.Add(AdminHesapislemMenu);
            Name = "AdminHesapislemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Hesap İşlemleri";
            Load += AdminHesapislemForm_Load;
            AdminHesapislemMenu.ResumeLayout(false);
            AdminHesapislemMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip AdminHesapislemMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private ToolStripMenuItem adminMenüToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button btnAdminSifreDegistir;
        private Label lblSifreDegistir;
        private TextBox DegistirilecekSifreTb;
        private TextBox AdminYeniSifre1Tb;
        private TextBox AdminYeniSifre2Tb;
        private Label lblAdminDegisilecekSifre;
        private Label lblAdminYeniSifre1;
        private Label lblAdminYeniSifre2;
        private CheckBox sifreGosterSifreDegistirCheckAdmin;
        private Label lblAdminHesapSilme;
        private Button btnAdminHesapSil;
    }
}