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

        // BAÐLANTI KURMA ÝÞLEMÝ:
        SqlConnection baglanti = new SqlConnection("server = DESKTOP-2L4LDGC ; initial catalog = Bankamatik ; integrated security = sspi");

        public static string nameSurname = ""; // diðer sayfalardan da eriþmek için public static string.
        public static int customerId;   // diðer sayfalardan da eriþebilmek için public static int.
        public static float bakiye = 0.0f;

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = textBoxUsername.Text;
            string psw = textBoxPsw.Text;
            bool sonuc = false;
            
            if(radioButtonYetkili.Checked)
            {
                if(userName == "admin" && psw == "456") // admin giriþi için 
                {
                    YetkiliIslem y = new YetkiliIslem();
                    y.Show();
                    this.Hide(); // ana formu gizlemek için
                }
                else
                {
                    MessageBox.Show("Hatalý Kullanýcý adý veya parola!", " Hatalý Giriþ Denemesi!");
                }
                textBoxUsername.Text = ""; // girme iþlemi hatalý da olsa baþarýlý da olsa texBox alanlarýný temizler.
                textBoxPsw.Text = "";

            }
            else
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("select * from musteriler where tcNo = @p1 and sifre = @p2 and durum = 1", baglanti); // kullanýcý adý ve parolasý eþit olanlar getirilecek.
                komut.Parameters.AddWithValue("@p1", userName); // @p1 kullanýcý adý olan userName deðiþkeni olacak
                komut.Parameters.AddWithValue("@p2", psw); // @p2 parola olan psw deðiþkeni olacak.
                
                SqlDataReader dr = komut.ExecuteReader();
                while(dr.Read()) // okuma iþlemi.
                {
                    nameSurname = dr["adSoyad"].ToString(); // nameSurname deðiþkeni SQL tablosundaki adSoyad ' a denk gelecek
                    customerId = int.Parse(dr["ID"].ToString()); // customerId deðiþkeni SQL tablosundaki ID ' ye denk gelecek (TosTring direkt olarak kabul edilemeyecði için int parse 'a dönüþtürülme yapýldý)
                    bakiye = float.Parse(dr["bakiye"].ToString()); // bakiye deðiþkeni SQL tablosundaki ID ' ye denk gelecek (ToString e direkt olarak dönüþtürülemeyecði için float.parse dönüþümü yapýldý.)
                    sonuc = true; // eðer baðlantý gerçekleþirse  sonuc true olacak.
                    // form açarken eðer müþteri ise adSoyad ve ID ' si diðer formlarda kullanýlacaðý için burada aldýk.
                }

                baglanti.Close();
                
                if (sonuc) // sonuç olumluysa form açýlacak.
                {
                    sonuc = false; // 1 defa açtýðý zaman kiþi tekrar giremesin. Kapattýðý zaman yeni þifreyi  tekrar istesin.
                    MusteriIslem m = new MusteriIslem();
                    m.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Kullanýcý adý ve þifrenizi kontrol ediniz eðer doðru olduðundan eminseniz, banka ile iletiþime geçiniz!"," Hatalý Giriþ Denemesi!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

                textBoxUsername.Text = ""; // kullanýcý ve þifre hatalý veya doðru girilse de denenen iþleminden sonra textBox alanlarý temizlenecek.
                textBoxPsw.Text = "";

            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitÝslemleri k = new KayitÝslemleri();
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