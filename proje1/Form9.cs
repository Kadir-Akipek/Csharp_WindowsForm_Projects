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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //Satranç tahtasının sütunlarının içinde bulundurduğu harfleri listeye atadım
            List<string> harf = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H" };

            //Harf listesini foreach döngüsüne aldık 
            foreach (var item in harf)
            {
                //İç içe döngü oluşturup harf listesindeki eleman sayısı kadar bir for döngüsü oluşturduk böylece combobox da iç içe fonksiyon oluşturdum
                for (int i = 1; i < 9; i++)
                {
                    //combobox a oluşturduğumuz iç içe döngüyü ekliyorum
                    comboBox1.Items.Add(item + i);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("A1"))
            {
                label3.Text = "B3,C2";
            }
            else if (comboBox1.SelectedItem.Equals("A2"))
            {
                label3.Text = "B4,C3,C1 ";
            }
            else if (comboBox1.SelectedItem.Equals("A3"))
            {
                label3.Text = "B5,C4,C2,B1 ";
            }
            else if (comboBox1.SelectedItem.Equals("A4"))
            {
                label3.Text = "B6,C5,C3,B2 ";
            }
            else if (comboBox1.SelectedItem.Equals("A5"))
            {
                label3.Text = "B7,C6,C4,B3 ";
            }
            else if (comboBox1.SelectedItem.Equals("A6"))
            {
                label3.Text = "B8,C7,C5,B4  ";
            }
            else if (comboBox1.SelectedItem.Equals("A7"))
            {
                label3.Text = "B5,C6,C8  ";
            }
            else if (comboBox1.SelectedItem.Equals("A8"))
            {
                label3.Text = "B6,C7";
            }
            else if (comboBox1.SelectedItem.Equals("B1"))
            {
                label3.Text = "A3,C3,D2";
            }
            else if (comboBox1.SelectedItem.Equals("B2"))
            {
                label3.Text = "A4,C4,D3,D1";
            }
            else if (comboBox1.SelectedItem.Equals("B3"))
            {
                label3.Text = "A5,C5,D4,D2,C1,A1";
            }
            else if (comboBox1.SelectedItem.Equals("B4"))
            {
                label3.Text = "A2,C2,D3,D5,C6,A6";
            }
            else if (comboBox1.SelectedItem.Equals("B5"))
            {
                label3.Text = "A3,C3,D4,D6,C7,A7";
            }
            else if (comboBox1.SelectedItem.Equals("B6"))
            {
                label3.Text = "A4,C4,D5,D7,C8,A8";
            }
            else if (comboBox1.SelectedItem.Equals("B6"))
            {
                label3.Text = "A4,C4,D5,D7,C8,A8";
            }
            else if (comboBox1.SelectedItem.Equals("B7"))
            {
                label3.Text = "A5,C5,D6,D8";
            }
            else if (comboBox1.SelectedItem.Equals("B8"))
            {
                label3.Text = "A6,C6,D7";
            }
            else if (comboBox1.SelectedItem.Equals("C1"))
            {
                label3.Text = "A2,E2,B3,D3";
            }
            else if (comboBox1.SelectedItem.Equals("C2"))
            {
                label3.Text = "A1,E1,A3,E3,B4,D4";
            }
            else if (comboBox1.SelectedItem.Equals("C3"))
            {
                label3.Text = "A2,B1,D1,E2,A4,B5,D5,E4";
            }
            else if (comboBox1.SelectedItem.Equals("C4"))
            {
                label3.Text = "A3,B2,D2,E3,A5,B6,D6,E5";
            }
            else if (comboBox1.SelectedItem.Equals("C5"))
            {
                label3.Text = "A4,B3,D3,E4,A6,B7,D7,E6";
            }
            else if (comboBox1.SelectedItem.Equals("C6"))
            {
                label3.Text = "A5,B4,D4,E5,A7,B8,D8,E7";
            }
            else if (comboBox1.SelectedItem.Equals("C7"))
            {
                label3.Text = "A6,B5,D5,E6,A8,E8";
            }
            else if (comboBox1.SelectedItem.Equals("C8"))
            {
                label3.Text = "A7,B6,D6,E7";
            }
            else if (comboBox1.SelectedItem.Equals("D1"))
            {
                label3.Text = "B2,F2,C3,E3";
            }
            else if (comboBox1.SelectedItem.Equals("D2"))
            {
                label3.Text = "B1,F1,B3,F3,C4,E4";
            }
            else if (comboBox1.SelectedItem.Equals("D3"))
            {
                label3.Text = "B2,C1,E1,F2,B4,C5,E5,F4";
            }
            else if (comboBox1.SelectedItem.Equals("D4"))
            {
                label3.Text = "B3,C2,E2,F3,B5,C6,E6,F5";
            }
            else if (comboBox1.SelectedItem.Equals("D5"))
            {
                label3.Text = "B4,C3,E3,F4,B6,C7,E7,F6";
            }
            else if (comboBox1.SelectedItem.Equals("D6"))
            {
                label3.Text = "B5,C4,E4,F5,B7,C8,E8,F7";
            }
            else if (comboBox1.SelectedItem.Equals("D7"))
            {
                label3.Text = "B6,C5,E5,F6,B8,F8";
            }
            else if (comboBox1.SelectedItem.Equals("D8"))
            {
                label3.Text = "B8,C6,E6,F7";
            }
            else if (comboBox1.SelectedItem.Equals("E1"))
            {
                label3.Text = "C2,G2,D3,F3";
            }
            else if (comboBox1.SelectedItem.Equals("E2"))
            {
                label3.Text = "C1,G1,C3,G3,D4,F4";
            }
            else if (comboBox1.SelectedItem.Equals("E3"))
            {
                label3.Text = "C2,D1,F1,G2,C4,D5,F5,G4";
            }
            else if (comboBox1.SelectedItem.Equals("E4"))
            {
                label3.Text = "C3,D2,F2,G3,C5,D6,F6,G5";
            }
            else if (comboBox1.SelectedItem.Equals("E5"))
            {
                label3.Text = "C4,D3,F3,G4,C6,D7,F7,G6";
            }
            else if (comboBox1.SelectedItem.Equals("E6"))
            {
                label3.Text = "C5,D4,F4,G5,C7,D8,F8,G7";
            }
            else if (comboBox1.SelectedItem.Equals("E7"))
            {
                label3.Text = "C6,D5,F5,G6,C8,G8";
            }
            else if (comboBox1.SelectedItem.Equals("E8"))
            {
                label3.Text = "C7,D6,F6,G7";
            }
            else if (comboBox1.SelectedItem.Equals("F1"))
            {
                label3.Text = "D2,H2,E3,G3";
            }
            else if (comboBox1.SelectedItem.Equals("F2"))
            {
                label3.Text = "D1,H1,D3,H3,E4,G4";
            }
            else if (comboBox1.SelectedItem.Equals("F3"))
            {
                label3.Text = "D2,E1,G1,H2,D4,E5,G5,H4";
            }
            else if (comboBox1.SelectedItem.Equals("F4"))
            {
                label3.Text = "D3,E2,G2,H3,D5,E6,G6,H5";
            }
            else if (comboBox1.SelectedItem.Equals("F5"))
            {
                label3.Text = "D4,E3,G3,H4,D6,E7,G7,H6";
            }
            else if (comboBox1.SelectedItem.Equals("F6"))
            {
                label3.Text = "D5,E4,G4,H5,D7,E8,G8,H7";
            }
            else if (comboBox1.SelectedItem.Equals("F7"))
            {
                label3.Text = "D6,E5,G5,H6,D8,H8";
            }
            else if (comboBox1.SelectedItem.Equals("F8"))
            {
                label3.Text = "D7,E6,G6,H7";
            }
            else if (comboBox1.SelectedItem.Equals("G1"))
            {
                label3.Text = "E2,F3,H3";
            }
            else if (comboBox1.SelectedItem.Equals("G2"))
            {
                label3.Text = "E1,E3,F4,H4";
            }
            else if (comboBox1.SelectedItem.Equals("G3"))
            {
                label3.Text = "E2,F1,H1,H5,F5,E4";
            }
            else if (comboBox1.SelectedItem.Equals("G4"))
            {
                label3.Text = "E3,F2,H2,H6,F6,E5";
            }
            else if (comboBox1.SelectedItem.Equals("G5"))
            {
                label3.Text = "E4,F3,H3,H7,F7,E6";
            }
            else if (comboBox1.SelectedItem.Equals("G6"))
            {
                label3.Text = "E5,F4,H4,H8,F8,E7";
            }
            else if (comboBox1.SelectedItem.Equals("G7"))
            {
                label3.Text = "E6,F5,H5,E8";
            }
            else if (comboBox1.SelectedItem.Equals("G8"))
            {
                label3.Text = "E7,F6,H6";
            }
            else if (comboBox1.SelectedItem.Equals("H1"))
            {
                label3.Text = "F2,G3";
            }
            else if (comboBox1.SelectedItem.Equals("H2"))
            {
                label3.Text = "F3,G4,G1";
            }
            else if (comboBox1.SelectedItem.Equals("H3"))
            {
                label3.Text = "F4,G5,F2,G1";
            }
            else if (comboBox1.SelectedItem.Equals("H4"))
            {
                label3.Text = "F5,G6,F3,G2";
            }
            else if (comboBox1.SelectedItem.Equals("H5"))
            {
                label3.Text = "F6,G7,F4,G3";
            }
            else if (comboBox1.SelectedItem.Equals("H6"))
            {
                label3.Text = "F7,G8,F5,G4";
            }
            else if (comboBox1.SelectedItem.Equals("H7"))
            {
                label3.Text = "F8,F6,G5";
            }
            else if (comboBox1.SelectedItem.Equals("H8"))
            {
                label3.Text = "F7,G6";
            }
            else
            {
                //comboboxdaki belirtilen değerlerden başka bir değer seçilmiş ise label 3 te uyarı mesajı yazdırdık
                label3.Text = "Herhangi bir konum bulunamadı !";
            }
        }
    }

}
