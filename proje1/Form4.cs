using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class form_askerdagitim : Form
    {
        //Önce kullanacağım dizileri tanımladım.
        ArrayList asker = new ArrayList();
        ArrayList il = new ArrayList();
        //Random sınıfımı oluşturdum.
        Random rastgele = new Random();
        public form_askerdagitim()
        {
            InitializeComponent();
        }

        private void tbx_isimgir_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_isimekle_Click(object sender, EventArgs e)
        {
            //Önce textbox ın boş olup olmadığını kontrol ediyorum.
            if (tbx_isimgir.Text == "" || tbx_isimgir.Text == null || tbx_isimgir.Text == " " || tbx_isimgir.Text == "  ")
            {
                MessageBox.Show("Lütfen askerin ismini giriniz.");
            }
            else
            {
                lbx_isim.Items.Add(tbx_isimgir.Text.ToUpper());
                //Toupper metodu ile textbox a girilen karakterlerin hepsini büyük harf yaptım.
                tbx_isimgir.Focus();
                //Focus metodu ile program çalıştırıldığı zaman imlecin textbox ta olmasını sağladım.
            }
            tbx_isimgir.Clear();
            //Clear metodu ile isim girildikten sonra textbox u temizledim
        }

        private void btn_ilekle_Click(object sender, EventArgs e)
        {
            //Önce textbox ın boş olup olmadığını kontrol ediyorum.
            if (tbx_ilgir.Text == "" || tbx_ilgir.Text == null || tbx_ilgir.Text == " " || tbx_ilgir.Text == "  ")
            {
                MessageBox.Show("Lütfen askerin ismini giriniz.");
            }
            else
            {
                lbx_il.Items.Add(tbx_ilgir.Text.ToUpper());
                //Toupper metodu ile textbox a girilen karakterlerin hepsini büyük harf yaptım.
                tbx_ilgir.Focus();
                //Focus metodu ile program çalıştırıldığı zaman imlecin textbox ta olmasını sağladım.
            }
            tbx_ilgir.Clear();
            //Clear metodu ile isim girildikten sonra textbox u temizledim
        }

        private void btn_dagit_Click(object sender, EventArgs e)
        {
            //Oluşturduğumuz 2 listeyi dizilere ekledik.
            asker.AddRange(lbx_isim.Items);
            il.AddRange(lbx_il.Items);
            //AddRange metodu ile birden fazla elemanı dizilere ekleyebiliriz.
            //Count ingilizcede sayma anlamına gelir.
            //Eğer asker ve il sayısı eşit ise
            if (asker.Count == il.Count)
            {
                int askersayisi = asker.Count;
                for (int i = 0; i < askersayisi; i++) 
                {
                    //Next metodu ile belirttiğimiz aralıkta rastgele bir tamsayı döndürürüz.Parantez içine yazdığımız sayılar ile ,döndürülecek olan sayının aralığını belirleriz.İlk yazdığımız değer en küçük,diğer yazdığımız değer ise en büyük olarak kabul edilir.
                    int gelenasker = rastgele.Next(0, asker.Count);
                    //0 ve "asker.count" arasında olan değeri döndürüp "gelenasker" adlı değişkene atadık.
                    int gelenil = rastgele.Next(0, il.Count);
                    //0 ve "il.count" arasında olan değeri döndürüp "gelenil" adlı değişkene atadık.
                    lbx_sonuc.Items.Add(asker![gelenasker]!.ToString() + "     " + il![gelenil]!.ToString());
                    //Yazdığımız programın boş değer döndürme ihtimaline karşı kullandığımız değişkenin başına ve sonuna ünlem işareti yerleştirdim.
                    asker.RemoveAt(gelenasker);
                    il.RemoveAt(gelenil);
                    //RemoveAt metodu ile parantez içindeki değişken hangi index e karşılık geliyorsa o index teki veriyi sildik.
                }
            }
            // Eğer asker sayısı ilden fazla ise
            if (asker.Count > il.Count)
            {
                int askersayisi = asker.Count;

                for (int i = 0; i < askersayisi; i++)
                {
                    int gelenaday = rastgele.Next(0, asker.Count);
                    //0 ve "asker.count" arasında olan değeri döndürüp "gelenaday" adlı değişkene atadık.
                    int gelenil = rastgele.Next(0, il.Count);
                    //0 ve "il.count" arasında olan değeri döndürüp "gelenil" adlı değişkene atadık.

                    lbx_sonuc.Items.Add(asker![gelenaday]!.ToString() + "     " + il![gelenil]!.ToString());
                    //Yazdığımız programın boş değer döndürme ihtimaline karşı kullandığımız değişkenin başına ve sonuna ünlem işareti yerleştirdim.
                    asker.RemoveAt(gelenaday);
                    //RemoveAt metodu ile parantez içindki değişken hangi index e karşılık geliyorsa o index teki veriyi sildik.
                }
            }
            //Eğer il sayısı askerden fazla ise
            if (asker.Count < il.Count)
            {
                int askersayisi = asker.Count;

                for (int i = 0; i < askersayisi; i++)
                {
                    int gelenaday = rastgele.Next(0, asker.Count);
                    //0 ve "asker.count" arasında olan değeri döndürüp "gelenaday" adlı değişkene atadık.
                    int gelenil = rastgele.Next(0, il.Count);
                    //0 ve "il.count" arasında olan değeri döndürüp "gelenil" adlı değişkene atadık.
                    lbx_sonuc.Items.Add(asker![gelenaday]!.ToString() + "     " + il![gelenil]!.ToString());
                    //Yazdığımız programın boş değer döndürme ihtimaline karşı kullandığımız değişkenin başına ve sonuna ünlem işareti yerleştirdim.
                    asker.RemoveAt(gelenaday);
                    il.RemoveAt(gelenil);
                    //RemoveAt metodu ile parantez içindki değişken hangi index e karşılık geliyorsa o index teki veriyi sildik.
                }
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            lbx_sonuc.Items.Clear();
            //Clear metodu ile lbx_sonuc taki verileri temizledim.
        }
    }
}
               
