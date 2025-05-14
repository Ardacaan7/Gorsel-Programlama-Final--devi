using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapTakipApp
{
    public partial class Form1: Form
    {
        int toplamSayfa = 0;
        public Form1()
        {
            InitializeComponent();
            lblToplamSayfa.Text = "Toplam Okunan Sayfa: 0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerHatirlat.Interval = 60000;
            timerHatirlat.Tick += timerHatirlat_Tick;
            timerHatirlat.Start();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            string kitapAdi = txtKitapAdi.Text;
            int sayfaSayisi = (int)numSayfa.Value;

            if (string.IsNullOrWhiteSpace(kitapAdi) || sayfaSayisi == 0)
            {
                MessageBox.Show("Lütfen kitap adı ve sayfa sayısını girin.");
                return;
            }

            
            listBoxKitaplar.Items.Add($"{kitapAdi} - {sayfaSayisi} sayfa");

            
            toplamSayfa += sayfaSayisi;
            lblToplamSayfa.Text = $"Toplam Okunan Sayfa: {toplamSayfa}";

            
            txtKitapAdi.Clear();
            numSayfa.Value = 0;
        }

        private void timerHatirlat_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour == 19 && DateTime.Now.Minute == 0)
            {
                MessageBox.Show("Gün bitmeden birkaç sayfa kitap oku!", "Kitap Hatırlatıcısı");
                timerHatirlat.Stop();
            }
        }
    }
}
