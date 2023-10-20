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
    public partial class Kayitİslemleri : Form
    {
        public Kayitİslemleri()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-2L4LDGC ; initial catalog = Bankamatik ; integrated security = sspi");

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                    string kayit = "insert into musteriler (tcNo,adSoyad,adres,telefon,sifre,bakiye,durum,cinsiyet) values (@tcno,@adsoyad,@adres,@telefon,@sifre,@bakiye,@durum,@cinsiyet)";
                    SqlCommand komut = new SqlCommand(kayit, con);
                    komut.Parameters.AddWithValue("@tcNo", textBox1.Text);
                    komut.Parameters.AddWithValue("@adSoyad", textBox2.Text);
                    komut.Parameters.AddWithValue("@adres", textBox3.Text);
                    komut.Parameters.AddWithValue("@telefon", textBox4.Text);
                    komut.Parameters.AddWithValue("@sifre", textBox5.Text);
                    komut.Parameters.AddWithValue("@bakiye", 0);
                    komut.Parameters.AddWithValue("@durum", 1);
                    if(radioButton1.Checked)
                    {
                        komut.Parameters.AddWithValue("@cinsiyet", radioButton1.Text); 
                    }
                    if(radioButton2.Checked)
                    {
                        komut.Parameters.AddWithValue("@cinsiyet", radioButton2.Text);
                    }

                    komut.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kayit ekleme islemi basarili!");

                }
            }
            catch(Exception hata)
            {
                MessageBox.Show("Bir seyler ters gitti ve maalesef kayit ekleme islemi basarili olamadi." + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }
    }
}
