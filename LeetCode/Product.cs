using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Product
    {
        public decimal Price {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image {  get; set; }
         
        public static implicit operator Child(Product parent)
        {
            return new Child
            {
                Price = parent.Price,
                Name = parent.Name,
            };
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
