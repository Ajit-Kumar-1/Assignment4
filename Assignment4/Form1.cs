namespace Assignment4
{
    public partial class Form1 : Form
    {
        // List of items
        private static Tuple<string, decimal, int>[] ITEMS = new Tuple<string, decimal, int>[60] { 
            new Tuple<string, decimal, int>("Compact Laptop (Silver)       ", 1129, 2),
            new Tuple<string, decimal, int>("Compact Laptop (Grey)         ", 1129, 2),
            new Tuple<string, decimal, int>("Compact Laptop (Gold)         ", 1129, 2),
            new Tuple<string, decimal, int>("Regular Laptop (Silver)       ", 2249, 2),
            new Tuple<string, decimal, int>("Regular Laptop (Grey)         ", 2249, 2),
            new Tuple<string, decimal, int>("Big Laptop (Silver)           ", 2749, 2),
            new Tuple<string, decimal, int>("Big Laptop (Grey)             ", 2749, 2),
            new Tuple<string, decimal, int>("Small Desktop (Silver)        ", 799, 2),
            new Tuple<string, decimal, int>("Small Desktop (Grey)          ", 799, 2),
            new Tuple<string, decimal, int>("All-in-one Desktop (Blue)     ", 1499, 2),
            new Tuple<string, decimal, int>("All-in-one Desktop (Green)    ", 1499, 2),
            new Tuple<string, decimal, int>("All-in-one Desktop (Pink)     ", 1499, 2),
            new Tuple<string, decimal, int>("All-in-one Desktop (Silver)   ", 1499, 2),
            new Tuple<string, decimal, int>("All-in-one Desktop (Yellow)   ", 1499, 2),
            new Tuple<string, decimal, int>("All-in-one Desktop (Orange)   ", 1499, 2),
            new Tuple<string, decimal, int>("All-in-one Desktop (Purple)   ", 1499, 2),
            new Tuple<string, decimal, int>("Big powerful tablet (Silver)  ", 1229, 2),
            new Tuple<string, decimal, int>("Big powerful tablet (Grey)    ", 1229, 2),
            new Tuple<string, decimal, int>("Powerful tablet (Silver)      ", 909, 2),
            new Tuple<string, decimal, int>("Powerful tablet (Grey)        ", 909, 2),
            new Tuple<string, decimal, int>("Regular tablet (Grey)         ", 679, 2),
            new Tuple<string, decimal, int>("Regular tablet (Silver)       ", 679, 2),
            new Tuple<string, decimal, int>("Regular tablet (Pink)         ", 679, 2),
            new Tuple<string, decimal, int>("Regular tablet (Green)        ", 679, 2),
            new Tuple<string, decimal, int>("Regular tablet (Blue)         ", 679, 2),
            new Tuple<string, decimal, int>("Compact tablet (Grey)         ", 569, 2),
            new Tuple<string, decimal, int>("Compact tablet (Pink)         ", 569, 2),
            new Tuple<string, decimal, int>("Compact tablet (Purple)       ", 569, 2),
            new Tuple<string, decimal, int>("Compact tablet (White)        ", 569, 2),
            new Tuple<string, decimal, int>("Basic tablet (Silver)         ", 369, 2),
            new Tuple<string, decimal, int>("Basic tablet (Grey)           ", 369, 2),
            new Tuple<string, decimal, int>("Compact phone (White)         ", 499, 2),
            new Tuple<string, decimal, int>("Compact phone (Black)         ", 499, 2),
            new Tuple<string, decimal, int>("Compact phone (Red)           ", 499, 2),
            new Tuple<string, decimal, int>("Small phone (White)           ", 829, 2),
            new Tuple<string, decimal, int>("Small phone (Black)           ", 829, 2),
            new Tuple<string, decimal, int>("Small phone (Red)             ", 829, 2),
            new Tuple<string, decimal, int>("Small phone (Blue)            ", 829, 2),
            new Tuple<string, decimal, int>("Small phone (Pink)            ", 829, 2),
            new Tuple<string, decimal, int>("Regular phone (White)         ", 929, 2),
            new Tuple<string, decimal, int>("Regular phone (Black)         ", 929, 2),
            new Tuple<string, decimal, int>("Regular phone (Red)           ", 929, 2),
            new Tuple<string, decimal, int>("Regular phone (Blue)          ", 929, 2),
            new Tuple<string, decimal, int>("Regular phone (Pink)          ", 929, 2),
            new Tuple<string, decimal, int>("Large phone (Silver)          ", 1279, 2),
            new Tuple<string, decimal, int>("Large phone (Grey)            ", 1279, 2),
            new Tuple<string, decimal, int>("Large phone (Gold)            ", 1279, 2),
            new Tuple<string, decimal, int>("Large phone (Blue)            ", 1279, 2),
            new Tuple<string, decimal, int>("Smartwatch (S/M) (White)      ", 429, 2),
            new Tuple<string, decimal, int>("Smartwatch (S/M) (Black)      ", 429, 2),
            new Tuple<string, decimal, int>("Smartwatch (S/M) (Green)      ", 429, 2),
            new Tuple<string, decimal, int>("Smartwatch (S/M) (Blue)       ", 429, 2),
            new Tuple<string, decimal, int>("Smartwatch (S/M) (Red)        ", 429, 2),
            new Tuple<string, decimal, int>("Smartwatch (L) (White)        ", 459, 2),
            new Tuple<string, decimal, int>("Smartwatch (L) (Black)        ", 459, 2),
            new Tuple<string, decimal, int>("Smartwatch (L) (Green)        ", 459, 2),
            new Tuple<string, decimal, int>("Smartwatch (L) (Blue)         ", 459, 2),
            new Tuple<string, decimal, int>("Smartwatch (L) (Red)          ", 459, 2),
            new Tuple<string, decimal, int>("In-ear Headphones             ", 199, 2),
            new Tuple<string, decimal, int>("In-ear Headphones with ANC    ", 279, 2),
        };

        // List of item categories
        private string[] CATEGORIES = new string[6] {
            "Laptop",
            "Desktop",
            "Tablet",
            "Phone",
            "Smartwatch",
            "Headphones"
        };

        // Item total prefix
        private const string ITEM_TOTAL_PREFIX = "Item Total: ";

        // Items left suffix
        private const string LEFT_SUFFIX = " left";

        // Method to set item total to zero
        void setItemTotalToZero()
        {
            ItemTotalLabel.Text = ITEM_TOTAL_PREFIX + 0.ToString("C");
        }

        // Method to print item variants' details in list box
        static string itemVariant(int index)
        {
            Tuple<string, decimal, int> item = ITEMS[index];
            string variant = "                                       ";
            return item.Item1 + item.Item2.ToString("C") + " " + item.Item3 + LEFT_SUFFIX;
        }

        private Array[] VARIANTS = new Array[6] {
            new string[7]{ itemVariant(0), itemVariant(1), itemVariant(2), itemVariant(3),
            itemVariant(4), itemVariant(5), itemVariant(6) },
            new string[9] { itemVariant(7), itemVariant(8), itemVariant(9), itemVariant(10),
                itemVariant(11), itemVariant(12), itemVariant(13), itemVariant(14), 
                itemVariant(15) },
            new string[15] { itemVariant(16), itemVariant(17), itemVariant(18), 
                itemVariant(19), itemVariant(20), itemVariant(21), itemVariant(22), 
                itemVariant(23), itemVariant(24), itemVariant(25), itemVariant(26), 
                itemVariant(27), itemVariant(28), itemVariant(29), itemVariant(30) },
            new string[17] { itemVariant(31), itemVariant(32), itemVariant(33),
                itemVariant(34), itemVariant(35), itemVariant(36), itemVariant(37),
                itemVariant(38), itemVariant(39), itemVariant(40), itemVariant(41),
                itemVariant(42), itemVariant(43), itemVariant(44), itemVariant(45),
                itemVariant(46), itemVariant(47)},
            new string[10] { itemVariant(48), itemVariant(49), itemVariant(50),
                itemVariant(51), itemVariant(52), itemVariant(53), itemVariant(54),
                itemVariant(55), itemVariant(56), itemVariant(57) },
            new string[2] { itemVariant(58), itemVariant(59) }
        };

        public Form1()
        {
            InitializeComponent();

            // Set list of item categories
            itemCategoryListBox.Items.Clear();
            itemCategoryListBox.Items.AddRange((object[])CATEGORIES);

            // Start with item total of zero
            setItemTotalToZero();
        }

        // Event handler called when item category is changed
        private void itemCategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Resetting index of item variants list
            itemVariantListBox.SelectedIndex = -1;
            
            // First clearing existing list of item variants
            itemVariantListBox.Items.Clear();

            // Hiding the "Add to Basket" button
            addToBasketButton.Hide();

            // Clearing existing list of item variants
            itemVariantListBox.Items.Clear();

            // Setting new list of item variants
            itemVariantListBox.Items.AddRange((object[])VARIANTS[itemCategoryListBox.SelectedIndex]);
        }

        // Event handler called when an item category is selected
        private void itemVariantListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show the "Add to Basket" button
            addToBasketButton.Show();
        }

        // Event handler called when pressing the "Add to Basket" button
        private void addToBasketButton_Click(object sender, EventArgs e)
        {
            // Add the selected item variant to basket
            basketListBox.Items.Add(itemVariantListBox.SelectedItem);
        }

        // Event handler called when pressing the "Clear Basket" button
        private void clearBasketButton_Click(object sender, EventArgs e)
        {
            // Empty the basket
            basketListBox.Items.Clear();

            // Hide the "Delete Item" button

            // Set item total to zero
            setItemTotalToZero();
        }

        // Event handler called on pressing the "Delete Item" button
        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            // Remove the selected item from basket
            basketListBox.Items.RemoveAt(basketListBox.SelectedIndex);
        }

        // Event handler called on selecting an item from the basket
        private void basketListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show the "Delete Item" button
            deleteItemButton.Show();
        }
    }
}       