namespace Dosya_İndirme
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDosyaBoyutu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlinanYuklenen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDosyaTuru = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDosyaYuzdesi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKalanSure = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIndirmeHizi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblDosyaAdi = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Dosya_İndirme.Properties.Resources.background;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(174, 471);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "İndir!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(132, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Dosya yolu giriniz.";
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // lblDosyaBoyutu
            // 
            this.lblDosyaBoyutu.AutoSize = true;
            this.lblDosyaBoyutu.BackColor = System.Drawing.Color.Transparent;
            this.lblDosyaBoyutu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDosyaBoyutu.ForeColor = System.Drawing.Color.White;
            this.lblDosyaBoyutu.Location = new System.Drawing.Point(229, 169);
            this.lblDosyaBoyutu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDosyaBoyutu.Name = "lblDosyaBoyutu";
            this.lblDosyaBoyutu.Size = new System.Drawing.Size(0, 21);
            this.lblDosyaBoyutu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dosya Boyutu :  ";
            // 
            // lblAlinanYuklenen
            // 
            this.lblAlinanYuklenen.AutoSize = true;
            this.lblAlinanYuklenen.BackColor = System.Drawing.Color.Transparent;
            this.lblAlinanYuklenen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlinanYuklenen.ForeColor = System.Drawing.Color.White;
            this.lblAlinanYuklenen.Location = new System.Drawing.Point(229, 221);
            this.lblAlinanYuklenen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlinanYuklenen.Name = "lblAlinanYuklenen";
            this.lblAlinanYuklenen.Size = new System.Drawing.Size(0, 21);
            this.lblAlinanYuklenen.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alınan / Yüklenen Dosya :  ";
            // 
            // lblDosyaTuru
            // 
            this.lblDosyaTuru.AutoSize = true;
            this.lblDosyaTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblDosyaTuru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDosyaTuru.ForeColor = System.Drawing.Color.White;
            this.lblDosyaTuru.Location = new System.Drawing.Point(229, 121);
            this.lblDosyaTuru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDosyaTuru.Name = "lblDosyaTuru";
            this.lblDosyaTuru.Size = new System.Drawing.Size(0, 21);
            this.lblDosyaTuru.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dosya Türü : ";
            // 
            // lblDosyaYuzdesi
            // 
            this.lblDosyaYuzdesi.AutoSize = true;
            this.lblDosyaYuzdesi.BackColor = System.Drawing.Color.Transparent;
            this.lblDosyaYuzdesi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDosyaYuzdesi.ForeColor = System.Drawing.Color.White;
            this.lblDosyaYuzdesi.Location = new System.Drawing.Point(229, 273);
            this.lblDosyaYuzdesi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDosyaYuzdesi.Name = "lblDosyaYuzdesi";
            this.lblDosyaYuzdesi.Size = new System.Drawing.Size(0, 21);
            this.lblDosyaYuzdesi.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 273);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Dosya İndirme Yüzdesi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dosya Yolu : ";
            // 
            // lblKalanSure
            // 
            this.lblKalanSure.AutoSize = true;
            this.lblKalanSure.BackColor = System.Drawing.Color.Transparent;
            this.lblKalanSure.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanSure.ForeColor = System.Drawing.Color.White;
            this.lblKalanSure.Location = new System.Drawing.Point(229, 377);
            this.lblKalanSure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKalanSure.Name = "lblKalanSure";
            this.lblKalanSure.Size = new System.Drawing.Size(0, 21);
            this.lblKalanSure.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 377);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kalan Süre :";
            // 
            // lblIndirmeHizi
            // 
            this.lblIndirmeHizi.AutoSize = true;
            this.lblIndirmeHizi.BackColor = System.Drawing.Color.Transparent;
            this.lblIndirmeHizi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIndirmeHizi.ForeColor = System.Drawing.Color.White;
            this.lblIndirmeHizi.Location = new System.Drawing.Point(229, 325);
            this.lblIndirmeHizi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndirmeHizi.Name = "lblIndirmeHizi";
            this.lblIndirmeHizi.Size = new System.Drawing.Size(0, 21);
            this.lblIndirmeHizi.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 325);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "İndirme Hızı :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 423);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(417, 23);
            this.progressBar1.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Dosya Adı : ";
            // 
            // lblDosyaAdi
            // 
            this.lblDosyaAdi.AutoSize = true;
            this.lblDosyaAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblDosyaAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDosyaAdi.ForeColor = System.Drawing.Color.White;
            this.lblDosyaAdi.Location = new System.Drawing.Point(231, 74);
            this.lblDosyaAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDosyaAdi.Name = "lblDosyaAdi";
            this.lblDosyaAdi.Size = new System.Drawing.Size(0, 21);
            this.lblDosyaAdi.TabIndex = 19;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dosya_İndirme.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(460, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDosyaAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblKalanSure);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAlinanYuklenen);
            this.Controls.Add(this.lblDosyaBoyutu);
            this.Controls.Add(this.lblDosyaYuzdesi);
            this.Controls.Add(this.lblIndirmeHizi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDosyaTuru);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paradox Dosya İndirici";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDosyaBoyutu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlinanYuklenen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDosyaTuru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDosyaYuzdesi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKalanSure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIndirmeHizi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDosyaAdi;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

