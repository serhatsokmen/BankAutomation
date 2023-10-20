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
    public partial class ParaYatir : Form
    {
        public ParaYatir()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-2L4LDGC ; initial catalog = Bankamatik ; integrated security = sspi");


        private void button3_Click(object sender, EventArgs e)
        {
            MusteriIslem ms = new MusteriIslem();
            ms.Show();
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // sadece tamsayılı değerler girilebilir.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sayi = float.Parse(textBox1.Text); // textBox ' tan gelen değer
            if (int.Parse(textBox1.Text) < 10) // 10 ' dan az değer girilmiş ise
            {
                MessageBox.Show("10 TL ve üzerinde para yatırmanız gerekmektedir.", "Para Yatırma İşlemi.");
            }
            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set bakiye = bakiye + @p1 where ID = @p2", con); // bakiye = bakiye+@p1 bakiye miktarını arttırmak için.
                komut.Parameters.AddWithValue("@p1", sayi); // @p1 sayı değeri
                komut.Parameters.AddWithValue("@p2", Form1.customerId); // customerId , Form1 ' de tanımlandığı için Form1.customerId.
                con.Open();

                int sonuc = komut.ExecuteNonQuery();
                if (sonuc == 1)
                {
                    MessageBox.Show("Para Yatırma İşlemi Başarılı!", "Para Yatırma İşlemi");
                    Form1.bakiye += sayi; // bakiye bilgileri sql'de güncellenirken Form'da güncellenmeme sorununu yaşamamak için Form1'in bakiyesini bu şekilde güncelledik.
                    HareketKaydet.kaydet(Form1.customerId, (sayi +" TL Para Yatirildi")); // hesaptaki hareketleri kaydetmek için HareketKaydet sınıfındaki kaydet metodunu kullandık.

                }
                else
                {
                    MessageBox.Show("Para Yatırma İşlemi Başarısız!", "Para Yatırma İşlemi");

                }
                textBox1.Text = "";
                con.Close();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
