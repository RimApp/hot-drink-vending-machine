using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotDrinkVendingMachine
{
    static class Program
    {
        public const int MarginPercentage = 30;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HotDrinkVendingMachineForm(AddDefaultRecipes()));
        }

        private static IEnumerable<Recipe> AddDefaultRecipes()
        {
            // Products
            var coffee = new Product("Café", 1);
            var sugar = new Product("Sucre", 0.1m);
            var cream = new Product("Crème", 0.5m);
            var tea = new Product("Thé", 2m);
            var water = new Product("Eau", 0.2m);
            var chocolate = new Product("Chocolat", 1);
            var milk = new Product("Lait", 0.4m);

            // Recipes
            var expressoRecipe = new Recipe { Name = "Expresso" };
            expressoRecipe.AddProduct(coffee);
            expressoRecipe.AddProduct(water);

            var elongateRecipe = new Recipe { Name = "Allongé" };
            elongateRecipe.AddProduct(coffee);
            elongateRecipe.AddProduct(water, 2);

            var capuccinoRecipe = new Recipe { Name = "Capuccino" };
            capuccinoRecipe.AddProduct(coffee);
            capuccinoRecipe.AddProduct(chocolate);
            capuccinoRecipe.AddProduct(water);
            capuccinoRecipe.AddProduct(cream);

            var chocolatRecipe = new Recipe { Name = "Chocolat" };
            chocolatRecipe.AddProduct(chocolate, 3);
            chocolatRecipe.AddProduct(milk, 2);
            chocolatRecipe.AddProduct(water);
            chocolatRecipe.AddProduct(sugar);

            var teaRecipe = new Recipe { Name = "The" };
            teaRecipe.AddProduct(tea);
            teaRecipe.AddProduct(water, 2);

            return new List<Recipe> { expressoRecipe, elongateRecipe, capuccinoRecipe, chocolatRecipe, teaRecipe };
        }
    }
}
