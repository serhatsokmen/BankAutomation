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
    public partial class YetkiliIslem : Form
    {
        public YetkiliIslem()
        {
            InitializeComponent();
        }

        private void buttonCik_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle me = new MusteriEkle();
            me.Show();
            this.Close();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            MusteriAra ma = new MusteriAra();
            ma.Show();
            this.Close();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            MusteriGuncelle mg = new MusteriGuncelle();
            mg.Show();
            this.Close();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            MusteriSil ms = new MusteriSil();
            ms.Show();
            this.Close();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            MusteriListele ml = new MusteriListele();
            ml.Show();
            this.Close();
        }
    }
}
