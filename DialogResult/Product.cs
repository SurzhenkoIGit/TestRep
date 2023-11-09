using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogResult
{
    public class Product
    {
        public string Name { get; set; }
        public string MadeIn { get; set; }
        public double Price { get; set; }
        
        public Product() 
        {
            Name = null; 
            MadeIn = null;
            Price = 0;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", Name, MadeIn, Price);
        }
    }
}
