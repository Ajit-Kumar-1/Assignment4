using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        // List of items
        private static Tuple<string, decimal, int, int>[] ITEMS = 
            new Tuple<string, decimal, int, int>[60] { 
            new Tuple<string, decimal, int, int>("Compact Laptop (Silver)", 1129, 0, 0),
            new Tuple<string, decimal, int, int>("Compact Laptop (Grey)", 1129, 0, 1),
            new Tuple<string, decimal, int, int>("Compact Laptop (Gold)", 1129, 0, 2),
            new Tuple<string, decimal, int, int>("Regular Laptop (Silver)", 2249, 0, 3),
            new Tuple<string, decimal, int, int>("Regular Laptop (Grey)", 2249, 0, 4),
            new Tuple<string, decimal, int, int>("Big Laptop (Silver)", 2749, 0, 5),
            new Tuple<string, decimal, int, int>("Big Laptop (Grey)", 2749, 0, 6),
            new Tuple<string, decimal, int, int>("Small Desktop (Silver)", 799, 0, 7),
            new Tuple<string, decimal, int, int>("Small Desktop (Grey)", 799, 0, 8),
            new Tuple<string, decimal, int, int>("All-in-one Desktop (Blue)", 1499, 0, 9),
            new Tuple<string, decimal, int, int>("All-in-one Desktop (Green)", 1499, 0, 10),
            new Tuple<string, decimal, int, int>("All-in-one Desktop (Pink)", 1499, 0, 11),
            new Tuple<string, decimal, int, int>("All-in-one Desktop (Silver)", 1499, 0, 12),
            new Tuple<string, decimal, int, int>("All-in-one Desktop (Yellow)", 1499, 0, 13),
            new Tuple<string, decimal, int, int>("All-in-one Desktop (Orange)", 1499, 0, 14),
            new Tuple<string, decimal, int, int>("All-in-one Desktop (Purple)", 1499, 0, 15),
            new Tuple<string, decimal, int, int>("Big powerful tablet (Silver)", 1229, 0, 16),
            new Tuple<string, decimal, int, int>("Big powerful tablet (Grey)", 1229, 0, 17),
            new Tuple<string, decimal, int, int>("Powerful tablet (Silver)", 909, 0, 18),
            new Tuple<string, decimal, int, int>("Powerful tablet (Grey)", 909, 0, 19),
            new Tuple<string, decimal, int, int>("Regular tablet (Grey)", 679, 0, 20),
            new Tuple<string, decimal, int, int>("Regular tablet (Silver)", 679, 0, 21),
            new Tuple<string, decimal, int, int>("Regular tablet (Pink)", 679, 0, 22),
            new Tuple<string, decimal, int, int>("Regular tablet (Green)", 679, 0, 23),
            new Tuple<string, decimal, int, int>("Regular tablet (Blue)", 679, 0, 24),
            new Tuple<string, decimal, int, int>("Compact tablet (Grey)", 569, 0, 25),
            new Tuple<string, decimal, int, int>("Compact tablet (Pink)", 569, 0, 26),
            new Tuple<string, decimal, int, int>("Compact tablet (Purple)", 569, 0, 27),
            new Tuple<string, decimal, int, int>("Compact tablet (White)", 569, 0, 28),
            new Tuple<string, decimal, int, int>("Basic tablet (Silver)", 369, 0, 29),
            new Tuple<string, decimal, int, int>("Basic tablet (Grey)", 369, 0, 30),
            new Tuple<string, decimal, int, int>("Compact phone (White)", 499, 0, 31),
            new Tuple<string, decimal, int, int>("Compact phone (Black)", 499, 0, 32),
            new Tuple<string, decimal, int, int>("Compact phone (Red)", 499, 0, 33),
            new Tuple<string, decimal, int, int>("Small phone (White)", 829, 0, 34),
            new Tuple<string, decimal, int, int>("Small phone (Black)", 829, 0, 35),
            new Tuple<string, decimal, int, int>("Small phone (Red)", 829, 0, 36),
            new Tuple<string, decimal, int, int>("Small phone (Blue)", 829, 0, 37),
            new Tuple<string, decimal, int, int>("Small phone (Pink)", 829, 0, 38),
            new Tuple<string, decimal, int, int>("Regular phone (White)", 929, 0, 39),
            new Tuple<string, decimal, int, int>("Regular phone (Black)", 929, 0, 40),
            new Tuple<string, decimal, int, int>("Regular phone (Red)", 929, 0, 41),
            new Tuple<string, decimal, int, int>("Regular phone (Blue)", 929, 0, 42),
            new Tuple<string, decimal, int, int>("Regular phone (Pink)", 929, 0, 43),
            new Tuple<string, decimal, int, int>("Large phone (Silver)", 1279, 0, 44),
            new Tuple<string, decimal, int, int>("Large phone (Grey)", 1279, 0, 45),
            new Tuple<string, decimal, int, int>("Large phone (Gold)", 1279, 0, 46),
            new Tuple<string, decimal, int, int>("Large phone (Blue)", 1279, 0, 47),
            new Tuple<string, decimal, int, int>("Smartwatch (S/M) (White)", 429, 0, 48),
            new Tuple<string, decimal, int, int>("Smartwatch (S/M) (Black)", 429, 0, 49),
            new Tuple<string, decimal, int, int>("Smartwatch (S/M) (Green)", 429, 0, 50),
            new Tuple<string, decimal, int, int>("Smartwatch (S/M) (Blue)", 429, 0, 51),
            new Tuple<string, decimal, int, int>("Smartwatch (S/M) (Red)", 429, 0, 52),
            new Tuple<string, decimal, int, int>("Smartwatch (L) (White)", 459, 0, 53),
            new Tuple<string, decimal, int, int>("Smartwatch (L) (Black)", 459, 0, 54),
            new Tuple<string, decimal, int, int>("Smartwatch (L) (Green)", 459, 0, 55),
            new Tuple<string, decimal, int, int>("Smartwatch (L) (Blue)", 459, 0, 56),
            new Tuple<string, decimal, int, int>("Smartwatch (L) (Red)", 459, 0, 57),
            new Tuple<string, decimal, int, int>("In-ear Headphones", 199, 0, 58),
            new Tuple<string, decimal, int, int>("In-ear Headphones with ANC", 279, 0, 59),
        };

        // Variable to track stock levels at the start of the day
        private Tuple<string, decimal, int, int>[] originalItems = ITEMS;

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

        // Error message
        private const string ERROR_MESSAGE = "Error";

        // Message indicating that nothing was entered to search
        private const string NO_SEARCH_TERM_MESSAGE = "Please enter a value to search by";

        // Message indicating no results were found
        private const string NO_RESULTS_FOUND_MESSAGE = "No results found";

        // Message reqeusting that a name be entered
        private const string ENTER_NAME_MESSAGE = "Name is empty. Please enter a name";

        // Message requesting that an email address be entered
        private const string ENTER_EMAIL_MESSAGE = 
            "Email address is empty. Please enter a valid email address";

        // Message requesting that a valid email address be entered
        private const string ENTER_VALID_EMAIL_MESSAGE =
            "Entered email address is invalid. Please enter a valid email address";

        // Message requesting that a phone number be entered
        private const string ENTER_PHONE_NUMBER_MESSAGE =
            "Phone number is empty. Please enter a valid phone number";
        // Message requesting that a valid phone number be entered
        private const string ENTER_VALID_PHONE_MESSAGE =
            "Entered phone number is invalid. Please enter a valid phone number";

        // Message segments for prompting confirmation of purchase
        private const string CHECKOUT_MESSAGE_PART_1 = "Do you confirm purchase of ";
        private const string CHECKOUT_MESSAGE_PART_2 = " item(s) for a total of ";
        private const string CHECKOUT_MESSAGE_PART_3 = "?";

        // Prefix text for displaying item total
        private const string ITEM_TOTAL_PREFIX = "Item Total: ";

        // Items left suffix
        private const string LEFT_SUFFIX = " left";

        // Prefix text for displaying transaction ID
        private const string TRANSACTIONID_PREFIX = "Transaction ID: ";

        // Prefix text for displaying name
        private const string NAME_PREFIX = "Name: ";

        // Prefix text for displaying date
        private const string TIMESTAMP_PREFIX = "Timestamp: ";

        // Prefix text for displaying email address
        private const string EMAIL_PREFIX = "Email address: ";

        // Prefix text for displaying phone number
        private const string PHONE_PREFIX = "Phone number: ";

        // Prefix text for displaying item count
        private const string COUNT_PREFIX = "Item count: ";

        // Prefix text for displaying items
        private const string ITEMS_PREFIX = "Item(s): ";

        // Tooltip message displayed on pressing the "Add to basket" button
        private const string ADD_TO_BASKET_TOOLTIP =  "Add the selected item to basket";

        // Tooltip message displayed on pressing the "Clear basket" button
        private const string CLEAR_BASKET_TOOLTIP = "Return items in basket to stock";

        // Tooltip message displayed on pressing the "Delete Item" button
        private const string DELETE_ITEM_TOOLTIP = "Remove the selected item from basket";

        // Tooltip message displayed on pressing the "Checkout" button
        private const string CHECKOUT_TOOLTIP = "Checkout selected items";

        // Tooltip message displayed on pressing the "Clear Search" button
        private const string CLEAR_SEARCH_TOOLTIP = "Clear search results and searched term";

        // Tooltip message displayed on pressing the "Search" button
        private const string SEARCH_TOOLTIP = 
            "Search file for transactions matching given ID/Date";

        // Tooltip message displayed on pressing the "Generate Sales Report" button
        private const string GENERATE_SALES_REPORT_TOOLTIP =
            "Generate a report for daily sales of all items and save to file";

        // Tooltip message displayed on pressing the "Display Stock Report" button
        private const string DISPLAY_STOCK_REPORT_TOOLTIP =
            "Display in a new window a report on stock levels of all items";

        // Tooltip message displayed on pressing the "Exit" button
        private const string EXIT_TOOLTIP = "Exit the application";

        // Specify the characters used to generate a transaction ID
        private const string characterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        // Format for storing and displaying date
        private const string DATE_FORMAT = "dd/MM/yyyy";

        // Random object used for generating transaction ID
        private Random random = new Random();

        // File name for transaction record file
        private const string TRANSACTION_FILE_NAME = "../transactions.txt";

        // File name for stock record file
        private const string STOCK_FILE_NAME = "../stock.txt";

        // Method to update the displayed basket total
        private void updateTotalDisplay()
        {
            // Display "Item Total: " followed by the amount as currency
            ItemTotalLabel.Text = ITEM_TOTAL_PREFIX + total.ToString("C");
        }

        // Method to print item variants' details in list box
        private static string itemVariant(int index)
        {
            Tuple<string, decimal, int, int> item = ITEMS[index];
            return item.Item1 + item.Item2.ToString("C") 
                + " " + item.Item3 + LEFT_SUFFIX;
        }

        // Method to print item in basket
        private string basketItem(int index)
        {
            Tuple<string, decimal, int, int> item = ITEMS[index];
            return item.Item1 + item.Item2.ToString("C");
        }

        // Variable to store transaction ID
        private string transactionID = "-";

        // Variable to store name
        private string name = "-";

        // Variable to store email address
        private string email = "-";

        // Variable to store phone number
        private string phone = "-";

        // Variable to track displayed item variants in the background`
        private List<Tuple<string, decimal, int, int>> variants =
            new List<Tuple<string, decimal, int, int>>();

        // Variable to track basket items in the background
        private List<Tuple<string, decimal, int, int>> basket =
            new List<Tuple<string, decimal, int, int>>();

        // Array to record starting stock level
        private int[] initialStock = new int[60];

        // Variable to keep track of basket total
        private decimal total = 0.00M;

        // Method to update stock
        private void updateStock(int index, int increment)
        {
            // Replace the item in the list with the stock level adjusted
            ITEMS[index] = new Tuple<string, decimal, int, int>
                (ITEMS[index].Item1, ITEMS[index].Item2, 
                ITEMS[index].Item3 + increment, ITEMS[index].Item4);
        }

        // Method to generate a 10-character random string for transaction ID
        private string generateRandomString()
        {
            // Initialize the output string
            string output = "";

            // Loop code 10 times
            for (int i = 0; i < 10; i++)
                // Add a random character from the character set
                output += characterSet[random.Next(characterSet.Length)];

            // This will be a transaction ID
            return output;
        }

        // Method to display item variants in list box and keep a list in the background
        private void loadVariants()
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

        // Method to check if a given string hasn't been used previously
        private Boolean isUnique(string searchString)
        {
            try
            {
                // Open file of transactions
                StreamReader inputFile = File.OpenText(TRANSACTION_FILE_NAME);

                // Until end of file
                while (!inputFile.EndOfStream)
                {
                    // Check if the candidate transaction ID has been used
                    if (searchString.Equals(inputFile.ReadLine()))
                    {
                        // Then, Stop reading the file
                        inputFile.Close();

                        // Then, indicate that the given string is not unique
                        return false;
                    }

                    // Skip 8 lines
                    for (int index = 0; index < 8; index++)
                        inputFile.ReadLine();
                }

                // Stop reading file
                inputFile.Close();
            }
            catch { }

            // If no match found, the given string must be unique
            return true;
        }

        // Method to generate a unique random string
        private void generateTransactionID()
        {
            
            string candidate = "";

            // Track whether the string is unique from those in file
            Boolean unique = false;
            do
            {
                // Use a random string to test
                candidate = generateRandomString();

                // Check if that string is unique
                unique = isUnique(candidate);
            }
            // Until the string is unique
            while (!unique);

            // Set the string as the transaction ID
            transactionID = candidate;
        }

        // Method to adjust spacing for listbox presentation
        private void addSpacesAfterName()
        {
            // Variable to track the length of the longest item name
            int maxLength = 0;

            // Width of single space
            int spaceWidth = TextRenderer
                .MeasureText((char)8239 + "", itemVariantListBox.Font).Width;

            for (int i = 0; i < 60; i++)
            {
                int lengthInSpaces = TextRenderer
                    .MeasureText(ITEMS[i].Item1, itemVariantListBox.Font).Width 
                    / spaceWidth;
                if (maxLength < lengthInSpaces)
                    maxLength = lengthInSpaces;
            }

            for (int i = 0; i < ITEMS.Length; i++)
            {
                int lengthInSpaces = TextRenderer
                    .MeasureText(ITEMS[i].Item1, itemVariantListBox.Font).Width
                    / spaceWidth;

                ITEMS[i] = new Tuple<string, decimal, int, int>(
                    ITEMS[i].Item1 +
                    new string((char)8239, maxLength - lengthInSpaces),
                    ITEMS[i].Item2, ITEMS[i].Item3, ITEMS[i].Item4);
            }                

        }

        // Method to enter initial values of stock for all items
        private void enterInitialStock()
        {

            // Initialize items of array
            Array.Fill(initialStock, 0);

            try
            {

                // Open file
                StreamReader stockFile = File.OpenText(STOCK_FILE_NAME);

                // Store contents of file in a new array
                string[] stockArray = stockFile.ReadToEnd().Split((char)13);

                // Close file
                stockFile.Close();

                // Store stock values in array
                for (int i = 0; i < stockArray.Length; i++)
                {
                    // Obtain the stock value for the item at this index
                    int stockValue = int.Parse(stockArray[i]);

                    // Save it to the initial stock record
                    initialStock[i] = stockValue;

                    // Save it to current stock record as well
                    updateStock(i, stockValue);
                }
            }
            catch { }
        }

        public Form1()
        {
            InitializeComponent();

            // Set list of item categories
            itemCategoryListBox.Items.Clear();
            itemCategoryListBox.Items.AddRange((object[])CATEGORIES);

            // Start with item total of zero
            updateTotalDisplay();

            // Generate and set a new transaction ID
            generateTransactionID();

            // Display the transaction ID
            transactionLabel.Text = TRANSACTIONID_PREFIX + transactionID;

            // Set a tooltip for the "Add to Basket" button
            toolTip.SetToolTip(addToBasketButton, ADD_TO_BASKET_TOOLTIP);

            // Set a tooltip for the "Clear Basket" button
            toolTip.SetToolTip(clearBasketButton, CLEAR_BASKET_TOOLTIP);

            // Set a tooltip for the "Delete Item" button
            toolTip.SetToolTip(deleteItemButton, DELETE_ITEM_TOOLTIP);

            // Set a tooltip for the "Checkout" button
            toolTip.SetToolTip(checkoutButton, CHECKOUT_TOOLTIP);

            // Set a tooltip for the "Clear Search" button
            toolTip.SetToolTip(clearSearchButton, CLEAR_SEARCH_TOOLTIP);

            // Set a tooltip for the "Search" button
            toolTip.SetToolTip(searchButton, SEARCH_TOOLTIP);

            // Set a tooltip for the "Generate Sales Report" button
            toolTip.SetToolTip(salesReportButton, GENERATE_SALES_REPORT_TOOLTIP);

            // Set a tooltip for the "Display Stock Report" button
            toolTip.SetToolTip(stockReportButton, DISPLAY_STOCK_REPORT_TOOLTIP);

            // Set a tooltip for the "Exit" button
            toolTip.SetToolTip(exitButton, EXIT_TOOLTIP);

            // Save starting stock levels
            enterInitialStock();

            addSpacesAfterName();
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

            // Update list of item variants displayed
            loadVariants();

            // Add item to basket and display it as such
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

            // Update item variants displayed
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
            // Obtain name
            name = nameTextBox.Text.Trim();

            // Obtain email address
            email = emailTextBox.Text.Trim();

            // Obtain phone number
            phone = phoneTextBox.Text.Trim();

            // Check if name is empty
            if (name == "")
            {
                // Display a message requesting that a name be entered
                MessageBox.Show(ENTER_NAME_MESSAGE, ERROR_MESSAGE,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Assign focus to the name text field
                nameTextBox.Focus();

                // Abort the checkout process
                return;

            }
            else if (email == "")
            {
                // Display a message requesting that an email address be entered
                MessageBox.Show(ENTER_EMAIL_MESSAGE, ERROR_MESSAGE,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Assign focus to the email address text field
                emailTextBox.Focus();

                // Abort the checkout process
                return;
            }
            else if(!new EmailAddressAttribute().IsValid(email) || 
                !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                // Display a message requesting that a valid email address be entered
                MessageBox.Show(ENTER_VALID_EMAIL_MESSAGE, ERROR_MESSAGE,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Assign focus to the name text field
                nameTextBox.Focus();

                // Abort the checkout process
                return;
            }
            else if (phone == "")
            {
                // Display a message requesting that a phone number be entered
                MessageBox.Show(ENTER_PHONE_NUMBER_MESSAGE, ERROR_MESSAGE,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Assign focus to the phone number text field
                phoneTextBox.Focus();

                // Abort the checkout process
                return;
            }
            else if (!(new PhoneAttribute().IsValid(phone)))
            {
                // Display a message requesting that a valid phone number be entered
                MessageBox.Show(ENTER_VALID_PHONE_MESSAGE, ERROR_MESSAGE,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Assign focus to the phone number text field
                phoneTextBox.Focus();

                // Abort the checkout process
                return;
            }

            // Display message box prompting confirmation of purchase
            DialogResult result = MessageBox.Show(CHECKOUT_MESSAGE_PART_1 + 
                basket.Count + CHECKOUT_MESSAGE_PART_2 
                + total.ToString("C") + CHECKOUT_MESSAGE_PART_3, ALERT_MESSAGE, 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // If user clicks "Yes"
            if(result == DialogResult.Yes)
                try
                {
                    // Open transaction record file
                    StreamWriter outputFile = File.AppendText(TRANSACTION_FILE_NAME);

                    // Write transaction ID
                    outputFile.WriteLine(transactionID);

                    // Write current date
                    outputFile.WriteLine(DateTime.Now);

                    // Write name
                    outputFile.WriteLine(name);

                    // Write email address
                    outputFile.WriteLine(email);

                    // Write phone number
                    outputFile.WriteLine(phone);

                    // Write item total
                    outputFile.WriteLine(total);

                    // Write item count
                    outputFile.WriteLine(basket.Count);

                    // Form the string containing item IDs, comma-separated
                    string itemList = "";

                    // Add item IDs to string
                    foreach (Tuple<string, decimal, int, int> item in basket)
                        itemList += item.Item4 + ",";

                    // Write the string
                    outputFile.WriteLine(itemList);

                    // Close file
                    outputFile.Close();

                    // Empty basket
                    basket.Clear();

                    // Update item variants displayed
                    loadVariants();

                    // Set values to default
                    total = 0.00M;
                    name = "-";
                    email = "-";
                    phone = "-";

                    // Prepare a new transaction ID
                    generateTransactionID();

                    // Display the new transaction ID
                    transactionLabel.Text = transactionID;

                    // Clear customer information
                    nameTextBox.Clear();
                    emailTextBox.Clear();
                    phoneTextBox.Clear();

                    // Empty basket
                    basketListBox.Items.Clear();

                    // Display updated total
                    updateTotalDisplay();

                    // Hide the "Delete Item" button
                    deleteItemButton.Hide();

                    // Hide the "Checkout" button
                    checkoutButton.Hide();

                }
                // In case of exception
                catch (Exception ex)
                {
                    // Display error message from exception thrown
                    MessageBox.Show(ex.Message, ERROR_MESSAGE,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Create a form to display stock details
            new StockReportForm().Show();
        }

        // Event handler called on pressing the "Clear Search" button
        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            // Clear search results
            searchResultsListBox.Items.Clear();

            // Clear search textbox
            searchTextBox.Clear();

            // Reset radio buttons to default
            transactionIDRadioButton.Checked = true;

        }

        // Event handler called on pressing the "Search" button
        private void searchButton_Click(object sender, EventArgs e)
        {
            // Obtain search term
            string searchTerm = searchTextBox.Text.Trim();

            if (searchTerm == "")
            {
                // Show message indicating that nothing was entered to search by
                MessageBox.Show(NO_SEARCH_TERM_MESSAGE, ERROR_MESSAGE,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Assign focus to the search textbox
                searchTextBox.Focus();

                // Abort the search process
                return;
            }

            // Clear the search results field
            searchResultsListBox.Items.Clear();

            try
            {
                // Open transaction record file
                StreamReader recordFile = File.OpenText(TRANSACTION_FILE_NAME);

                // Read the entire file and store it as an array of lines
                string[] fileData = recordFile.ReadToEnd().Split((char)13);

                // Close file
                recordFile.Close();

                // Initiate array index
                int index = 0;

                // Variable to check if search is by transaction ID
                Boolean isSearchingByID = transactionIDRadioButton.Checked;

                // Variable to check if a match was found
                Boolean matchFound = false;

                // Until end of file
                while (index < fileData.Length - 7)
                {
                    // Read the first line, which is supposed to be a record's transaction ID
                    string? recordID = fileData[index++];

                    // Read the second line, which is supposed to be a record's date
                    string recordDate = fileData[index++];

                    // Variable to track if the current record is a match
                    Boolean isMatch = false;

                    if (isSearchingByID)
                        isMatch = recordID == searchTerm;
                    else
                    {
                        string[] recordDateArray = recordDate.Split(' ')[0].Split('/');
                        string[] searchDateArray = searchTerm.Split('/');

                        isMatch = int.Parse(recordDateArray[0]) == int.Parse(searchDateArray[0])
                            && int.Parse(recordDateArray[1]) == int.Parse(searchDateArray[1])
                            && int.Parse(recordDateArray[2]) == int.Parse(searchDateArray[2]);
                    }

                    // Check if search term matches ID or date, whichever is applicable
                    if (isMatch)
                    {
                        // Note that a match was found
                        matchFound = true;

                        // Print the transaction ID
                        searchResultsListBox.Items.Add(TRANSACTIONID_PREFIX + recordID);

                        // Print the transaction date
                        searchResultsListBox.Items.Add(TIMESTAMP_PREFIX + recordDate);

                        // Print the name associated with the record
                        searchResultsListBox.Items.Add(NAME_PREFIX + fileData[index++]);

                        // Print the email address associated with the record
                        searchResultsListBox.Items.Add(EMAIL_PREFIX + fileData[index++]);

                        // Print the phone number associated with the record
                        searchResultsListBox.Items.Add(PHONE_PREFIX + fileData[index++]);

                        // Print the item total
                        searchResultsListBox.Items.Add(ITEM_TOTAL_PREFIX + 
                            decimal.Parse(fileData[index++]).ToString("C"));

                        // Print the item count
                        searchResultsListBox.Items.Add(COUNT_PREFIX + fileData[index++]);

                        // Obtain the comma-separated list of item IDs
                        string? itemIDList = fileData[index++];

                        // Form an array of IDs
                        var itemIDArray = itemIDList!.Split(",");

                        searchResultsListBox.Items.Add(ITEMS_PREFIX);

                        // Iterate through each ID
                        for (int i = 0; i < itemIDArray.Length - 1; i++)
                            // Print item name
                            searchResultsListBox.Items
                            .Add(ITEMS[int.Parse(itemIDArray[i])].Item1 + "\n");

                        // Quit searching if search is by ID
                        if (isSearchingByID)
                            break;
                        else
                            // Print a separator line
                            searchResultsListBox.Items.Add(" ");
                    }
                    else
                        // Skip the next 6 lines
                        index += 6;
            }

            // In case of no match being found
            if (!matchFound)
                    // Indicate such
                    searchResultsListBox.Items.Add(NO_RESULTS_FOUND_MESSAGE);

            }
            // In case of exception
            catch(Exception ex)
            {
                // Display message detailing cause of exception
                MessageBox.Show(ex.Message, ERROR_MESSAGE, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}       