namespace Otel_Otomasyonu
{
    partial class FrmAnaForm
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button9 = new Button();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Location = new Point(13, 35);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(143, 90);
            button1.TabIndex = 0;
            button1.Text = "Admin Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Plum;
            button2.Location = new Point(235, 35);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(143, 90);
            button2.TabIndex = 1;
            button2.Text = "Yeni Müşteri";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Location = new Point(445, 35);
            button3.Name = "button3";
            button3.Size = new Size(143, 90);
            button3.TabIndex = 2;
            button3.Text = "Odalar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SpringGreen;
            button4.Location = new Point(13, 184);
            button4.Name = "button4";
            button4.Size = new Size(143, 90);
            button4.TabIndex = 3;
            button4.Text = "Müşteriler";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 255, 128);
            button5.Location = new Point(445, 184);
            button5.Name = "button5";
            button5.Size = new Size(143, 90);
            button5.TabIndex = 4;
            button5.Text = "Çıkış";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonShadow;
            button9.Location = new Point(235, 184);
            button9.Name = "button9";
            button9.Size = new Size(143, 90);
            button9.TabIndex = 8;
            button9.Text = "Hakkımızda";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(254, 304);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(254, 347);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmAnaForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(624, 432);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmAnaForm";
            Text = "FrmAnaForm";
            Load += FrmAnaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button9;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}