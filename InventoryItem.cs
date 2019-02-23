namespace Milestone2
{
    class InventoryItem
    {
        private string type;
        private string name;
        private int quantity;
        private decimal price;

        public InventoryItem()
        {

        }

        public InventoryItem(string type, string name, int quantity, decimal price)
        {
            this.type = type;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public decimal Price
        {
            get => price;
            set => price = value;
        }
    }
}


        