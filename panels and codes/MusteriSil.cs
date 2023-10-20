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

namespace BankAuto1
{
    public partial class MusteriSil : Form
    {
        public MusteriSil()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-2L4LDGC ; initial catalog = Bankamatik ; integrated security = sspi");
        private void button3_Click(object sender, EventArgs e)
        {
            YetkiliIslem yt = new YetkiliIslem();
            yt.Show();
            this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update  musteriler set durum = @p3 where ID = @p1 or tcNo = @p2", con); // müşterilerin aktiflik durumunu 0'a getirebilmek için update kullandık. Eğer delete kullanılsaydı hareketkaydet sınıfımız olduğu için müşteri silme işlemlerinde hata alınırdı.
            komut.Parameters.AddWithValue("@p1", textBoxAra.Text); // ID ' ye göre arama yapmak için
            komut.Parameters.AddWithValue("@p2", textBoxAra.Text); // tcNo ' ya göre arama yapmak için.
            komut.Parameters.AddWithValue("@p3", 0); // @p3 yani durum 0 ' a eşitlendi. Müşteri silme işlemi esnasında aktiflik durumunu 0 ' a getirmek için.


            con.Open();
            // sillme işlemi yapılmadan önce silme işleminden emin misiniz sorusunu sormak için DialogResult dr = MessageBox.Show kullandım.
            DialogResult dr =  MessageBox.Show("Müşteri Kaydını Silmek İstediğinize Emin Misiniz?","Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dr == DialogResult.No) // silme işlemi onayında hayır seçeneği seçilir ise:
            {
                MessageBox.Show("Silme İşlemi İptal Edildi!", "Silme İşlemi İptali");
            }
            else // silme işlemi onayında evet seçeneği seçilir ise 
            {
                
                int sonuc = komut.ExecuteNonQuery(); //  komutu çalıştırmak için ExecuteNonQuery. 
                if (sonuc == 1) // silme işlemi başarılı ise 
                {
                    MessageBox.Show("Silme İşlemi Başarılı!", "Silme İşlemi");
                }
                else // silme işlemi başarısız ise
                {
                    // silme işleminin başarısız olması halinde textBox ' lardaki tüm değereler silinecek.
                    MessageBox.Show("Silme İşlemi tamamlanamadı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                
            }


            con.Close();


        }
    }
}
