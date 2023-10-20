using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BankAuto1
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-2L4LDGC ; initial catalog = Bankamatik ; integrated security = sspi"); // bağlantı işlemi

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into musteriler (tcNo, adSoyad, adres, telefon, sifre, bakiye, durum, cinsiyet) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", con); // textBoxlardaki değerleri SQL tablosuna kaydetmek için. 
            komut.Parameters.AddWithValue("@p1", textBoxtc.Text); //textBoxTc ' ye girilen değer SQL tablosunda tcNo sütununa kaydedilecek. (@p1 tcNo ' ya denk geldiği için)
            komut.Parameters.AddWithValue("@p2", textBoxadsoyad.Text); // textBoxadSoyad ' da yazılan değer SQL tablosundaki adSoyad kısmına kaydedilecek (@p2 adSoyad ' a denk geldiği için.)
            komut.Parameters.AddWithValue("@p3", textBoxadres.Text);
            komut.Parameters.AddWithValue("@p4", textBoxtel.Text);
            komut.Parameters.AddWithValue("@p5", textBoxparola.Text);
            komut.Parameters.AddWithValue("@p6", 0); // müşteri ekleme ekranına bakiye alanı yapmadım. Yani yeni eklenen müşterinin bakiyesi default olarak 0 olacak.
            komut.Parameters.AddWithValue("@p7", 1); // yeni kaydedilen birisinin aktiflik durumu 1 olarak başlasın (yani aktif olarak görünsün.)
            if(radioButton1.Checked) // eğer erkek seçilir ise 
            {
                komut.Parameters.AddWithValue("@p8", radioButton1.Text); // seçilen RadioButton SQL tablosundaki cinsiyet kısmına kaydedilecek. (@p8 cinsiyet ' e denk geldiği için.)
            }
            if(radioButton2.Checked) // eğer kadın seçilir ise 
            {
                komut.Parameters.AddWithValue("@p8", radioButton2.Text);
            }

            if(textBoxtc.Text == "" || textBoxadsoyad.Text == "" || textBoxadres.Text == "" || textBoxtel.Text == "" || textBoxparola.Text == "") // herhangi bir textBox alanını boş bırakılırsa hata alınır.
            {
                MessageBox.Show("Tum alanlari Doldurmaniz Gerekmektedir!", "HATA!");
            }
            else
            {
                con.Open();
                int sonuc = komut.ExecuteNonQuery(); // komutu çalıştırmak için ExecuteNonQuery. Burada int sonuc = komut.ExecuteNonQuery yapmamın sebebi eğer müşteri başarılı bir şekilde kayıt olmuş ise sonuc == 1 döndürecek.
                con.Close();
                if (sonuc == 1) // müşteri eğer başarılı bir şekilde eklendiyse
                {
                    MessageBox.Show("Yeni Musteri Kaydi Basarili!", "Musteri Kaydi İslemleri");
                }
                else // müşteri eklemede hata alındıysa.
                {
                    MessageBox.Show("Maalesef Kayit islemi basarili olamadi.", "Musteri Kayit Hatasi!");
                }
            }



            
            // Müşteri ekleme işlemi başarılı veya başarısız sona erdikten sonra textBox ' lardaki tüm alanları temizlemek için.
            textBoxtc.Text = "";
            textBoxadsoyad.Text = "";
            textBoxadres.Text = "";
            textBoxtel.Text = "";
            textBoxparola.Text = "";


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YetkiliIslem yis = new YetkiliIslem();
            yis.Show();
            this.Close();
        }
    }
}
