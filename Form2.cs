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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba rb2 = new Araba();
            rb2.renk = "Turuncu";
            rb2.durum = "İkinci el";
            rb2.fiyat = 120000;
            rb2.beygir = 702;
            rb2.marka = "Nissan";
            rb2.uretimYılı = 2020;
            rb2.plaka = "24 TGC 0207";
            rb2.kullaniciAdi = "Tuğçe Çetin";

            label1.Text = "Marka " + rb2.marka;
            label2.Text = "Durumu: " + rb2.durum;
            label3.Text = "Beygir: " + rb2.beygir;
            label4.Text = "Fiyatı: " + rb2.fiyat;
            label5.Text = "Üretim Yılı: " + rb2.uretimYılı;
            label6.Text = "Rengi: " + rb2.renk;
            label9.Text = "Plaka: " + rb2.plaka;
            label8.Text = "Sürücü: " + rb2.kullaniciAdi;
        }
    }
}
