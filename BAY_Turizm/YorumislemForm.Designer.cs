namespace BAY_Turizm
{
    partial class YorumislemForm
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
            YorumislemMenu = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            adminMenüToolStripMenuItem = new ToolStripMenuItem();
            lblYorumlar = new Label();
            lblYorumSilGoruntule = new Label();
            btnYorumSil = new Button();
            AdminYorumGoruntuleDgv = new DataGridView();
            YorumislemMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminYorumGoruntuleDgv).BeginInit();
            SuspendLayout();
            // 
            // YorumislemMenu
            // 
            YorumislemMenu.BackColor = Color.FromArgb(109, 33, 79);
            YorumislemMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YorumislemMenu.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem, adminMenüToolStripMenuItem });
            YorumislemMenu.Location = new Point(0, 0);
            YorumislemMenu.Name = "YorumislemMenu";
            YorumislemMenu.Size = new Size(884, 29);
            YorumislemMenu.TabIndex = 2;
            YorumislemMenu.Text = "menuStrip1";
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
            // lblYorumlar
            // 
            lblYorumlar.AutoSize = true;
            lblYorumlar.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYorumlar.ForeColor = Color.FromArgb(33, 140, 116);
            lblYorumlar.Location = new Point(12, 72);
            lblYorumlar.Name = "lblYorumlar";
            lblYorumlar.Size = new Size(136, 40);
            lblYorumlar.TabIndex = 28;
            lblYorumlar.Text = "Yorumlar:";
            // 
            // lblYorumSilGoruntule
            // 
            lblYorumSilGoruntule.AutoSize = true;
            lblYorumSilGoruntule.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYorumSilGoruntule.ForeColor = Color.FromArgb(44, 44, 84);
            lblYorumSilGoruntule.Location = new Point(168, 29);
            lblYorumSilGoruntule.Name = "lblYorumSilGoruntule";
            lblYorumSilGoruntule.Size = new Size(469, 40);
            lblYorumSilGoruntule.TabIndex = 30;
            lblYorumSilGoruntule.Text = "Yorum Görüntüleme ve Silme İşlemi";
            // 
            // btnYorumSil
            // 
            btnYorumSil.BackColor = Color.White;
            btnYorumSil.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnYorumSil.ForeColor = Color.FromArgb(179, 57, 57);
            btnYorumSil.Location = new Point(643, 67);
            btnYorumSil.Name = "btnYorumSil";
            btnYorumSil.Size = new Size(229, 45);
            btnYorumSil.TabIndex = 31;
            btnYorumSil.Text = "Seçilen Yorumu Sil";
            btnYorumSil.UseVisualStyleBackColor = false;
            // 
            // AdminYorumGoruntuleDgv
            // 
            AdminYorumGoruntuleDgv.BackgroundColor = Color.White;
            AdminYorumGoruntuleDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminYorumGoruntuleDgv.GridColor = Color.FromArgb(30, 39, 46);
            AdminYorumGoruntuleDgv.Location = new Point(12, 118);
            AdminYorumGoruntuleDgv.Name = "AdminYorumGoruntuleDgv";
            AdminYorumGoruntuleDgv.Size = new Size(860, 431);
            AdminYorumGoruntuleDgv.TabIndex = 32;
            // 
            // YorumislemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(AdminYorumGoruntuleDgv);
            Controls.Add(btnYorumSil);
            Controls.Add(lblYorumSilGoruntule);
            Controls.Add(lblYorumlar);
            Controls.Add(YorumislemMenu);
            Name = "YorumislemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yorum İşlemleri";
            YorumislemMenu.ResumeLayout(false);
            YorumislemMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminYorumGoruntuleDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip YorumislemMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private ToolStripMenuItem adminMenüToolStripMenuItem;
        private Label lblYorumlar;
        private Label lblYorumSilGoruntule;
        private Button btnYorumSil;
        private DataGridView AdminYorumGoruntuleDgv;
    }
}