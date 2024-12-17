namespace BAY_Turizm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            AdminGiris = new Button();
            KullaniciGiris = new Button();
            button3 = new Button();
            KayitOl = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(479, 560);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AdminGiris
            // 
            AdminGiris.BackColor = Color.FromArgb(33, 140, 116);
            AdminGiris.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminGiris.ForeColor = Color.FromArgb(247, 241, 227);
            AdminGiris.Location = new Point(546, 50);
            AdminGiris.Name = "AdminGiris";
            AdminGiris.Size = new Size(267, 97);
            AdminGiris.TabIndex = 1;
            AdminGiris.Text = "Admin Girişi";
            AdminGiris.UseVisualStyleBackColor = false;
            AdminGiris.Click += AdminGiris_Click;
            // 
            // KullaniciGiris
            // 
            KullaniciGiris.BackColor = Color.FromArgb(33, 140, 116);
            KullaniciGiris.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KullaniciGiris.ForeColor = Color.FromArgb(247, 241, 227);
            KullaniciGiris.Location = new Point(546, 217);
            KullaniciGiris.Name = "KullaniciGiris";
            KullaniciGiris.Size = new Size(267, 97);
            KullaniciGiris.TabIndex = 2;
            KullaniciGiris.Text = "Kullanıcı Girişi";
            KullaniciGiris.UseVisualStyleBackColor = false;
            KullaniciGiris.Click += KullaniciGiris_Click;
            // 
            // button3
            // 
            button3.Location = new Point(599, 332);
            button3.Name = "button3";
            button3.Size = new Size(8, 8);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // KayitOl
            // 
            KayitOl.BackColor = Color.FromArgb(33, 140, 116);
            KayitOl.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KayitOl.ForeColor = Color.FromArgb(247, 241, 227);
            KayitOl.Location = new Point(546, 381);
            KayitOl.Name = "KayitOl";
            KayitOl.Size = new Size(267, 97);
            KayitOl.TabIndex = 4;
            KayitOl.Text = "Kullanıcı Kaydı ";
            KayitOl.UseVisualStyleBackColor = false;
            KayitOl.Click += KayitOl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 241, 227);
            ClientSize = new Size(884, 561);
            Controls.Add(KayitOl);
            Controls.Add(button3);
            Controls.Add(KullaniciGiris);
            Controls.Add(AdminGiris);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Menü";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button AdminGiris;
        private Button KullaniciGiris;
        private Button button3;
        private Button KayitOl;
    }
}
