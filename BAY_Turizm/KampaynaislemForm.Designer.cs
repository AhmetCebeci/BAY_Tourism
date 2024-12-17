namespace BAY_Turizm
{
    partial class KampaynaislemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KampaynaislemForm));
            KampanyaislemMenu = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            adminMenüToolStripMenuItem = new ToolStripMenuItem();
            btnKampanyaSil = new Button();
            AdminKampanyaGoruntuleDgv = new DataGridView();
            lblKampanyaSil = new Label();
            pictureBox1 = new PictureBox();
            KEkleKampanyaIdMTb = new MaskedTextBox();
            lblKampanyaId = new Label();
            lblKampanyaMiktari = new Label();
            lblKampanyaEkle = new Label();
            KEkleKampanyaMiktariMTb = new MaskedTextBox();
            btnKampanyaEkle = new Button();
            pictureBox2 = new PictureBox();
            KampanyaislemMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminKampanyaGoruntuleDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // KampanyaislemMenu
            // 
            KampanyaislemMenu.BackColor = Color.FromArgb(109, 33, 79);
            KampanyaislemMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KampanyaislemMenu.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem, adminMenüToolStripMenuItem });
            KampanyaislemMenu.Location = new Point(0, 0);
            KampanyaislemMenu.Name = "KampanyaislemMenu";
            KampanyaislemMenu.Size = new Size(884, 29);
            KampanyaislemMenu.TabIndex = 3;
            KampanyaislemMenu.Text = "menuStrip1";
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
            // btnKampanyaSil
            // 
            btnKampanyaSil.BackColor = Color.White;
            btnKampanyaSil.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            btnKampanyaSil.ForeColor = Color.FromArgb(179, 57, 57);
            btnKampanyaSil.Location = new Point(605, 92);
            btnKampanyaSil.Name = "btnKampanyaSil";
            btnKampanyaSil.Size = new Size(267, 38);
            btnKampanyaSil.TabIndex = 36;
            btnKampanyaSil.Text = "Seçilen Kampanyayı Sil";
            btnKampanyaSil.UseVisualStyleBackColor = false;
            // 
            // AdminKampanyaGoruntuleDgv
            // 
            AdminKampanyaGoruntuleDgv.BackgroundColor = Color.White;
            AdminKampanyaGoruntuleDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminKampanyaGoruntuleDgv.GridColor = Color.FromArgb(30, 39, 46);
            AdminKampanyaGoruntuleDgv.Location = new Point(12, 92);
            AdminKampanyaGoruntuleDgv.Name = "AdminKampanyaGoruntuleDgv";
            AdminKampanyaGoruntuleDgv.Size = new Size(575, 38);
            AdminKampanyaGoruntuleDgv.TabIndex = 38;
            // 
            // lblKampanyaSil
            // 
            lblKampanyaSil.AutoSize = true;
            lblKampanyaSil.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKampanyaSil.ForeColor = Color.FromArgb(44, 44, 84);
            lblKampanyaSil.Location = new Point(237, 41);
            lblKampanyaSil.Name = "lblKampanyaSil";
            lblKampanyaSil.Size = new Size(310, 40);
            lblKampanyaSil.TabIndex = 39;
            lblKampanyaSil.Text = "Kampanya Silme İşlemi";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(109, 33, 79);
            pictureBox1.Location = new Point(0, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(884, 10);
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // KEkleKampanyaIdMTb
            // 
            KEkleKampanyaIdMTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KEkleKampanyaIdMTb.ForeColor = Color.FromArgb(30, 39, 46);
            KEkleKampanyaIdMTb.Location = new Point(274, 242);
            KEkleKampanyaIdMTb.Mask = "00000";
            KEkleKampanyaIdMTb.Name = "KEkleKampanyaIdMTb";
            KEkleKampanyaIdMTb.Size = new Size(209, 39);
            KEkleKampanyaIdMTb.TabIndex = 41;
            KEkleKampanyaIdMTb.ValidatingType = typeof(int);
            // 
            // lblKampanyaId
            // 
            lblKampanyaId.AutoSize = true;
            lblKampanyaId.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKampanyaId.ForeColor = Color.FromArgb(33, 140, 116);
            lblKampanyaId.Location = new Point(12, 242);
            lblKampanyaId.Name = "lblKampanyaId";
            lblKampanyaId.Size = new Size(193, 40);
            lblKampanyaId.TabIndex = 43;
            lblKampanyaId.Text = "Kampanya ID:";
            // 
            // lblKampanyaMiktari
            // 
            lblKampanyaMiktari.AutoSize = true;
            lblKampanyaMiktari.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKampanyaMiktari.ForeColor = Color.FromArgb(33, 140, 116);
            lblKampanyaMiktari.Location = new Point(12, 341);
            lblKampanyaMiktari.Name = "lblKampanyaMiktari";
            lblKampanyaMiktari.Size = new Size(254, 40);
            lblKampanyaMiktari.TabIndex = 44;
            lblKampanyaMiktari.Text = "Kampanya Miktarı:";
            // 
            // lblKampanyaEkle
            // 
            lblKampanyaEkle.AutoSize = true;
            lblKampanyaEkle.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKampanyaEkle.ForeColor = Color.FromArgb(44, 44, 84);
            lblKampanyaEkle.Location = new Point(237, 158);
            lblKampanyaEkle.Name = "lblKampanyaEkle";
            lblKampanyaEkle.Size = new Size(332, 40);
            lblKampanyaEkle.TabIndex = 45;
            lblKampanyaEkle.Text = "Kampanya Ekleme İşlemi";
            // 
            // KEkleKampanyaMiktariMTb
            // 
            KEkleKampanyaMiktariMTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KEkleKampanyaMiktariMTb.ForeColor = Color.FromArgb(30, 39, 46);
            KEkleKampanyaMiktariMTb.Location = new Point(274, 341);
            KEkleKampanyaMiktariMTb.Mask = "00000";
            KEkleKampanyaMiktariMTb.Name = "KEkleKampanyaMiktariMTb";
            KEkleKampanyaMiktariMTb.Size = new Size(209, 39);
            KEkleKampanyaMiktariMTb.TabIndex = 46;
            KEkleKampanyaMiktariMTb.ValidatingType = typeof(int);
            // 
            // btnKampanyaEkle
            // 
            btnKampanyaEkle.BackColor = Color.White;
            btnKampanyaEkle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            btnKampanyaEkle.ForeColor = Color.FromArgb(179, 57, 57);
            btnKampanyaEkle.Location = new Point(93, 425);
            btnKampanyaEkle.Name = "btnKampanyaEkle";
            btnKampanyaEkle.Size = new Size(314, 71);
            btnKampanyaEkle.TabIndex = 47;
            btnKampanyaEkle.Text = "Kampanya Ekle";
            btnKampanyaEkle.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(510, 218);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(362, 331);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // KampaynaislemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(pictureBox2);
            Controls.Add(btnKampanyaEkle);
            Controls.Add(KEkleKampanyaMiktariMTb);
            Controls.Add(lblKampanyaEkle);
            Controls.Add(lblKampanyaMiktari);
            Controls.Add(lblKampanyaId);
            Controls.Add(KEkleKampanyaIdMTb);
            Controls.Add(pictureBox1);
            Controls.Add(lblKampanyaSil);
            Controls.Add(AdminKampanyaGoruntuleDgv);
            Controls.Add(btnKampanyaSil);
            Controls.Add(KampanyaislemMenu);
            Name = "KampaynaislemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kampanya İşlemleri";
            Load += KampaynaislemForm_Load;
            KampanyaislemMenu.ResumeLayout(false);
            KampanyaislemMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminKampanyaGoruntuleDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip KampanyaislemMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private ToolStripMenuItem adminMenüToolStripMenuItem;
        private Button btnKampanyaSil;
        private Label lblKampanyalar;
        private DataGridView AdminKampanyaGoruntuleDgv;
        private Label lblKampanyaSil;
        private PictureBox pictureBox1;
        private MaskedTextBox KEkleKampanyaIdMTb;
        private Label lblKampanyaId;
        private Label lblKampanyaMiktari;
        private Label lblKampanyaEkle;
        private MaskedTextBox KEkleKampanyaMiktariMTb;
        private Button btnKampanyaEkle;
        private PictureBox pictureBox2;
    }
}