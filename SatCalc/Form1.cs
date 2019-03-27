using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatCalc
{
    public partial class Form1 : Form
    {
        public Dictionary<int, Item> Items;
        public List<RecipeItem> Recipes;
        public Dictionary<int, Machine> Machines;
        public Dictionary<string, double> MinerLevel;
        public Dictionary<string, double> OrePurity;

        public Form1()
        {
            InitializeComponent();
            Items = new Dictionary<int, Item> {
                {0, new Item(){Name = "Iron Ore", MadeInKey = 0, OutputPerMinute = 60.0, OutputQuantity = 1 } },
                {1, new Item(){Name = "Copper Ore", MadeInKey = 0, OutputPerMinute = 60.0, OutputQuantity = 1} },
                {2, new Item(){Name = "Iron Ingot", MadeInKey = 1, OutputPerMinute = 30.0, OutputQuantity = 1} },
                {3, new Item(){Name = "Copper Ingot", MadeInKey = 1, OutputPerMinute = 30.0, OutputQuantity = 1 } },
                {4, new Item(){Name = "Iron Plate", MadeInKey = 2, OutputPerMinute = 15.0 , OutputQuantity = 1} },
                {5, new Item(){Name = "Iron Rod", MadeInKey = 2, OutputPerMinute = 15.0, OutputQuantity = 1} },
                {6, new Item(){Name = "Wire", MadeInKey = 2, OutputPerMinute = 45.0, OutputQuantity = 3 } },
                {7, new Item(){Name = "Cable", MadeInKey = 2, OutputPerMinute = 15.0, OutputQuantity = 1 } },
                {8, new Item(){Name = "Screw", MadeInKey = 2, OutputPerMinute = 90.0, OutputQuantity = 6 } },
                {9, new Item(){Name = "Reinforced Iron Plate", MadeInKey = 3, OutputPerMinute = 5.0, OutputQuantity = 1 } },
            };

            Recipes = new List<RecipeItem>
            {
                { new RecipeItem() { ItemKey = 2, PartKey = 0, Qauntity = 1} },
                { new RecipeItem() { ItemKey = 3, PartKey = 1, Qauntity = 1} },
                { new RecipeItem() { ItemKey = 4, PartKey = 2, Qauntity = 2} },
                { new RecipeItem() { ItemKey = 5, PartKey = 2, Qauntity = 1} },
                { new RecipeItem() { ItemKey = 6, PartKey = 3, Qauntity = 1} },
                { new RecipeItem() { ItemKey = 7, PartKey = 6, Qauntity = 2} },
                { new RecipeItem() { ItemKey = 8, PartKey = 5, Qauntity = 1} },
                { new RecipeItem() { ItemKey = 9, PartKey = 8, Qauntity = 24} },
                { new RecipeItem() { ItemKey = 9, PartKey = 4, Qauntity = 4} },
            };

            MinerLevel = new Dictionary<string, double>
            {
                { "MK1", 1.0},
                { "MK2", 2.0}
            };

            OrePurity = new Dictionary<string, double>
            {
                { "Impure", .5},
                { "Normal", 1.0},
                { "Pure", 2.0}
            };

            Machines = new Dictionary<int, Machine>
            {
                {0, new Machine() { Name = "Miner"} },
                {1, new Machine() { Name = "Smelter"} },
                {2, new Machine() { Name = "Constructor"} },
                {3, new Machine() { Name = "Assembler"} },
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ItemDropdownBox.DataSource = new BindingSource(Items, null);
            ItemDropdownBox.DisplayMember = "Value";
            ItemDropdownBox.ValueMember = "Key";

            MinerLevelComboBox.DataSource = new BindingSource(MinerLevel, null);
            MinerLevelComboBox.DisplayMember = "Key";
            MinerLevelComboBox.ValueMember = "Value";

            OrePurityComboBox.DataSource = new BindingSource(OrePurity, null);
            OrePurityComboBox.DisplayMember = "Key";
            OrePurityComboBox.ValueMember = "Value";
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            ResultOutputListView.Clear();

            List<ResultItem> result = new List<ResultItem>();
            var ItemDropDownObj = (KeyValuePair<int, Item>)ItemDropdownBox.SelectedItem;
            var AmountNeededPerMinute = Convert.ToInt32(ItemsPerMinuteTextBox.Text);
            Items.TryGetValue(ItemDropDownObj.Key, out var itemObj);
            Machines.TryGetValue(itemObj.MadeInKey, out var machineObj);


            result.Add(new ResultItem()
            {
                Item = itemObj.ToString(),
                Machine = machineObj.ToString(),
                AmountOfMachine = AmountNeededPerMinute / itemObj.OutputPerMinute,
                AmountPerMinute = Convert.ToInt32(ItemsPerMinuteTextBox.Text),
            });


            result = DoTheStuff(((KeyValuePair<int, Item>)ItemDropdownBox.SelectedItem).Key, Convert.ToInt32(ItemsPerMinuteTextBox.Text), result);

            foreach (var resultItem in result)
            {
                ResultOutputListView.Items.Add(resultItem.ToString());
            }
        }

        private List<ResultItem> DoTheStuff(int ItemKey, double AmountPerMinute, List<ResultItem> result)
        {
            //Base Case
            //If the item has no more things need to craft it (aka ore), then lets JET!
            var recipeParts = Recipes.FindAll(item => item.ItemKey == ItemKey);
            Items.TryGetValue(ItemKey, out var CurrentItemOutput);
            if (recipeParts.Count < 1) {
                result[result.Count - 1].AmountOfMachine = (result[result.Count - 1].AmountOfMachine / ((KeyValuePair<string, double>)MinerLevelComboBox.SelectedItem).Value) / ((KeyValuePair<string, double>)OrePurityComboBox.SelectedItem).Value;
                return result;
            } else
            {
                foreach (var part in recipeParts)
                {
                    Items.TryGetValue(part.PartKey, out var itemObj);
                    Machines.TryGetValue(itemObj.MadeInKey, out var machineObj);
                    var PartAmountPerMinute = (AmountPerMinute * (double)part.Qauntity) / CurrentItemOutput.OutputQuantity;
                    result.Add(new ResultItem()
                    {
                        Item = itemObj.ToString(),
                        AmountPerMinute = PartAmountPerMinute,
                        Machine = machineObj.ToString(),
                        AmountOfMachine = (((double)part.Qauntity * AmountPerMinute) / itemObj.OutputPerMinute/ CurrentItemOutput.OutputQuantity)
                    });
                    result = DoTheStuff(part.PartKey, PartAmountPerMinute, result);
                }
            }
            return result;
        }
    }
}
