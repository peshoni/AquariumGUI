using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumGUI
{
    public class DBUtill
    {
        private DBUtill()
        {
        }
        public static string GetConnectionString()
        {
            string returnValue = null;
            string connString = AquariumGUI.Properties.Settings.Default.AquariumDatabaseConnectionString;
            if (connString != null)
                returnValue = connString;
            return returnValue;
        }
    }
}
