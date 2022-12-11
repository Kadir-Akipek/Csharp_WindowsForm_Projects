using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class form_slotmakine : Form
    {
        public form_slotmakine()
        {
            InitializeComponent();
        }
        //Random değişkenimi oluşturacağım.
        Random rastgele = new Random();
        int a, b, c, hamle,kazanma,durum,kaybetme;

        private void btn_bahis_Click(object sender, EventArgs e)
        {
            //Son olarak bahise para ekleme tuşunu yapacağız.
            lbl_slot.Text = "Slot";
            //Kaybetmede durum 0 olacak , ekrandaki değişmeler sıfırlanacak ve oyna tuşu aktif edilecek.
            durum = 0;
            txt_miktar.Enabled = true;
            txt_miktar.Text = "";
            txt_miktar.BackColor = Color.White;
            txt_miktar.Focus();
            btn_oyna.Enabled = true;
            btn_oyna.Text = "Oyna";
            lbl_durum.Text = "Durum $: ";
        }

        //Oyun sonuçları için fonksiyon oluşturacağım.
        void Oyun_sonuclari()
        {
            //Eğer a ve b c ye eşit değilse
            if (System.Convert.ToInt32(a & b) != c)
            {
                //Kazanmayı 1 artır ve yazdır
                kazanma++;
                lbl_kazanma.Text = "Kazanma: " + kazanma;
                //Oyuncunun girdiği paranı 2 katı ve 2 nin katlarını kazanabilmesi için durum değişkenini 2 şer 2 şer artırıyorum
                durum += 2;
                lbl_durum.Text = "Durum: $" + Convert.ToInt32(txt_miktar.Text) * durum;
                //Oyuncu kazanırsa girilen miktar 2 katına çıkacak
                btn_oyna.Text = "Oynamaya devam et...";
                lbl_slot.Text = "Tebrikler Kazandınız...";
            }
            //Kaybetme durumunda oluşacakları yazacağım
            else
            {
                lbl_slot.Text = "Kaybettiniz Tekrar deneyin...";
                kaybetme++;
                lbl_kaybetme.Text = "Loss :"+ kaybetme;
                lbl_durum.Text = "Durum $: 0";
                //Kaybetme durumunda miktar kutucuğu boşalırsa kullanıcı oyna tuşunu kullanamayacak ve slotlar sıfırlanacak.
                durum = 0;
                txt_miktar.Text = "";
                btn_oyna.Enabled = false;
                pictureBox1.Image = Properties.Resources.dollar;
                pictureBox2.Image = Properties.Resources.dollar;
                pictureBox3.Image = Properties.Resources.dollar;
            }
        }

        private void btn_oyna_Click(object sender, EventArgs e)
        {
            //Eğer bahis kısmındaki miktar boş ise kullanıcıya bahis değeri girmesini istedim.
            if (txt_miktar.Text == "")
            {
                MessageBox.Show("Lütfen ekranda gördüğünüz boş kutucuğa bahis oynayacağınız miktarı girin");
            }
            else
            {
                timer1.Enabled = true;
                //Timer 1 in koşullu biçimlendirmesini açtım.
                lbl_slot.Text = "Slot";
                txt_miktar.Enabled = false;
                //Enabled = False ile koşullu biçimlendirmeyi kapattım.
                txt_miktar.BackColor = Color.Black;
                //Arka plan rengini siyah yaptım.
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Hamleyi 1 artırdık
            hamle++;
            //Hamle 30 dan küçükse rastgele komutu ile  atanan değişkeni  5 defa döndürecek.
            if (hamle<30)
            {
                a = rastgele.Next(5);
                b = rastgele.Next(5);
                c = rastgele.Next(5);
                //Random fonksiyonu ve switch ile farklı resimler döndüreceğim. 
                // a değişkeninin slotu
                switch (a)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.altın;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.gümüş;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.bronz;
                        break;
                }
                // b değişkeninin slotu
                switch (b)
                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.altın;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.gümüş;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.bronz;
                        break;
                }
                //  c değişkeninin slotu
                switch (c)
                {
                    case 1:
                        pictureBox3.Image = Properties.Resources.altın;
                        break;
                    case 2:
                        pictureBox3.Image = Properties.Resources.gümüş;
                        break;
                    case 3:
                        pictureBox3.Image = Properties.Resources.bronz;
                        break;
                }


            }
            else
            {
                timer1.Enabled = false;
                hamle = 0;
                //Fonksiyonumuzu çağırıyorum.
                Oyun_sonuclari();
            }
        }
    }
}
