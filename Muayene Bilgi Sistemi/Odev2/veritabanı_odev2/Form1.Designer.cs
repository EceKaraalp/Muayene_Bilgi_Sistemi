
namespace veritabanı_odev2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGoster = new System.Windows.Forms.Button();
            this.buttonKayıtEkle = new System.Windows.Forms.Button();
            this.buttonKayıtGuncel = new System.Windows.Forms.Button();
            this.buttonKayıtSil = new System.Windows.Forms.Button();
            this.labelAd = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxGüncelle = new System.Windows.Forms.TextBox();
            this.labelTC = new System.Windows.Forms.Label();
            this.labelDT = new System.Windows.Forms.Label();
            this.labelDY = new System.Windows.Forms.Label();
            this.labelHT = new System.Windows.Forms.Label();
            this.labelilac = new System.Windows.Forms.Label();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.textBoxDY = new System.Windows.Forms.TextBox();
            this.textBoxHT = new System.Windows.Forms.TextBox();
            this.textBoxDT = new System.Windows.Forms.TextBox();
            this.textBoxilac = new System.Windows.Forms.TextBox();
            this.buttonListele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxliste = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTCSil = new System.Windows.Forms.TextBox();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(718, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "MUAYENE BİLGİLERİ :";
            // 
            // buttonGoster
            // 
            this.buttonGoster.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonGoster.Location = new System.Drawing.Point(274, 17);
            this.buttonGoster.Name = "buttonGoster";
            this.buttonGoster.Size = new System.Drawing.Size(120, 27);
            this.buttonGoster.TabIndex = 2;
            this.buttonGoster.Text = "Göster";
            this.buttonGoster.UseVisualStyleBackColor = false;
            this.buttonGoster.Click += new System.EventHandler(this.buttonGoster_Click);
            // 
            // buttonKayıtEkle
            // 
            this.buttonKayıtEkle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKayıtEkle.Location = new System.Drawing.Point(803, 419);
            this.buttonKayıtEkle.Name = "buttonKayıtEkle";
            this.buttonKayıtEkle.Size = new System.Drawing.Size(136, 43);
            this.buttonKayıtEkle.TabIndex = 3;
            this.buttonKayıtEkle.Text = "Kayıt Ekle";
            this.buttonKayıtEkle.UseVisualStyleBackColor = false;
            this.buttonKayıtEkle.Click += new System.EventHandler(this.buttonKayıtEkle_Click);
            // 
            // buttonKayıtGuncel
            // 
            this.buttonKayıtGuncel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKayıtGuncel.Location = new System.Drawing.Point(973, 419);
            this.buttonKayıtGuncel.Name = "buttonKayıtGuncel";
            this.buttonKayıtGuncel.Size = new System.Drawing.Size(136, 43);
            this.buttonKayıtGuncel.TabIndex = 4;
            this.buttonKayıtGuncel.Text = "Kayıt Güncelle";
            this.buttonKayıtGuncel.UseVisualStyleBackColor = false;
            // 
            // buttonKayıtSil
            // 
            this.buttonKayıtSil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKayıtSil.Location = new System.Drawing.Point(533, 388);
            this.buttonKayıtSil.Name = "buttonKayıtSil";
            this.buttonKayıtSil.Size = new System.Drawing.Size(136, 33);
            this.buttonKayıtSil.TabIndex = 5;
            this.buttonKayıtSil.Text = "Kayıt Sil";
            this.buttonKayıtSil.UseVisualStyleBackColor = false;
            this.buttonKayıtSil.Click += new System.EventHandler(this.buttonKayıtSil_Click);
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAd.Location = new System.Drawing.Point(791, 90);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(33, 17);
            this.labelAd.TabIndex = 7;
            this.labelAd.Text = "Ad :";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyad.Location = new System.Drawing.Point(791, 128);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(56, 17);
            this.labelSoyad.TabIndex = 8;
            this.labelSoyad.Text = "Soyad :";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdres.Location = new System.Drawing.Point(791, 203);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(54, 18);
            this.labelAdres.TabIndex = 9;
            this.labelAdres.Text = "Adres :";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTel.Location = new System.Drawing.Point(791, 165);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(65, 18);
            this.labelTel.TabIndex = 10;
            this.labelTel.Text = "Telefon :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "- Güncelleme Yapılacak Hastanın TC Giriniz :";
            // 
            // textBoxAd
            // 
            this.textBoxAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAd.Location = new System.Drawing.Point(912, 88);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(153, 22);
            this.textBoxAd.TabIndex = 13;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSoyad.Location = new System.Drawing.Point(912, 126);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(153, 22);
            this.textBoxSoyad.TabIndex = 14;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAdres.Location = new System.Drawing.Point(912, 203);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(294, 22);
            this.textBoxAdres.TabIndex = 15;
            // 
            // textBoxTel
            // 
            this.textBoxTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTel.Location = new System.Drawing.Point(912, 165);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(153, 22);
            this.textBoxTel.TabIndex = 16;
            // 
            // textBoxGüncelle
            // 
            this.textBoxGüncelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGüncelle.Location = new System.Drawing.Point(324, 463);
            this.textBoxGüncelle.Name = "textBoxGüncelle";
            this.textBoxGüncelle.Size = new System.Drawing.Size(154, 22);
            this.textBoxGüncelle.TabIndex = 17;
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Location = new System.Drawing.Point(791, 50);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(56, 17);
            this.labelTC.TabIndex = 18;
            this.labelTC.Text = "TC No :";
            // 
            // labelDT
            // 
            this.labelDT.AutoSize = true;
            this.labelDT.Location = new System.Drawing.Point(791, 246);
            this.labelDT.Name = "labelDT";
            this.labelDT.Size = new System.Drawing.Size(101, 17);
            this.labelDT.TabIndex = 19;
            this.labelDT.Text = "Doğum Tarihi :";
            // 
            // labelDY
            // 
            this.labelDY.AutoSize = true;
            this.labelDY.Location = new System.Drawing.Point(791, 286);
            this.labelDY.Name = "labelDY";
            this.labelDY.Size = new System.Drawing.Size(90, 17);
            this.labelDY.TabIndex = 20;
            this.labelDY.Text = "Doğum Yeri :";
            // 
            // labelHT
            // 
            this.labelHT.AutoSize = true;
            this.labelHT.Location = new System.Drawing.Point(791, 324);
            this.labelHT.Name = "labelHT";
            this.labelHT.Size = new System.Drawing.Size(115, 17);
            this.labelHT.TabIndex = 21;
            this.labelHT.Text = "Hastalık Teşhisi :";
            // 
            // labelilac
            // 
            this.labelilac.AutoSize = true;
            this.labelilac.Location = new System.Drawing.Point(791, 363);
            this.labelilac.Name = "labelilac";
            this.labelilac.Size = new System.Drawing.Size(37, 17);
            this.labelilac.TabIndex = 22;
            this.labelilac.Text = "İlaç :";
            // 
            // textBoxTC
            // 
            this.textBoxTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTC.Location = new System.Drawing.Point(912, 50);
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(153, 22);
            this.textBoxTC.TabIndex = 23;
            // 
            // textBoxDY
            // 
            this.textBoxDY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDY.Location = new System.Drawing.Point(912, 284);
            this.textBoxDY.Name = "textBoxDY";
            this.textBoxDY.Size = new System.Drawing.Size(138, 22);
            this.textBoxDY.TabIndex = 24;
            // 
            // textBoxHT
            // 
            this.textBoxHT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHT.Location = new System.Drawing.Point(912, 322);
            this.textBoxHT.Name = "textBoxHT";
            this.textBoxHT.Size = new System.Drawing.Size(138, 22);
            this.textBoxHT.TabIndex = 25;
            // 
            // textBoxDT
            // 
            this.textBoxDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDT.Location = new System.Drawing.Point(912, 244);
            this.textBoxDT.Name = "textBoxDT";
            this.textBoxDT.Size = new System.Drawing.Size(138, 22);
            this.textBoxDT.TabIndex = 26;
            // 
            // textBoxilac
            // 
            this.textBoxilac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxilac.Location = new System.Drawing.Point(912, 361);
            this.textBoxilac.Name = "textBoxilac";
            this.textBoxilac.Size = new System.Drawing.Size(138, 22);
            this.textBoxilac.TabIndex = 27;
            // 
            // buttonListele
            // 
            this.buttonListele.Location = new System.Drawing.Point(533, 524);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(136, 35);
            this.buttonListele.TabIndex = 28;
            this.buttonListele.Text = "Listele";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "- Neye Göre listelemek İstersiniz :";
            // 
            // comboBoxliste
            // 
            this.comboBoxliste.FormattingEnabled = true;
            this.comboBoxliste.Items.AddRange(new object[] {
            "TC",
            "Ad",
            "Soyad",
            "Doğum Yeri",
            "Doğum Tarihi",
            "Telefon",
            "Adres",
            "Hastalık Teşhisi",
            "İlaç Tedavisi"});
            this.comboBoxliste.Location = new System.Drawing.Point(324, 529);
            this.comboBoxliste.Name = "comboBoxliste";
            this.comboBoxliste.Size = new System.Drawing.Size(154, 24);
            this.comboBoxliste.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "- Silmek İstediğiniz Hastanın TC No :";
            // 
            // textBoxTCSil
            // 
            this.textBoxTCSil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTCSil.Location = new System.Drawing.Point(324, 394);
            this.textBoxTCSil.Name = "textBoxTCSil";
            this.textBoxTCSil.Size = new System.Drawing.Size(154, 22);
            this.textBoxTCSil.TabIndex = 32;
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonTemizle.Location = new System.Drawing.Point(1067, 529);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(139, 57);
            this.buttonTemizle.TabIndex = 33;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = false;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonGetir
            // 
            this.buttonGetir.Location = new System.Drawing.Point(533, 457);
            this.buttonGetir.Name = "buttonGetir";
            this.buttonGetir.Size = new System.Drawing.Size(136, 33);
            this.buttonGetir.TabIndex = 34;
            this.buttonGetir.Text = "Bilgileri Getir";
            this.buttonGetir.UseVisualStyleBackColor = true;
            this.buttonGetir.Click += new System.EventHandler(this.buttonGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1238, 604);
            this.Controls.Add(this.buttonGetir);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.textBoxTCSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxliste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.textBoxilac);
            this.Controls.Add(this.textBoxDT);
            this.Controls.Add(this.textBoxHT);
            this.Controls.Add(this.textBoxDY);
            this.Controls.Add(this.textBoxTC);
            this.Controls.Add(this.labelilac);
            this.Controls.Add(this.labelHT);
            this.Controls.Add(this.labelDY);
            this.Controls.Add(this.labelDT);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.textBoxGüncelle);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.buttonKayıtSil);
            this.Controls.Add(this.buttonKayıtGuncel);
            this.Controls.Add(this.buttonKayıtEkle);
            this.Controls.Add(this.buttonGoster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "220601046_Ece_Karaalp_Odev2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGoster;
        private System.Windows.Forms.Button buttonKayıtEkle;
        private System.Windows.Forms.Button buttonKayıtGuncel;
        private System.Windows.Forms.Button buttonKayıtSil;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxGüncelle;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label labelDT;
        private System.Windows.Forms.Label labelDY;
        private System.Windows.Forms.Label labelHT;
        private System.Windows.Forms.Label labelilac;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.TextBox textBoxDY;
        private System.Windows.Forms.TextBox textBoxHT;
        private System.Windows.Forms.TextBox textBoxDT;
        private System.Windows.Forms.TextBox textBoxilac;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxliste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTCSil;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonGetir;
    }
}

