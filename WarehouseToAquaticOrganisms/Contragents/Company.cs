using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseToAquaticOrganisms.Classes
{
    [TypeConverter(typeof(PropertySort))]
    public class Company: Partner
    {
       // protected const string COMPANY = "Copmany details";
       
        private string _bulstat;
        private string _acountablePerson;

        public Company() {
        }

        #region Getters
        [Category(COMPANY)]
        [DisplayName("6. BULSTAT")]
        public string Bulstat
        {
            get
            {
                return _bulstat;
            }

            set
            {
                _bulstat = value;
            }
        }
        [Category(COMPANY)]
        [DisplayName("7. Accountable person")]
        public string AcountablePerson
        {
            get
            {
                return _acountablePerson;
            }

            set
            {
                _acountablePerson = value;
            }
        }
        #endregion
    }
}
