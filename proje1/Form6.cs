using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        //global değişken tanımlarız burda
        int kapanmasuresi;
        string yenisaatdeger;
        string yenidakikadeger;
        string yenisaniyedeger;
        private void Form6_Load(object sender, EventArgs e)
        {
            //Form açıldığında timer1 i aktif ettik
            timer1.Enabled = true;
            lbl_1.Text = DateTime.Now.ToLongTimeString();
            //combobox1 e saat i yükledik(1 gün 24 saattir)
            for (int i = 0; i <=23 ; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 0; i <= 59; i++)
            {
                //combobox2 ve combobox3 e dakikayı ve saniyeyi yükledik(1 saat 60 dakikadır ve 1 dakika 60 saniyedir)
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(i);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Güncel saati yazdırdık
            lbl_1.Text = DateTime.Now.ToLongTimeString();
            if (lbl_yenisaat.Text == DateTime.Now.ToLongTimeString())                 //Ayarlanan saat ile güncel saat birbirine eşit olduğunda
            {
                //Bilgisayarı 30 sn içinde kapat
                System.Diagnostics.Process.Start("shutdown", "-f -s");
            }
        }

        private void btn_saatayarla_Click(object sender, EventArgs e)
        {
            //Eğer saate göre kapama seçiliyse combobox taki değerleri string olarak alacağım
            if (radioButton1.Checked == true)
            {
                string saat = comboBox1.SelectedItem.ToString();
                string dakika = comboBox2.SelectedItem.ToString();
                string saniye = comboBox3.SelectedItem.ToString();
                //Aldığım değerleri bilgisayar karşılaştırma yapabilsin diye int e convert edeceğim
                int saatdeger = Convert.ToInt32(saat);
                int dakikadeger = Convert.ToInt32(dakika);
                int saniyedeger = Convert.ToInt32(saniye);

                //Seçilen saat değeri tek basamaklıysa yani 10 dan küçükse başına 0 ekle
                if (saatdeger <10)
                {
                    yenisaatdeger = "0" + saatdeger.ToString();
                }
                else
                {
                    yenisaatdeger = saatdeger.ToString();
                }

                //Seçilen dakika değeri tek  basamaklıysa yani 10 dan küçükse başına 0 ekle
                if (dakikadeger < 10)
                {
                    yenidakikadeger = "0" + dakikadeger.ToString();
                }
                else
                {
                    yenidakikadeger = dakikadeger.ToString();
                }

                //Seçilen saniye değeri tek  basamaklıysa yani 10 dan küçükse başına 0 ekle
                if (saniyedeger < 10)
                {
                    yenisaniyedeger = "0" + saniyedeger.ToString();
                }
                else
                {
                    yenisaniyedeger = saniyedeger.ToString();
                }

                //Saat formatını belirlediğim karar yapısına göre label a yazdıracağım
                lbl_yenisaat.Text = yenisaatdeger + ":" + yenidakikadeger + ":" + yenisaniyedeger;
            }

            //Eğer dakikaya göre seçili ise
            //Seçilen dakika sıfıra eşit değilse 60 ile çarparak saniye değerine çeviriyorum
            if (radioButton2.Checked == true)
            {
                if (Convert.ToInt32(comboBox2.SelectedItem) != 0)
                {
                    int kapanmadakika = Convert.ToInt32(comboBox2.SelectedItem.ToString());
                    kapanmasuresi = 60 * kapanmadakika;
                    timer2.Start();
                }
                else
                {
                    MessageBox.Show("Lütfen sıfır dışında başka bir değer seçiniz");
                }
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            //Kapanma işlemini durdurmak için
            System.Diagnostics.Process.Start("shutdown", " -a");
            lbl_yenisaat.Text = "";
            timer2.Stop();
            MessageBox.Show("Bilgisayar Kapatma İşlemi durduruldu");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Eğer dakikaya göre kapat seçili ise saat ve saniye değeri girmeyeceğimiz için dakika ve saniye combobox larını false yapacağım
            comboBox1.Enabled = false;
            comboBox2.Enabled = true;
            comboBox3.Enabled = false;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //Kalan süreyi ekrana yazdıracağım
            kapanmasuresi--;
            lbl_yenisaat.Text = kapanmasuresi.ToString();
            Refresh();

            //Süre 0 a eşit olduğunda bilgisayarı 30 saniye içinde kapat
            if (kapanmasuresi == 0)
            {
                System.Diagnostics.Process.Start("shutdown", "-f -s");
            }
        }
        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            {
                if (sonuc == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}

