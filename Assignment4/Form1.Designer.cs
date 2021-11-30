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
            this.itemSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.itemCategoryListBox = new System.Windows.Forms.ListBox();
            this.itemVariantListBox = new System.Windows.Forms.ListBox();
            this.addToBasketButton = new System.Windows.Forms.Button();
            this.basketGroupBox = new System.Windows.Forms.GroupBox();
            this.basketListBox = new System.Windows.Forms.ListBox();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.ItemTotalLabel = new System.Windows.Forms.Label();
            this.clearBasketButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.buttonGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.salesReportButton = new System.Windows.Forms.Button();
            this.stockReportButton = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.searchResultsListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.transactionDateRadioButton = new System.Windows.Forms.RadioButton();
            this.transactionIDRadioButton = new System.Windows.Forms.RadioButton();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.mainPanel.SuspendLayout();
            this.itemSelectionGroupBox.SuspendLayout();
            this.basketGroupBox.SuspendLayout();
            this.buttonGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.itemSelectionGroupBox);
            this.mainPanel.Controls.Add(this.basketGroupBox);
            this.mainPanel.Controls.Add(this.buttonGroupBox);
            this.mainPanel.Controls.Add(this.searchGroupBox);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1466, 1202);
            this.mainPanel.TabIndex = 0;
            // 
            // itemSelectionGroupBox
            // 
            this.itemSelectionGroupBox.Controls.Add(this.itemCategoryListBox);
            this.itemSelectionGroupBox.Controls.Add(this.itemVariantListBox);
            this.itemSelectionGroupBox.Controls.Add(this.addToBasketButton);
            this.itemSelectionGroupBox.Location = new System.Drawing.Point(34, 34);
            this.itemSelectionGroupBox.Name = "itemSelectionGroupBox";
            this.itemSelectionGroupBox.Size = new System.Drawing.Size(868, 628);
            this.itemSelectionGroupBox.TabIndex = 15;
            this.itemSelectionGroupBox.TabStop = false;
            this.itemSelectionGroupBox.Text = "Select item";
            // 
            // itemCategoryListBox
            // 
            this.itemCategoryListBox.FormattingEnabled = true;
            this.itemCategoryListBox.ItemHeight = 32;
            this.itemCategoryListBox.Location = new System.Drawing.Point(30, 52);
            this.itemCategoryListBox.Name = "itemCategoryListBox";
            this.itemCategoryListBox.Size = new System.Drawing.Size(156, 324);
            this.itemCategoryListBox.TabIndex = 0;
            this.itemCategoryListBox.SelectedIndexChanged += new System.EventHandler(this.itemCategoryListBox_SelectedIndexChanged);
            // 
            // itemVariantListBox
            // 
            this.itemVariantListBox.FormattingEnabled = true;
            this.itemVariantListBox.ItemHeight = 32;
            this.itemVariantListBox.Location = new System.Drawing.Point(188, 52);
            this.itemVariantListBox.Name = "itemVariantListBox";
            this.itemVariantListBox.Size = new System.Drawing.Size(650, 484);
            this.itemVariantListBox.TabIndex = 3;
            this.itemVariantListBox.SelectedIndexChanged += new System.EventHandler(this.itemVariantListBox_SelectedIndexChanged);
            // 
            // addToBasketButton
            // 
            this.addToBasketButton.AutoSize = true;
            this.addToBasketButton.Location = new System.Drawing.Point(666, 560);
            this.addToBasketButton.Name = "addToBasketButton";
            this.addToBasketButton.Size = new System.Drawing.Size(172, 46);
            this.addToBasketButton.TabIndex = 4;
            this.addToBasketButton.Text = "Add to basket";
            this.addToBasketButton.UseVisualStyleBackColor = true;
            this.addToBasketButton.Visible = false;
            this.addToBasketButton.Click += new System.EventHandler(this.addToBasketButton_Click);
            // 
            // basketGroupBox
            // 
            this.basketGroupBox.Controls.Add(this.basketListBox);
            this.basketGroupBox.Controls.Add(this.deleteItemButton);
            this.basketGroupBox.Controls.Add(this.ItemTotalLabel);
            this.basketGroupBox.Controls.Add(this.clearBasketButton);
            this.basketGroupBox.Controls.Add(this.checkoutButton);
            this.basketGroupBox.Location = new System.Drawing.Point(34, 668);
            this.basketGroupBox.Name = "basketGroupBox";
            this.basketGroupBox.Size = new System.Drawing.Size(868, 354);
            this.basketGroupBox.TabIndex = 14;
            this.basketGroupBox.TabStop = false;
            this.basketGroupBox.Text = "Basket";
            // 
            // basketListBox
            // 
            this.basketListBox.FormattingEnabled = true;
            this.basketListBox.ItemHeight = 32;
            this.basketListBox.Location = new System.Drawing.Point(30, 54);
            this.basketListBox.Name = "basketListBox";
            this.basketListBox.Size = new System.Drawing.Size(522, 260);
            this.basketListBox.TabIndex = 5;
            this.basketListBox.SelectedIndexChanged += new System.EventHandler(this.basketListBox_SelectedIndexChanged);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.AutoSize = true;
            this.deleteItemButton.Location = new System.Drawing.Point(632, 131);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(172, 46);
            this.deleteItemButton.TabIndex = 7;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Visible = false;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // ItemTotalLabel
            // 
            this.ItemTotalLabel.AutoSize = true;
            this.ItemTotalLabel.Location = new System.Drawing.Point(577, 215);
            this.ItemTotalLabel.Name = "ItemTotalLabel";
            this.ItemTotalLabel.Size = new System.Drawing.Size(132, 32);
            this.ItemTotalLabel.TabIndex = 11;
            this.ItemTotalLabel.Text = "Item Total: ";
            // 
            // clearBasketButton
            // 
            this.clearBasketButton.AutoSize = true;
            this.clearBasketButton.Location = new System.Drawing.Point(632, 64);
            this.clearBasketButton.Name = "clearBasketButton";
            this.clearBasketButton.Size = new System.Drawing.Size(172, 46);
            this.clearBasketButton.TabIndex = 8;
            this.clearBasketButton.Text = "Clear Basket";
            this.clearBasketButton.UseVisualStyleBackColor = true;
            this.clearBasketButton.Click += new System.EventHandler(this.clearBasketButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.AutoSize = true;
            this.checkoutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkoutButton.Location = new System.Drawing.Point(632, 268);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(172, 46);
            this.checkoutButton.TabIndex = 10;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Visible = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Controls.Add(this.exitButton);
            this.buttonGroupBox.Controls.Add(this.salesReportButton);
            this.buttonGroupBox.Controls.Add(this.stockReportButton);
            this.buttonGroupBox.Location = new System.Drawing.Point(34, 1028);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Size = new System.Drawing.Size(868, 140);
            this.buttonGroupBox.TabIndex = 12;
            this.buttonGroupBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(647, 52);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(172, 46);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // salesReportButton
            // 
            this.salesReportButton.AutoSize = true;
            this.salesReportButton.Location = new System.Drawing.Point(46, 52);
            this.salesReportButton.Name = "salesReportButton";
            this.salesReportButton.Size = new System.Drawing.Size(259, 46);
            this.salesReportButton.TabIndex = 14;
            this.salesReportButton.Text = "Generate Sales Report";
            this.salesReportButton.UseVisualStyleBackColor = true;
            // 
            // stockReportButton
            // 
            this.stockReportButton.AutoSize = true;
            this.stockReportButton.Location = new System.Drawing.Point(342, 52);
            this.stockReportButton.Name = "stockReportButton";
            this.stockReportButton.Size = new System.Drawing.Size(259, 46);
            this.stockReportButton.TabIndex = 13;
            this.stockReportButton.Text = "Display Stock Report";
            this.stockReportButton.UseVisualStyleBackColor = true;
            this.stockReportButton.Click += new System.EventHandler(this.stockReportButton_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.clearSearchButton);
            this.searchGroupBox.Controls.Add(this.searchResultsLabel);
            this.searchGroupBox.Controls.Add(this.searchResultsListBox);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Controls.Add(this.transactionDateRadioButton);
            this.searchGroupBox.Controls.Add(this.transactionIDRadioButton);
            this.searchGroupBox.Location = new System.Drawing.Point(922, 34);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(512, 1134);
            this.searchGroupBox.TabIndex = 9;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.AutoSize = true;
            this.clearSearchButton.Location = new System.Drawing.Point(302, 53);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(172, 46);
            this.clearSearchButton.TabIndex = 15;
            this.clearSearchButton.Text = "Clear Search";
            this.clearSearchButton.UseVisualStyleBackColor = true;
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Location = new System.Drawing.Point(38, 219);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(166, 32);
            this.searchResultsLabel.TabIndex = 14;
            this.searchResultsLabel.Text = "Search Results";
            // 
            // searchResultsListBox
            // 
            this.searchResultsListBox.FormattingEnabled = true;
            this.searchResultsListBox.ItemHeight = 32;
            this.searchResultsListBox.Location = new System.Drawing.Point(38, 254);
            this.searchResultsListBox.Name = "searchResultsListBox";
            this.searchResultsListBox.Size = new System.Drawing.Size(436, 836);
            this.searchResultsListBox.TabIndex = 13;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(302, 147);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(172, 46);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(38, 151);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(252, 39);
            this.searchTextBox.TabIndex = 2;
            // 
            // transactionDateRadioButton
            // 
            this.transactionDateRadioButton.AutoSize = true;
            this.transactionDateRadioButton.Location = new System.Drawing.Point(38, 95);
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
            this.transactionIDRadioButton.Location = new System.Drawing.Point(38, 53);
            this.transactionIDRadioButton.Name = "transactionIDRadioButton";
            this.transactionIDRadioButton.Size = new System.Drawing.Size(228, 36);
            this.transactionIDRadioButton.TabIndex = 0;
            this.transactionIDRadioButton.TabStop = true;
            this.transactionIDRadioButton.Text = "By Transaction ID";
            this.transactionIDRadioButton.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 1201);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = ",";
            this.mainPanel.ResumeLayout(false);
            this.itemSelectionGroupBox.ResumeLayout(false);
            this.itemSelectionGroupBox.PerformLayout();
            this.basketGroupBox.ResumeLayout(false);
            this.basketGroupBox.PerformLayout();
            this.buttonGroupBox.ResumeLayout(false);
            this.buttonGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private ListBox itemCategoryListBox;
        private ListBox itemVariantListBox;
        private Button addToBasketButton;
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
        private Button salesReportButton;
        private Button stockReportButton;
        private Button exitButton;
        private GroupBox basketGroupBox;
        private FileSystemWatcher fileSystemWatcher1;
        private GroupBox itemSelectionGroupBox;
        private Button clearSearchButton;
    }
}