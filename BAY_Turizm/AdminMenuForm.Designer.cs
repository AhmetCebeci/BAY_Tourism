namespace BAY_Turizm
{
    partial class AdminMenuForm
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
            AdminMenu = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            btnSeferislem = new Button();
            btnFirmaislem = new Button();
            btnOtobusislem = new Button();
            btnTerminalislem = new Button();
            btnYorumislem = new Button();
            btnFaturaislem = new Button();
            btnAdminHesapIslem = new Button();
            btnKampanyaIslem = new Button();
            AdminMenu.SuspendLayout();
            SuspendLayout();
            // 
            // AdminMenu
            // 
            AdminMenu.BackColor = Color.FromArgb(109, 33, 79);
            AdminMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminMenu.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem });
            AdminMenu.Location = new Point(0, 0);
            AdminMenu.Name = "AdminMenu";
            AdminMenu.Size = new Size(884, 29);
            AdminMenu.TabIndex = 1;
            AdminMenu.Text = "menuStrip1";
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
            // btnSeferislem
            // 
            btnSeferislem.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSeferislem.ForeColor = Color.FromArgb(179, 57, 57);
            btnSeferislem.Location = new Point(12, 79);
            btnSeferislem.Name = "btnSeferislem";
            btnSeferislem.Size = new Size(365, 80);
            btnSeferislem.TabIndex = 21;
            btnSeferislem.Text = "Sefer İşlemleri";
            btnSeferislem.UseVisualStyleBackColor = true;
            btnSeferislem.Click += btnSeferislem_Click;
            // 
            // btnFirmaislem
            // 
            btnFirmaislem.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFirmaislem.ForeColor = Color.FromArgb(179, 57, 57);
            btnFirmaislem.Location = new Point(455, 79);
            btnFirmaislem.Name = "btnFirmaislem";
            btnFirmaislem.Size = new Size(365, 80);
            btnFirmaislem.TabIndex = 22;
            btnFirmaislem.Text = "Firma İşlemleri";
            btnFirmaislem.UseVisualStyleBackColor = true;
            btnFirmaislem.Click += btnFirmaislem_Click;
            // 
            // btnOtobusislem
            // 
            btnOtobusislem.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOtobusislem.ForeColor = Color.FromArgb(179, 57, 57);
            btnOtobusislem.Location = new Point(12, 194);
            btnOtobusislem.Name = "btnOtobusislem";
            btnOtobusislem.Size = new Size(365, 80);
            btnOtobusislem.TabIndex = 23;
            btnOtobusislem.Text = "Otobüs İşlemleri";
            btnOtobusislem.UseVisualStyleBackColor = true;
            btnOtobusislem.Click += btnOtobusislem_Click;
            // 
            // btnTerminalislem
            // 
            btnTerminalislem.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTerminalislem.ForeColor = Color.FromArgb(179, 57, 57);
            btnTerminalislem.Location = new Point(455, 194);
            btnTerminalislem.Name = "btnTerminalislem";
            btnTerminalislem.Size = new Size(365, 80);
            btnTerminalislem.TabIndex = 24;
            btnTerminalislem.Text = "Terminal İşlemleri";
            btnTerminalislem.UseVisualStyleBackColor = true;
            btnTerminalislem.Click += btnTerminalislem_Click;
            // 
            // btnYorumislem
            // 
            btnYorumislem.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnYorumislem.ForeColor = Color.FromArgb(179, 57, 57);
            btnYorumislem.Location = new Point(12, 318);
            btnYorumislem.Name = "btnYorumislem";
            btnYorumislem.Size = new Size(365, 80);
            btnYorumislem.TabIndex = 25;
            btnYorumislem.Text = "Yorum İşlemleri";
            btnYorumislem.UseVisualStyleBackColor = true;
            btnYorumislem.Click += btnYorumislem_Click;
            // 
            // btnFaturaislem
            // 
            btnFaturaislem.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFaturaislem.ForeColor = Color.FromArgb(179, 57, 57);
            btnFaturaislem.Location = new Point(455, 318);
            btnFaturaislem.Name = "btnFaturaislem";
            btnFaturaislem.Size = new Size(365, 80);
            btnFaturaislem.TabIndex = 26;
            btnFaturaislem.Text = "Fatura İşlemleri";
            btnFaturaislem.UseVisualStyleBackColor = true;
            btnFaturaislem.Click += btnFaturaislem_Click;
            // 
            // btnAdminHesapIslem
            // 
            btnAdminHesapIslem.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdminHesapIslem.ForeColor = Color.FromArgb(179, 57, 57);
            btnAdminHesapIslem.Location = new Point(455, 434);
            btnAdminHesapIslem.Name = "btnAdminHesapIslem";
            btnAdminHesapIslem.Size = new Size(365, 80);
            btnAdminHesapIslem.TabIndex = 27;
            btnAdminHesapIslem.Text = "Admin Hesap İşlemleri";
            btnAdminHesapIslem.UseVisualStyleBackColor = true;
            btnAdminHesapIslem.Click += btnAdminHesapIslem_Click;
            // 
            // btnKampanyaIslem
            // 
            btnKampanyaIslem.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKampanyaIslem.ForeColor = Color.FromArgb(179, 57, 57);
            btnKampanyaIslem.Location = new Point(12, 434);
            btnKampanyaIslem.Name = "btnKampanyaIslem";
            btnKampanyaIslem.Size = new Size(365, 80);
            btnKampanyaIslem.TabIndex = 28;
            btnKampanyaIslem.Text = "Kampanya İşlemleri";
            btnKampanyaIslem.UseVisualStyleBackColor = true;
            btnKampanyaIslem.Click += btnKampanyaIslem_Click;
            // 
            // AdminMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(btnKampanyaIslem);
            Controls.Add(btnAdminHesapIslem);
            Controls.Add(btnFaturaislem);
            Controls.Add(btnYorumislem);
            Controls.Add(btnTerminalislem);
            Controls.Add(btnOtobusislem);
            Controls.Add(btnFirmaislem);
            Controls.Add(btnSeferislem);
            Controls.Add(AdminMenu);
            Name = "AdminMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Menüsü";
            Load += AdminMenuForm_Load;
            AdminMenu.ResumeLayout(false);
            AdminMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip AdminMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private Button btnSeferislem;
        private Button btnFirmaislem;
        private Button btnOtobusislem;
        private Button btnTerminalislem;
        private Button btnYorumislem;
        private Button btnFaturaislem;
        private Button btnAdminHesapIslem;
        private Button btnKampanyaIslem;
    }
}