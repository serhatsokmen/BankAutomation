using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAuto1
{
    public partial class MusteriIslem : Form
    {
        public MusteriIslem()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HavaleEft he = new HavaleEft();
            he.Show();
            this.Close();
        }

        private void buttonCik_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void MusteriIslem_Load(object sender, EventArgs e)
        {
            labelAdsoyad.Text = Form1.nameSurname; // kulllanıcının adını ve soyadını müşteri işlem formunda görüntülemek için ana sayfamız olan Form1 formundan kullanıcının adını soyadını alıyoruz. Bu işlemi yapabilmek için Form1'de bu değerleri public static olarak tanımlamıştık.
            labelBankano.Text = Form1.customerId.ToString(); // customerId int tipinde olduğundan dolayı hata almamak için toString metodunu kulllandık.
            labelBakiye.Text = Form1.bakiye.ToString() + "TL";
        }

        private void buttonParaCek_Click(object sender, EventArgs e)
        {
            ParaCek pc = new ParaCek();
            pc.Show();
            this.Close();
        }

        private void buttonParaYatir_Click(object sender, EventArgs e)
        {
            ParaYatir py = new ParaYatir();
            py.Show();
            this.Close();
        }

        private void buttonSifre_Click(object sender, EventArgs e)
        {
            SifreDegistir sd = new SifreDegistir();
            sd.Show();
            this.Close();
        }

        private void buttonHesap_Click(object sender, EventArgs e)
        {
            HesapHareketleri h = new HesapHareketleri();
            h.Show();
            this.Close();
        }

        private void labelAdsoyad_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
