using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Layer;
using System.Data.SqlClient;
using System.Data;

namespace Data_Acces_Layer
{
    public class DAL_Personel
    {
        public static List<Entity_Personel> PersonelListesi()
        {
            List<Entity_Personel> degerler = new List<Entity_Personel>();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Bilgi", baglanti.bgl);
            if(komut.Connection.State!= ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Entity_Personel ent = new Entity_Personel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Sehir = dr["SEHİR"].ToString();
                ent.Maas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int PersonelEkle(Entity_Personel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into Tbl_Bilgi (AD, SOYAD, SEHİR, MAAS, GOREV) values (@p1, @p2, @p3, @p4, @p5)", baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p.Ad);
            komut2.Parameters.AddWithValue("@p2", p.Soyad);
            komut2.Parameters.AddWithValue("@p3", p.Sehir);
            komut2.Parameters.AddWithValue("@p4", p.Maas);
            komut2.Parameters.AddWithValue("@p5", p.Gorev);
            return komut2.ExecuteNonQuery();
        }

        public static int PersonelSil(Entity_Personel p)
        {
            SqlCommand komut3 = new SqlCommand("Delete from Tbl_Bilgi where ID=@p1", baglanti.bgl);
            komut3.Parameters.AddWithValue("@p1", p.Id);
            return komut3.ExecuteNonQuery();
        }

        public static int PersonelGüncelle(Entity_Personel p)
        {
            SqlCommand komut4 = new SqlCommand("Update  Tbl_Bilgi set AD=@p1, SOYAD=@p2, SEHİR=@p3, GOREV=@p4, MAAS=@p5 where ID=@p6", baglanti.bgl);
            komut4.Parameters.AddWithValue("@p1", p.Ad);
            komut4.Parameters.AddWithValue("@p2", p.Soyad);
            komut4.Parameters.AddWithValue("@p3", p.Sehir);
            komut4.Parameters.AddWithValue("@p4", p.Gorev);
            komut4.Parameters.AddWithValue("@p5", p.Maas);
            komut4.Parameters.AddWithValue("@p6", p.Id);
            return komut4.ExecuteNonQuery();
        }


    }
}
