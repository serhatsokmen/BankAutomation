using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAuto1
{
    internal class HareketKaydet
    {
        public static void kaydet(int customerId, string mesaj) // ..Id ' ye ..mesajı kaydetmesi için id ve mesaj.
        {
            SqlConnection con = new SqlConnection("server = DESKTOP-2L4LDGC ; initial catalog = Bankamatik ; integrated security = sspi");

            SqlCommand komut = new SqlCommand("insert into hareketler (musteriId, islem, tarih) values (@p1, @p2, @p3)", con); // Id, işlem, tarih değerlerini kaydetemek için SQL komutu.
            komut.Parameters.AddWithValue("@p1", customerId); // @p1 ile customerId eşleştir
            komut.Parameters.AddWithValue("@p2", mesaj); // @p2 ile mesaj eşleştir
            komut.Parameters.AddWithValue("@p3", DateTime.Now); // DateTime.Now -> şu anki tarih.

            
            con.Open();


            komut.ExecuteNonQuery(); // komutu çalıştırabilmek için.



            con.Close();

        }
    }
}
