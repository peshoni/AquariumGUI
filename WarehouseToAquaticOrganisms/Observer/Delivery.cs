using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer;
using WarehouseToAquaticOrganisms.Classes;

namespace WarehouseToAquaticOrganisms.Observer
{
   public class Delivery
    {
        private int id;
        private DateTime dateTime;
        private string provider;
        private string product;
        private int quantity;
        private decimal price;

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

        public string Provider
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

        public string Product
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
        #endregion

        public Delivery(   )
        { 
        }
    }
}
