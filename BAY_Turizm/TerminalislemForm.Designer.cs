namespace BAY_Turizm
{
    partial class TerminalislemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminalislemForm));
            TerminalislemMenu = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            adminMenüToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            TSilTerminallerCb = new ComboBox();
            btnTerminalSil = new Button();
            lblTerminalSil = new Label();
            lblTerminalEkle = new Label();
            lblTEkleSehirId = new Label();
            lblTEkleTerminalAdi = new Label();
            btnTerminalEkle = new Button();
            TEkleSehirIdCb = new ComboBox();
            TEkleTerminalAdiTb = new TextBox();
            pictureBox2 = new PictureBox();
            TerminalislemMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TerminalislemMenu
            // 
            TerminalislemMenu.BackColor = Color.FromArgb(109, 33, 79);
            TerminalislemMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TerminalislemMenu.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem, adminMenüToolStripMenuItem });
            TerminalislemMenu.Location = new Point(0, 0);
            TerminalislemMenu.Name = "TerminalislemMenu";
            TerminalislemMenu.Size = new Size(884, 29);
            TerminalislemMenu.TabIndex = 2;
            TerminalislemMenu.Text = "menuStrip1";
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
            pictureBox1.Location = new Point(0, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(884, 10);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // TSilTerminallerCb
            // 
            TSilTerminallerCb.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TSilTerminallerCb.ForeColor = Color.FromArgb(30, 39, 46);
            TSilTerminallerCb.FormattingEnabled = true;
            TSilTerminallerCb.Location = new Point(12, 83);
            TSilTerminallerCb.Name = "TSilTerminallerCb";
            TSilTerminallerCb.Size = new Size(594, 45);
            TSilTerminallerCb.TabIndex = 26;
            // 
            // btnTerminalSil
            // 
            btnTerminalSil.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTerminalSil.ForeColor = Color.FromArgb(179, 57, 57);
            btnTerminalSil.Location = new Point(631, 83);
            btnTerminalSil.Name = "btnTerminalSil";
            btnTerminalSil.Size = new Size(241, 45);
            btnTerminalSil.TabIndex = 28;
            btnTerminalSil.Text = "Seçilen Terminali Sil";
            btnTerminalSil.UseVisualStyleBackColor = true;
            // 
            // lblTerminalSil
            // 
            lblTerminalSil.AutoSize = true;
            lblTerminalSil.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTerminalSil.ForeColor = Color.FromArgb(44, 44, 84);
            lblTerminalSil.Location = new Point(285, 29);
            lblTerminalSil.Name = "lblTerminalSil";
            lblTerminalSil.Size = new Size(283, 40);
            lblTerminalSil.TabIndex = 29;
            lblTerminalSil.Text = "Terminal Silme İşlemi";
            // 
            // lblTerminalEkle
            // 
            lblTerminalEkle.AutoSize = true;
            lblTerminalEkle.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTerminalEkle.ForeColor = Color.FromArgb(44, 44, 84);
            lblTerminalEkle.Location = new Point(285, 164);
            lblTerminalEkle.Name = "lblTerminalEkle";
            lblTerminalEkle.Size = new Size(305, 40);
            lblTerminalEkle.TabIndex = 30;
            lblTerminalEkle.Text = "Terminal Ekleme İşlemi";
            // 
            // lblTEkleSehirId
            // 
            lblTEkleSehirId.AutoSize = true;
            lblTEkleSehirId.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTEkleSehirId.ForeColor = Color.FromArgb(33, 140, 116);
            lblTEkleSehirId.Location = new Point(12, 243);
            lblTEkleSehirId.Name = "lblTEkleSehirId";
            lblTEkleSehirId.Size = new Size(122, 40);
            lblTEkleSehirId.TabIndex = 31;
            lblTEkleSehirId.Text = "Şehir ID:";
            // 
            // lblTEkleTerminalAdi
            // 
            lblTEkleTerminalAdi.AutoSize = true;
            lblTEkleTerminalAdi.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTEkleTerminalAdi.ForeColor = Color.FromArgb(33, 140, 116);
            lblTEkleTerminalAdi.Location = new Point(12, 318);
            lblTEkleTerminalAdi.Name = "lblTEkleTerminalAdi";
            lblTEkleTerminalAdi.Size = new Size(181, 40);
            lblTEkleTerminalAdi.TabIndex = 33;
            lblTEkleTerminalAdi.Text = "Terminal Adı:";
            // 
            // btnTerminalEkle
            // 
            btnTerminalEkle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTerminalEkle.ForeColor = Color.FromArgb(179, 57, 57);
            btnTerminalEkle.Location = new Point(72, 405);
            btnTerminalEkle.Name = "btnTerminalEkle";
            btnTerminalEkle.Size = new Size(280, 65);
            btnTerminalEkle.TabIndex = 34;
            btnTerminalEkle.Text = "Terminal Ekle";
            btnTerminalEkle.UseVisualStyleBackColor = true;
            btnTerminalEkle.Click += btnTerminalEkle_Click;
            // 
            // TEkleSehirIdCb
            // 
            TEkleSehirIdCb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TEkleSehirIdCb.ForeColor = Color.FromArgb(30, 39, 46);
            TEkleSehirIdCb.FormattingEnabled = true;
            TEkleSehirIdCb.Location = new Point(168, 243);
            TEkleSehirIdCb.Name = "TEkleSehirIdCb";
            TEkleSehirIdCb.Size = new Size(239, 40);
            TEkleSehirIdCb.TabIndex = 38;
            // 
            // TEkleTerminalAdiTb
            // 
            TEkleTerminalAdiTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TEkleTerminalAdiTb.ForeColor = Color.FromArgb(30, 39, 46);
            TEkleTerminalAdiTb.Location = new Point(210, 319);
            TEkleTerminalAdiTb.Name = "TEkleTerminalAdiTb";
            TEkleTerminalAdiTb.Size = new Size(197, 39);
            TEkleTerminalAdiTb.TabIndex = 39;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(471, 243);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(391, 289);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // TerminalislemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(pictureBox2);
            Controls.Add(TEkleTerminalAdiTb);
            Controls.Add(TEkleSehirIdCb);
            Controls.Add(btnTerminalEkle);
            Controls.Add(lblTEkleTerminalAdi);
            Controls.Add(lblTEkleSehirId);
            Controls.Add(lblTerminalEkle);
            Controls.Add(lblTerminalSil);
            Controls.Add(btnTerminalSil);
            Controls.Add(TSilTerminallerCb);
            Controls.Add(pictureBox1);
            Controls.Add(TerminalislemMenu);
            Name = "TerminalislemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Terminal İşlemleri";
            TerminalislemMenu.ResumeLayout(false);
            TerminalislemMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip TerminalislemMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private ToolStripMenuItem adminMenüToolStripMenuItem;
        private PictureBox pictureBox1;
        private ComboBox TSilTerminallerCb;
        private Button btnTerminalSil;
        private Label lblTerminalSil;
        private Label lblTerminalEkle;
        private Label lblTEkleSehirId;
        private Label lblTEkleTerminalAdi;
        private Button btnTerminalEkle;
        private ComboBox TEkleSehirIdCb;
        private TextBox TEkleTerminalAdiTb;
        private PictureBox pictureBox2;
    }
}