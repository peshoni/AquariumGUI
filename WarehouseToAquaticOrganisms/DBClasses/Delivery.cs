using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseToAquaticOrganisms.DBClasses
{
   public class Delivery : IDataErrorInfo
    {
        private int docID;
        private string providerName;
        private bool isPaid;

        private string accountablePerson;
        private string bulstat;
        private DateTime dateTime;
        private string phone;
        private decimal deliveryPrice;
        private int productID;


        private string category;
        private int categoryId;


        private string productName;
        private int quantity;
        public Delivery() {
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

        public decimal DeliveryPrice
        {
            get
            {
                return deliveryPrice;
            }

            set
            {
                deliveryPrice = value;
            }
        }

        public int ProductID
        {
            get
            {
                return productID;
            }

            set
            {
                productID = value;
            }
        }

        public string Error
        {
            get
            {
                return string.Empty;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public int CategoryId
        {
            get
            {
                return categoryId;
            }

            set
            {
                categoryId = value;
            }
        }

        public string this [string columnName]
        {
            get
            {

                if ("Quantity" == columnName && Quantity == 0)
                    return "Please fill Quantity";


                else if ("DeliveryPrice" == columnName && DeliveryPrice==0)
                    return "Please fill Price";

                return string.Empty;
            }
        }
    }
}
