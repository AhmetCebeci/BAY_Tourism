namespace BAY_Turizm
{
    partial class FirmaislemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmaislemForm));
            FirmaislemMenu = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            adminMenüToolStripMenuItem = new ToolStripMenuItem();
            lblFirmaSil = new Label();
            pictureBox1 = new PictureBox();
            FiSilFirmalarCb = new ComboBox();
            btnFirmaSil = new Button();
            lblFirmaEkle = new Label();
            lblFiEkleFirmaAdi = new Label();
            FiEkleFirmaAdiTb = new TextBox();
            btnFirmaEkle = new Button();
            pictureBox2 = new PictureBox();
            FirmaislemMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // FirmaislemMenu
            // 
            FirmaislemMenu.BackColor = Color.FromArgb(109, 33, 79);
            FirmaislemMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirmaislemMenu.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem, adminMenüToolStripMenuItem });
            FirmaislemMenu.Location = new Point(0, 0);
            FirmaislemMenu.Name = "FirmaislemMenu";
            FirmaislemMenu.Size = new Size(884, 29);
            FirmaislemMenu.TabIndex = 2;
            FirmaislemMenu.Text = "Firma İşlemleri";
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
            // lblFirmaSil
            // 
            lblFirmaSil.AutoSize = true;
            lblFirmaSil.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirmaSil.ForeColor = Color.FromArgb(44, 44, 84);
            lblFirmaSil.Location = new Point(282, 29);
            lblFirmaSil.Name = "lblFirmaSil";
            lblFirmaSil.Size = new Size(247, 40);
            lblFirmaSil.TabIndex = 29;
            lblFirmaSil.Text = "Firma Silme İşlemi";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(109, 33, 79);
            pictureBox1.Location = new Point(0, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(884, 10);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // FiSilFirmalarCb
            // 
            FiSilFirmalarCb.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FiSilFirmalarCb.ForeColor = Color.FromArgb(30, 39, 46);
            FiSilFirmalarCb.FormattingEnabled = true;
            FiSilFirmalarCb.Location = new Point(12, 72);
            FiSilFirmalarCb.Name = "FiSilFirmalarCb";
            FiSilFirmalarCb.Size = new Size(614, 43);
            FiSilFirmalarCb.TabIndex = 31;
            // 
            // btnFirmaSil
            // 
            btnFirmaSil.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFirmaSil.ForeColor = Color.FromArgb(179, 57, 57);
            btnFirmaSil.Location = new Point(652, 72);
            btnFirmaSil.Name = "btnFirmaSil";
            btnFirmaSil.Size = new Size(220, 45);
            btnFirmaSil.TabIndex = 32;
            btnFirmaSil.Text = "Seçilen Firmayı Sil";
            btnFirmaSil.UseVisualStyleBackColor = true;
            btnFirmaSil.Click += btnFirmaSil_Click;
            // 
            // lblFirmaEkle
            // 
            lblFirmaEkle.AutoSize = true;
            lblFirmaEkle.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirmaEkle.ForeColor = Color.FromArgb(44, 44, 84);
            lblFirmaEkle.Location = new Point(282, 138);
            lblFirmaEkle.Name = "lblFirmaEkle";
            lblFirmaEkle.Size = new Size(269, 40);
            lblFirmaEkle.TabIndex = 33;
            lblFirmaEkle.Text = "Firma Ekleme İşlemi";
            // 
            // lblFiEkleFirmaAdi
            // 
            lblFiEkleFirmaAdi.AutoSize = true;
            lblFiEkleFirmaAdi.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFiEkleFirmaAdi.ForeColor = Color.FromArgb(33, 140, 116);
            lblFiEkleFirmaAdi.Location = new Point(12, 224);
            lblFiEkleFirmaAdi.Name = "lblFiEkleFirmaAdi";
            lblFiEkleFirmaAdi.Size = new Size(163, 45);
            lblFiEkleFirmaAdi.TabIndex = 40;
            lblFiEkleFirmaAdi.Text = "Firma Adı:";
            // 
            // FiEkleFirmaAdiTb
            // 
            FiEkleFirmaAdiTb.Font = new Font("Segoe UI", 22F);
            FiEkleFirmaAdiTb.ForeColor = Color.FromArgb(30, 39, 46);
            FiEkleFirmaAdiTb.Location = new Point(192, 222);
            FiEkleFirmaAdiTb.Name = "FiEkleFirmaAdiTb";
            FiEkleFirmaAdiTb.Size = new Size(283, 47);
            FiEkleFirmaAdiTb.TabIndex = 41;
            // 
            // btnFirmaEkle
            // 
            btnFirmaEkle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFirmaEkle.ForeColor = Color.FromArgb(179, 57, 57);
            btnFirmaEkle.Location = new Point(123, 306);
            btnFirmaEkle.Name = "btnFirmaEkle";
            btnFirmaEkle.Size = new Size(232, 57);
            btnFirmaEkle.TabIndex = 42;
            btnFirmaEkle.Text = "Firma Ekle";
            btnFirmaEkle.UseVisualStyleBackColor = true;
            btnFirmaEkle.Click += btnFirmaEkle_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(494, 201);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(378, 348);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // FirmaislemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(pictureBox2);
            Controls.Add(btnFirmaEkle);
            Controls.Add(FiEkleFirmaAdiTb);
            Controls.Add(lblFiEkleFirmaAdi);
            Controls.Add(lblFirmaEkle);
            Controls.Add(btnFirmaSil);
            Controls.Add(FiSilFirmalarCb);
            Controls.Add(pictureBox1);
            Controls.Add(lblFirmaSil);
            Controls.Add(FirmaislemMenu);
            Name = "FirmaislemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Firma İşlemleri";
            FirmaislemMenu.ResumeLayout(false);
            FirmaislemMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip FirmaislemMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private ToolStripMenuItem adminMenüToolStripMenuItem;
        private Label lblFirmaSil;
        private PictureBox pictureBox1;
        private ComboBox FiSilFirmalarCb;
        private Button btnFirmaSil;
        private Label lblFirmaEkle;
        private Label lblFiEkleFirmaAdi;
        private TextBox FiEkleFirmaAdiTb;
        private Button btnFirmaEkle;
        private PictureBox pictureBox2;
    }
}