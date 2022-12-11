using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class form_buyukkucuk_uyum : Form
    {
        //Önce public değikenlerimi oluşturuyorum.
        string inceharfler = "EİÖÜeiöü";
        string kalinharfler = "AIOUaıou";
        string rakamlar = "0123456789";
        string metin;
        public form_buyukkucuk_uyum()
        {
            InitializeComponent();
        }

        private void form_buyukkucuk_uyum_Load(object sender, EventArgs e)
        {

        }

        private void btn_kontrol_Click(object sender, EventArgs e)
        {
            //Önce kullanıcının yapabileceği hataları tanımlayacağım.
            //Contains metodu: Parantez içine girdiğimiz metinsel ifadenin yazdığımız kelimenin içinde olup olmadığını kontrol eder.
            //Textbox un içinde boşluk karakteri varsa.
            if (txt_kelime.Text.Contains(" "))
            {
                MessageBox.Show("Lütfen tek kelime giriniz.");
                txt_kelime.Focus();
                txt_kelime.Clear();
                lbl_durum.Text = "";
            }
            //Kullanıcı hiçbir metinsel ifade girmişse.
            else if (lbl_durum.Text == null)
            {
                MessageBox.Show("Lütfen tek kelime giriniz.");
                txt_kelime.Focus();
                txt_kelime.Clear();
                lbl_durum.Text = "";
            }
            else if (txt_kelime.Text == "")
            {
                MessageBox.Show("Lütfen tek kelime giriniz.");
                txt_kelime.Focus();
                txt_kelime.Clear();
                lbl_durum.Text = "";
            }
            else
            {
                kelimekontrol();
            }
            //Void ile metod oluştururuz.Şimdi kelime kontol metodu oluşturacağım
            void kelimekontrol()
            {
                //Textbox a yazılan metinsel ifadeyi metin adlı değişkene atadım
                metin = txt_kelime.Text;
                //Bool veri tipi sadece iki tane değer alır.Bunlar True ve False tur.
                bool varyok1 = false;
                bool varyok2 = false;
                bool varyok3 = false;
                //Ortaya çıkabilecek her durumu tek tek taramak için foeach döngüsünü kullancağım.
                foreach (char item in metin)
                {
                    /*
                    İndexOf metodu: Arama işlemini, kendisini çağıran değişkenin içindeki verinin ilk karakterinden başlayıp son karakterine doğru yapar.
                    Aradığını bulamazsa geriye -1 değerini döndürür.
                    Eğer ince harfler için çıkan sonuç -1 e eşit değilse , girdiğimiz ifade  ince harf bulunduruyor demektir.
                    */
                    if (inceharfler.IndexOf(item) != -1)
                    {
                        varyok1 = true;
                    }
                    //Eğer kalın harfler için aradığımız değer -1 e eşit değilse ,girdiğimiz ifade kalın harf bulunduruyor demektir.
                    if (kalinharfler.IndexOf(item) != -1)
                    {
                        //Girdiğimiz kalın harfleri aradı
                        varyok2 = true;
                    }
                    //Rakamları arıyorum.Eğer rakam var ise True.
                    if(rakamlar.IndexOf(item) != -1)
                    {
                        //Girdiğimiz rakamları aradı
                        varyok3 = true;
                    }
                }
                //Eğer ikisi de true ise kelime de hem ince hem kalın harf vardır, yani Büyük Ünlü Uyumuna Uymaz.
                if (varyok1 == true && varyok2 == true)
                {
                    lbl_durum.Text = "Büyük Ünlü Uyumuna Uymuyor";
                }
                //Eğer iki durum birbirinden farklı ise demek ki, kelime büyük ünlü uyumuna uyuyor.
                else if (varyok1 != varyok2)
                {
                    lbl_durum.Text = "Büyük Ünlü Uyumuna Uyuyor";
                }
                //Eğer varyok3 true ise demekki metin rakam içeriyor.
                else if (varyok3 == true)
                {
                    lbl_durum.Text = "Kelime lütfen rakam içermesin";
                }
                else if (varyok3 == true && (varyok1 == true || varyok1 == false || varyok2 == true || varyok2 == false))
                {
                    lbl_durum.Text = "Kelime Lütfen Rakam İçermesin";
                }
                //Eğer bu durumların haricinde ise kelime sesli harf içermez..
                else
                {
                    lbl_durum.Text = "Kelime Sesli Harf İçermiyor";
                }
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            //DialogResult bize herhangi bir durumda programın önüne (ShowDialog açar gibi) bir uyarı mesajından sonucu verir.
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Eminmisiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            {
                if (sonuc == DialogResult.OK)
                {
                    //Uygulamadan çıkış yap.
                    Application.Exit();
                }
            }
        }
    }
}
