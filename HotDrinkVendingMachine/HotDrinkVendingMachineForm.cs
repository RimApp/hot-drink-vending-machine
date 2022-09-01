using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotDrinkVendingMachine
{
    public partial class HotDrinkVendingMachineForm : Form
    {
        public HotDrinkVendingMachineForm(IEnumerable<Recipe> recipes)
        {
            InitializeComponent();
            drinkComboBox.Items.AddRange(recipes?.ToArray());
            drinkComboBox.SelectedValueChanged += (s, e) =>
            {
                var recipe = (s as ComboBox)?.SelectedItem as Recipe;
                priceTextBox.Text = $"{recipe?.GetPrice()} €";
            };
        }
    }
}
