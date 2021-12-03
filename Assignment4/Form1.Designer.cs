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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.customerInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.itemSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.itemCategoryListBox = new System.Windows.Forms.ListBox();
            this.itemVariantListBox = new System.Windows.Forms.ListBox();
            this.addToBasketButton = new System.Windows.Forms.Button();
            this.basketGroupBox = new System.Windows.Forms.GroupBox();
            this.basketListBox = new System.Windows.Forms.ListBox();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.ItemTotalLabel = new System.Windows.Forms.Label();
            this.clearBasketButton = new System.Windows.Forms.Button();
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.customerInformationGroupBox.SuspendLayout();
            this.itemSelectionGroupBox.SuspendLayout();
            this.basketGroupBox.SuspendLayout();
            this.buttonGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.customerInformationGroupBox);
            this.mainPanel.Controls.Add(this.itemSelectionGroupBox);
            this.mainPanel.Controls.Add(this.basketGroupBox);
            this.mainPanel.Controls.Add(this.buttonGroupBox);
            this.mainPanel.Controls.Add(this.searchGroupBox);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1466, 1465);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Visible = false;
            // 
            // customerInformationGroupBox
            // 
            this.customerInformationGroupBox.Controls.Add(this.transactionLabel);
            this.customerInformationGroupBox.Controls.Add(this.phoneTextBox);
            this.customerInformationGroupBox.Controls.Add(this.phoneLabel);
            this.customerInformationGroupBox.Controls.Add(this.emailTextBox);
            this.customerInformationGroupBox.Controls.Add(this.checkoutButton);
            this.customerInformationGroupBox.Controls.Add(this.emailLabel);
            this.customerInformationGroupBox.Controls.Add(this.nameTextBox);
            this.customerInformationGroupBox.Controls.Add(this.nameLabel);
            this.customerInformationGroupBox.Location = new System.Drawing.Point(35, 1028);
            this.customerInformationGroupBox.Name = "customerInformationGroupBox";
            this.customerInformationGroupBox.Size = new System.Drawing.Size(867, 410);
            this.customerInformationGroupBox.TabIndex = 2;
            this.customerInformationGroupBox.TabStop = false;
            this.customerInformationGroupBox.Text = "Customer Information";
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Location = new System.Drawing.Point(29, 64);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(176, 32);
            this.transactionLabel.TabIndex = 12;
            this.transactionLabel.Text = "Transaction ID: ";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(115, 234);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(520, 39);
            this.phoneTextBox.TabIndex = 2;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(29, 237);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(87, 32);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Phone:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(115, 178);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(520, 39);
            this.emailTextBox.TabIndex = 1;
            // 
            // checkoutButton
            // 
            this.checkoutButton.AutoSize = true;
            this.checkoutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkoutButton.Location = new System.Drawing.Point(329, 326);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(172, 46);
            this.checkoutButton.TabIndex = 3;
            this.checkoutButton.Text = "&Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Visible = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(29, 181);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(83, 32);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(115, 118);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(520, 39);
            this.nameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(29, 121);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(90, 32);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name: ";
            // 
            // itemSelectionGroupBox
            // 
            this.itemSelectionGroupBox.Controls.Add(this.itemCategoryListBox);
            this.itemSelectionGroupBox.Controls.Add(this.itemVariantListBox);
            this.itemSelectionGroupBox.Controls.Add(this.addToBasketButton);
            this.itemSelectionGroupBox.Location = new System.Drawing.Point(34, 34);
            this.itemSelectionGroupBox.Name = "itemSelectionGroupBox";
            this.itemSelectionGroupBox.Size = new System.Drawing.Size(868, 628);
            this.itemSelectionGroupBox.TabIndex = 0;
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
            this.itemVariantListBox.TabIndex = 1;
            this.itemVariantListBox.SelectedIndexChanged += new System.EventHandler(this.itemVariantListBox_SelectedIndexChanged);
            // 
            // addToBasketButton
            // 
            this.addToBasketButton.AutoSize = true;
            this.addToBasketButton.Location = new System.Drawing.Point(632, 561);
            this.addToBasketButton.Name = "addToBasketButton";
            this.addToBasketButton.Size = new System.Drawing.Size(172, 46);
            this.addToBasketButton.TabIndex = 2;
            this.addToBasketButton.Text = "&Add to basket";
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
            this.basketGroupBox.Location = new System.Drawing.Point(34, 668);
            this.basketGroupBox.Name = "basketGroupBox";
            this.basketGroupBox.Size = new System.Drawing.Size(868, 354);
            this.basketGroupBox.TabIndex = 1;
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
            this.basketListBox.TabIndex = 0;
            this.basketListBox.SelectedIndexChanged += new System.EventHandler(this.basketListBox_SelectedIndexChanged);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.AutoSize = true;
            this.deleteItemButton.Location = new System.Drawing.Point(632, 131);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(172, 46);
            this.deleteItemButton.TabIndex = 2;
            this.deleteItemButton.Text = "&Delete Item";
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
            this.ItemTotalLabel.TabIndex = 3;
            this.ItemTotalLabel.Text = "Item Total: ";
            // 
            // clearBasketButton
            // 
            this.clearBasketButton.AutoSize = true;
            this.clearBasketButton.Location = new System.Drawing.Point(632, 64);
            this.clearBasketButton.Name = "clearBasketButton";
            this.clearBasketButton.Size = new System.Drawing.Size(172, 46);
            this.clearBasketButton.TabIndex = 1;
            this.clearBasketButton.Text = "Clear &Basket";
            this.clearBasketButton.UseVisualStyleBackColor = true;
            this.clearBasketButton.Click += new System.EventHandler(this.clearBasketButton_Click);
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Controls.Add(this.exitButton);
            this.buttonGroupBox.Controls.Add(this.salesReportButton);
            this.buttonGroupBox.Controls.Add(this.stockReportButton);
            this.buttonGroupBox.Location = new System.Drawing.Point(922, 1174);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Size = new System.Drawing.Size(512, 264);
            this.buttonGroupBox.TabIndex = 4;
            this.buttonGroupBox.TabStop = false;
            this.buttonGroupBox.Text = "Actions";
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(179, 180);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(172, 46);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // salesReportButton
            // 
            this.salesReportButton.Location = new System.Drawing.Point(38, 54);
            this.salesReportButton.Name = "salesReportButton";
            this.salesReportButton.Size = new System.Drawing.Size(197, 91);
            this.salesReportButton.TabIndex = 0;
            this.salesReportButton.Text = "&Generate Sales Report";
            this.salesReportButton.UseVisualStyleBackColor = true;
            this.salesReportButton.Click += new System.EventHandler(this.salesReportButton_Click);
            // 
            // stockReportButton
            // 
            this.stockReportButton.Location = new System.Drawing.Point(277, 54);
            this.stockReportButton.Name = "stockReportButton";
            this.stockReportButton.Size = new System.Drawing.Size(197, 91);
            this.stockReportButton.TabIndex = 1;
            this.stockReportButton.Text = "D&isplay Stock Report";
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
            this.searchGroupBox.TabIndex = 3;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.AutoSize = true;
            this.clearSearchButton.Location = new System.Drawing.Point(302, 53);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(172, 46);
            this.clearSearchButton.TabIndex = 6;
            this.clearSearchButton.Text = "C&lear Search";
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Location = new System.Drawing.Point(38, 219);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(166, 32);
            this.searchResultsLabel.TabIndex = 4;
            this.searchResultsLabel.Text = "Search Results";
            // 
            // searchResultsListBox
            // 
            this.searchResultsListBox.FormattingEnabled = true;
            this.searchResultsListBox.ItemHeight = 32;
            this.searchResultsListBox.Location = new System.Drawing.Point(38, 254);
            this.searchResultsListBox.Name = "searchResultsListBox";
            this.searchResultsListBox.Size = new System.Drawing.Size(436, 836);
            this.searchResultsListBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(302, 147);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(172, 46);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            // passwordPanel
            // 
            this.passwordPanel.Controls.Add(this.passwordButton);
            this.passwordPanel.Controls.Add(this.passwordTextBox);
            this.passwordPanel.Controls.Add(this.passwordLabel);
            this.passwordPanel.Controls.Add(this.pictureBox1);
            this.passwordPanel.Location = new System.Drawing.Point(4, -1);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(1454, 779);
            this.passwordPanel.TabIndex = 6;
            // 
            // passwordButton
            // 
            this.passwordButton.Location = new System.Drawing.Point(669, 525);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(150, 46);
            this.passwordButton.TabIndex = 3;
            this.passwordButton.Text = "Sign In";
            this.passwordButton.UseVisualStyleBackColor = true;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(583, 457);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(378, 39);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextBox_KeyPress);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(392, 460);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(180, 32);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Enter password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(583, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 258);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 777);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Electronics Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.mainPanel.ResumeLayout(false);
            this.customerInformationGroupBox.ResumeLayout(false);
            this.customerInformationGroupBox.PerformLayout();
            this.itemSelectionGroupBox.ResumeLayout(false);
            this.itemSelectionGroupBox.PerformLayout();
            this.basketGroupBox.ResumeLayout(false);
            this.basketGroupBox.PerformLayout();
            this.buttonGroupBox.ResumeLayout(false);
            this.buttonGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private GroupBox customerInformationGroupBox;
        private Label transactionLabel;
        private TextBox phoneTextBox;
        private Label phoneLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private ToolTip toolTip;
        private Panel passwordPanel;
        private PictureBox pictureBox1;
        private Button passwordButton;
        private TextBox passwordTextBox;
        private Label passwordLabel;
    }
}