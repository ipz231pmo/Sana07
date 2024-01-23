using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ShoppingCart
    {
        List<Product> products = new List<Product>();
        public void AddProduct(Product product) 
        { 
            products.Add(product);
        }
        public string Display()
        {
            string res = "Shopping Cart\n";
            foreach (Product item in products) 
            {
                res += item.Display();
            }
            res += "Shopping Cart End\n";
            return res;
        }
        public decimal CalculateSum()
        {
            decimal sum = 0;
            foreach (Product item in products)
            {
                sum += item.Price * item.Count;
            }
            return sum;
        }
    }
}
