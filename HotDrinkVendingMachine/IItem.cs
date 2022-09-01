namespace HotDrinkVendingMachine
{
    public interface IItem
    {
        string Name { get; set; }

        decimal GetPrice();
    }
}
