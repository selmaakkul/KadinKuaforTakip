namespace GerçekNypProjem
{
    partial class CagriForm
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
            this.lstMusteriler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.grpMusteri = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.duzenleSoyad = new System.Windows.Forms.TextBox();
            this.duzenleAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.Label();
            this.grpEkle = new System.Windows.Forms.GroupBox();
            this.btnKaydet1 = new System.Windows.Forms.Button();
            this.txtAd1 = new System.Windows.Forms.TextBox();
            this.txtSoyad1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTalepAd = new System.Windows.Forms.TextBox();
            this.txtTalepSoyad = new System.Windows.Forms.TextBox();
            this.cmbHizmet = new System.Windows.Forms.ComboBox();
            this.btnTalepKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpMusteri.SuspendLayout();
            this.grpEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMusteriler
            // 
            this.lstMusteriler.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstMusteriler.FormattingEnabled = true;
            this.lstMusteriler.ItemHeight = 16;
            this.lstMusteriler.Location = new System.Drawing.Point(40, 46);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(203, 308);
            this.lstMusteriler.TabIndex = 0;
            this.lstMusteriler.SelectedIndexChanged += new System.EventHandler(this.lstMusteriler_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(76, 447);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 39);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(76, 401);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(120, 39);
            this.btnDuzenle.TabIndex = 2;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(76, 359);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 39);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // grpMusteri
            // 
            this.grpMusteri.Controls.Add(this.btnKaydet);
            this.grpMusteri.Controls.Add(this.duzenleSoyad);
            this.grpMusteri.Controls.Add(this.duzenleAd);
            this.grpMusteri.Controls.Add(this.txtSoyad);
            this.grpMusteri.Controls.Add(this.txtAd);
            this.grpMusteri.Location = new System.Drawing.Point(443, 127);
            this.grpMusteri.Name = "grpMusteri";
            this.grpMusteri.Size = new System.Drawing.Size(164, 220);
            this.grpMusteri.TabIndex = 4;
            this.grpMusteri.TabStop = false;
            this.grpMusteri.Text = "MÜŞTERİ";
            this.grpMusteri.Visible = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(31, 152);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 32);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // duzenleSoyad
            // 
            this.duzenleSoyad.Location = new System.Drawing.Point(31, 104);
            this.duzenleSoyad.Name = "duzenleSoyad";
            this.duzenleSoyad.Size = new System.Drawing.Size(100, 22);
            this.duzenleSoyad.TabIndex = 3;
            // 
            // duzenleAd
            // 
            this.duzenleAd.Location = new System.Drawing.Point(31, 51);
            this.duzenleAd.Name = "duzenleAd";
            this.duzenleAd.Size = new System.Drawing.Size(100, 22);
            this.duzenleAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.AutoSize = true;
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(28, 85);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(51, 17);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Text = "SOYAD";
            // 
            // txtAd
            // 
            this.txtAd.AutoSize = true;
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(28, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(27, 17);
            this.txtAd.TabIndex = 0;
            this.txtAd.Text = "AD";
            // 
            // grpEkle
            // 
            this.grpEkle.BackColor = System.Drawing.Color.LavenderBlush;
            this.grpEkle.Controls.Add(this.btnKaydet1);
            this.grpEkle.Controls.Add(this.txtAd1);
            this.grpEkle.Controls.Add(this.txtSoyad1);
            this.grpEkle.Controls.Add(this.label2);
            this.grpEkle.Controls.Add(this.label1);
            this.grpEkle.Location = new System.Drawing.Point(91, 130);
            this.grpEkle.Name = "grpEkle";
            this.grpEkle.Size = new System.Drawing.Size(184, 268);
            this.grpEkle.TabIndex = 5;
            this.grpEkle.TabStop = false;
            this.grpEkle.Text = "YENİ MÜŞTERİ";
            this.grpEkle.Visible = false;
            this.grpEkle.Enter += new System.EventHandler(this.grpEkle_Enter);
            // 
            // btnKaydet1
            // 
            this.btnKaydet1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet1.Location = new System.Drawing.Point(44, 202);
            this.btnKaydet1.Name = "btnKaydet1";
            this.btnKaydet1.Size = new System.Drawing.Size(85, 32);
            this.btnKaydet1.TabIndex = 5;
            this.btnKaydet1.Text = "KAYDET";
            this.btnKaydet1.UseVisualStyleBackColor = true;
            this.btnKaydet1.Click += new System.EventHandler(this.btnKaydet1_Click);
            // 
            // txtAd1
            // 
            this.txtAd1.Location = new System.Drawing.Point(44, 83);
            this.txtAd1.Name = "txtAd1";
            this.txtAd1.Size = new System.Drawing.Size(100, 22);
            this.txtAd1.TabIndex = 4;
            // 
            // txtSoyad1
            // 
            this.txtSoyad1.Location = new System.Drawing.Point(44, 142);
            this.txtSoyad1.Name = "txtSoyad1";
            this.txtSoyad1.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "SOYAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "AD";
            // 
            // txtTalepAd
            // 
            this.txtTalepAd.Location = new System.Drawing.Point(599, 272);
            this.txtTalepAd.Name = "txtTalepAd";
            this.txtTalepAd.Size = new System.Drawing.Size(100, 22);
            this.txtTalepAd.TabIndex = 6;
            // 
            // txtTalepSoyad
            // 
            this.txtTalepSoyad.Location = new System.Drawing.Point(599, 332);
            this.txtTalepSoyad.Name = "txtTalepSoyad";
            this.txtTalepSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtTalepSoyad.TabIndex = 7;
            // 
            // cmbHizmet
            // 
            this.cmbHizmet.FormattingEnabled = true;
            this.cmbHizmet.Location = new System.Drawing.Point(599, 401);
            this.cmbHizmet.Name = "cmbHizmet";
            this.cmbHizmet.Size = new System.Drawing.Size(121, 24);
            this.cmbHizmet.TabIndex = 8;
            // 
            // btnTalepKaydet
            // 
            this.btnTalepKaydet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTalepKaydet.Location = new System.Drawing.Point(599, 441);
            this.btnTalepKaydet.Name = "btnTalepKaydet";
            this.btnTalepKaydet.Size = new System.Drawing.Size(121, 45);
            this.btnTalepKaydet.TabIndex = 9;
            this.btnTalepKaydet.Text = "KAYDET";
            this.btnTalepKaydet.UseVisualStyleBackColor = true;
            this.btnTalepKaydet.Click += new System.EventHandler(this.btnTalepKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(600, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Müşteri Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(600, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Müşteri Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(595, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Müşteri Hizmet Talebi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GerçekNypProjem.Properties.Resources.ç;
            this.pictureBox2.Location = new System.Drawing.Point(539, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(321, 231);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerçekNypProjem.Properties.Resources.ayırma_sütunu1;
            this.pictureBox1.Location = new System.Drawing.Point(215, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 711);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(59, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Müşteri Listesi";
            // 
            // CagriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(872, 508);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpMusteri);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTalepKaydet);
            this.Controls.Add(this.cmbHizmet);
            this.Controls.Add(this.txtTalepSoyad);
            this.Controls.Add(this.txtTalepAd);
            this.Controls.Add(this.grpEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstMusteriler);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CagriForm";
            this.Text = "CagriForm";
            this.Load += new System.EventHandler(this.CagriForm_Load);
            this.grpMusteri.ResumeLayout(false);
            this.grpMusteri.PerformLayout();
            this.grpEkle.ResumeLayout(false);
            this.grpEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMusteriler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox grpMusteri;
        private System.Windows.Forms.TextBox duzenleSoyad;
        private System.Windows.Forms.TextBox duzenleAd;
        private System.Windows.Forms.Label txtSoyad;
        private System.Windows.Forms.Label txtAd;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox grpEkle;
        private System.Windows.Forms.TextBox txtAd1;
        private System.Windows.Forms.TextBox txtSoyad1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet1;
        private System.Windows.Forms.TextBox txtTalepAd;
        private System.Windows.Forms.TextBox txtTalepSoyad;
        private System.Windows.Forms.ComboBox cmbHizmet;
        private System.Windows.Forms.Button btnTalepKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
    }
}