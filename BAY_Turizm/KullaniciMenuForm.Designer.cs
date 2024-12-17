namespace BAY_Turizm
{
    partial class KullaniciMenuForm
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
            KullaniciMenu = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            lblBiletAlArama = new Label();
            btnSeferAra = new Button();
            BiletAlTarihDtp = new DateTimePicker();
            lblNeredenBiletAl = new Label();
            BiletAlNeredenCb = new ComboBox();
            BiletAlNereyeCb = new ComboBox();
            lblNereyeBiletAl = new Label();
            lblBiletAlTarih = new Label();
            btnYolcularim = new Button();
            btnGecmisFaturalarim = new Button();
            btnKampanyalar = new Button();
            lblDigerIslemler = new Label();
            KullaniciMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // KullaniciMenu
            // 
            KullaniciMenu.BackColor = Color.FromArgb(109, 33, 79);
            KullaniciMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KullaniciMenu.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem });
            KullaniciMenu.Location = new Point(0, 0);
            KullaniciMenu.Name = "KullaniciMenu";
            KullaniciMenu.Size = new Size(884, 29);
            KullaniciMenu.TabIndex = 1;
            KullaniciMenu.Text = "menuStrip1";
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
            pictureBox1.BackColor = Color.FromArgb(109, 33, 79);
            pictureBox1.Location = new Point(435, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 564);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // lblBiletAlArama
            // 
            lblBiletAlArama.AutoSize = true;
            lblBiletAlArama.Font = new Font("Segoe UI", 28F);
            lblBiletAlArama.ForeColor = Color.FromArgb(44, 44, 84);
            lblBiletAlArama.Location = new Point(116, 53);
            lblBiletAlArama.Name = "lblBiletAlArama";
            lblBiletAlArama.Size = new Size(139, 51);
            lblBiletAlArama.TabIndex = 29;
            lblBiletAlArama.Text = "Bilet Al";
            // 
            // btnSeferAra
            // 
            btnSeferAra.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSeferAra.ForeColor = Color.FromArgb(179, 57, 57);
            btnSeferAra.Location = new Point(74, 413);
            btnSeferAra.Name = "btnSeferAra";
            btnSeferAra.Size = new Size(264, 66);
            btnSeferAra.TabIndex = 31;
            btnSeferAra.Text = "Sefer Ara";
            btnSeferAra.UseVisualStyleBackColor = true;
            btnSeferAra.Click += btnSeferAra_Click;
            // 
            // BiletAlTarihDtp
            // 
            BiletAlTarihDtp.CalendarForeColor = Color.FromArgb(30, 39, 46);
            BiletAlTarihDtp.Font = new Font("Segoe UI", 18F);
            BiletAlTarihDtp.Location = new Point(122, 311);
            BiletAlTarihDtp.Name = "BiletAlTarihDtp";
            BiletAlTarihDtp.Size = new Size(282, 39);
            BiletAlTarihDtp.TabIndex = 45;
            // 
            // lblNeredenBiletAl
            // 
            lblNeredenBiletAl.AutoSize = true;
            lblNeredenBiletAl.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNeredenBiletAl.ForeColor = Color.FromArgb(33, 140, 116);
            lblNeredenBiletAl.Location = new Point(12, 152);
            lblNeredenBiletAl.Name = "lblNeredenBiletAl";
            lblNeredenBiletAl.Size = new Size(133, 40);
            lblNeredenBiletAl.TabIndex = 46;
            lblNeredenBiletAl.Text = "Nereden:";
            // 
            // BiletAlNeredenCb
            // 
            BiletAlNeredenCb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BiletAlNeredenCb.ForeColor = Color.FromArgb(30, 39, 46);
            BiletAlNeredenCb.FormattingEnabled = true;
            BiletAlNeredenCb.Location = new Point(176, 152);
            BiletAlNeredenCb.Name = "BiletAlNeredenCb";
            BiletAlNeredenCb.Size = new Size(228, 40);
            BiletAlNeredenCb.TabIndex = 49;
            // 
            // BiletAlNereyeCb
            // 
            BiletAlNereyeCb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BiletAlNereyeCb.ForeColor = Color.FromArgb(30, 39, 46);
            BiletAlNereyeCb.FormattingEnabled = true;
            BiletAlNereyeCb.Location = new Point(176, 234);
            BiletAlNereyeCb.Name = "BiletAlNereyeCb";
            BiletAlNereyeCb.Size = new Size(228, 40);
            BiletAlNereyeCb.TabIndex = 50;
            // 
            // lblNereyeBiletAl
            // 
            lblNereyeBiletAl.AutoSize = true;
            lblNereyeBiletAl.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNereyeBiletAl.ForeColor = Color.FromArgb(33, 140, 116);
            lblNereyeBiletAl.Location = new Point(12, 234);
            lblNereyeBiletAl.Name = "lblNereyeBiletAl";
            lblNereyeBiletAl.Size = new Size(114, 40);
            lblNereyeBiletAl.TabIndex = 51;
            lblNereyeBiletAl.Text = "Nereye:";
            // 
            // lblBiletAlTarih
            // 
            lblBiletAlTarih.AutoSize = true;
            lblBiletAlTarih.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBiletAlTarih.ForeColor = Color.FromArgb(33, 140, 116);
            lblBiletAlTarih.Location = new Point(12, 311);
            lblBiletAlTarih.Name = "lblBiletAlTarih";
            lblBiletAlTarih.Size = new Size(83, 40);
            lblBiletAlTarih.TabIndex = 52;
            lblBiletAlTarih.Text = "Tarih:";
            // 
            // btnYolcularim
            // 
            btnYolcularim.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnYolcularim.ForeColor = Color.FromArgb(179, 57, 57);
            btnYolcularim.Location = new Point(531, 300);
            btnYolcularim.Name = "btnYolcularim";
            btnYolcularim.Size = new Size(291, 66);
            btnYolcularim.TabIndex = 53;
            btnYolcularim.Text = "Yolcularım";
            btnYolcularim.UseVisualStyleBackColor = true;
            btnYolcularim.Click += btnYolcularim_Click;
            // 
            // btnGecmisFaturalarim
            // 
            btnGecmisFaturalarim.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGecmisFaturalarim.ForeColor = Color.FromArgb(179, 57, 57);
            btnGecmisFaturalarim.Location = new Point(531, 126);
            btnGecmisFaturalarim.Name = "btnGecmisFaturalarim";
            btnGecmisFaturalarim.Size = new Size(291, 66);
            btnGecmisFaturalarim.TabIndex = 54;
            btnGecmisFaturalarim.Text = "Geçmiş Faturalarım";
            btnGecmisFaturalarim.UseVisualStyleBackColor = true;
            // 
            // btnKampanyalar
            // 
            btnKampanyalar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKampanyalar.ForeColor = Color.FromArgb(179, 57, 57);
            btnKampanyalar.Location = new Point(531, 413);
            btnKampanyalar.Name = "btnKampanyalar";
            btnKampanyalar.Size = new Size(291, 66);
            btnKampanyalar.TabIndex = 55;
            btnKampanyalar.Text = "Geçerli Kampanyalar";
            btnKampanyalar.UseVisualStyleBackColor = true;
            // 
            // lblDigerIslemler
            // 
            lblDigerIslemler.AutoSize = true;
            lblDigerIslemler.Font = new Font("Segoe UI", 28F);
            lblDigerIslemler.ForeColor = Color.FromArgb(44, 44, 84);
            lblDigerIslemler.Location = new Point(547, 53);
            lblDigerIslemler.Name = "lblDigerIslemler";
            lblDigerIslemler.Size = new Size(253, 51);
            lblDigerIslemler.TabIndex = 56;
            lblDigerIslemler.Text = "Diğer İşlemler";
            // 
            // KullaniciMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(lblDigerIslemler);
            Controls.Add(btnKampanyalar);
            Controls.Add(btnGecmisFaturalarim);
            Controls.Add(btnYolcularim);
            Controls.Add(lblBiletAlTarih);
            Controls.Add(lblNereyeBiletAl);
            Controls.Add(BiletAlNereyeCb);
            Controls.Add(BiletAlNeredenCb);
            Controls.Add(lblNeredenBiletAl);
            Controls.Add(BiletAlTarihDtp);
            Controls.Add(btnSeferAra);
            Controls.Add(lblBiletAlArama);
            Controls.Add(pictureBox1);
            Controls.Add(KullaniciMenu);
            Name = "KullaniciMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Menüsü";
            Load += KullaniciMenuForm_Load;
            KullaniciMenu.ResumeLayout(false);
            KullaniciMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip KullaniciMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label lblBiletAlArama;
        private Button btnSeferAra;
        private DateTimePicker BiletAlTarihDtp;
        private Label lblNeredenBiletAl;
        private ComboBox BiletAlNeredenCb;
        private ComboBox BiletAlNereyeCb;
        private Label lblNereyeBiletAl;
        private Label lblBiletAlTarih;
        private Button btnYolcularim;
        private Button btnGecmisFaturalarim;
        private Button btnKampanyalar;
        private Label lblDigerIslemler;
    }
}