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
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-2L4LDGC ; initial catalog = Bankamatik ; integrated security = sspi");


        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxEski.Text == "" || textBoxYeni.Text == "" ||textBoxYeni2.Text == "") 
            {
                MessageBox.Show("Tüm ALanları Doldurunuz!", "Şifre Değiştirme İşlemi"); 
            }
            else if(textBoxYeni.Text == textBoxEski.Text || textBoxYeni2.Text == textBoxEski.Text)
            {
                MessageBox.Show("Eski şifre ile yeni şifre aynı olmamalıdır!", "Şifre Değiştirme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(textBoxYeni.Text != textBoxYeni2.Text)
            {
                MessageBox.Show("Yeni şifreler uyuşmuyor. Lütfen Kontrol edin!", "Şifre Değiştirme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set sifre = @p1 where sifre = @p2", con); // şifre değiştirme için güncelleme SQL.
                komut.Parameters.AddWithValue("@p1", textBoxYeni.Text); // yeni şifre olarak @p1
                komut.Parameters.AddWithValue("@p2", textBoxEski.Text); // eski şifre olarak @p2
                con.Open();


                int sonuc = komut.ExecuteNonQuery(); // 
                if(sonuc == 1) // şifre değiştirme işlemi başarılı ise 
                {
                    MessageBox.Show("Şifre değiştirme işlemi başarılı!", "Şifre Değiştirme İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    HareketKaydet.kaydet(Form1.customerId, "Sifre Degistirildi");
                }
                else
                {
                    MessageBox.Show("Şifre değiştirme işlemi gerçekleştirilemedi!", "Şifre Değiştirme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //  tüm textBox ' lardaki değerler silinecek.
                con.Close();
                textBoxEski.Text = "";
                textBoxYeni.Text = "";
                textBoxYeni2.Text = "";

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriIslem m = new MusteriIslem();
            m.Show();
            this.Close();
        }
    }
}
