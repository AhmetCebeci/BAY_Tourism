namespace BAY_Turizm
{
    partial class FaturaislemForm
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
            FaturaislemMenu = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            adminMenüToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            AdminFaturaGoruntuleDgv = new DataGridView();
            lblFaturaSilGoruntule = new Label();
            btnFaturaSil = new Button();
            lblFaturalar = new Label();
            FaturaislemMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminFaturaGoruntuleDgv).BeginInit();
            SuspendLayout();
            // 
            // FaturaislemMenu
            // 
            FaturaislemMenu.BackColor = Color.FromArgb(109, 33, 79);
            FaturaislemMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FaturaislemMenu.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem, adminMenüToolStripMenuItem, toolStripMenuItem1 });
            FaturaislemMenu.Location = new Point(0, 0);
            FaturaislemMenu.Name = "FaturaislemMenu";
            FaturaislemMenu.Size = new Size(884, 29);
            FaturaislemMenu.TabIndex = 2;
            FaturaislemMenu.Text = "menuStrip1";
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
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(26, 25);
            toolStripMenuItem1.Text = " ";
            // 
            // AdminFaturaGoruntuleDgv
            // 
            AdminFaturaGoruntuleDgv.BackgroundColor = Color.White;
            AdminFaturaGoruntuleDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminFaturaGoruntuleDgv.GridColor = Color.FromArgb(30, 39, 46);
            AdminFaturaGoruntuleDgv.Location = new Point(12, 133);
            AdminFaturaGoruntuleDgv.Name = "AdminFaturaGoruntuleDgv";
            AdminFaturaGoruntuleDgv.Size = new Size(860, 426);
            AdminFaturaGoruntuleDgv.TabIndex = 33;
            // 
            // lblFaturaSilGoruntule
            // 
            lblFaturaSilGoruntule.AutoSize = true;
            lblFaturaSilGoruntule.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFaturaSilGoruntule.ForeColor = Color.FromArgb(44, 44, 84);
            lblFaturaSilGoruntule.Location = new Point(180, 29);
            lblFaturaSilGoruntule.Name = "lblFaturaSilGoruntule";
            lblFaturaSilGoruntule.Size = new Size(467, 40);
            lblFaturaSilGoruntule.TabIndex = 34;
            lblFaturaSilGoruntule.Text = "Fatura Görüntüleme ve Silme İşlemi";
            // 
            // btnFaturaSil
            // 
            btnFaturaSil.BackColor = Color.White;
            btnFaturaSil.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFaturaSil.ForeColor = Color.FromArgb(179, 57, 57);
            btnFaturaSil.Location = new Point(643, 72);
            btnFaturaSil.Name = "btnFaturaSil";
            btnFaturaSil.Size = new Size(229, 45);
            btnFaturaSil.TabIndex = 35;
            btnFaturaSil.Text = "Seçilen Faturayı Sil";
            btnFaturaSil.UseVisualStyleBackColor = false;
            // 
            // lblFaturalar
            // 
            lblFaturalar.AutoSize = true;
            lblFaturalar.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFaturalar.ForeColor = Color.FromArgb(33, 140, 116);
            lblFaturalar.Location = new Point(12, 77);
            lblFaturalar.Name = "lblFaturalar";
            lblFaturalar.Size = new Size(134, 40);
            lblFaturalar.TabIndex = 36;
            lblFaturalar.Text = "Faturalar:";
            // 
            // FaturaislemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(lblFaturalar);
            Controls.Add(btnFaturaSil);
            Controls.Add(lblFaturaSilGoruntule);
            Controls.Add(AdminFaturaGoruntuleDgv);
            Controls.Add(FaturaislemMenu);
            Name = "FaturaislemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fatura İşlemleri";
            FaturaislemMenu.ResumeLayout(false);
            FaturaislemMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminFaturaGoruntuleDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip FaturaislemMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private ToolStripMenuItem adminMenüToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private DataGridView AdminFaturaGoruntuleDgv;
        private Label lblFaturaSilGoruntule;
        private Button btnFaturaSil;
        private Label lblFaturalar;
    }
}