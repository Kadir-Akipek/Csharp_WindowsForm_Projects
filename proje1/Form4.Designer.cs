namespace proje1
{
    partial class form_askerdagitim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_isimekle = new System.Windows.Forms.Button();
            this.btn_ilekle = new System.Windows.Forms.Button();
            this.tbx_isimgir = new System.Windows.Forms.TextBox();
            this.tbx_ilgir = new System.Windows.Forms.TextBox();
            this.lbx_isim = new System.Windows.Forms.ListBox();
            this.lbx_il = new System.Windows.Forms.ListBox();
            this.btn_dagit = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.lbx_sonuc = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_isimekle
            // 
            this.btn_isimekle.Location = new System.Drawing.Point(54, 339);
            this.btn_isimekle.Name = "btn_isimekle";
            this.btn_isimekle.Size = new System.Drawing.Size(125, 56);
            this.btn_isimekle.TabIndex = 0;
            this.btn_isimekle.Text = "Asker ismini giriniz";
            this.btn_isimekle.UseVisualStyleBackColor = true;
            this.btn_isimekle.Click += new System.EventHandler(this.btn_isimekle_Click);
            // 
            // btn_ilekle
            // 
            this.btn_ilekle.Location = new System.Drawing.Point(396, 339);
            this.btn_ilekle.Name = "btn_ilekle";
            this.btn_ilekle.Size = new System.Drawing.Size(125, 56);
            this.btn_ilekle.TabIndex = 1;
            this.btn_ilekle.Text = "İl ekle";
            this.btn_ilekle.UseVisualStyleBackColor = true;
            this.btn_ilekle.Click += new System.EventHandler(this.btn_ilekle_Click);
            // 
            // tbx_isimgir
            // 
            this.tbx_isimgir.Location = new System.Drawing.Point(54, 291);
            this.tbx_isimgir.Name = "tbx_isimgir";
            this.tbx_isimgir.Size = new System.Drawing.Size(125, 27);
            this.tbx_isimgir.TabIndex = 2;
            this.tbx_isimgir.TextChanged += new System.EventHandler(this.tbx_isimgir_TextChanged);
            // 
            // tbx_ilgir
            // 
            this.tbx_ilgir.Location = new System.Drawing.Point(396, 291);
            this.tbx_ilgir.Name = "tbx_ilgir";
            this.tbx_ilgir.Size = new System.Drawing.Size(125, 27);
            this.tbx_ilgir.TabIndex = 3;
            // 
            // lbx_isim
            // 
            this.lbx_isim.FormattingEnabled = true;
            this.lbx_isim.ItemHeight = 20;
            this.lbx_isim.Location = new System.Drawing.Point(32, 102);
            this.lbx_isim.Name = "lbx_isim";
            this.lbx_isim.Size = new System.Drawing.Size(250, 164);
            this.lbx_isim.TabIndex = 4;
            // 
            // lbx_il
            // 
            this.lbx_il.FormattingEnabled = true;
            this.lbx_il.ItemHeight = 20;
            this.lbx_il.Location = new System.Drawing.Point(387, 102);
            this.lbx_il.Name = "lbx_il";
            this.lbx_il.Size = new System.Drawing.Size(245, 164);
            this.lbx_il.TabIndex = 5;
            // 
            // btn_dagit
            // 
            this.btn_dagit.Location = new System.Drawing.Point(75, 411);
            this.btn_dagit.Name = "btn_dagit";
            this.btn_dagit.Size = new System.Drawing.Size(94, 65);
            this.btn_dagit.TabIndex = 6;
            this.btn_dagit.Text = "Dağıt";
            this.btn_dagit.UseVisualStyleBackColor = true;
            this.btn_dagit.Click += new System.EventHandler(this.btn_dagit_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(803, 419);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(112, 49);
            this.btn_temizle.TabIndex = 7;
            this.btn_temizle.Text = "Listeyi Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // lbx_sonuc
            // 
            this.lbx_sonuc.FormattingEnabled = true;
            this.lbx_sonuc.ItemHeight = 20;
            this.lbx_sonuc.Location = new System.Drawing.Point(762, 91);
            this.lbx_sonuc.Name = "lbx_sonuc";
            this.lbx_sonuc.Size = new System.Drawing.Size(353, 304);
            this.lbx_sonuc.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Askere gidecek kişilerin isimleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(278, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Askere gidecek kişilerin görev yapacakları şehir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(822, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sonuçlar";
            // 
            // form_askerdagitim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(1216, 622);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_sonuc);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_dagit);
            this.Controls.Add(this.lbx_il);
            this.Controls.Add(this.lbx_isim);
            this.Controls.Add(this.tbx_ilgir);
            this.Controls.Add(this.tbx_isimgir);
            this.Controls.Add(this.btn_ilekle);
            this.Controls.Add(this.btn_isimekle);
            this.Name = "form_askerdagitim";
            this.Text = "Asker Dağıtım Otomasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_isimekle;
        private Button btn_ilekle;
        private TextBox tbx_isimgir;
        private TextBox tbx_ilgir;
        private ListBox lbx_isim;
        private ListBox lbx_il;
        private Button btn_dagit;
        private Button btn_temizle;
        private ListBox lbx_sonuc;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}