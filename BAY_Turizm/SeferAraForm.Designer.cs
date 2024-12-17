namespace BAY_Turizm
{
    partial class SeferAraForm
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
            SeferAraMenu = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıMenüToolStripMenuItem = new ToolStripMenuItem();
            lblUygunSeferler = new Label();
            AdminFaturaGoruntuleDgv = new DataGridView();
            btnSeferSec = new Button();
            SeferAraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminFaturaGoruntuleDgv).BeginInit();
            SuspendLayout();
            // 
            // SeferAraMenu
            // 
            SeferAraMenu.BackColor = Color.FromArgb(109, 33, 79);
            SeferAraMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SeferAraMenu.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem, kullanıcıMenüToolStripMenuItem });
            SeferAraMenu.Location = new Point(0, 0);
            SeferAraMenu.Name = "SeferAraMenu";
            SeferAraMenu.Size = new Size(884, 29);
            SeferAraMenu.TabIndex = 2;
            SeferAraMenu.Text = "menuStrip1";
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
            // lblUygunSeferler
            // 
            lblUygunSeferler.AutoSize = true;
            lblUygunSeferler.Font = new Font("Segoe UI", 22F);
            lblUygunSeferler.ForeColor = Color.FromArgb(44, 44, 84);
            lblUygunSeferler.Location = new Point(332, 29);
            lblUygunSeferler.Name = "lblUygunSeferler";
            lblUygunSeferler.Size = new Size(214, 41);
            lblUygunSeferler.TabIndex = 30;
            lblUygunSeferler.Text = "Uygun Seferler";
            // 
            // AdminFaturaGoruntuleDgv
            // 
            AdminFaturaGoruntuleDgv.BackgroundColor = Color.White;
            AdminFaturaGoruntuleDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminFaturaGoruntuleDgv.GridColor = Color.FromArgb(30, 39, 46);
            AdminFaturaGoruntuleDgv.Location = new Point(12, 73);
            AdminFaturaGoruntuleDgv.Name = "AdminFaturaGoruntuleDgv";
            AdminFaturaGoruntuleDgv.Size = new Size(852, 380);
            AdminFaturaGoruntuleDgv.TabIndex = 34;
            // 
            // btnSeferSec
            // 
            btnSeferSec.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSeferSec.ForeColor = Color.FromArgb(179, 57, 57);
            btnSeferSec.Location = new Point(332, 509);
            btnSeferSec.Name = "btnSeferSec";
            btnSeferSec.Size = new Size(214, 40);
            btnSeferSec.TabIndex = 35;
            btnSeferSec.Text = "Seferi Seç";
            btnSeferSec.UseVisualStyleBackColor = true;
            // 
            // SeferAraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(btnSeferSec);
            Controls.Add(AdminFaturaGoruntuleDgv);
            Controls.Add(lblUygunSeferler);
            Controls.Add(SeferAraMenu);
            Name = "SeferAraForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seferler";
            Load += SeferAraForm_Load;
            SeferAraMenu.ResumeLayout(false);
            SeferAraMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminFaturaGoruntuleDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip SeferAraMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private ToolStripMenuItem kullanıcıMenüToolStripMenuItem;
        private Label lblUygunSeferler;
        private DataGridView AdminFaturaGoruntuleDgv;
        private Button btnSeferSec;
    }
}