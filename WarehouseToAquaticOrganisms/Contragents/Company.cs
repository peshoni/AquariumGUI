using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseToAquaticOrganisms.Classes
{
    public class Company: Partner
    {
        private string _bulstat;
        private string _acountablePerson;

        public Company() {
        } 

        #region Getters
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
