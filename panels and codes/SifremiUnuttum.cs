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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-2L4LDGC ; initial catalog = Bankamatik ; integrated security = sspi"); // SQL bağlantı kodu.


        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBoxTc.Text == "" || textBoxTel.Text == "" || textBoxSifre.Text == "") // herhangi bir alan boş bırakılırsa hata alınır.
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!", "Şifre Oluşturma İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set sifre = @p1 where tcNo = @p2 and telefon = @p3", con);

                komut.Parameters.AddWithValue("@p1", textBoxSifre.Text); // @p1 textBoxSifre ' deki değere eşitlenir. (yeni şifre için)
                komut.Parameters.AddWithValue("@p2", textBoxTc.Text); // @p2 textBoxTc ' deki değere eşitlenir. (yeni şifre oluşturulması için gereken tc için)
                komut.Parameters.AddWithValue("@p3", textBoxTel.Text); // @p3 textBoxTel ' deki değere eşitlenir. (yeni şifre oluşturulması için gereken telefon için)

                con.Open();

                int sonuc = komut.ExecuteNonQuery();
                if(sonuc == 1) // Komut çalışıyor ise
                {
                    MessageBox.Show("Şifre Oluşturma İşlemi Başarılı.", "Şifre Oluşturma İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // HareketKaydet.kaydet(Form1.customerId, "Yeni Şifre Oluşturma"); // FOREIGN KEY BAĞLANTI HATASI
                }
                else
                {
                    MessageBox.Show("Şifre Oluşturma İşlemi Başarısız!", "Şifre Oluşturma İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                con.Close();

                textBoxSifre.Text = "";
                textBoxTc.Text = "";
                textBoxTel.Text = "";


            }


        }
    }
}
