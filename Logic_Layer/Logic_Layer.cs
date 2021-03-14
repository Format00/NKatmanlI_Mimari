using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Layer;
using Data_Acces_Layer;

namespace Logic_Layer
{
    public class Logic_Layer
    {
        public static List<Entity_Personel> LLPersonelListesi()
        {
            return DAL_Personel.PersonelListesi();
        }
        public static int LLPersonelEkle(Entity_Personel p)
        {
            if(p.Ad != "" && p.Soyad != "" && p.Maas>=3500 && p.Ad.Length >= 3)
            {
                return DAL_Personel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }

        public static int LLPersonelSil(Entity_Personel p)
        {
            return DAL_Personel.PersonelSil(p);
        }

        public static int LLPersonelGüncelle(Entity_Personel p)
        {
            return DAL_Personel.PersonelGüncelle(p);
        }


    }
}
