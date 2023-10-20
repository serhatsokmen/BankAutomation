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
using System.Diagnostics;

namespace BankAuto1
{
    public partial class MusteriListele : Form
    {
        public MusteriListele()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-2L4LDGC ; initial catalog = Bankamatik ; integrated security = sspi");



        private void MusteriListele_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from musteriler", con);
            SqlDataAdapter da = new SqlDataAdapter(komut); // verileri veritabanından almak için SqlDataAdapter kullandım.
            DataTable dt = new DataTable();
            da.Fill(dt); // SqlDataAdapter olarak oluşturduğum da ' nın da.Fill komutu ile tabloya gerekli bilgileri toplamak için.
            dataGridView1.DataSource = dt; // tabloyu atamak için.

        }

        private void button3_Click(object sender, EventArgs e)
        {
            YetkiliIslem yet = new YetkiliIslem();
            yet.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from musteriler where adSoyad like '"+textBox1.Text+ "%'", con); // isme göre listeleme yapabilmek için gereken SQL komutu
            SqlDataAdapter da = new SqlDataAdapter(komut); // veritabanından biligleri almak için.
            DataTable dt = new DataTable(); 
            da.Fill(dt); // tabloya gerekli biligleri toplamak için. 
            dataGridView1.DataSource = dt; // tabloyu atamak için.
        }
    }
}
