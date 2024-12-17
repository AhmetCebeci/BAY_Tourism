namespace BAY_Turizm
{
    partial class OtobusislemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtobusislemForm));
            OtobusislemMenu = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            adminMenüToolStripMenuItem = new ToolStripMenuItem();
            oSilOtobuslerCb = new ComboBox();
            btnOtobusSil = new Button();
            pictureBox1 = new PictureBox();
            lblOtobusSil = new Label();
            lblOtobusEkle = new Label();
            lblOtobusPlaka = new Label();
            OEklePlakaTb = new TextBox();
            lblModel = new Label();
            OEkleModelTb = new TextBox();
            lblOEkleFirmaId = new Label();
            btnOtobusEkle = new Button();
            pictureBox2 = new PictureBox();
            OEkleFirmaIdCb = new ComboBox();
            OtobusislemMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // OtobusislemMenu
            // 
            OtobusislemMenu.BackColor = Color.FromArgb(109, 33, 79);
            OtobusislemMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OtobusislemMenu.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem, adminMenüToolStripMenuItem });
            OtobusislemMenu.Location = new Point(0, 0);
            OtobusislemMenu.Name = "OtobusislemMenu";
            OtobusislemMenu.Size = new Size(884, 29);
            OtobusislemMenu.TabIndex = 2;
            OtobusislemMenu.Text = "Otobüs İşlemleri";
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
            // oSilOtobuslerCb
            // 
            oSilOtobuslerCb.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oSilOtobuslerCb.ForeColor = Color.FromArgb(30, 39, 46);
            oSilOtobuslerCb.FormattingEnabled = true;
            oSilOtobuslerCb.Location = new Point(12, 79);
            oSilOtobuslerCb.Name = "oSilOtobuslerCb";
            oSilOtobuslerCb.Size = new Size(597, 45);
            oSilOtobuslerCb.TabIndex = 3;
            // 
            // btnOtobusSil
            // 
            btnOtobusSil.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOtobusSil.ForeColor = Color.FromArgb(179, 57, 57);
            btnOtobusSil.Location = new Point(629, 79);
            btnOtobusSil.Name = "btnOtobusSil";
            btnOtobusSil.Size = new Size(243, 45);
            btnOtobusSil.TabIndex = 23;
            btnOtobusSil.Text = "Seçilen Otobüsü Sil";
            btnOtobusSil.UseVisualStyleBackColor = true;
            btnOtobusSil.Click += btnOtobusSil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(109, 33, 79);
            pictureBox1.Location = new Point(0, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(884, 10);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // lblOtobusSil
            // 
            lblOtobusSil.AutoSize = true;
            lblOtobusSil.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOtobusSil.ForeColor = Color.FromArgb(44, 44, 84);
            lblOtobusSil.Location = new Point(279, 29);
            lblOtobusSil.Name = "lblOtobusSil";
            lblOtobusSil.Size = new Size(270, 40);
            lblOtobusSil.TabIndex = 27;
            lblOtobusSil.Text = "Otobüs Silme İşlemi";
            // 
            // lblOtobusEkle
            // 
            lblOtobusEkle.AutoSize = true;
            lblOtobusEkle.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOtobusEkle.ForeColor = Color.FromArgb(44, 44, 84);
            lblOtobusEkle.Location = new Point(279, 156);
            lblOtobusEkle.Name = "lblOtobusEkle";
            lblOtobusEkle.Size = new Size(292, 40);
            lblOtobusEkle.TabIndex = 28;
            lblOtobusEkle.Text = "Otobüs Ekleme İşlemi";
            // 
            // lblOtobusPlaka
            // 
            lblOtobusPlaka.AutoSize = true;
            lblOtobusPlaka.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOtobusPlaka.ForeColor = Color.FromArgb(33, 140, 116);
            lblOtobusPlaka.Location = new Point(10, 236);
            lblOtobusPlaka.Name = "lblOtobusPlaka";
            lblOtobusPlaka.Size = new Size(90, 40);
            lblOtobusPlaka.TabIndex = 29;
            lblOtobusPlaka.Text = "Plaka:";
            // 
            // OEklePlakaTb
            // 
            OEklePlakaTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OEklePlakaTb.ForeColor = Color.FromArgb(30, 39, 46);
            OEklePlakaTb.Location = new Point(176, 237);
            OEklePlakaTb.Name = "OEklePlakaTb";
            OEklePlakaTb.Size = new Size(197, 39);
            OEklePlakaTb.TabIndex = 30;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModel.ForeColor = Color.FromArgb(33, 140, 116);
            lblModel.Location = new Point(12, 310);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(105, 40);
            lblModel.TabIndex = 31;
            lblModel.Text = "Model:";
            // 
            // OEkleModelTb
            // 
            OEkleModelTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OEkleModelTb.ForeColor = Color.FromArgb(30, 39, 46);
            OEkleModelTb.Location = new Point(176, 310);
            OEkleModelTb.Name = "OEkleModelTb";
            OEkleModelTb.Size = new Size(197, 39);
            OEkleModelTb.TabIndex = 32;
            // 
            // lblOEkleFirmaId
            // 
            lblOEkleFirmaId.AutoSize = true;
            lblOEkleFirmaId.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOEkleFirmaId.ForeColor = Color.FromArgb(33, 140, 116);
            lblOEkleFirmaId.Location = new Point(12, 378);
            lblOEkleFirmaId.Name = "lblOEkleFirmaId";
            lblOEkleFirmaId.Size = new Size(127, 40);
            lblOEkleFirmaId.TabIndex = 34;
            lblOEkleFirmaId.Text = "Firma Id:";
            lblOEkleFirmaId.Click += lblFirmaNo_Click;
            // 
            // btnOtobusEkle
            // 
            btnOtobusEkle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOtobusEkle.ForeColor = Color.FromArgb(179, 57, 57);
            btnOtobusEkle.Location = new Point(41, 458);
            btnOtobusEkle.Name = "btnOtobusEkle";
            btnOtobusEkle.Size = new Size(315, 58);
            btnOtobusEkle.TabIndex = 35;
            btnOtobusEkle.Text = "Otobüs Ekle";
            btnOtobusEkle.UseVisualStyleBackColor = true;
            btnOtobusEkle.Click += btnOtobusEkle_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(482, 223);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(367, 326);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // OEkleFirmaIdCb
            // 
            OEkleFirmaIdCb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OEkleFirmaIdCb.ForeColor = Color.FromArgb(30, 39, 46);
            OEkleFirmaIdCb.FormattingEnabled = true;
            OEkleFirmaIdCb.Location = new Point(176, 378);
            OEkleFirmaIdCb.Name = "OEkleFirmaIdCb";
            OEkleFirmaIdCb.Size = new Size(197, 40);
            OEkleFirmaIdCb.TabIndex = 37;
            // 
            // OtobusislemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(OEkleFirmaIdCb);
            Controls.Add(pictureBox2);
            Controls.Add(btnOtobusEkle);
            Controls.Add(lblOEkleFirmaId);
            Controls.Add(OEkleModelTb);
            Controls.Add(lblModel);
            Controls.Add(OEklePlakaTb);
            Controls.Add(lblOtobusPlaka);
            Controls.Add(lblOtobusEkle);
            Controls.Add(lblOtobusSil);
            Controls.Add(pictureBox1);
            Controls.Add(btnOtobusSil);
            Controls.Add(oSilOtobuslerCb);
            Controls.Add(OtobusislemMenu);
            Name = "OtobusislemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Otobüs İşlemleri";
            Load += OtobusislemForm_Load;
            OtobusislemMenu.ResumeLayout(false);
            OtobusislemMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip OtobusislemMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private ToolStripMenuItem adminMenüToolStripMenuItem;
        private ComboBox oSilOtobuslerCb;
        private Button btnOtobusSil;
        private PictureBox pictureBox1;
        private Label lblOtobusSil;
        private Label lblOtobusEkle;
        private Label lblOtobusPlaka;
        private TextBox OEklePlakaTb;
        private Label lblModel;
        private TextBox OEkleModelTb;
        private Label lblOEkleFirmaId;
        private Button btnOtobusEkle;
        private PictureBox pictureBox2;
        private ComboBox OEkleFirmaIdCb;
    }
}