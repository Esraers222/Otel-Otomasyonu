namespace Otel_Otomasyonu
{
    partial class FrmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            label1 = new Label();
            label2 = new Label();
            TxtKullaniciAdi = new TextBox();
            TxtSifre = new TextBox();
            BtnGirisYap = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(222, 246);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(277, 281);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // TxtKullaniciAdi
            // 
            TxtKullaniciAdi.BackColor = Color.Tan;
            TxtKullaniciAdi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtKullaniciAdi.ForeColor = SystemColors.WindowText;
            TxtKullaniciAdi.Location = new Point(331, 242);
            TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            TxtKullaniciAdi.Size = new Size(179, 25);
            TxtKullaniciAdi.TabIndex = 2;
            // 
            // TxtSifre
            // 
            TxtSifre.BackColor = Color.Tan;
            TxtSifre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSifre.Location = new Point(331, 281);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(179, 25);
            TxtSifre.TabIndex = 3;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGirisYap.Location = new Point(360, 344);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(98, 34);
            BtnGirisYap.TabIndex = 4;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = true;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FloralWhite;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnGirisYap);
            Controls.Add(TxtSifre);
            Controls.Add(TxtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAdminGiris";
            Text = "Admin Giriş";
            Load += FrmAdminGiris_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtKullaniciAdi;
        private TextBox TxtSifre;
        private Button BtnGirisYap;
        public PictureBox pictureBox1;
    }
}