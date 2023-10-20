using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankAuto1
{
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-2L4LDGC ; initial catalog = Bankamatik ; integrated security = sspi");

        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from musteriler where ID = @p1 or tcNo = @p2", con);
            komut.Parameters.AddWithValue("@p1", textBoxAra.Text);
            komut.Parameters.AddWithValue("@p2", textBoxAra.Text);

            con.Open();

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBoxID.Text = dr["ID"].ToString();
                textBoxTC.Text = dr["tcNo"].ToString();
                textBoxAdSoyad.Text = dr["adSoyad"].ToString();
                textBoxAdres.Text = dr["adres"].ToString();
                textBoxTelefon.Text = dr["telefon"].ToString();
                textBoxBakiye.Text = dr["bakiye"].ToString();
                textBoxAktiflik.Text = dr["durum"].ToString();
                textBoxCinsiyet.Text = dr["cinsiyet"].ToString();
            }
            else
            {
                MessageBox.Show("Girmiş oldugunuz kayıt bulunamadı.", "Kayıt Arama");
                textBoxID.Text = "";
                textBoxTC.Text = "";
                textBoxAdSoyad.Text = "";
                textBoxAdres.Text = "";
                textBoxAdres.Text = "";
                textBoxTelefon.Text = "";
                textBoxBakiye.Text = "";
                textBoxAktiflik.Text = "";
                textBoxCinsiyet.Text = "";

            }




            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YetkiliIslem y = new YetkiliIslem();
            y.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update musteriler set adSoyad = @pAdSoyad, adres= @pAdres, telefon = @pTel, durum = @pDurum where ID = @p4 or tcNo = @p5", con); // güncelleme yapmak için gereken SQL komutu
            // müşteri güncelleme işleminde sadece adsoyad , adres , telefon ve aktiflik durumu değiştirilebilir. Bundan dolayı tüm değerleri almadım.
            komut.Parameters.AddWithValue("@p4", textBoxAra.Text); // ID ' ye göre arama yapılırsa
            komut.Parameters.AddWithValue("@p5", textBoxAra.Text); // tcNo ' ya göre arama yapılırsa 
            komut.Parameters.AddWithValue("@pAdSoyad", textBoxAdSoyad.Text); // müşterinin adı soyadı için
            komut.Parameters.AddWithValue("pAdres", textBoxAdres.Text); // müşterinin adresi için
            komut.Parameters.AddWithValue("pTel", textBoxTelefon.Text); // müşterinin telefonu için
            komut.Parameters.AddWithValue("@pDurum", int.Parse(textBoxAktiflik.Text)); // müşterinin aktiflik durumu için.

            con.Open();

            int sonuc = komut.ExecuteNonQuery(); //  komutu çalıştırmak için ExecuteNonQuery. Burada int sonuc = komut.ExecuteNonQuery yapmamın sebebi eğer güncelleme işlemi başarılı ise sonuc == 1 döndürecek.
            if (sonuc == 1) // güncelleme işlemi başarılı ise 
            {
                MessageBox.Show("Güncelleme İşlemi Başarılı!", "Güncelleme İşlemi");
            }
            else // güncelleme işlemi başarısız ise
            {
                // güncelleme işleminin başarısız olması halinde textBox ' lardaki tüm değerler silincek.
                MessageBox.Show("Güncelleme İşlemi tamamlanamadı.", "Güncelleme İşlemi");
                textBoxID.Text = "";
                textBoxTC.Text = "";
                textBoxAdSoyad.Text = "";
                textBoxAdres.Text = "";
                textBoxAdres.Text = "";
                textBoxTelefon.Text = "";
                textBoxBakiye.Text = "";
                textBoxAktiflik.Text = "";
                textBoxCinsiyet.Text = "";
            }
            con.Close();



        }

        private void textBoxAktiflik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // sadece tamsayılı değerler girilebilir.
        }
    }
}
