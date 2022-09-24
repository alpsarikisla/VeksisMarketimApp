using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ConnectionStrings
    {
        static string DataSource = "mssql08.turhost.com";
        static string InitialCatalog = "veksisc2_Veksis_Marketim_DB";
        static string UserID = "vk_Admn";
        static string Password = "&Pw8pr99?*";

        public static string ConStrLive = String.Format("Data Source={0}; Initial Catalog={1}; Persist Security Info=True;User ID={2}; Password={3}", DataSource, InitialCatalog, UserID, Password);

        public static string ConStrTest = @"Data Source=DESKTOP-6NIP90O\SQLEXPRESS; Initial Catalog=Veksis_Market_DB; Integrated Security=True";
    }
}
