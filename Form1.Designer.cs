namespace Proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_yaziekle = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(12, 63);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(157, 66);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "Resim Ekle";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(13, 135);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(157, 66);
            this.Btn2.TabIndex = 1;
            this.Btn2.Text = "Resim Düzenle";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(12, 556);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(157, 66);
            this.Btn3.TabIndex = 2;
            this.Btn3.Text = "Resim Kaydet";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(15, 207);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(155, 66);
            this.Btn4.TabIndex = 3;
            this.Btn4.Text = "Resim Sıkıştırma";
            this.Btn4.UseVisualStyleBackColor = true;
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(12, 384);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(157, 66);
            this.Btn5.TabIndex = 4;
            this.Btn5.Text = "Resim Efekti";
            this.Btn5.UseVisualStyleBackColor = true;
//            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(12, 279);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(157, 66);
            this.Btn6.TabIndex = 5;
            this.Btn6.Text = "Resim Bulanıklaştırma";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(200, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(614, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(411, 559);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Orjinal Resim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(705, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Değişen Resim";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 27);
            this.textBox1.TabIndex = 10;
            // 
            // Btn_yaziekle
            // 
            this.Btn_yaziekle.Location = new System.Drawing.Point(11, 456);
            this.Btn_yaziekle.Name = "Btn_yaziekle";
            this.Btn_yaziekle.Size = new System.Drawing.Size(157, 66);
            this.Btn_yaziekle.TabIndex = 11;
            this.Btn_yaziekle.Text = "YazıEkle";
            this.Btn_yaziekle.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 528);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 27);
            this.textBox2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1075, 643);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Btn_yaziekle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_yaziekle;
        private System.Windows.Forms.TextBox textBox2;
    }
}

