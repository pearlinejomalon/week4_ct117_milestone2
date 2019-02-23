using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Milestone2
{
    public partial class inventoryScreen : Form
    {
        public inventoryScreen()
        {
            InitializeComponent();

            Inventory inventory = new Inventory();

            List<InventoryItem> inventoryList = Program.inventoryList;

            int row = 0;

            foreach (InventoryItem inventoryItem in inventoryList)
            {
                inventoryDataGrid[0, row].Value = inventoryItem.Type;
                inventoryDataGrid[1, row].Value = inventoryItem.Name;
                inventoryDataGrid[2, row].Value = inventoryItem.Quantity;
                inventoryDataGrid[3, row].Value = inventoryItem.Price;

                row++;
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();

            this.Hide();
            mainForm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            IndividualProductScreen individualProductScreen = new IndividualProductScreen();

            this.Hide();
            individualProductScreen.Show();
        }
    }
}