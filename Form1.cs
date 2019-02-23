using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone2
{
    public partial class MainForm : Form
    {
        inventoryScreen inventoryScreen = new inventoryScreen();
        SearchScreen searchScreen = new SearchScreen();
        NewItemScreen newItemScreen = new NewItemScreen();

        public MainForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewInventoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventoryScreen.Show(this);
        }

        private void searchInventoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchScreen.Show(this);
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            newItemScreen.Show(this);
        }
    }
}
