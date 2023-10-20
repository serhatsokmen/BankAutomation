using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace BankAuto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // BA�LANTI KURMA ��LEM�:
        SqlConnection baglanti = new SqlConnection("server = DESKTOP-2L4LDGC ; initial catalog = Bankamatik ; integrated security = sspi");

        public static string nameSurname = ""; // di�er sayfalardan da eri�mek i�in public static string.
        public static int customerId;   // di�er sayfalardan da eri�ebilmek i�in public static int.
        public static float bakiye = 0.0f;

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = textBoxUsername.Text;
            string psw = textBoxPsw.Text;
            bool sonuc = false;
            
            if(radioButtonYetkili.Checked)
            {
                if(userName == "admin" && psw == "456") // admin giri�i i�in 
                {
                    YetkiliIslem y = new YetkiliIslem();
                    y.Show();
                    this.Hide(); // ana formu gizlemek i�in
                }
                else
                {
                    MessageBox.Show("Hatal� Kullan�c� ad� veya parola!", " Hatal� Giri� Denemesi!");
                }
                textBoxUsername.Text = ""; // girme i�lemi hatal� da olsa ba�ar�l� da olsa texBox alanlar�n� temizler.
                textBoxPsw.Text = "";

            }
            else
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("select * from musteriler where tcNo = @p1 and sifre = @p2 and durum = 1", baglanti); // kullan�c� ad� ve parolas� e�it olanlar getirilecek.
                komut.Parameters.AddWithValue("@p1", userName); // @p1 kullan�c� ad� olan userName de�i�keni olacak
                komut.Parameters.AddWithValue("@p2", psw); // @p2 parola olan psw de�i�keni olacak.
                
                SqlDataReader dr = komut.ExecuteReader();
                while(dr.Read()) // okuma i�lemi.
                {
                    nameSurname = dr["adSoyad"].ToString(); // nameSurname de�i�keni SQL tablosundaki adSoyad ' a denk gelecek
                    customerId = int.Parse(dr["ID"].ToString()); // customerId de�i�keni SQL tablosundaki ID ' ye denk gelecek (TosTring direkt olarak kabul edilemeyec�i i�in int parse 'a d�n��t�r�lme yap�ld�)
                    bakiye = float.Parse(dr["bakiye"].ToString()); // bakiye de�i�keni SQL tablosundaki ID ' ye denk gelecek (ToString e direkt olarak d�n��t�r�lemeyec�i i�in float.parse d�n���m� yap�ld�.)
                    sonuc = true; // e�er ba�lant� ger�ekle�irse  sonuc true olacak.
                    // form a�arken e�er m��teri ise adSoyad ve ID ' si di�er formlarda kullan�laca�� i�in burada ald�k.
                }

                baglanti.Close();
                
                if (sonuc) // sonu� olumluysa form a��lacak.
                {
                    sonuc = false; // 1 defa a�t��� zaman ki�i tekrar giremesin. Kapatt��� zaman yeni �ifreyi  tekrar istesin.
                    MusteriIslem m = new MusteriIslem();
                    m.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� ve �ifrenizi kontrol ediniz e�er do�ru oldu�undan eminseniz, banka ile ileti�ime ge�iniz!"," Hatal� Giri� Denemesi!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

                textBoxUsername.Text = ""; // kullan�c� ve �ifre hatal� veya do�ru girilse de denenen i�leminden sonra textBox alanlar� temizlenecek.
                textBoxPsw.Text = "";

            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kayit�slemleri k = new Kayit�slemleri();
            k.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum su = new SifremiUnuttum();
            su.Show();
            this.Hide();
        }
    }
}