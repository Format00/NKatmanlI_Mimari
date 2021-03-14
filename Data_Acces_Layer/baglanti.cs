using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data_Acces_Layer
{
    class baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-NDPEIH4\SQLEXPRESS;Initial Catalog=Db_Personel;Integrated Security=True");

    }
}
