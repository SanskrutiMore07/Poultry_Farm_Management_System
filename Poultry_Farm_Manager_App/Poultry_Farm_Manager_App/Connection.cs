using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Poultry_Farm_Manager_App
{
   internal class Connection
    {
        public static SqlConnection DBCon = new SqlConnection(@"Data Source=DESKTOP-2RCOABL;Initial Catalog=Poultry_Farm_Manager_App_DB;Integrated Security=True");

        public static void S_Con_Open()
        {
            if(DBCon.State !=ConnectionState.Open)
            {
                DBCon.Open();
            }
        }
        public static void S_Con_Close()
        {
            if(DBCon.State != ConnectionState.Closed)
            {
                DBCon.Close();
            }
        }
    }
}
