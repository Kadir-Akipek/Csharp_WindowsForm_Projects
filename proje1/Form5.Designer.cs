namespace proje1
{
    partial class form_buyukkucuk_uyum
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
            this.txt_kelime = new System.Windows.Forms.TextBox();
            this.btn_kontrol = new System.Windows.Forms.Button();
            this.lbl_durum = new System.Windows.Forms.Label();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_kelime
            // 
            this.txt_kelime.Location = new System.Drawing.Point(162, 63);
            this.txt_kelime.Name = "txt_kelime";
            this.txt_kelime.Size = new System.Drawing.Size(201, 27);
            this.txt_kelime.TabIndex = 0;
            // 
            // btn_kontrol
            // 
            this.btn_kontrol.BackColor = System.Drawing.Color.Yellow;
            this.btn_kontrol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_kontrol.Location = new System.Drawing.Point(12, 116);
            this.btn_kontrol.Name = "btn_kontrol";
            this.btn_kontrol.Size = new System.Drawing.Size(131, 58);
            this.btn_kontrol.TabIndex = 1;
            this.btn_kontrol.Text = "Kontrol Et";
            this.btn_kontrol.UseVisualStyleBackColor = false;
            this.btn_kontrol.Click += new System.EventHandler(this.btn_kontrol_Click);
            // 
            // lbl_durum
            // 
            this.lbl_durum.AutoSize = true;
            this.lbl_durum.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_durum.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_durum.Location = new System.Drawing.Point(12, 205);
            this.lbl_durum.Name = "lbl_durum";
            this.lbl_durum.Size = new System.Drawing.Size(80, 31);
            this.lbl_durum.TabIndex = 2;
            this.lbl_durum.Text = "Sonuc";
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Red;
            this.btn_cikis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cikis.Location = new System.Drawing.Point(12, 277);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(138, 45);
            this.btn_cikis.TabIndex = 3;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kelime giriniz:";
            // 
            // form_buyukkucuk_uyum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(453, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.lbl_durum);
            this.Controls.Add(this.btn_kontrol);
            this.Controls.Add(this.txt_kelime);
            this.Name = "form_buyukkucuk_uyum";
            this.Text = "Büyük - Küçük Ünlü Uyumu";
            this.Load += new System.EventHandler(this.form_buyukkucuk_uyum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_kelime;
        private Button btn_kontrol;
        private Label lbl_durum;
        private Button btn_cikis;
        private Label label1;
    }
}