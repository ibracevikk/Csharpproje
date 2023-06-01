using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastaneoto
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-S69NDOA\\SQLEXPRESS;Initial Catalog=projehastane;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
