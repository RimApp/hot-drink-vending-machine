using System.Collections.Generic;
using System.Linq;

namespace HotDrinkVendingMachine
{
    public class Recipe : IItem
    {
        public Recipe()
        {
            Products = new Dictionary<Product, int>();
        }

        public string Name { get; set; }

        private IDictionary<Product, int> Products { get; set; }

        public void AddProduct(Product product, int qantity = 1)
        {
            Products.Add(product, qantity);
        }

        public decimal GetPrice()
        {
            var purchasePrice = Products?.Sum(p => p.Key.GetPrice() * p.Value) ?? 0;
            var margin = purchasePrice * Program.MarginPercentage / 100;
            return purchasePrice + margin;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
