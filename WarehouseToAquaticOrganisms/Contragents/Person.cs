using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseToAquaticOrganisms.Classes
{
    public class Person:Partner
    {
        private long _egn;

        public Person() { 
        }
    /// <summary>
    /// Getters and setters.
    /// </summary>
        #region Getters
        public long Egn
        {
            get
            {
                return _egn;
            }

            set
            {
                _egn = value;
            }
        }
        #endregion
    }
}
