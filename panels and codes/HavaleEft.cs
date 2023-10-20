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
    public partial class HavaleEft : Form
    {
        public HavaleEft()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-2L4LDGC ; initial catalog = Bankamatik ; integrated security = sspi");


        private void button1_Click(object sender, EventArgs e)
        {

            float sayi = float.Parse(textBoxMiktar.Text);
            float havale = 2.0f;

            if (sayi + havale> Form1.bakiye ) // miktar kontrolü
            {
                MessageBox.Show("Yetersiz Bakiye!", "Havale/EFT İşlemi.");
            }
            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set bakiye = bakiye - @p1 - 2 where ID = @p2", con); // havale / EFT yapan kişinin bakiyesinden para eksiltmek için.
                SqlCommand komut2 = new SqlCommand("update musteriler set bakiye = bakiye + @p3 where ID = @p4", con); // havale EFT yapılan kişinin bakiyesindeki parayı arttırmak için.


                komut.Parameters.AddWithValue("@p1", sayi); // hesabından para çıkan kişi.
                komut.Parameters.AddWithValue("@p2", Form1.customerId); // customerId Form1'de tanımlandığından dolayı tanımlamayı bu şekilde yaptık.
               
                komut2.Parameters.AddWithValue("@p3", sayi); // hesabına para giden kişi.
                komut2.Parameters.AddWithValue("@p4", textBoxNo.Text);

                if(sayi < 10)
                {
                    MessageBox.Show("Havale veya EFT İşlemleri için 10TL ve üzeri para aktarabilirsiniz!", "Havale/EFT İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    con.Open();

                    int sonuc1 = komut2.ExecuteNonQuery();
                    con.Close();

                    if(sonuc1 == 1) // sql'de sadece 1 satırı etkileyecek anlamına gelir.
                    {
                        con.Open();
                        komut.ExecuteNonQuery(); // SQL komtunu çalıştırmak için.
                        con.Close();
                        MessageBox.Show("Havale/EFT İşlemi Gerçekleştirildi!", "Havale/EFT İşlemi");
                        Form1.bakiye -= sayi + havale; // havale veya eft işlemini yapan kişinin bakiyesinden yaptığı eft veya havale tutarı kadar düş havale değeri 2tl yi de düş

                        HareketKaydet.kaydet(Form1.customerId, (sayi +" TL Havale Gonderildi")); // hesaptaki hareketleri kaydetmek için HareketKaydet sınıfındaki kaydet metodunu kullandık.
                        HareketKaydet.kaydet( int.Parse(textBoxNo.Text), (sayi + "TL Havale Alindi")); // textBoxNo ' da girilen kullanıcı TL havale aldı. Hareketleri kaydetmek için HareketKaydet sınıfını burada da kullandık.

                    }
                    else
                    {
                        MessageBox.Show("Alıcı Hesap Numarası Hatalı!", "Havale/EFT İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }


                    

                }

                textBoxMiktar.Text = "";
                textBoxNo.Text = "";
                
                 
                
                

            }
        }

        private void textBoxNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // sadece tamsayılı değerler girilebilir.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriIslem m = new MusteriIslem();
            m.Show();
            this.Close();
        }
    }
}
