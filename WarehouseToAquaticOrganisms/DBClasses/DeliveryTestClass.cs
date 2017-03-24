using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseToAquaticOrganisms.Contragents
{
   public class TestDeliveryClass 
    {
        private int docID;
        private string providerName;
        private bool isPaid;

        private string accountablePerson;
        private string bulstat;
        private DateTime dateTime;
        private string phone;


        private string productName;
        private int quantity;
        public TestDeliveryClass() {
        }

        public int DocID
        {
            get
            {
                return docID;
            }

            set
            {
                docID = value;
            }
        }

        public string ProviderName
        {
            get
            {
                return providerName;
            }

            set
            {
                providerName = value;
            }
        }
 

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }

            set
            {
                productName = value;
            }
        }

        public bool IsPaid
        {
            get
            {
                return isPaid;
            }

            set
            {
                isPaid = value;
            }
        }

        public string AccountablePerson
        {
            get
            {
                return accountablePerson;
            }

            set
            {
                accountablePerson = value;
            }
        }

        public string Bulstat
        {
            get
            {
                return bulstat;
            }

            set
            {
                bulstat = value;
            }
        }

        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }

            set
            {
                dateTime = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }
    }
}
