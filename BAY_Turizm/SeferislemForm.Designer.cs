namespace BAY_Turizm
{
    partial class SeferislemForm
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
            SeferislemMenu = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            adminMenüToolStripMenuItem = new ToolStripMenuItem();
            SSilSeferlerCb = new ComboBox();
            lblSeferSil = new Label();
            pictureBox1 = new PictureBox();
            btnSeferSil = new Button();
            lblSeferEkleme = new Label();
            lblFirmaId = new Label();
            FirmaIdMTb = new MaskedTextBox();
            lblSEkleKalkis = new Label();
            lblSEkleVaris = new Label();
            lblSEkleSaat = new Label();
            lblSEkleOtobusSaseNo = new Label();
            lblSEkleTarih = new Label();
            SEkleOtobusSaseNoCb = new ComboBox();
            SEkleTarihDtp = new DateTimePicker();
            SEkleSaatDtp = new DateTimePicker();
            btnSeferEkle = new Button();
            SEkleVarisNoktasiCb = new ComboBox();
            SEkleKalkisNoktasiCb = new ComboBox();
            SeferislemMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SeferislemMenu
            // 
            SeferislemMenu.BackColor = Color.FromArgb(109, 33, 79);
            SeferislemMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SeferislemMenu.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem, adminMenüToolStripMenuItem });
            SeferislemMenu.Location = new Point(0, 0);
            SeferislemMenu.Name = "SeferislemMenu";
            SeferislemMenu.Size = new Size(884, 29);
            SeferislemMenu.TabIndex = 2;
            SeferislemMenu.Text = "Sefer İşlemleri";
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
            // SSilSeferlerCb
            // 
            SSilSeferlerCb.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SSilSeferlerCb.ForeColor = Color.FromArgb(30, 39, 46);
            SSilSeferlerCb.FormattingEnabled = true;
            SSilSeferlerCb.Location = new Point(12, 72);
            SSilSeferlerCb.Name = "SSilSeferlerCb";
            SSilSeferlerCb.Size = new Size(634, 43);
            SSilSeferlerCb.TabIndex = 3;
            // 
            // lblSeferSil
            // 
            lblSeferSil.AutoSize = true;
            lblSeferSil.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeferSil.ForeColor = Color.FromArgb(44, 44, 84);
            lblSeferSil.Location = new Point(279, 29);
            lblSeferSil.Name = "lblSeferSil";
            lblSeferSil.Size = new Size(240, 40);
            lblSeferSil.TabIndex = 28;
            lblSeferSil.Text = "Sefer Silme İşlemi";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(109, 33, 79);
            pictureBox1.Location = new Point(0, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(884, 10);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // btnSeferSil
            // 
            btnSeferSil.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSeferSil.ForeColor = Color.FromArgb(179, 57, 57);
            btnSeferSil.Location = new Point(664, 72);
            btnSeferSil.Name = "btnSeferSil";
            btnSeferSil.Size = new Size(208, 45);
            btnSeferSil.TabIndex = 30;
            btnSeferSil.Text = "Seçilen Seferi Sil";
            btnSeferSil.UseVisualStyleBackColor = true;
            btnSeferSil.Click += btnSeferSil_Click;
            // 
            // lblSeferEkleme
            // 
            lblSeferEkleme.AutoSize = true;
            lblSeferEkleme.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeferEkleme.ForeColor = Color.FromArgb(44, 44, 84);
            lblSeferEkleme.Location = new Point(279, 136);
            lblSeferEkleme.Name = "lblSeferEkleme";
            lblSeferEkleme.Size = new Size(262, 40);
            lblSeferEkleme.TabIndex = 31;
            lblSeferEkleme.Text = "Sefer Ekleme İşlemi";
            // 
            // lblFirmaId
            // 
            lblFirmaId.AutoSize = true;
            lblFirmaId.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirmaId.ForeColor = Color.FromArgb(33, 140, 116);
            lblFirmaId.Location = new Point(12, 192);
            lblFirmaId.Name = "lblFirmaId";
            lblFirmaId.Size = new Size(127, 40);
            lblFirmaId.TabIndex = 32;
            lblFirmaId.Text = "Firma Id:";
            // 
            // FirmaIdMTb
            // 
            FirmaIdMTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirmaIdMTb.ForeColor = Color.FromArgb(30, 39, 46);
            FirmaIdMTb.Location = new Point(152, 193);
            FirmaIdMTb.Mask = "00000";
            FirmaIdMTb.Name = "FirmaIdMTb";
            FirmaIdMTb.Size = new Size(283, 39);
            FirmaIdMTb.TabIndex = 33;
            FirmaIdMTb.ValidatingType = typeof(int);
            // 
            // lblSEkleKalkis
            // 
            lblSEkleKalkis.AutoSize = true;
            lblSEkleKalkis.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSEkleKalkis.ForeColor = Color.FromArgb(33, 140, 116);
            lblSEkleKalkis.Location = new Point(12, 258);
            lblSEkleKalkis.Name = "lblSEkleKalkis";
            lblSEkleKalkis.Size = new Size(200, 40);
            lblSEkleKalkis.TabIndex = 34;
            lblSEkleKalkis.Text = "Kalkış Noktası:";
            // 
            // lblSEkleVaris
            // 
            lblSEkleVaris.AutoSize = true;
            lblSEkleVaris.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSEkleVaris.ForeColor = Color.FromArgb(33, 140, 116);
            lblSEkleVaris.Location = new Point(441, 255);
            lblSEkleVaris.Name = "lblSEkleVaris";
            lblSEkleVaris.Size = new Size(188, 40);
            lblSEkleVaris.TabIndex = 35;
            lblSEkleVaris.Text = "Varış Noktası:";
            // 
            // lblSEkleSaat
            // 
            lblSEkleSaat.AutoSize = true;
            lblSEkleSaat.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSEkleSaat.ForeColor = Color.FromArgb(33, 140, 116);
            lblSEkleSaat.Location = new Point(441, 331);
            lblSEkleSaat.Name = "lblSEkleSaat";
            lblSEkleSaat.Size = new Size(78, 40);
            lblSEkleSaat.TabIndex = 39;
            lblSEkleSaat.Text = "Saat:";
            // 
            // lblSEkleOtobusSaseNo
            // 
            lblSEkleOtobusSaseNo.AutoSize = true;
            lblSEkleOtobusSaseNo.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSEkleOtobusSaseNo.ForeColor = Color.FromArgb(33, 140, 116);
            lblSEkleOtobusSaseNo.Location = new Point(441, 190);
            lblSEkleOtobusSaseNo.Name = "lblSEkleOtobusSaseNo";
            lblSEkleOtobusSaseNo.Size = new Size(229, 40);
            lblSEkleOtobusSaseNo.TabIndex = 40;
            lblSEkleOtobusSaseNo.Text = "Otobüs Şase No:";
            // 
            // lblSEkleTarih
            // 
            lblSEkleTarih.AutoSize = true;
            lblSEkleTarih.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSEkleTarih.ForeColor = Color.FromArgb(33, 140, 116);
            lblSEkleTarih.Location = new Point(12, 330);
            lblSEkleTarih.Name = "lblSEkleTarih";
            lblSEkleTarih.Size = new Size(83, 40);
            lblSEkleTarih.TabIndex = 41;
            lblSEkleTarih.Text = "Tarih:";
            // 
            // SEkleOtobusSaseNoCb
            // 
            SEkleOtobusSaseNoCb.Font = new Font("Segoe UI", 18F);
            SEkleOtobusSaseNoCb.ForeColor = Color.FromArgb(30, 39, 46);
            SEkleOtobusSaseNoCb.FormattingEnabled = true;
            SEkleOtobusSaseNoCb.Location = new Point(683, 193);
            SEkleOtobusSaseNoCb.Name = "SEkleOtobusSaseNoCb";
            SEkleOtobusSaseNoCb.Size = new Size(189, 40);
            SEkleOtobusSaseNoCb.TabIndex = 43;
            // 
            // SEkleTarihDtp
            // 
            SEkleTarihDtp.CalendarForeColor = Color.FromArgb(30, 39, 46);
            SEkleTarihDtp.Font = new Font("Segoe UI", 18F);
            SEkleTarihDtp.Location = new Point(101, 332);
            SEkleTarihDtp.Name = "SEkleTarihDtp";
            SEkleTarihDtp.Size = new Size(327, 39);
            SEkleTarihDtp.TabIndex = 44;
            // 
            // SEkleSaatDtp
            // 
            SEkleSaatDtp.CalendarForeColor = Color.FromArgb(30, 39, 46);
            SEkleSaatDtp.CustomFormat = "\"HH:mm:00\"";
            SEkleSaatDtp.Font = new Font("Segoe UI", 18F);
            SEkleSaatDtp.Format = DateTimePickerFormat.Time;
            SEkleSaatDtp.Location = new Point(628, 330);
            SEkleSaatDtp.Name = "SEkleSaatDtp";
            SEkleSaatDtp.ShowUpDown = true;
            SEkleSaatDtp.Size = new Size(244, 39);
            SEkleSaatDtp.TabIndex = 45;
            // 
            // btnSeferEkle
            // 
            btnSeferEkle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            btnSeferEkle.ForeColor = Color.FromArgb(179, 57, 57);
            btnSeferEkle.Location = new Point(279, 415);
            btnSeferEkle.Name = "btnSeferEkle";
            btnSeferEkle.Size = new Size(262, 59);
            btnSeferEkle.TabIndex = 46;
            btnSeferEkle.Text = "Sefer Ekle";
            btnSeferEkle.UseVisualStyleBackColor = true;
            btnSeferEkle.Click += btnSeferEkle_Click;
            // 
            // SEkleVarisNoktasiCb
            // 
            SEkleVarisNoktasiCb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SEkleVarisNoktasiCb.ForeColor = Color.FromArgb(30, 39, 46);
            SEkleVarisNoktasiCb.FormattingEnabled = true;
            SEkleVarisNoktasiCb.Location = new Point(628, 255);
            SEkleVarisNoktasiCb.Name = "SEkleVarisNoktasiCb";
            SEkleVarisNoktasiCb.Size = new Size(244, 40);
            SEkleVarisNoktasiCb.TabIndex = 47;
            // 
            // SEkleKalkisNoktasiCb
            // 
            SEkleKalkisNoktasiCb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SEkleKalkisNoktasiCb.ForeColor = Color.FromArgb(30, 39, 46);
            SEkleKalkisNoktasiCb.FormattingEnabled = true;
            SEkleKalkisNoktasiCb.Location = new Point(218, 258);
            SEkleKalkisNoktasiCb.Name = "SEkleKalkisNoktasiCb";
            SEkleKalkisNoktasiCb.Size = new Size(210, 40);
            SEkleKalkisNoktasiCb.TabIndex = 48;
            // 
            // SeferislemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(SEkleKalkisNoktasiCb);
            Controls.Add(SEkleVarisNoktasiCb);
            Controls.Add(btnSeferEkle);
            Controls.Add(SEkleSaatDtp);
            Controls.Add(SEkleTarihDtp);
            Controls.Add(SEkleOtobusSaseNoCb);
            Controls.Add(lblSEkleTarih);
            Controls.Add(lblSEkleOtobusSaseNo);
            Controls.Add(lblSEkleSaat);
            Controls.Add(lblSEkleVaris);
            Controls.Add(lblSEkleKalkis);
            Controls.Add(FirmaIdMTb);
            Controls.Add(lblFirmaId);
            Controls.Add(lblSeferEkleme);
            Controls.Add(btnSeferSil);
            Controls.Add(pictureBox1);
            Controls.Add(lblSeferSil);
            Controls.Add(SSilSeferlerCb);
            Controls.Add(SeferislemMenu);
            Name = "SeferislemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sefer İşlemleri";
            Load += SeferislemForm_Load;
            SeferislemMenu.ResumeLayout(false);
            SeferislemMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip SeferislemMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private ToolStripMenuItem adminMenüToolStripMenuItem;
        private ComboBox SSilSeferlerCb;
        private Label lblSeferSil;
        private PictureBox pictureBox1;
        private Button btnSeferSil;
        private Label lblSeferEkleme;
        private Label lblFirmaId;
        private MaskedTextBox FirmaIdMTb;
        private Label lblSEkleKalkis;
        private Label lblSEkleVaris;
        private Label lblSEkleSaat;
        private Label lblSEkleOtobusSaseNo;
        private Label lblSEkleTarih;
        private ComboBox SEkleOtobusSaseNoCb;
        private DateTimePicker SEkleTarihDtp;
        private DateTimePicker SEkleSaatDtp;
        private Button btnSeferEkle;
        private ComboBox SEkleVarisNoktasiCb;
        private ComboBox SEkleKalkisNoktasiCb;
    }
}