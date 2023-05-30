namespace Otel_Otomasyonu
{
    partial class FrmMusteriler
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            BtnVerileriGoster = new Button();
            BtnGuncelle = new Button();
            BtnSil = new Button();
            BtnAra = new Button();
            comboBox1 = new ComboBox();
            label12 = new Label();
            TxtUcret = new TextBox();
            label13 = new Label();
            label14 = new Label();
            TxtMail = new TextBox();
            DtpCikisTarihi = new DateTimePicker();
            DtpGirisTarihi = new DateTimePicker();
            MskTxtTelefon = new MaskedTextBox();
            TxtOdaNo = new TextBox();
            TxtKimlikNo = new TextBox();
            TxtSoyadi = new TextBox();
            TxtAdi = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            textBox7 = new TextBox();
            label1 = new Label();
            BtnTemizle = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.LabelEdit = true;
            listView1.Location = new Point(3, 316);
            listView1.Name = "listView1";
            listView1.Size = new Size(826, 131);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adı";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyadı";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cinsiyet";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telefon";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Mail";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "TC";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Oda No";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ücret";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Giriş Tarihi";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Çıkış Tarihi";
            // 
            // BtnVerileriGoster
            // 
            BtnVerileriGoster.BackColor = Color.FromArgb(128, 128, 255);
            BtnVerileriGoster.Location = new Point(712, 2);
            BtnVerileriGoster.Name = "BtnVerileriGoster";
            BtnVerileriGoster.Size = new Size(117, 27);
            BtnVerileriGoster.TabIndex = 1;
            BtnVerileriGoster.Text = "Verileri Göster";
            BtnVerileriGoster.UseVisualStyleBackColor = false;
            BtnVerileriGoster.Click += button1_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = Color.FromArgb(128, 128, 255);
            BtnGuncelle.Location = new Point(712, 35);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(117, 27);
            BtnGuncelle.TabIndex = 2;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = Color.FromArgb(128, 128, 255);
            BtnSil.Location = new Point(712, 68);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(117, 27);
            BtnSil.TabIndex = 3;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnAra
            // 
            BtnAra.BackColor = Color.FromArgb(128, 128, 255);
            BtnAra.Location = new Point(712, 135);
            BtnAra.Name = "BtnAra";
            BtnAra.Size = new Size(117, 27);
            BtnAra.TabIndex = 4;
            BtnAra.Text = "Ara";
            BtnAra.UseVisualStyleBackColor = false;
            BtnAra.Click += BtnAra_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.BurlyWood;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bay\t", "Bayan" });
            comboBox1.Location = new Point(100, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 23);
            comboBox1.TabIndex = 77;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(35, 77);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 76;
            label12.Text = "Cinsiyeti:";
            // 
            // TxtUcret
            // 
            TxtUcret.BackColor = Color.BurlyWood;
            TxtUcret.Location = new Point(465, 37);
            TxtUcret.Name = "TxtUcret";
            TxtUcret.Size = new Size(241, 23);
            TxtUcret.TabIndex = 75;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(416, 45);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 74;
            label13.Text = "Ücret:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(57, 141);
            label14.Name = "label14";
            label14.Size = new Size(33, 15);
            label14.TabIndex = 73;
            label14.Text = "Mail:";
            // 
            // TxtMail
            // 
            TxtMail.BackColor = Color.BurlyWood;
            TxtMail.Location = new Point(100, 133);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(241, 23);
            TxtMail.TabIndex = 72;
            // 
            // DtpCikisTarihi
            // 
            DtpCikisTarihi.Location = new Point(465, 101);
            DtpCikisTarihi.Name = "DtpCikisTarihi";
            DtpCikisTarihi.Size = new Size(241, 23);
            DtpCikisTarihi.TabIndex = 71;
            // 
            // DtpGirisTarihi
            // 
            DtpGirisTarihi.Location = new Point(465, 68);
            DtpGirisTarihi.Name = "DtpGirisTarihi";
            DtpGirisTarihi.Size = new Size(241, 23);
            DtpGirisTarihi.TabIndex = 70;
            // 
            // MskTxtTelefon
            // 
            MskTxtTelefon.BackColor = Color.BurlyWood;
            MskTxtTelefon.Location = new Point(100, 102);
            MskTxtTelefon.Mask = "(999) 000-0000";
            MskTxtTelefon.Name = "MskTxtTelefon";
            MskTxtTelefon.Size = new Size(241, 23);
            MskTxtTelefon.TabIndex = 69;
            // 
            // TxtOdaNo
            // 
            TxtOdaNo.BackColor = Color.BurlyWood;
            TxtOdaNo.Location = new Point(465, 6);
            TxtOdaNo.Name = "TxtOdaNo";
            TxtOdaNo.Size = new Size(241, 23);
            TxtOdaNo.TabIndex = 68;
            // 
            // TxtKimlikNo
            // 
            TxtKimlikNo.BackColor = Color.BurlyWood;
            TxtKimlikNo.Location = new Point(100, 164);
            TxtKimlikNo.MaxLength = 11;
            TxtKimlikNo.Name = "TxtKimlikNo";
            TxtKimlikNo.Size = new Size(241, 23);
            TxtKimlikNo.TabIndex = 67;
            // 
            // TxtSoyadi
            // 
            TxtSoyadi.BackColor = Color.BurlyWood;
            TxtSoyadi.Location = new Point(100, 39);
            TxtSoyadi.Name = "TxtSoyadi";
            TxtSoyadi.Size = new Size(241, 23);
            TxtSoyadi.TabIndex = 66;
            // 
            // TxtAdi
            // 
            TxtAdi.BackColor = Color.BurlyWood;
            TxtAdi.Location = new Point(100, 6);
            TxtAdi.Name = "TxtAdi";
            TxtAdi.Size = new Size(241, 23);
            TxtAdi.TabIndex = 65;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(385, 109);
            label15.Name = "label15";
            label15.Size = new Size(66, 15);
            label15.TabIndex = 64;
            label15.Text = "Çıkış Tarihi:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(385, 76);
            label16.Name = "label16";
            label16.Size = new Size(64, 15);
            label16.TabIndex = 63;
            label16.Text = "Giriş Tarihi:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(360, 14);
            label17.Name = "label17";
            label17.Size = new Size(86, 15);
            label17.TabIndex = 62;
            label17.Text = "Oda Numarası:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(4, 172);
            label18.Name = "label18";
            label18.Size = new Size(82, 15);
            label18.TabIndex = 61;
            label18.Text = "T.C Kimlik No:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(40, 110);
            label19.Name = "label19";
            label19.Size = new Size(48, 15);
            label19.TabIndex = 60;
            label19.Text = "Telefon:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(43, 47);
            label20.Name = "label20";
            label20.Size = new Size(45, 15);
            label20.TabIndex = 59;
            label20.Text = "Soyadı:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(63, 14);
            label21.Name = "label21";
            label21.Size = new Size(28, 15);
            label21.TabIndex = 58;
            label21.Text = "Adı:";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.BurlyWood;
            textBox7.Location = new Point(576, 187);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(241, 23);
            textBox7.TabIndex = 79;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(527, 195);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 78;
            label1.Text = "İsim:";
            // 
            // BtnTemizle
            // 
            BtnTemizle.BackColor = Color.FromArgb(128, 128, 255);
            BtnTemizle.Location = new Point(712, 101);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(117, 27);
            BtnTemizle.TabIndex = 80;
            BtnTemizle.Text = "Temizle";
            BtnTemizle.UseVisualStyleBackColor = false;
            BtnTemizle.Click += BtnTemizle_Click;
            // 
            // FrmMusteriler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(829, 450);
            Controls.Add(BtnTemizle);
            Controls.Add(textBox7);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label12);
            Controls.Add(TxtUcret);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(TxtMail);
            Controls.Add(DtpCikisTarihi);
            Controls.Add(DtpGirisTarihi);
            Controls.Add(MskTxtTelefon);
            Controls.Add(TxtOdaNo);
            Controls.Add(TxtKimlikNo);
            Controls.Add(TxtSoyadi);
            Controls.Add(TxtAdi);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(BtnAra);
            Controls.Add(BtnSil);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnVerileriGoster);
            Controls.Add(listView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMusteriler";
            Text = "Müşteri Bilgileri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button BtnVerileriGoster;
        private Button BtnGuncelle;
        private Button BtnSil;
        private Button BtnAra;
        private ComboBox comboBox1;
        private Label label12;
        private TextBox TxtUcret;
        private Label label13;
        private Label label14;
        private TextBox TxtMail;
        private DateTimePicker DtpCikisTarihi;
        private DateTimePicker DtpGirisTarihi;
        private MaskedTextBox MskTxtTelefon;
        private TextBox TxtOdaNo;
        private TextBox TxtKimlikNo;
        private TextBox TxtSoyadi;
        private TextBox TxtAdi;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox textBox7;
        private Label label1;
        private Button BtnTemizle;
    }
}