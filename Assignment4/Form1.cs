namespace Assignment4
{
    public partial class Form1 : Form
    {
        // List of items
        private static Tuple<string, decimal, int, int>[] ITEMS = 
            new Tuple<string, decimal, int, int>[60] { 
            new Tuple<string, decimal, int, int>("Compact Laptop (Silver)       ", 1129, 2, 0),
            new Tuple<string, decimal, int, int>("Compact Laptop (Grey)         ", 1129, 2, 1),
            new Tuple<string, decimal, int, int>("Compact Laptop (Gold)         ", 1129, 2, 2),
            new Tuple<string, decimal, int, int>("Regular Laptop (Silver)       ", 2249, 2, 3),
            new Tuple<string, decimal, int, int>("Regular Laptop (Grey)         ", 2249, 2, 4),
            new Tuple<string, decimal, int, int>("Big Laptop (Silver)           ", 2749, 2, 5),
            new Tuple<string, decimal, int, int>("Big Laptop (Grey)             ", 2749, 2, 6),
            new Tuple<string, decimal, int, int>("Small Desktop (Silver)        ", 799, 2, 7),
            new Tuple<string, decimal, int, int>("Small Desktop (Grey)          ", 799, 2, 8),
            new Tuple<string, decimal, int, int>("All-in-one Desktop (Blue)     ", 1499, 2, 9),
            new Tuple<string, decimal, int, int>("All-in-one Desktop (Green)    ", 1499, 2, 10),
            new Tuple<string, decimal, int, int>("All-in-one Desktop (Pink)     ", 1499, 2, 11),
            new Tuple<string, decimal, int, int>("All-in-one Desktop (Silver)   ", 1499, 2, 12),
            new Tuple<string, decimal, int, int>("All-in-one Desktop (Yellow)   ", 1499, 2, 13),
            new Tuple<string, decimal, int, int>("All-in-one Desktop (Orange)   ", 1499, 2, 14),
            new Tuple<string, decimal, int, int>("All-in-one Desktop (Purple)   ", 1499, 2, 15),
            new Tuple<string, decimal, int, int>("Big powerful tablet (Silver)  ", 1229, 2, 16),
            new Tuple<string, decimal, int, int>("Big powerful tablet (Grey)    ", 1229, 2, 17),
            new Tuple<string, decimal, int, int>("Powerful tablet (Silver)      ", 909, 2, 18),
            new Tuple<string, decimal, int, int>("Powerful tablet (Grey)        ", 909, 2, 19),
            new Tuple<string, decimal, int, int>("Regular tablet (Grey)         ", 679, 2, 20),
            new Tuple<string, decimal, int, int>("Regular tablet (Silver)       ", 679, 2, 21),
            new Tuple<string, decimal, int, int>("Regular tablet (Pink)         ", 679, 2, 22),
            new Tuple<string, decimal, int, int>("Regular tablet (Green)        ", 679, 2, 23),
            new Tuple<string, decimal, int, int>("Regular tablet (Blue)         ", 679, 2, 24),
            new Tuple<string, decimal, int, int>("Compact tablet (Grey)         ", 569, 2, 25),
            new Tuple<string, decimal, int, int>("Compact tablet (Pink)         ", 569, 2, 26),
            new Tuple<string, decimal, int, int>("Compact tablet (Purple)       ", 569, 2, 27),
            new Tuple<string, decimal, int, int>("Compact tablet (White)        ", 569, 2, 28),
            new Tuple<string, decimal, int, int>("Basic tablet (Silver)         ", 369, 2, 29),
            new Tuple<string, decimal, int, int>("Basic tablet (Grey)           ", 369, 2, 30),
            new Tuple<string, decimal, int, int>("Compact phone (White)         ", 499, 2, 31),
            new Tuple<string, decimal, int, int>("Compact phone (Black)         ", 499, 2, 32),
            new Tuple<string, decimal, int, int>("Compact phone (Red)           ", 499, 2, 33),
            new Tuple<string, decimal, int, int>("Small phone (White)           ", 829, 2, 34),
            new Tuple<string, decimal, int, int>("Small phone (Black)           ", 829, 2, 35),
            new Tuple<string, decimal, int, int>("Small phone (Red)             ", 829, 2, 36),
            new Tuple<string, decimal, int, int>("Small phone (Blue)            ", 829, 2, 37),
            new Tuple<string, decimal, int, int>("Small phone (Pink)            ", 829, 2, 38),
            new Tuple<string, decimal, int, int>("Regular phone (White)         ", 929, 2, 39),
            new Tuple<string, decimal, int, int>("Regular phone (Black)         ", 929, 2, 40),
            new Tuple<string, decimal, int, int>("Regular phone (Red)           ", 929, 2, 41),
            new Tuple<string, decimal, int, int>("Regular phone (Blue)          ", 929, 2, 42),
            new Tuple<string, decimal, int, int>("Regular phone (Pink)          ", 929, 2, 43),
            new Tuple<string, decimal, int, int>("Large phone (Silver)          ", 1279, 2, 44),
            new Tuple<string, decimal, int, int>("Large phone (Grey)            ", 1279, 2, 45),
            new Tuple<string, decimal, int, int>("Large phone (Gold)            ", 1279, 2, 46),
            new Tuple<string, decimal, int, int>("Large phone (Blue)            ", 1279, 2, 47),
            new Tuple<string, decimal, int, int>("Smartwatch (S/M) (White)      ", 429, 2, 48),
            new Tuple<string, decimal, int, int>("Smartwatch (S/M) (Black)      ", 429, 2, 49),
            new Tuple<string, decimal, int, int>("Smartwatch (S/M) (Green)      ", 429, 2, 50),
            new Tuple<string, decimal, int, int>("Smartwatch (S/M) (Blue)       ", 429, 2, 51),
            new Tuple<string, decimal, int, int>("Smartwatch (S/M) (Red)        ", 429, 2, 52),
            new Tuple<string, decimal, int, int>("Smartwatch (L) (White)        ", 459, 2, 53),
            new Tuple<string, decimal, int, int>("Smartwatch (L) (Black)        ", 459, 2, 54),
            new Tuple<string, decimal, int, int>("Smartwatch (L) (Green)        ", 459, 2, 55),
            new Tuple<string, decimal, int, int>("Smartwatch (L) (Blue)         ", 459, 2, 56),
            new Tuple<string, decimal, int, int>("Smartwatch (L) (Red)          ", 459, 2, 57),
            new Tuple<string, decimal, int, int>("In-ear Headphones             ", 199, 2, 58),
            new Tuple<string, decimal, int, int>("In-ear Headphones with ANC    ", 279, 2, 59),
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

        // Alert message
        private const string ALERT_MESSAGE = "Alert";

        // Message segments for prompting confirmation of purchase
        private const string CHECKOUT_MESSAGE_PART_1 = "Do you confirm purchase of ";
        private const string CHECKOUT_MESSAGE_PART_2 = " item(s) for a total of ";
        private const string CHECKOUT_MESSAGE_PART_3 = "?";

        // Item total prefix
        private const string ITEM_TOTAL_PREFIX = "Item Total: ";

        // Items left suffix
        private const string LEFT_SUFFIX = " left";

        // Method to update the displayed basket total
        private void updateTotalDisplay()
        {
            ItemTotalLabel.Text = ITEM_TOTAL_PREFIX + total.ToString("C");
        }

        // Method to print item variants' details in list box
        private static string itemVariant(int index)
        {
            Tuple<string, decimal, int, int> item = ITEMS[index];
            return item.Item1 + item.Item2.ToString("C") + " " + item.Item3 + LEFT_SUFFIX;
        }

        // Method to print item in basket
        private string basketItem(int index)
        {
            Tuple<string, decimal, int, int> item = ITEMS[index];
            return item.Item1 + item.Item2.ToString("C");
        }

        // Variable to track displayed item variants in the background
        private List<Tuple<string, decimal, int, int>> variants =
            new List<Tuple<string, decimal, int, int>>();

        // Variable to track basket items in the background
        private List<Tuple<string, decimal, int, int>> basket =
            new List<Tuple<string, decimal, int, int>>();

        // Variable to keep track of basket total
        private decimal total = 0.00M;

        // Method to update stock
        private void updateStock(int index, int increment)
        {
            ITEMS[index] = new Tuple<string, decimal, int, int>
                (ITEMS[index].Item1, ITEMS[index].Item2, 
                ITEMS[index].Item3 + increment, ITEMS[index].Item4);
        }

        public Form1()
        {
            InitializeComponent();

            // Set list of item categories
            itemCategoryListBox.Items.Clear();
            itemCategoryListBox.Items.AddRange((object[])CATEGORIES);

            // Start with item total of zero
            updateTotalDisplay();
        }

        // Method to display item variants in list box and keep a list in the background
        void loadVariants()
        {
            // Clearing existing list of item variants
            itemVariantListBox.Items.Clear();
            variants.Clear();

            // Setting new list of item variants
            switch (itemCategoryListBox.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < 7; i++)
                    {
                        variants.Add(ITEMS[i]);
                        itemVariantListBox.Items.Add(itemVariant(i));
                    }
                    break;
                case 1:
                    for (int i = 7; i < 16; i++)
                    {
                        variants.Add(ITEMS[i]);
                        itemVariantListBox.Items.Add(itemVariant(i));
                    }
                    break;
                case 2:
                    for (int i = 16; i < 31; i++)
                    {
                        variants.Add(ITEMS[i]);
                        itemVariantListBox.Items.Add(itemVariant(i));
                    }
                    break;
                case 3:
                    for (int i = 31; i < 48; i++)
                    {
                        variants.Add(ITEMS[i]);
                        itemVariantListBox.Items.Add(itemVariant(i));
                    }
                    break;
                case 4:
                    for (int i = 48; i < 58; i++)
                    {
                        variants.Add(ITEMS[i]);
                        itemVariantListBox.Items.Add(itemVariant(i));
                    }
                    break;
                case 5:
                    for (int i = 58; i < 60; i++)
                    {
                        variants.Add(ITEMS[i]);
                        itemVariantListBox.Items.Add(itemVariant(i));
                    }
                    break;
                default:
                    break;
            }
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

            // Load up the list of item variants
            loadVariants();

        }

        // Event handler called when an item category is selected
        private void itemVariantListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
                // Index out of bounds exception occurs when changing categories
            {
                // Check if there is stock for the selected item variant
                if (variants[itemVariantListBox.SelectedIndex].Item3 > 0)
                {
                    // Show the "Add to Basket" button
                    addToBasketButton.Show();
                }
                else
                    // Otherwise, Hide the "Add to Basket" button
                    addToBasketButton.Hide();
            }
            catch
            {
                // Otherwise, Hide the "Add to Basket" button
                addToBasketButton.Hide();
            }
            
        }

        // Event handler called when pressing the "Add to Basket" button
        private void addToBasketButton_Click(object sender, EventArgs e)
        {

            // Obtain index in full item list, for the selected variant
            int index = variants[itemVariantListBox.SelectedIndex].Item4;

            // Update stock
            updateStock(index, -1);

            // Update list of item variants shown
            loadVariants();

            // Add item to basket and show it as such
            basket.Add(ITEMS[index]);
            basketListBox.Items.Add(basketItem(index));

            // Update total
            total += ITEMS[index].Item2;

            // Display the updated total
            updateTotalDisplay();

            // Hide this button
            addToBasketButton.Hide();

            // Show the "Checkout" button
            checkoutButton.Show();
        }

        // Event handler called when pressing the "Clear Basket" button
        private void clearBasketButton_Click(object sender, EventArgs e)
        {
            // Restore stock
            for (int i = 0; i < basket.Count; i++)
                updateStock(basket[i].Item4, 1);

            // Empty the basket
            basketListBox.Items.Clear();
            basket.Clear();

            // Update item variants shown
            loadVariants();

            // Hide the "Delete Item" button
            deleteItemButton.Hide();

            // Set item total to zero
            total = 0.00M;

            // Display updated total
            updateTotalDisplay();

            // Hide the "Checkout" button
            checkoutButton.Hide();
        }

        // Event handler called on pressing the "Delete Item" button
        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            try
                // Index out of bounds exception may occur
            {
                // Obtain index of item in basket
                int basketIndex = basketListBox.SelectedIndex;

                // Obtain index in full item list, for the selected variant
                int index = basket[basketIndex].Item4;

                // Update total
                total -= ITEMS[index].Item2;

                // Update stock
                updateStock(index, 1);

                // Update variants displayed
                loadVariants();

                // Display updated total
                updateTotalDisplay();

                // Remove the selected item from basket
                basketListBox.Items.RemoveAt(basketIndex);
                basket.RemoveAt(basketIndex);

                // Set new index in basket
                // If the item selected was the last item of a now non-empty basket
                if (basketIndex == basket.Count && basketIndex > 0)
                    // Select the new last item of the basket
                    basketListBox.SelectedIndex = basketIndex - 1;
                // If the basket is non-empty
                else if (basket.Count > 0)
                    // Select the item at the same position in the basket
                    basketListBox.SelectedIndex = basketIndex;
                else
                {
                    // Hide this button
                    deleteItemButton.Hide();
                }                    

            }
            catch
            {
                // Hide this button
                deleteItemButton.Hide();
            }
            if (basket.Count == 0)
                // Hide the "Checkout" button
                checkoutButton.Hide();
        }

        // Event handler called on selecting an item from the basket
        private void basketListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show the "Delete Item" button
            deleteItemButton.Show();
        }

        // Event handler called on pressing the "Checkout" button
        private void checkoutButton_Click(object sender, EventArgs e)
        {
            // Show message box prompting confirmation of purchase
            DialogResult result = MessageBox.Show(CHECKOUT_MESSAGE_PART_1 + basket.Count +
                CHECKOUT_MESSAGE_PART_2 + total.ToString("C") + CHECKOUT_MESSAGE_PART_3,
                ALERT_MESSAGE, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // If user clicks "Yes"
            if(result == DialogResult.Yes)
            {
                // Write transaction to file

                // Empty the basket
                basketListBox.Items.Clear();
                basket.Clear();

                // Update item variants shown
                loadVariants();

                // Hide the "Delete Item" button
                deleteItemButton.Hide();

                // Set item total to zero
                total = 0.00M;

                // Display updated total
                updateTotalDisplay();

                // Hide the "Checkout" button
                checkoutButton.Hide();
            }
        }

        // Event handler called on pressing the "Exit" button
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        // Event handler called on pressing the "Display Stock Report" button
        private void stockReportButton_Click(object sender, EventArgs e)
        {
            // Create a form to show stock details
            new StockReportForm().Show();
        }
    }
}       