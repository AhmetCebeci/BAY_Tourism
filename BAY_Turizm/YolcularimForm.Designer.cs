namespace BAY_Turizm
{
    partial class YolcularimForm
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
            YolcularimMenu = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıMenüToolStripMenuItem = new ToolStripMenuItem();
            YolcularimGoruntuleDgv = new DataGridView();
            lblYolcularim = new Label();
            pictureBox1 = new PictureBox();
            lblYolcuEkle = new Label();
            lblYolcuAdi = new Label();
            lblYolcuSoyadi = new Label();
            lblYolcuTc = new Label();
            YEkleTelNoMTb = new MaskedTextBox();
            lblYolcuTelNo = new Label();
            YEkleAdiTb = new TextBox();
            YEkleSoyadiTb = new TextBox();
            YEkleYolcuTcMTb = new MaskedTextBox();
            lblYEkleKullaniciTc = new Label();
            YEkleKullaniciTcMTb = new MaskedTextBox();
            btnYolcuEkle = new Button();
            YolcularimMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)YolcularimGoruntuleDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // YolcularimMenu
            // 
            YolcularimMenu.BackColor = Color.FromArgb(109, 33, 79);
            YolcularimMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YolcularimMenu.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem, kullanıcıMenüToolStripMenuItem });
            YolcularimMenu.Location = new Point(0, 0);
            YolcularimMenu.Name = "YolcularimMenu";
            YolcularimMenu.Size = new Size(884, 29);
            YolcularimMenu.TabIndex = 3;
            YolcularimMenu.Text = "menuStrip1";
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
            // kullanıcıMenüToolStripMenuItem
            // 
            kullanıcıMenüToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            kullanıcıMenüToolStripMenuItem.ForeColor = Color.FromArgb(247, 241, 227);
            kullanıcıMenüToolStripMenuItem.Name = "kullanıcıMenüToolStripMenuItem";
            kullanıcıMenüToolStripMenuItem.Size = new Size(137, 25);
            kullanıcıMenüToolStripMenuItem.Text = "Kullanıcı Menü";
            kullanıcıMenüToolStripMenuItem.Click += kullanıcıMenüToolStripMenuItem_Click;
            // 
            // YolcularimGoruntuleDgv
            // 
            YolcularimGoruntuleDgv.BackgroundColor = Color.White;
            YolcularimGoruntuleDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            YolcularimGoruntuleDgv.GridColor = Color.FromArgb(30, 39, 46);
            YolcularimGoruntuleDgv.Location = new Point(12, 79);
            YolcularimGoruntuleDgv.Name = "YolcularimGoruntuleDgv";
            YolcularimGoruntuleDgv.Size = new Size(464, 410);
            YolcularimGoruntuleDgv.TabIndex = 35;
            // 
            // lblYolcularim
            // 
            lblYolcularim.AutoSize = true;
            lblYolcularim.Font = new Font("Segoe UI", 22F);
            lblYolcularim.ForeColor = Color.FromArgb(44, 44, 84);
            lblYolcularim.Location = new Point(12, 35);
            lblYolcularim.Name = "lblYolcularim";
            lblYolcularim.Size = new Size(160, 41);
            lblYolcularim.TabIndex = 36;
            lblYolcularim.Text = "Yolcularım:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(109, 33, 79);
            pictureBox1.Location = new Point(482, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 564);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // lblYolcuEkle
            // 
            lblYolcuEkle.AutoSize = true;
            lblYolcuEkle.Font = new Font("Segoe UI", 22F);
            lblYolcuEkle.ForeColor = Color.FromArgb(44, 44, 84);
            lblYolcuEkle.Location = new Point(613, 35);
            lblYolcuEkle.Name = "lblYolcuEkle";
            lblYolcuEkle.Size = new Size(149, 41);
            lblYolcuEkle.TabIndex = 38;
            lblYolcuEkle.Text = "Yolcu Ekle";
            // 
            // lblYolcuAdi
            // 
            lblYolcuAdi.AutoSize = true;
            lblYolcuAdi.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYolcuAdi.ForeColor = Color.FromArgb(33, 140, 116);
            lblYolcuAdi.Location = new Point(498, 104);
            lblYolcuAdi.Name = "lblYolcuAdi";
            lblYolcuAdi.Size = new Size(66, 40);
            lblYolcuAdi.TabIndex = 47;
            lblYolcuAdi.Text = "Adı:";
            // 
            // lblYolcuSoyadi
            // 
            lblYolcuSoyadi.AutoSize = true;
            lblYolcuSoyadi.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYolcuSoyadi.ForeColor = Color.FromArgb(33, 140, 116);
            lblYolcuSoyadi.Location = new Point(498, 167);
            lblYolcuSoyadi.Name = "lblYolcuSoyadi";
            lblYolcuSoyadi.Size = new Size(108, 40);
            lblYolcuSoyadi.TabIndex = 48;
            lblYolcuSoyadi.Text = "Soyadı:";
            // 
            // lblYolcuTc
            // 
            lblYolcuTc.AutoSize = true;
            lblYolcuTc.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYolcuTc.ForeColor = Color.FromArgb(33, 140, 116);
            lblYolcuTc.Location = new Point(498, 230);
            lblYolcuTc.Name = "lblYolcuTc";
            lblYolcuTc.Size = new Size(129, 40);
            lblYolcuTc.TabIndex = 49;
            lblYolcuTc.Text = "Yolcu TC:";
            // 
            // YEkleTelNoMTb
            // 
            YEkleTelNoMTb.Font = new Font("Segoe UI", 18F);
            YEkleTelNoMTb.ForeColor = Color.FromArgb(30, 39, 46);
            YEkleTelNoMTb.Location = new Point(633, 302);
            YEkleTelNoMTb.Mask = "(999) 000-0000";
            YEkleTelNoMTb.Name = "YEkleTelNoMTb";
            YEkleTelNoMTb.Size = new Size(239, 39);
            YEkleTelNoMTb.TabIndex = 50;
            // 
            // lblYolcuTelNo
            // 
            lblYolcuTelNo.AutoSize = true;
            lblYolcuTelNo.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYolcuTelNo.ForeColor = Color.FromArgb(33, 140, 116);
            lblYolcuTelNo.Location = new Point(498, 302);
            lblYolcuTelNo.Name = "lblYolcuTelNo";
            lblYolcuTelNo.Size = new Size(131, 40);
            lblYolcuTelNo.TabIndex = 51;
            lblYolcuTelNo.Text = "Yolcu Tel:";
            // 
            // YEkleAdiTb
            // 
            YEkleAdiTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YEkleAdiTb.ForeColor = Color.FromArgb(30, 39, 46);
            YEkleAdiTb.Location = new Point(633, 104);
            YEkleAdiTb.Name = "YEkleAdiTb";
            YEkleAdiTb.Size = new Size(239, 39);
            YEkleAdiTb.TabIndex = 52;
            // 
            // YEkleSoyadiTb
            // 
            YEkleSoyadiTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YEkleSoyadiTb.ForeColor = Color.FromArgb(30, 39, 46);
            YEkleSoyadiTb.Location = new Point(633, 168);
            YEkleSoyadiTb.Name = "YEkleSoyadiTb";
            YEkleSoyadiTb.Size = new Size(239, 39);
            YEkleSoyadiTb.TabIndex = 53;
            // 
            // YEkleYolcuTcMTb
            // 
            YEkleYolcuTcMTb.Font = new Font("Segoe UI", 18F);
            YEkleYolcuTcMTb.ForeColor = Color.FromArgb(30, 39, 46);
            YEkleYolcuTcMTb.Location = new Point(633, 233);
            YEkleYolcuTcMTb.Mask = "00000000000";
            YEkleYolcuTcMTb.Name = "YEkleYolcuTcMTb";
            YEkleYolcuTcMTb.Size = new Size(239, 39);
            YEkleYolcuTcMTb.TabIndex = 54;
            YEkleYolcuTcMTb.ValidatingType = typeof(int);
            // 
            // lblYEkleKullaniciTc
            // 
            lblYEkleKullaniciTc.AutoSize = true;
            lblYEkleKullaniciTc.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYEkleKullaniciTc.ForeColor = Color.FromArgb(33, 140, 116);
            lblYEkleKullaniciTc.Location = new Point(498, 366);
            lblYEkleKullaniciTc.Name = "lblYEkleKullaniciTc";
            lblYEkleKullaniciTc.Size = new Size(161, 40);
            lblYEkleKullaniciTc.TabIndex = 55;
            lblYEkleKullaniciTc.Text = "Kullanıcı Tc:";
            // 
            // YEkleKullaniciTcMTb
            // 
            YEkleKullaniciTcMTb.Font = new Font("Segoe UI", 18F);
            YEkleKullaniciTcMTb.ForeColor = Color.FromArgb(30, 39, 46);
            YEkleKullaniciTcMTb.Location = new Point(663, 366);
            YEkleKullaniciTcMTb.Mask = "00000000000";
            YEkleKullaniciTcMTb.Name = "YEkleKullaniciTcMTb";
            YEkleKullaniciTcMTb.Size = new Size(199, 39);
            YEkleKullaniciTcMTb.TabIndex = 56;
            YEkleKullaniciTcMTb.ValidatingType = typeof(int);
            // 
            // btnYolcuEkle
            // 
            btnYolcuEkle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnYolcuEkle.ForeColor = Color.FromArgb(179, 57, 57);
            btnYolcuEkle.Location = new Point(546, 438);
            btnYolcuEkle.Name = "btnYolcuEkle";
            btnYolcuEkle.Size = new Size(285, 51);
            btnYolcuEkle.TabIndex = 57;
            btnYolcuEkle.Text = "Yolcu Ekle";
            btnYolcuEkle.UseVisualStyleBackColor = true;
            // 
            // YolcularimForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(btnYolcuEkle);
            Controls.Add(YEkleKullaniciTcMTb);
            Controls.Add(lblYEkleKullaniciTc);
            Controls.Add(YEkleYolcuTcMTb);
            Controls.Add(YEkleSoyadiTb);
            Controls.Add(YEkleAdiTb);
            Controls.Add(lblYolcuTelNo);
            Controls.Add(YEkleTelNoMTb);
            Controls.Add(lblYolcuTc);
            Controls.Add(lblYolcuSoyadi);
            Controls.Add(lblYolcuAdi);
            Controls.Add(lblYolcuEkle);
            Controls.Add(pictureBox1);
            Controls.Add(lblYolcularim);
            Controls.Add(YolcularimGoruntuleDgv);
            Controls.Add(YolcularimMenu);
            Name = "YolcularimForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YolcularimForm";
            YolcularimMenu.ResumeLayout(false);
            YolcularimMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)YolcularimGoruntuleDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip YolcularimMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private ToolStripMenuItem kullanıcıMenüToolStripMenuItem;
        private DataGridView YolcularimGoruntuleDgv;
        private Label lblYolcularim;
        private PictureBox pictureBox1;
        private Label lblYolcuEkle;
        private Label lblYolcuAdi;
        private Label lblYolcuSoyadi;
        private Label lblYolcuTc;
        private MaskedTextBox YEkleTelNoMTb;
        private Label lblYolcuTelNo;
        private TextBox YEkleAdiTb;
        private TextBox YEkleSoyadiTb;
        private MaskedTextBox YEkleYolcuTcMTb;
        private Label lblYEkleKullaniciTc;
        private MaskedTextBox YEkleKullaniciTcMTb;
        private Button btnYolcuEkle;
    }
}