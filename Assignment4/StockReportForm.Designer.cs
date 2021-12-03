namespace Assignment4
{
    partial class StockReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timestampLabel = new System.Windows.Forms.Label();
            this.itemNameHeadingLabel = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.startingStockHeading = new System.Windows.Forms.Label();
            this.currentStockHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timestampLabel
            // 
            this.timestampLabel.AutoSize = true;
            this.timestampLabel.Location = new System.Drawing.Point(234, 25);
            this.timestampLabel.Name = "timestampLabel";
            this.timestampLabel.Size = new System.Drawing.Size(144, 32);
            this.timestampLabel.TabIndex = 0;
            this.timestampLabel.Text = "Timestamp: ";
            // 
            // itemNameHeadingLabel
            // 
            this.itemNameHeadingLabel.AutoSize = true;
            this.itemNameHeadingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.itemNameHeadingLabel.Location = new System.Drawing.Point(36, 82);
            this.itemNameHeadingLabel.Name = "itemNameHeadingLabel";
            this.itemNameHeadingLabel.Size = new System.Drawing.Size(129, 32);
            this.itemNameHeadingLabel.TabIndex = 1;
            this.itemNameHeadingLabel.Text = "Item name";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 32;
            this.listBox.Location = new System.Drawing.Point(36, 119);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(785, 1028);
            this.listBox.TabIndex = 4;
            // 
            // startingStockHeading
            // 
            this.startingStockHeading.AutoSize = true;
            this.startingStockHeading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.startingStockHeading.Location = new System.Drawing.Point(380, 82);
            this.startingStockHeading.Name = "startingStockHeading";
            this.startingStockHeading.Size = new System.Drawing.Size(225, 32);
            this.startingStockHeading.TabIndex = 5;
            this.startingStockHeading.Text = "Stock at start of day";
            // 
            // currentStockHeading
            // 
            this.currentStockHeading.AutoSize = true;
            this.currentStockHeading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.currentStockHeading.Location = new System.Drawing.Point(601, 82);
            this.currentStockHeading.Name = "currentStockHeading";
            this.currentStockHeading.Size = new System.Drawing.Size(156, 32);
            this.currentStockHeading.TabIndex = 6;
            this.currentStockHeading.Text = "Current stock";
            // 
            // StockReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 1191);
            this.Controls.Add(this.currentStockHeading);
            this.Controls.Add(this.startingStockHeading);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.itemNameHeadingLabel);
            this.Controls.Add(this.timestampLabel);
            this.Name = "StockReportForm";
            this.Text = "StockReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label timestampLabel;
        private Label itemNameHeadingLabel;
        private ListBox listBox;
        private Label startingStockHeading;
        private Label currentStockHeading;
    }
}