using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //!!!

namespace VTYS_ECZS_AppV0
{
    class SqlBaglantisi
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-G8E8I7JL;Initial Catalog=EczaneOtomasyonDB;Integrated Security=True"); //;Trust Server Certificate=True
            baglan.Open();
            return baglan;
        }
    }
}
