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
    public partial class HesapHareketleri : Form
    {
        public HesapHareketleri()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-2L4LDGC ; initial catalog = Bankamatik ; integrated security = sspi");


        private void HesapHareketleri_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("select * from hareketler where musteriId = @p1", con); // İşlemleri gerçekleştiren kullanıcı sadece kendi hesap hareketlerini görebilsin diye sadece musteriId
            komut.Parameters.AddWithValue("@p1", Form1.customerId); // @p1'i public static olan Form1 ' deki customerId ile eşleştirme. 

            SqlDataAdapter da = new SqlDataAdapter(komut); // veritabanından bilgileri çekebilmek için.

            DataTable table = new DataTable(); // verileri tablo şelinde gösterebilmek için DataTable.
            da.Fill(table);  // tabloya gerekli biligileri toplamak için.
            dataGridView1.DataSource = table; // tabloyu atamak için.

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriIslem m = new MusteriIslem();
            m.Show();
            this.Close();
        }
    }
}
