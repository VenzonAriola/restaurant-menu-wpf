using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding_Lab3.Model
{
    public class MenuItems
    {
        public string Name { get; set; }
        public double Price;
        public string Category { get; set; }

        private int Quantity;


        public double price
        {
            get { return Price; }
            set
            {
                if (Price != value)
                {
                    Price = value;
                }
            }
        }
        public int quantity
        {
            get { return Quantity; }
            set
            {
                Quantity = value;
            }

        }
    }
}
