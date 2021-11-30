namespace Assignment4
{
    public partial class Form1 : Form
    {

        // List of item categories
        private string[] CATEGORIES = new string[6] {
            "Laptop",
            "Desktop",
            "Tablet",
            "Phone",
            "Smartwatch",
            "Headphones"
        };

        // List of item variants
        private Array[] VARIANTS = new Array[6]
        {
            new string[7] {
                "13\" Laptop (Silver)", "13\" Laptop (Grey)", "13\" Laptop (Gold)", 
                "14\" Laptop (Silver)", "14\" Laptop (Grey)", "16\" Laptop (Silver)", "16\" Laptop (Grey)"
            },
            new string[10] { 
                "Small Desktop (Silver)", "Small Desktop (Grey)", 
                "AIO (Blue)", "AIO (Green)", "AIO (Pink)", "AIO (Yellow)", "AIO (Silver)",
                "AIO (Orange)", "AIO (Purple)", "AIO (Grey)"
            },
            new string[13]
            {
                "12.9\" Tablet (Silver)", "12.9\" Tablet (Grey)", "11\" Tablet (Silver)", "11\" Tablet (Grey)",
                "11\" Tablet (Green)", "11\" Tablet (Blue)", "11\" Tablet (Pink)", 
                "10\" Tablet (Siler)", "10\" Tablet (Grey)",
                "8\" Tablet (Silver)", "8\" Tablet (Grey)", "8\" Tablet (Purple)", "8\" Tablet (Pink)"
            },
            new string[17]
            {
                "Compact Phone (White)", "Compact Phone (Black)", "Compact Phone (Red)",
                "Small Phone (Pink)", "Small Phone (Blue)", "Small Phone (Black)", "Small Phone (White)",
                "Small Phone (Red)",
                "Regular Phone (Pink)", "Regular Phone (Blue)", "Regular Phone (Black)", 
                "Regular Phone (White)", "Regular Phone (Red)",
                "Large Phone (Silver)", "Large Phone (Grey)", "Large Phone (Gold)", "Large Phone (Blue)"
            },
            new string[8]
            {
                "Watch (S/M) (Silver)", "Watch (S/M) (Grey)", "Watch (S/M) (Green)",
                "Watch (S/M) (Blue)",
                "Watch (L) (Silver)", "Watch (L) (Grey)", "Watch (L) (Green)",
                "Watch (L) (Blue)",
            },
            new string[7]
            {
                "In-ear Headphones", "In-ear Headphones with ANC",
                "Over-ear Headphones (Silver)", "Over-ear Headphones (Grey)",
                "Over-ear Headphones (Pink)", "Over-ear Headphones (Blue)",
                "Over-ear Headphones (Green)"
            }
        };

        public Form1()
        {
            InitializeComponent();

            // Set list of item categories
            itemCategoryListBox.Items.Clear();
            itemCategoryListBox.Items.AddRange((object[])CATEGORIES);
        }

        // Event handler called when item category is changed
        private void itemCategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemVariantListBox.Items.Clear();
            itemVariantListBox.Items.AddRange((object[])VARIANTS[itemCategoryListBox.SelectedIndex]);
        }
    }
}       