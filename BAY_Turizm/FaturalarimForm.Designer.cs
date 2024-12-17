namespace BAY_Turizm
{
    partial class FaturalarimForm
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
            SeferAraMenu.SuspendLayout();
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
            SeferAraMenu.TabIndex = 3;
            SeferAraMenu.Text = "menuStrip1";
            // 
            // anaMenüToolStripMenuItem
            // 
            anaMenüToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            anaMenüToolStripMenuItem.ForeColor = Color.FromArgb(247, 241, 227);
            anaMenüToolStripMenuItem.Name = "anaMenüToolStripMenuItem";
            anaMenüToolStripMenuItem.Size = new Size(100, 25);
            anaMenüToolStripMenuItem.Text = "Ana Menü";
            // 
            // kullanıcıMenüToolStripMenuItem
            // 
            kullanıcıMenüToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            kullanıcıMenüToolStripMenuItem.ForeColor = Color.FromArgb(247, 241, 227);
            kullanıcıMenüToolStripMenuItem.Name = "kullanıcıMenüToolStripMenuItem";
            kullanıcıMenüToolStripMenuItem.Size = new Size(137, 25);
            kullanıcıMenüToolStripMenuItem.Text = "Kullanıcı Menü";
            // 
            // FaturalarimForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(SeferAraMenu);
            Name = "FaturalarimForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Faturalarım";
            Load += FaturalarimForm_Load;
            SeferAraMenu.ResumeLayout(false);
            SeferAraMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip SeferAraMenu;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private ToolStripMenuItem kullanıcıMenüToolStripMenuItem;
    }
}