using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumGUI
{
   internal  class DatabaseUtillity
    {
         
        //Get the connection string from App config file.  
        internal static string GetConnectionString()
        {            
            string returnValue = null;
            string connString=  AquariumGUI.Properties.Settings.Default.AquariumDatabaseConnectionString; 
            if (connString != null)
                returnValue = connString; 
            return returnValue;
        }
 

    }
}
