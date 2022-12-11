namespace proje1
{
    partial class form_slotmakine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_slotmakine));
            this.lbl_slot = new System.Windows.Forms.Label();
            this.lbl_durum = new System.Windows.Forms.Label();
            this.lbl_kazanma = new System.Windows.Forms.Label();
            this.lbl_kaybetme = new System.Windows.Forms.Label();
            this.lbl_bahismiktar = new System.Windows.Forms.Label();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.btn_oyna = new System.Windows.Forms.Button();
            this.btn_bahis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_slot
            // 
            this.lbl_slot.AutoSize = true;
            this.lbl_slot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_slot.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_slot.Location = new System.Drawing.Point(12, 26);
            this.lbl_slot.Name = "lbl_slot";
            this.lbl_slot.Size = new System.Drawing.Size(129, 28);
            this.lbl_slot.TabIndex = 3;
            this.lbl_slot.Text = "Slot Makinesi";
            // 
            // lbl_durum
            // 
            this.lbl_durum.AutoSize = true;
            this.lbl_durum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_durum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_durum.Location = new System.Drawing.Point(12, 68);
            this.lbl_durum.Name = "lbl_durum";
            this.lbl_durum.Size = new System.Drawing.Size(76, 28);
            this.lbl_durum.TabIndex = 4;
            this.lbl_durum.Text = "Durum:";
            // 
            // lbl_kazanma
            // 
            this.lbl_kazanma.AutoSize = true;
            this.lbl_kazanma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_kazanma.ForeColor = System.Drawing.Color.Green;
            this.lbl_kazanma.Location = new System.Drawing.Point(12, 210);
            this.lbl_kazanma.Name = "lbl_kazanma";
            this.lbl_kazanma.Size = new System.Drawing.Size(106, 28);
            this.lbl_kazanma.TabIndex = 5;
            this.lbl_kazanma.Text = "Kazanma:0";
            // 
            // lbl_kaybetme
            // 
            this.lbl_kaybetme.AutoSize = true;
            this.lbl_kaybetme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_kaybetme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_kaybetme.Location = new System.Drawing.Point(12, 249);
            this.lbl_kaybetme.Name = "lbl_kaybetme";
            this.lbl_kaybetme.Size = new System.Drawing.Size(115, 28);
            this.lbl_kaybetme.TabIndex = 6;
            this.lbl_kaybetme.Text = "Kaybetme:0";
            // 
            // lbl_bahismiktar
            // 
            this.lbl_bahismiktar.AutoSize = true;
            this.lbl_bahismiktar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_bahismiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_bahismiktar.Location = new System.Drawing.Point(199, 199);
            this.lbl_bahismiktar.Name = "lbl_bahismiktar";
            this.lbl_bahismiktar.Size = new System.Drawing.Size(122, 28);
            this.lbl_bahismiktar.TabIndex = 7;
            this.lbl_bahismiktar.Text = "Bahis-Miktar";
            // 
            // txt_miktar
            // 
            this.txt_miktar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_miktar.Location = new System.Drawing.Point(199, 230);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(125, 43);
            this.txt_miktar.TabIndex = 8;
            // 
            // btn_oyna
            // 
            this.btn_oyna.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_oyna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_oyna.Location = new System.Drawing.Point(12, 290);
            this.btn_oyna.Name = "btn_oyna";
            this.btn_oyna.Size = new System.Drawing.Size(129, 57);
            this.btn_oyna.TabIndex = 9;
            this.btn_oyna.Text = "Oyna";
            this.btn_oyna.UseVisualStyleBackColor = true;
            this.btn_oyna.Click += new System.EventHandler(this.btn_oyna_Click);
            // 
            // btn_bahis
            // 
            this.btn_bahis.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_bahis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_bahis.Location = new System.Drawing.Point(199, 290);
            this.btn_bahis.Name = "btn_bahis";
            this.btn_bahis.Size = new System.Drawing.Size(125, 57);
            this.btn_bahis.TabIndex = 10;
            this.btn_bahis.Text = "Yeni Bahis";
            this.btn_bahis.UseVisualStyleBackColor = true;
            this.btn_bahis.Click += new System.EventHandler(this.btn_bahis_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proje1.Properties.Resources.dollar;
            this.pictureBox1.Location = new System.Drawing.Point(33, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proje1.Properties.Resources.dollar;
            this.pictureBox2.Location = new System.Drawing.Point(124, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::proje1.Properties.Resources.dollar;
            this.pictureBox3.Location = new System.Drawing.Point(215, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // form_slotmakine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(336, 359);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_bahis);
            this.Controls.Add(this.btn_oyna);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.lbl_bahismiktar);
            this.Controls.Add(this.lbl_kaybetme);
            this.Controls.Add(this.lbl_kazanma);
            this.Controls.Add(this.lbl_durum);
            this.Controls.Add(this.lbl_slot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_slotmakine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Makinesi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_slot;
        private Label lbl_durum;
        private Label lbl_kazanma;
        private Label lbl_kaybetme;
        private Label lbl_bahismiktar;
        private TextBox txt_miktar;
        private Button btn_oyna;
        private Button btn_bahis;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}