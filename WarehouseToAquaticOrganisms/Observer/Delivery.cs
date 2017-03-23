using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer;
using WarehouseToAquaticOrganisms.Classes;

namespace WarehouseToAquaticOrganisms.Observer
{
   public class Delivery : IDataErrorInfo
    {
        private int id;
        private DateTime dateTime;
        private int provider;
        private int product;
        private string providerName;
        private string productName;
        private int quantity;
        private decimal price;

        public Delivery()
        {
        }

        #region getters
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
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

        public int ProviderID
        {
            get
            {
                return provider;
            }

            set
            {
                provider = value;
            }
        }

        public int ProductID
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
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
 

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
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

        public string Error
        {
            get
            {
                return string.Empty;
            }
        }

        public string this [string columnName]
        {
            get
            {
                if ("Quantity" == columnName && Quantity <= 0)
                {
                    int tmp = 0;
                    if(!int.TryParse(Quantity.ToString(), out tmp))
                      
                    return ":-)))";
                   // return "Please fill Quantity";
                }
                
                else if ("Price" == columnName && Price == 0)
                    return "Please fill Price";              

                return string.Empty;
            }
        }
        #endregion
    }
}
