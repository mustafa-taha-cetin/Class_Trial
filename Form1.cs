using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınıf_Yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();
            rb.renk = "Beyaz";
            rb.durum = "sıfır";
            rb.fiyat = 100000;
            rb.beygir = 1224;
            rb.marka = "Toyota";
            rb.uretimYılı = 2022;
            rb.plaka = "24 TGC 0207";
            rb.kullaniciAdi = "Mustafa Çetin";

            label1.Text = "Marka " + rb.marka;
            label2.Text = "Durumu: " + rb.durum;
            label3.Text = "Beygir: " + rb.beygir;
            label4.Text = "Fiyatı: " + rb.fiyat;
            label5.Text = "Üretim Yılı: " + rb.uretimYılı;
            label6.Text = "Rengi: " + rb.renk;
            label9.Text = "Plaka: " + rb.plaka;
            label8.Text = "Sürücü: " + rb.kullaniciAdi;


        }
    }
}
