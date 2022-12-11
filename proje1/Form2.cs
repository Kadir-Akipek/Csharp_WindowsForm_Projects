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
    public partial class form_hesapmakinesi : Form
    {
        //C# girdiğimiz değerleri otomatikmen string olarak alır.İşlem yapabilmemiz için Convert metodunu kullanmalıyız.
        //Public kısmına girdiğimiz değişkenlere kodun tüm kısımlarından erişim sağlayabiliriz.
        double x, y;
        string islem;
        public form_hesapmakinesi()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lbl_panel.Text == "0")
            //Eğer paneldeki sayı 0 ise 0 yerine 1 yaz.
            {
                lbl_panel.Text = "1";
            }
            else
            //Değilse panele 1 yazdırmaya devam et.
            {
                lbl_panel.Text += 1;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lbl_panel.Text == "0")
            //Eğer paneldeki sayı 0 ise 0 yerine 2 yaz.
            {
                lbl_panel.Text = "2";
            }
            else
            //Değilse panele 2 yazdırmaya devam et.
            {
                lbl_panel.Text += 2;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lbl_panel.Text == "0")
            //Eğer paneldeki sayı 0 ise 0 yerine 3 yaz.
            {
                lbl_panel.Text = "3";
            }
            else
            //Değilse panele 3 yazdırmaya devam et.
            {
                lbl_panel.Text += 3;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lbl_panel.Text == "0")
            //Eğer paneldeki sayı 0 ise 0 yerine 4 yaz.
            {
                lbl_panel.Text = "4";
            }
            else
            //Değilse panele 4 yazdırmaya devam et.
            {
                lbl_panel.Text += 4;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lbl_panel.Text == "0")
            //Eğer paneldeki sayı 0 ise 0 yerine 5 yaz.
            {
                lbl_panel.Text = "5";
            }
            else
            //Değilse panele 5 yazdırmaya devam et.
            {
                lbl_panel.Text += 5;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lbl_panel.Text == "0")
            //Eğer paneldeki sayı 0 ise 0 yerine 6 yaz.
            {
                lbl_panel.Text = "6";
            }
            else
            //Değilse panele 6 yazdırmaya devam et.
            {
                lbl_panel.Text += 6;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lbl_panel.Text == "0")
            //Eğer paneldeki sayı 0 ise 0 yerine 7 yaz.
            {
                lbl_panel.Text = "7";
            }
            else
            //Değilse panele 7 yazdırmaya devam et.
            {
                lbl_panel.Text += 7;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lbl_panel.Text == "0")
            //Eğer paneldeki sayı 0 ise 0 yerine 8 yaz.
            {
                lbl_panel.Text = "8";
            }
            else
            //Değilse panele 8 yazdırmaya devam et.
            {
                lbl_panel.Text += 8;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lbl_panel.Text == "0")
            //Eğer paneldeki sayı 0 ise 0 yerine 9 yaz.
            {
                lbl_panel.Text = "9";
            }
            else
            //Değilse panele 9 yazdırmaya devam et.
            {
                lbl_panel.Text += 9;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lbl_panel.Text == "0")
            //Eğer paneldeki sayı 0 ise 0 yerine 0 yaz.
            {
                lbl_panel.Text = "0";
            }
            else
            //Değilse panele 0 yazdırmaya devam et.
            {
                lbl_panel.Text += 0;
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(lbl_panel.Text) > 0)
            {
                lbl_panel.Text = lbl_panel.Text.Remove(lbl_panel.Text.Length - 1, 1);
                //Eğer paneldeki sayı 0 dan büyükse paneledeki sayıyı birer birer sil.
                if (lbl_panel.Text.Length == 0)
                //Panelde kalan son sayı 0 a eşit ise silme işlemini durdur.Bunu yapmamın sebebi sınır aşımı durumunu önlemek.
                {
                    lbl_panel.Text = "0";
                }
            }
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(lbl_panel.Text);
            islem = "+";
            //Toplama fonksiyonumuzu + olarak kaydettik.
            lbl_gecmis.Text = lbl_panel.Text + "+";
            lbl_panel.Text = "0";
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(lbl_panel.Text);
            if (islem == "+")
            //Eğer işlem + ise toplama işlemini gerçekleştir.
            {
                lbl_panel.Text = Convert.ToString(x + y);
                lbl_gecmis.Text = "";
            }
            if (islem == "-")
            //Eğer işlem - ise toplama işlemini gerçekleştir.
            {
                lbl_panel.Text = Convert.ToString(x - y);
                lbl_gecmis.Text = "";
            }
            if (islem == "*")
            //Eğer işlem * ise toplama işlemini gerçekleştir.
            {
                lbl_panel.Text = Convert.ToString(x * y);
                lbl_gecmis.Text = "";
            }
            if (islem == "/")
            //Eğer işlem / ise toplama işlemini gerçekleştir.
            {
                lbl_panel.Text = Convert.ToString(x / y);
                lbl_gecmis.Text = "";
            }
            if (islem == "mod")
                //Eğer işlem "mod" ise mod alma işlemini gerçekleştir.
            {
                lbl_panel.Text=Convert.ToString(x % y);
                lbl_gecmis.Text = "";
            }
        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(lbl_panel.Text);
            islem = "-";
            //Çıkarma fonksiyonumuzu - olarak kaydettik.
            lbl_gecmis.Text = lbl_panel.Text + "-";
            lbl_panel.Text = "0";
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(lbl_panel.Text);
            islem = "*";
            //Çarpma fonksiyonumuzu * olarak kaydettik.
            lbl_gecmis.Text = lbl_panel.Text + "*";
            lbl_panel.Text = "0";
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(lbl_panel.Text);
            islem = "/";
            //Bölme fonksiyonumuzu / olarak kaydettik.
            lbl_gecmis.Text = lbl_panel.Text + "/";
            lbl_panel.Text = "0";
        }

        private void btn_modal_Click(object sender, EventArgs e)
        {
            //Mod alma fonksiyonumuzu "mod" olarak kaydettik.
            x = Convert.ToDouble(lbl_panel.Text);
            islem = "mod";
            lbl_gecmis.Text = lbl_panel.Text + "mod";
            lbl_panel.Text = "0";
        }

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            lbl_panel.Text = "0";
            //Paneli sıfırlar.
        }
    }
}
