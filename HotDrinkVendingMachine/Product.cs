namespace HotDrinkVendingMachine
{
    public class Product : IItem
    {
        private readonly decimal price;

        public Product(string name, decimal price)
        {
            Name = name;
            this.price = price;
        }

        public string Name { get; set; }

        public decimal GetPrice()
        {
            return price;
        }
    }
}
