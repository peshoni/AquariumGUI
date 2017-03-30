using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseToAquaticOrganisms.Classes;

namespace WarehouseToAquaticOrganisms.DBClasses
{
   public  class DBManager
    {
       // private static SqlConnection connection=null;
        private DBManager()
        { 
        }
        public static string GetConnectionString()
        {
            string returnValue = null;
            string connString = WarehouseToAquaticOrganisms.Properties.Settings.Default.AquariumDatabaseConnectionString;
            if (connString != null)
                returnValue = connString;
            return returnValue;
        }


        public static SqlConnection GetConnection()
        {
            SqlConnection connection = null;
            if (connection == null)
            {
                connection = new SqlConnection(GetConnectionString());
            }
            return connection;
        }
    }
}
