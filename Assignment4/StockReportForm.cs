using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class StockReportForm : Form
    {
        public StockReportForm(Tuple<string, decimal, int, int>[] items, 
            int[] initialStock, string timestamp)
        {
            InitializeComponent();

            // Set timestamp
            timestampLabel.Text = timestampLabel.Text + timestamp;

            // Iterate over list of items
            for (int i = 0; i < items.Length; i++)
            {
                // Initialize display string
                string output = items[i].Item1 + '\t' 
                    + initialStock[i] + "\t\t" + items[i].Item3;

                // Display string
                listBox.Items.Add(output);
            }


        }

    }
}
