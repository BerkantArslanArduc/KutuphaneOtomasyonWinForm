using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm
{
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        public void Listele()
        {
            
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.kullanici_Ad = kullaniciAdtxt.Text;
            kullanicilar.kullanici_soyad = KullaniciSoyadtxt.Text;
            kullanicilar.kullanici_tc = kullaniciTCtxt.Text;
            kullanicilar.kullanici_tel = kullaniciTeltxt.Text;
            kullanicilar.kullanici_mail = kullaniciMailtxt.Text;
            kullanicilar.kullanici_ceza1 = Convert.ToDouble(kullaniciCezatxt.Text);
            if (radioE.Checked == true)
            {
                kullanicilar.kullanici_cinsiyet = "Erkek";
            }
            else if (radioK.Checked == false)
            {
                kullanicilar.kullanici_cinsiyet = "Kadın";
            }
            //else
            //    MessageBox.Show("lütfen Cinsiyetinizi Seçiniz");
            db.Kullanicilar.Add(kullanicilar);
            db.SaveChanges();
            Listele();
           
        }
    }
}
