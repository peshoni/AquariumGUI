using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Product
    {
        private int _id;
        private string _name;
        private int _categoryId;

        public Product()
        {
        }


        #region Getters and setters

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
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

        public int CategoryId
        {
            get
            {
                return _categoryId;
            }

            set
            {
                _categoryId = value;
            }
        }


        #endregion
    }
}
