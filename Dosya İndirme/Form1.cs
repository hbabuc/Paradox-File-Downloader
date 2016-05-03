using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Diagnostics;

namespace Dosya_İndirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string dosyaAdi = string.Empty;

        string dosyaTuru = string.Empty;

        WebClient wc;

        Uri uri;

        double alinan = 0;

        double oncekiAlinan = 0;

        double tamami = 0;

        int kalanSure = 0;

        WebRequest webReq;

        private string DosyaAdi(string yol)
        {
            return yol.Split('/')[yol.Split('/').Length - 1];
        }

        private string DosyaTuru(string isim)
        {
            return isim.Substring(isim.Length - 4).Replace('.',' ').Trim();
        }

        private string byteToMb(double bit)
        {
            return (bit / 1024 / 1024).ToString().Substring(0,4);
        }

        private string byteToKb(double bit)
        {
            double d = bit / 1024;

            if (d.ToString().Length >= 4)
            {
                return d.ToString().Substring(0, 4);
            }
            else if (d.ToString().Length >= 2)
            {
                return d.ToString().Substring(0, 2);
            }
            else
            {
                return d.ToString();
            }
        }

        private string kalanZamanBulma(int saniye)
        {
            if (saniye <= 59)
            {
                return saniye.ToString() + " saniye";
            }
            else
            {
                int dakika = saniye / 60;
                int kSaniye = saniye % 60;

                return dakika.ToString() + " dakika " + kSaniye.ToString() + " saniye";
            }
        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (MessageBox.Show(dosyaAdi + " dosyası başarıyla indirildi. Dosya çalıştırılsın mı ?","Dosya indirildi",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(saveFileDialog1.FileName);
            }

            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
            wc.DownloadProgressChanged -= new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);

            button1.Enabled = true;

            button1.Text = "İndir!";
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            lblDosyaBoyutu.Text = byteToMb(e.TotalBytesToReceive) + " Mb";
            lblAlinanYuklenen.Text = e.BytesReceived.ToString() + " / " + e.TotalBytesToReceive.ToString() + " bytes";
            lblDosyaYuzdesi.Text = "%" + e.ProgressPercentage.ToString();
            progressBar1.Value = e.ProgressPercentage;
            alinan = e.BytesReceived;
            tamami = e.TotalBytesToReceive;
            if (!timer1.Enabled) timer1.Enabled = true;
            if (e.ProgressPercentage == 100) timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "İptal")
            {
                Application.Restart();

                return;
            }

            button1.Text = "İptal";

            wc = new WebClient();

            try
            {
                uri = new Uri(textBox1.Text);
            }
            catch (UriFormatException)
            {
                MessageBox.Show("Girilen adres geçersiz.");

                button1.Text = "İndir!";

                return;
            }
            
            dosyaAdi = DosyaAdi(textBox1.Text);

            dosyaTuru = DosyaTuru(dosyaAdi);

            lblDosyaAdi.Text = dosyaAdi;

            lblDosyaTuru.Text = dosyaTuru;

            saveFileDialog1.Filter = dosyaTuru + " dosyası|*." + dosyaTuru;

            saveFileDialog1.FileName = dosyaAdi;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                wc.DownloadFileAsync(uri, saveFileDialog1.FileName);

                lblAlinanYuklenen.Text = "Hesaplanıyor...";

                lblDosyaBoyutu.Text = "Hesaplanıyor...";

                lblDosyaYuzdesi.Text = "Hesaplanıyor...";

                lblIndirmeHizi.Text = "Hesaplanıyor...";

                lblKalanSure.Text = "Hesaplanıyor...";

                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);

                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
            }

            
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Dosya yolu giriniz.")
            textBox1.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double indirmeHizi = alinan - oncekiAlinan;
            kalanSure = Convert.ToInt16((tamami - alinan) / indirmeHizi);
            lblKalanSure.Text = kalanZamanBulma(kalanSure);
            lblIndirmeHizi.Text = byteToKb(indirmeHizi) + " Kb/s";
            oncekiAlinan = alinan;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}