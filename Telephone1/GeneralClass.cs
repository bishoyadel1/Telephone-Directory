using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlTypes;
using System.Data.Common;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Telephone1
{
  class GeneralClass
    {
       public static SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-ARVU609;DataBase=TelephoneDB;Trusted_Connection=True;Encrypt=False");

        public void LoadTable(string TableName , DataGridView dvg)
        {
            DataTable dt = new DataTable();


            SqlDataAdapter da = new SqlDataAdapter();
            dt.Clear();
            da = new SqlDataAdapter("select * from "+TableName+" ", GeneralClass.sqlConnection);
            da.Fill(dt);
            dvg.DataSource = dt;    
        }

    }
}
