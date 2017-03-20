using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Product
    {
        private string _name;
        private int _quantity;
        public Product(string name, int quantity)
        {
            this._name = name;
            this._quantity = quantity;
        }
        #region Getters and setters
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                _quantity = value;
            }
        }
        #endregion
    }
}
