using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proje1
{
    public partial class form_notdefteri : Form
    {
        //Hocam öncelikle şunu söyleyeyim not defterini yabancı bi kanaldan bakıp yaptım ,kodları kendim yorumladım eğer yanlış yorumladığım yerler varsa kusura bakmayın.
        //Yeni formu oluşturduktan sonra Menu Strip tool unu ekleyerek araç çubuklarını oluşturdum.
        //Rich Text Box tool u ile metin yazacağımız kısmı oluşturdum.
        public form_notdefteri()
        {
            InitializeComponent();
        }
        private string file = "";

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Clear();
            //Yeni bir dosya açtığımzda ekranı temizledik.
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Exit ile uygulamadan çıkış yaptım.
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            //Dosya uzantısını kullanıcıya görünür hale getirip yazdırdık.
            openFileDialog1.Filter = "Text Files |*.txt";
            if (dr == DialogResult.OK)
            {
                StreamReader read = new StreamReader(openFileDialog1.FileName);
                //StreamReader, dosya içerisindeki verileri okumak için kullanılır.openFileDialog1 deki verileri okutup yeni oluşturduğumuz read adlı değişkene atadık.
                read.Close();
                file = openFileDialog1.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Yazdığımız verileri kaydetmeye yarayan kodlar.
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(saveFileDialog1.FileName);
                write.Write(rtb1.Text);
                write.Close();
            }
            else
            {
                try
                {
                    StreamWriter write = new StreamWriter(saveFileDialog1.FileName);
                    write.Write(rtb1.Text);
                    write.Close();
                }
                catch
                {

                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = printDialog1.ShowDialog();
            //dr adlı değişkene yazdığımız verileri atayıp gösterdik.
            if (dr == DialogResult.OK)
            //Eğer dr , dialog sonuçlarına eşit ise
            {

            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Undo yani geri alma işlemini gerçekleştirdik.
            if (rtb1.CanUndo == true)
            {
                rtb1.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Redo işlemini gerçekleştirdik.Undo nun tam tersidir.Yani ilerleyen kayıtları tutar.
            if (rtb1.CanRedo == true)
            {
                rtb1.Redo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Kesme işlemini gerçekleştirdik.
            if (rtb1.SelectedText != "")
            //Eğer richbox boş değilse kesme işlemini gerçekleştir.
            {
                rtb1.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Kopyalama işlemini gerçekleştirdik.
            if (rtb1.SelectionLength > 0)
            //Eğer metin uzunluğu 0 dan büyükse kopyalama işlemini gerçekleştir.
            {
                rtb1.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Yapıştırma işlemini gerçekleştirdik.
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                rtb1.Paste();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Richbox taki seçili kısmı sildik.
            rtb1.SelectedText = "";
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Richbox ta bulunan her şeyi temizledik.
            rtb1.Clear();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Richbox ta bulunan her şeyi seçtik.
            rtb1.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            DateTime dt = DateTime.Now;
            rtb1.Text = dt.ToString();
            //Date time daki sayısal değerleri string e çevirdik.
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                rtb1.Font = fontDialog1.Font;
            }
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.WordWrap = true;
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.WordWrap = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hakkında kısmını yazdım
            MessageBox.Show("Ücretsiz not defteri uygulaması");
        }

        private void rtb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
