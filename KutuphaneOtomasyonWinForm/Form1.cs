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
    public partial class Form1 : Form
    {
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string gelenAd = adGiristxt.Text;
            string gelenSifre = sifreGiristxt.Text;

            //linq sorgusu yapıyorum
            var personel = db.Personeller.Where(x=> x.personel_ad.Equals(gelenAd)&& x.personel_sifre.Equals(gelenSifre)).FirstOrDefault(); 

            
            if (personel == null)
               MessageBox.Show("try again bitch");
            else
            {
                MessageBox.Show("başarılı");
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }
                 
        }
    }
}
