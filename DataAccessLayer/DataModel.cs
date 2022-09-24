using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

       public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStrLive);
            cmd = con.CreateCommand();
        }

        #region Kullanıcı Metotları



        #endregion
    }
}
