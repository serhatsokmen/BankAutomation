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
    public partial class ParaCek : Form
    {
        public ParaCek()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-2L4LDGC ; initial catalog = Bankamatik ; integrated security = sspi");


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // kullanıcının texBox'a sadece rakam girebilmesini sağlar. Başka herhangiş bir karakter giremez.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriIslem ms = new MusteriIslem();
            ms.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            float sayi = float.Parse(textBox1.Text); // textBox ' tan gelen değer.
            if(sayi > Form1.bakiye) // Form1' de global değer olarak oluşturulan public static float bakiye değerine eriştik. Girilen sayı var olan bakiyeden fazla ise para çekemez. 
            {
                MessageBox.Show("Yetersiz Bakiye!", "Para Çekme İşlemi.");
            }
            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set bakiye = bakiye - @p1 where ID = @p2", con); // bakiye - @p1, bakiyeden çekilen miktarı düşmek için.
                komut.Parameters.AddWithValue("@p1", sayi); // @p1 sayi değeri.
                komut.Parameters.AddWithValue("@p2", Form1.customerId); // customerId Form1'de tanımlandığından dolayı tanımlamayı bu şekilde yaptık.
                con.Open();

                int sonuc = komut.ExecuteNonQuery();
                if(sonuc == 1) // para çekme işlemi başarılı ise 
                {
                    MessageBox.Show("Para Çekme İşlemi Başarılı!", "Para Çekme İşlemi");
                    Form1.bakiye -= sayi; // bakiye bilgileri sql'de güncellenirken Form'da güncellenmeme sorununu yaşamamak için Form1'in bakiyesini bu şekilde güncelledik.

                    HareketKaydet.kaydet(Form1.customerId, (sayi + " TL Para Cekildi")); // hesaptaki hareketleri kaydetmek için HareketKaydet sınıfındaki kaydet metodunu kullandık.

                }
                else // para çekme işlemi başarısız ise 
                {
                    MessageBox.Show("Para Çekme İşlemi Başarısız!", "Para Çekme İşlemi");
                    
                }
                textBox1.Text = "";
                con.Close();


            }

        }

        private void ParaCek_Load(object sender, EventArgs e)
        {
            
        }
    }
}
