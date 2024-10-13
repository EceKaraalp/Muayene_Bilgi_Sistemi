using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace veritabanı_odev2
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id = postgres; Password=12345");
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGoster_Click(object sender, EventArgs e)
        {
            VerileriGoster("select * from \"HASTA\"");
        }
        private void VerileriGoster(string sorgu)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open(); // bağlantıyı aç
                }

                NpgsqlCommand cmd = new NpgsqlCommand(sorgu, conn);
                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;

                dataReader.Close();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close(); //bağlantıyı kapat
                }
            }
        }

        private void buttonKayıtEkle_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open(); //bağlantıyı aç
                string query = $"INSERT INTO \"HASTA\" (\"TC\", \"Ad\", \"Soyad\", \"Doğum Yeri\", \"Doğum Tarihi\",\"Adres\", \"Telefon\", \"Hastalık Teşhisi\", \"İlaç Tedavisi\") " +
                               $"VALUES (@TC, @Ad, @Soyad, @DoğumYeri, @DoğumTarihi, @Adres, @Telefon, @HastalıkTeşhisi, @İlaçTedavisi)";

                NpgsqlCommand command = new NpgsqlCommand(query, conn);
                //parametre ekleme işlemleri
                //TC için gerekli dönüşümler yapıldı
                command.Parameters.Add(new NpgsqlParameter("@TC", NpgsqlDbType.Bigint));
                command.Parameters["@TC"].Value = Convert.ToInt64(textBoxTC.Text);

                command.Parameters.AddWithValue("@Ad", textBoxAd.Text);
                command.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
                command.Parameters.AddWithValue("@DoğumYeri", textBoxDY.Text);

                //Doğum Tarihi date time formatına dönüştürüldü
                if (DateTime.TryParse(textBoxDT.Text, out DateTime dogumTarihi))
                {
                    command.Parameters.AddWithValue("@DoğumTarihi", dogumTarihi);
                }
                command.Parameters.AddWithValue("@Adres", textBoxAdres.Text);

                //Telefon için gerekli dönüşümler yapıldı
                command.Parameters.Add(new NpgsqlParameter("@Telefon", NpgsqlDbType.Bigint));
                command.Parameters["@Telefon"].Value = Convert.ToInt64(textBoxTel.Text);

                command.Parameters.AddWithValue("@HastalıkTeşhisi", textBoxHT.Text);
                command.Parameters.AddWithValue("@İlaçTedavisi", textBoxilac.Text);

                int veri_ekle = command.ExecuteNonQuery();

                if (veri_ekle > 0)
                {
                    MessageBox.Show("Hasta Bilgileri Başarıyla Eklendi.");

                    VerileriGoster("select * from \"HASTA\"");
                }
                else
                {
                    MessageBox.Show("Hasta Bilgileri Eklenirken Hata OLuştu.");
                }
            }
            finally
            {
                conn.Close(); //bağlantıyı kapat
            }
        }

        private void buttonKayıtSil_Click(object sender, EventArgs e)
        {
            string query_delete = textBoxTCSil.Text;

            if (string.IsNullOrEmpty(query_delete))
            {
                MessageBox.Show("Lütfen silmek istediğiniz hastanın TC numarasını giriniz.");
                return;
            }

            if (long.TryParse(query_delete, out long tc))
            {
                try
                {
                    conn.Open();
                    NpgsqlCommand sil_command = new NpgsqlCommand("delete from \"HASTA\" where \"TC\" = @TC", conn);
                    sil_command.Parameters.Add("@TC", NpgsqlDbType.Bigint).Value = tc;

                    int veri_sil = sil_command.ExecuteNonQuery();
                    if (veri_sil > 0)
                    {
                        MessageBox.Show("Hasta Bilgileri Başarıyla Silindi.");
                        VerileriGoster("select * from \"HASTA\"");
                    }
                    else
                    {
                        MessageBox.Show("Hasta Bilgileri Silinirken Hata OLuştu.");
                    }
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void buttonKayıtGuncel_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                command.CommandText = "update \"HASTA\" set " +
                      "\"Ad\" = @Ad, " +
                      "\"Soyad\" = @Soyad, " +
                      "\"Doğum Yeri\" = @DoğumYeri, " +
                      "\"Doğum Tarihi\" = @DoğumTarihi, " +
                      "\"Adres\" = @Adres, " +
                      "\"Telefon\" = @Telefon, " +
                      "\"Hastalık Teşhisi\" = @HastalıkTeşhisi, " +
                      "\"İlaç Tedavisi\" = @İlaçTedavisi " +
                      "WHERE \"TC\" = @TC";
                command.Parameters.Add(new NpgsqlParameter("@TC", NpgsqlDbType.Bigint));
                command.Parameters["@TC"].Value = Convert.ToInt64(textBoxTC.Text);

                command.Parameters.AddWithValue("@Ad", textBoxAd.Text);
                command.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
                command.Parameters.AddWithValue("@DoğumYeri", textBoxDY.Text);
                //Doğum Tarihi date time formatına dönüştürüldü
                if (DateTime.TryParse(textBoxDT.Text, out DateTime dogumTarihi))
                {
                    command.Parameters.AddWithValue("@DoğumTarihi", dogumTarihi);
                }
                command.Parameters.AddWithValue("@Adres", textBoxAdres.Text);
                //Telefon için gerekli dönüşümler yapıldı
                command.Parameters.Add(new NpgsqlParameter("@Telefon", NpgsqlDbType.Bigint));
                command.Parameters["@Telefon"].Value = Convert.ToInt64(textBoxTel.Text);

                command.Parameters.AddWithValue("@HastalıkTeşhisi", textBoxHT.Text);
                command.Parameters.AddWithValue("@İlaçTedavisi", textBoxilac.Text);
                VerileriGoster("select * from \"HASTA\"");

                int veri_guncelle = command.ExecuteNonQuery();

                if (veri_guncelle > 0)
                {
                    MessageBox.Show("Hasta Bilgileri Başarıyla Güncellendi.");

                    VerileriGoster("select * from \"HASTA\""); 
                }
                else
                {
                    MessageBox.Show("Hasta Bilgileri Güncellerirken Hata OLuştu.");
                }
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        private void buttonGetir_Click(object sender, EventArgs e)
        {
            string TC_guncelle = textBoxGüncelle.Text;

            if (string.IsNullOrEmpty(TC_guncelle))
            {
                MessageBox.Show("Lütfen silmek istediğiniz hastanın TC numarasını giriniz.");
                return;
            }

            if (long.TryParse(TC_guncelle, out long tc))
            {
                try
                {
                    conn.Open(); //bağlantıyı aç
                    //yeni nesne oluştur
                    NpgsqlCommand command = new NpgsqlCommand("select * from \"HASTA\" where \"TC\" = @TC", conn);

                    command.Parameters.Add("@TC", NpgsqlDbType.Bigint).Value = tc;
                    NpgsqlDataReader dataReader = command.ExecuteReader();
                        
                    if (dataReader.Read())
                    {
                        // tablodaki tc si girilen hastanın blgilerini textboxlara yerleştir
                        textBoxAd.Text = dataReader["Ad"].ToString();
                        textBoxSoyad.Text = dataReader["Soyad"].ToString();
                        textBoxDY.Text = dataReader["Doğum Yeri"].ToString();
                        
                        if (DateTime.TryParse(dataReader["Doğum Tarihi"].ToString(), out DateTime dogumTarihi))
                        {
                            textBoxDT.Text = dogumTarihi.ToString();
                        }
                        textBoxAdres.Text = dataReader["Adres"].ToString();

                        if (long.TryParse(dataReader["Telefon"].ToString(), out long telefon))
                        {
                            textBoxTel.Text = telefon.ToString();
                        }
                        textBoxHT.Text = dataReader["Hastalık Teşhisi"].ToString();
                        textBoxilac.Text = dataReader["İlaç Tedavisi"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Girilen TC numarasına ait hasta bulunmamaktadır.");
                    }
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
        private void buttonListele_Click(object sender, EventArgs e)
        {
            string sec = comboBoxliste.SelectedItem.ToString(); //comboboxtan seçileni stringe çevir ve seçilene göre sırala
            string sorgu = $"select * from \"HASTA\" order by \"{sec}\"";

            VerileriGoster(sorgu);
        }
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            //textboxları temizle
            textBoxTC.Clear();
            textBoxAd.Clear();
            textBoxAdres.Clear();
            textBoxDT.Clear();
            textBoxDY.Clear();
            textBoxHT.Clear();
            textBoxSoyad.Clear();
            textBoxTel.Clear();
            textBoxilac.Clear();
            textBoxTCSil.Clear();
            textBoxGüncelle.Clear();
        }
    }
}
