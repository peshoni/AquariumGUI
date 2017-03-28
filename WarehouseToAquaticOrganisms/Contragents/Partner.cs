using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseToAquaticOrganisms
{
    [TypeConverter(typeof(PropertySort))]
    //[DefaultProperty("Name")]    
    public abstract class Partner
    {
        protected const string COMPANY = "Copmany details";
        [Category (COMPANY)]
        [DisplayName("2. Name")]
        public string Name { get; set; }
        [Category(COMPANY)]
        [DisplayName("1. ID")]
        public int ID { get; set; }
        [Category(COMPANY)]
        [DisplayName("3. Address")]
        public string Address { get; set; }
        [Category(COMPANY)]
        [DisplayName("4. Phone number")]
        public string PhoneNumber { get; set; } 
    }
}
