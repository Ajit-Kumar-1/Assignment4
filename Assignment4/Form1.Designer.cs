namespace Assignment4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.unitsLeftLabel = new System.Windows.Forms.Label();
            this.buttonGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.salesReportButton = new System.Windows.Forms.Button();
            this.stockReportButton = new System.Windows.Forms.Button();
            this.ItemTotalLabel = new System.Windows.Forms.Label();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.searchResultsListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.transactionDateRadioButton = new System.Windows.Forms.RadioButton();
            this.transactionIDRadioButton = new System.Windows.Forms.RadioButton();
            this.clearBasketButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.basketLabel = new System.Windows.Forms.Label();
            this.basketListBox = new System.Windows.Forms.ListBox();
            this.addToBasketButton = new System.Windows.Forms.Button();
            this.itemVariantListBox = new System.Windows.Forms.ListBox();
            this.itemVariantLabel = new System.Windows.Forms.Label();
            this.itemCategoryLabel = new System.Windows.Forms.Label();
            this.itemCategoryListBox = new System.Windows.Forms.ListBox();
            this.mainPanel.SuspendLayout();
            this.buttonGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.unitsLeftLabel);
            this.mainPanel.Controls.Add(this.buttonGroupBox);
            this.mainPanel.Controls.Add(this.ItemTotalLabel);
            this.mainPanel.Controls.Add(this.checkoutButton);
            this.mainPanel.Controls.Add(this.searchGroupBox);
            this.mainPanel.Controls.Add(this.clearBasketButton);
            this.mainPanel.Controls.Add(this.deleteItemButton);
            this.mainPanel.Controls.Add(this.basketLabel);
            this.mainPanel.Controls.Add(this.basketListBox);
            this.mainPanel.Controls.Add(this.addToBasketButton);
            this.mainPanel.Controls.Add(this.itemVariantListBox);
            this.mainPanel.Controls.Add(this.itemVariantLabel);
            this.mainPanel.Controls.Add(this.itemCategoryLabel);
            this.mainPanel.Controls.Add(this.itemCategoryListBox);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1573, 1080);
            this.mainPanel.TabIndex = 0;
            // 
            // unitsLeftLabel
            // 
            this.unitsLeftLabel.AutoSize = true;
            this.unitsLeftLabel.Location = new System.Drawing.Point(670, 141);
            this.unitsLeftLabel.Name = "unitsLeftLabel";
            this.unitsLeftLabel.Size = new System.Drawing.Size(127, 32);
            this.unitsLeftLabel.TabIndex = 13;
            this.unitsLeftLabel.Text = "Units Left: ";
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Controls.Add(this.exitButton);
            this.buttonGroupBox.Controls.Add(this.salesReportButton);
            this.buttonGroupBox.Controls.Add(this.stockReportButton);
            this.buttonGroupBox.Location = new System.Drawing.Point(43, 894);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Size = new System.Drawing.Size(835, 140);
            this.buttonGroupBox.TabIndex = 12;
            this.buttonGroupBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(627, 52);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(172, 46);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // salesReportButton
            // 
            this.salesReportButton.AutoSize = true;
            this.salesReportButton.Location = new System.Drawing.Point(30, 52);
            this.salesReportButton.Name = "salesReportButton";
            this.salesReportButton.Size = new System.Drawing.Size(259, 46);
            this.salesReportButton.TabIndex = 14;
            this.salesReportButton.Text = "Generate Sales Report";
            this.salesReportButton.UseVisualStyleBackColor = true;
            // 
            // stockReportButton
            // 
            this.stockReportButton.AutoSize = true;
            this.stockReportButton.Location = new System.Drawing.Point(323, 52);
            this.stockReportButton.Name = "stockReportButton";
            this.stockReportButton.Size = new System.Drawing.Size(259, 46);
            this.stockReportButton.TabIndex = 13;
            this.stockReportButton.Text = "Display Stock Report";
            this.stockReportButton.UseVisualStyleBackColor = true;
            // 
            // ItemTotalLabel
            // 
            this.ItemTotalLabel.AutoSize = true;
            this.ItemTotalLabel.Location = new System.Drawing.Point(43, 789);
            this.ItemTotalLabel.Name = "ItemTotalLabel";
            this.ItemTotalLabel.Size = new System.Drawing.Size(132, 32);
            this.ItemTotalLabel.TabIndex = 11;
            this.ItemTotalLabel.Text = "Item Total: ";
            // 
            // checkoutButton
            // 
            this.checkoutButton.AutoSize = true;
            this.checkoutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkoutButton.Location = new System.Drawing.Point(670, 782);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(172, 46);
            this.checkoutButton.TabIndex = 10;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchResultsLabel);
            this.searchGroupBox.Controls.Add(this.searchResultsListBox);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Controls.Add(this.transactionDateRadioButton);
            this.searchGroupBox.Controls.Add(this.transactionIDRadioButton);
            this.searchGroupBox.Location = new System.Drawing.Point(959, 46);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(567, 988);
            this.searchGroupBox.TabIndex = 9;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Location = new System.Drawing.Point(51, 290);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(166, 32);
            this.searchResultsLabel.TabIndex = 14;
            this.searchResultsLabel.Text = "Search Results";
            // 
            // searchResultsListBox
            // 
            this.searchResultsListBox.FormattingEnabled = true;
            this.searchResultsListBox.ItemHeight = 32;
            this.searchResultsListBox.Location = new System.Drawing.Point(51, 325);
            this.searchResultsListBox.Name = "searchResultsListBox";
            this.searchResultsListBox.Size = new System.Drawing.Size(462, 612);
            this.searchResultsListBox.TabIndex = 13;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(193, 210);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(172, 46);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(54, 156);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(459, 39);
            this.searchTextBox.TabIndex = 2;
            // 
            // transactionDateRadioButton
            // 
            this.transactionDateRadioButton.AutoSize = true;
            this.transactionDateRadioButton.Location = new System.Drawing.Point(51, 95);
            this.transactionDateRadioButton.Name = "transactionDateRadioButton";
            this.transactionDateRadioButton.Size = new System.Drawing.Size(252, 36);
            this.transactionDateRadioButton.TabIndex = 1;
            this.transactionDateRadioButton.Text = "By Transaction date";
            this.transactionDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // transactionIDRadioButton
            // 
            this.transactionIDRadioButton.AutoSize = true;
            this.transactionIDRadioButton.Checked = true;
            this.transactionIDRadioButton.Location = new System.Drawing.Point(51, 53);
            this.transactionIDRadioButton.Name = "transactionIDRadioButton";
            this.transactionIDRadioButton.Size = new System.Drawing.Size(228, 36);
            this.transactionIDRadioButton.TabIndex = 0;
            this.transactionIDRadioButton.TabStop = true;
            this.transactionIDRadioButton.Text = "By Transaction ID";
            this.transactionIDRadioButton.UseVisualStyleBackColor = true;
            // 
            // clearBasketButton
            // 
            this.clearBasketButton.AutoSize = true;
            this.clearBasketButton.Location = new System.Drawing.Point(670, 620);
            this.clearBasketButton.Name = "clearBasketButton";
            this.clearBasketButton.Size = new System.Drawing.Size(172, 46);
            this.clearBasketButton.TabIndex = 8;
            this.clearBasketButton.Text = "Clear Basket";
            this.clearBasketButton.UseVisualStyleBackColor = true;
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.AutoSize = true;
            this.deleteItemButton.Location = new System.Drawing.Point(670, 507);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(172, 46);
            this.deleteItemButton.TabIndex = 7;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            // 
            // basketLabel
            // 
            this.basketLabel.AutoSize = true;
            this.basketLabel.Location = new System.Drawing.Point(43, 417);
            this.basketLabel.Name = "basketLabel";
            this.basketLabel.Size = new System.Drawing.Size(83, 32);
            this.basketLabel.TabIndex = 6;
            this.basketLabel.Text = "Basket";
            // 
            // basketListBox
            // 
            this.basketListBox.FormattingEnabled = true;
            this.basketListBox.ItemHeight = 32;
            this.basketListBox.Location = new System.Drawing.Point(43, 452);
            this.basketListBox.Name = "basketListBox";
            this.basketListBox.Size = new System.Drawing.Size(598, 324);
            this.basketListBox.TabIndex = 5;
            // 
            // addToBasketButton
            // 
            this.addToBasketButton.AutoSize = true;
            this.addToBasketButton.Location = new System.Drawing.Point(670, 226);
            this.addToBasketButton.Name = "addToBasketButton";
            this.addToBasketButton.Size = new System.Drawing.Size(172, 46);
            this.addToBasketButton.TabIndex = 4;
            this.addToBasketButton.Text = "Add to basket";
            this.addToBasketButton.UseVisualStyleBackColor = true;
            // 
            // itemVariantListBox
            // 
            this.itemVariantListBox.FormattingEnabled = true;
            this.itemVariantListBox.ItemHeight = 32;
            this.itemVariantListBox.Location = new System.Drawing.Point(366, 81);
            this.itemVariantListBox.Name = "itemVariantListBox";
            this.itemVariantListBox.Size = new System.Drawing.Size(275, 292);
            this.itemVariantListBox.TabIndex = 3;
            // 
            // itemVariantLabel
            // 
            this.itemVariantLabel.AutoSize = true;
            this.itemVariantLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemVariantLabel.Location = new System.Drawing.Point(366, 46);
            this.itemVariantLabel.Name = "itemVariantLabel";
            this.itemVariantLabel.Size = new System.Drawing.Size(254, 32);
            this.itemVariantLabel.TabIndex = 2;
            this.itemVariantLabel.Text = "2. Select item variant";
            // 
            // itemCategoryLabel
            // 
            this.itemCategoryLabel.AutoSize = true;
            this.itemCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemCategoryLabel.Location = new System.Drawing.Point(43, 46);
            this.itemCategoryLabel.Name = "itemCategoryLabel";
            this.itemCategoryLabel.Size = new System.Drawing.Size(275, 32);
            this.itemCategoryLabel.TabIndex = 1;
            this.itemCategoryLabel.Text = "1. Select item category";
            // 
            // itemCategoryListBox
            // 
            this.itemCategoryListBox.FormattingEnabled = true;
            this.itemCategoryListBox.ItemHeight = 32;
            this.itemCategoryListBox.Items.AddRange(new object[] {
            "Laptop",
            "Desktop",
            "Tablet",
            "Phone",
            "Smartwatch",
            "Headphones",
            "Speaker",
            "Computer Accessories"});
            this.itemCategoryListBox.Location = new System.Drawing.Point(43, 81);
            this.itemCategoryListBox.Name = "itemCategoryListBox";
            this.itemCategoryListBox.Size = new System.Drawing.Size(275, 292);
            this.itemCategoryListBox.TabIndex = 0;
            this.itemCategoryListBox.SelectedIndexChanged += new System.EventHandler(this.itemCategoryListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 1080);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = ",";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.buttonGroupBox.ResumeLayout(false);
            this.buttonGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private ListBox itemCategoryListBox;
        private Label itemCategoryLabel;
        private Label itemVariantLabel;
        private ListBox itemVariantListBox;
        private Button addToBasketButton;
        private Label basketLabel;
        private ListBox basketListBox;
        private Button clearBasketButton;
        private Button deleteItemButton;
        private GroupBox searchGroupBox;
        private RadioButton transactionDateRadioButton;
        private RadioButton transactionIDRadioButton;
        private Button checkoutButton;
        private Label ItemTotalLabel;
        private TextBox searchTextBox;
        private Button searchButton;
        private Label searchResultsLabel;
        private ListBox searchResultsListBox;
        private GroupBox buttonGroupBox;
        private Label unitsLeftLabel;
        private Button salesReportButton;
        private Button stockReportButton;
        private Button exitButton;
    }
}