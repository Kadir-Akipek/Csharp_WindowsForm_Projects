using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class form_poker : Form
    {
        public form_poker()
        {
            InitializeComponent();
        }
        //Önce kullanacağım desteleri oluşturacağım.
        ArrayList kartlar = new ArrayList();
        string[] kartTur = new string[] { "Maça", "Karo", "Sinek", "Kupa" };
        string[] kartNo = new string[] { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Vale", "Kız", "Papaz" };
        //Kartları rastgele dağıtabilmek için random komutumu oluşturacağım.
        Random rastgele = new Random();

        ArrayList oyuncu1deger = new ArrayList();
        ArrayList oyuncu2deger = new ArrayList();
        ArrayList oyuncu3deger = new ArrayList();
        ArrayList oyuncu4deger = new ArrayList();
        //Kartları sayabilmek için sayac oluşturdum.
        int sayac = 0;
        string yazi;

        void yazdirma()
        {
            // Sayacın durumuna göre oyuncuların ellerindeki kartların durumu yazdırılıyor.
            if (sayac == 0)
            {
                yazi = "Elinizde bir Şey yok";
            }
            if (sayac == 1)
            {
                yazi = "Elinizde ikili var";
            }
            if (sayac == 2)
            {
                yazi = "Elinizde üçlü var";
            }
            if (sayac == 3)
            {
                yazi = "Elinizde dörtlü var";
            }
            if (sayac == 4)
            {
                yazi = "Elinizde beşli var";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_kartdagit_Click(object sender, EventArgs e)
        {
            //Önce kartları dağıtacağımız listbox ları temizleyeceğim.
            lbx_oyuncu1.Items.Clear();
            lbx_oyuncu2.Items.Clear();
            lbx_oyuncu3.Items.Clear();
            lbx_oyuncu4.Items.Clear();

            lbl5.Text = "";
            lbl6.Text = "";
            lbl7.Text = "";
            lbl8.Text = "";

            kartlar.Clear();

            //Şimdi kartları oluşturacağız

            //For döngüsü ile kartları saydıracağız
            //Gelen kart değerlerini 2. bir for döngüsü ile kartlara yazdıracağız.
            for (int i = 0; i < kartTur.Length; i++)
            {
                for (int x = 0; x < kartNo.Length; x++)
                {
                    string gelenkart = kartTur[i] + "-" + kartNo[x];
                    kartlar.Add(gelenkart);
                }
            }

            //Oyuncu1 in kartlarını oluşturacağım.
            for (int i = 0; i < 5; i++)
            {
                int gidenkart = rastgele.Next(0, kartlar.Count);
                lbx_oyuncu1.Items.Add(kartlar[gidenkart]);
                //RemoveAt metodu ile gelen kartı bir daha gelmesin diye kaldıracağım.
                kartlar.RemoveAt(gidenkart);
            }

            //Oyuncu2 nin kartlarını oluşturacağım.
            for (int i = 0; i < 5; i++)
            {
                int gidenkart = rastgele.Next(0, kartlar.Count);
                lbx_oyuncu2.Items.Add(kartlar[gidenkart]);
                //RemoveAt metodu ile gelen kartı bir daha gelmesin diye kaldıracağım.
                kartlar.RemoveAt(gidenkart);
            }

            //Oyuncu3 ün kartlarını oluşturacağım.
            for (int i = 0; i < 5; i++)
            {
                int gidenkart = rastgele.Next(0, kartlar.Count);
                lbx_oyuncu3.Items.Add(kartlar[gidenkart]);
                //RemoveAt metodu ile gelen kartı bir daha gelmesin diye kaldıracağım.
                kartlar.RemoveAt(gidenkart);
            }

            //Oyuncu4 ün kartlarını oluşturacağım.
            for (int i = 0; i < 5; i++)
            {
                int gidenkart = rastgele.Next(0, kartlar.Count);
                lbx_oyuncu4.Items.Add(kartlar[gidenkart]);
                //RemoveAt metodu ile gelen kartı bir daha gelmesin diye kaldıracağım.
                kartlar.RemoveAt(gidenkart);
            }
        }

        private void btn_kapa_Click(object sender, EventArgs e)
        {
            //Çıkış butonunu yaptım.
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Eminmisiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            {
                if (sonuc == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void btn_kartkonrol_Click(object sender, EventArgs e)
        {
            //Oyuncuların ellerindeki kartları kontrol edeceğim.
            //Oyuncu 1 için
            {
                foreach (string item in lbx_oyuncu1.Items)  
                {
                    //Split metodu ile kartları "-" işaretiyle ayırıyorum, ikinci kısımda index 1 oluyor , ayrı bir diziye alıyorum.
                    string[] dizi = item.Split('-');  
                    //Contain metodu ile dizide önceden tanımladığım elemanı arıyorum.
                    if (oyuncu1deger.Contains(dizi[1]))  
                    {
                        sayac++;                        
                    }
                    oyuncu1deger.Add(dizi[1]);           
                }
                //Oluşturduğum metodu çağırıyorum.
                yazdirma();
                //Değişkenden gelen değeri lbl 5 e yazdırıyorum
                lbl5.Text = yazi;     
                //Yeni dağıtım işlemi için sayacımı sıfırlayıp Oyuncu1 in değerini temizliyorum
                sayac = 0;
                oyuncu1deger.Clear();
            }

            //Oyuncu 2 için
            {
                foreach (string item in lbx_oyuncu2.Items)
                {
                    //Split metodu ile kartları "-" işaretiyle ayırıyorum, ikinci kısımda index 1 oluyor , ayrı bir diziye alıyorum.
                    string[] dizi = item.Split('-');
                    //Contain metodu ile dizide önceden tanımladığım elemanı arıyorum.
                    if (oyuncu2deger.Contains(dizi[1]))
                    {
                        sayac++;
                    }
                    oyuncu2deger.Add(dizi[1]);
                }
                //Oluşturduğum metodu çağırıyorum.
                yazdirma();
                //Değişkenden gelen değeri lbl 6 ya yazdırıyorum
                lbl6.Text = yazi;
                //Yeni dağıtım işlemi için sayacımı sıfırlayıp Oyuncu2 nin değerini temizliyorum
                sayac = 0;
                oyuncu1deger.Clear();
            }

            //Oyuncu 3 için
            {
                foreach (string item in lbx_oyuncu3.Items)
                {
                    //Split metodu ile kartları "-" işaretiyle ayırıyorum, ikinci kısımda index 1 oluyor , ayrı bir diziye alıyorum.
                    string[] dizi = item.Split('-');
                    //Contain metodu ile dizide önceden tanımladığım elemanı arıyorum.
                    if (oyuncu3deger.Contains(dizi[1]))
                    {
                        sayac++;
                    }
                    oyuncu3deger.Add(dizi[1]);
                }
                //Oluşturduğum metodu çağırıyorum.
                yazdirma();
                //Değişkenden gelen değeri lbl 7 ye yazdırıyorum
                lbl7.Text = yazi;
                //Yeni dağıtım işlemi için sayacımı sıfırlayıp Oyuncu3 ün değerini temizliyorum
                sayac = 0;
                oyuncu3deger.Clear();
            }

            //Oyuncu 4 için
            {
                foreach (string item in lbx_oyuncu4.Items)
                {
                    //Split metodu ile kartları "-" işaretiyle ayırıyorum, ikinci kısımda index 1 oluyor , ayrı bir diziye alıyorum.
                    string[] dizi = item.Split('-');
                    //Contain metodu ile dizide önceden tanımladığım elemanı arıyorum.
                    if (oyuncu4deger.Contains(dizi[1]))
                    {
                        sayac++;
                    }
                    oyuncu4deger.Add(dizi[1]);
                }
                //Oluşturduğum metodu çağırıyorum.
                yazdirma();
                //Değişkenden gelen değeri lbl 8 e yazdırıyorum
                lbl8.Text = yazi;
                //Yeni dağıtım işlemi için sayacımı sıfırlayıp Oyuncu4 ün değerini temizliyorum
                sayac = 0;
                oyuncu4deger.Clear();
            }

        }
    }
}
