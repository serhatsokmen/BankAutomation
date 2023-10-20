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
    public partial class MusteriAra : Form
    {
        public MusteriAra()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-2L4LDGC ; initial catalog = Bankamatik ; integrated security = sspi");

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from musteriler where ID = @p1 or tcNo = @p2", con); // ID veya TC numarasına göre arama yapacağımız için @p1 ' i ID ' ye; @p2 ' yi ise tcNo 'ya eşitledik.
            komut.Parameters.AddWithValue("@p1", textBoxAra.Text); // arama kısmmına Id girilirse 
            komut.Parameters.AddWithValue("@p2", textBoxAra.Text); // arama kısmına Tc girilirse

            con.Open(); // bağlantıyı aç

            SqlDataReader dr = komut.ExecuteReader(); // veritabanından verileri almak , yani arama yapmak için ExecuteReader kullandım.
            if(dr.Read()) // okuma işlemi (başarılı ise)
            {
                // TOString kullanmamın nedeni veri tabanındaki değerleri textBox ' lara yazdıracak olmam. Bunun için ToString kullandım.
                textBoxID.Text = dr["ID"].ToString(); // veri tabanındaki ID değerini getirir.
                textBoxTC.Text = dr["tcNo"].ToString(); // veri tabanındaki tcNo değerini getirir
                textBoxAdSoyad.Text = dr["adSoyad"].ToString(); // veri tabanındaki adSoyad değerini getirir.
                textBoxAdres.Text = dr["adres"].ToString(); // veritabanındaki adres değerini getirir.
                textBoxTelefon.Text = dr["telefon"].ToString(); 
                textBoxBakiye.Text = dr["bakiye"].ToString();
                textBoxAktiflik.Text = dr["durum"].ToString();
                textBoxCinsiyet.Text = dr["cinsiyet"].ToString();
            }
            else
            {
                // eğer herhangi bir kayıt bulunamazsa textBox'larda eğer daha önceden veriler yazıyorsa yazılan tüm verileri textBox'lardan silmek için:
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
            
            
            

            con.Close(); // bağlantıyı kapat.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            YetkiliIslem y = new YetkiliIslem();
            y.Show();
            this.Close();
        }
    }
}
