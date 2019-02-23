using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Milestone2
{
    class Inventory
    {
        List<InventoryItem> inventoryList = new List<InventoryItem>();
        private char delimiter = ',';
        private string header1;
        private string header2;

        public List<InventoryItem> ReadInventoryFile()
        {
            try
            {
                //open inventory file
                StreamReader streamReader = new StreamReader(File.OpenRead("inventory.csv"));

                //skip header and blank lines in file
                header1 = streamReader.ReadLine();
                header2 = streamReader.ReadLine();

                //read file to the end
                //create new InventoryItem objects to add to the inventory lit
                while (!streamReader.EndOfStream)
                {
                    string inventoryLine = streamReader.ReadLine();
                    string[] inventoryStrings = inventoryLine.Split(delimiter);

                    InventoryItem inventoryItem = new InventoryItem();
                    inventoryItem.Type = inventoryStrings[0];
                    inventoryItem.Name = inventoryStrings[1];
                    inventoryItem.Quantity = int.Parse(inventoryStrings[2]);
                    inventoryItem.Price = decimal.Parse(inventoryStrings[3]);

                    inventoryList.Add(inventoryItem);
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

            return inventoryList;
        }

        public void SaveInventoryFile()
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(File.OpenWrite("inventory.csv"));

                streamWriter.WriteLine(header1);
                streamWriter.WriteLine(header2);

                foreach (InventoryItem inventoryItem in inventoryList)
                {
                    streamWriter.WriteLine(inventoryItem.Type + "," + inventoryItem.Name + "," + inventoryItem.Quantity + ","
                        + inventoryItem.Price);
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        public void DeleteItem(InventoryItem inventory)
        {

        }

        public void AddItem()
        {

        }
    }
}
      