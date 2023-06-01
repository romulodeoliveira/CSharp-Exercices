namespace Exercice05
{
    class Products
    {
        private int _id { get; set; }
        private int _quantity { get; set; }
        private double _price { get; set; }

        public Products(int id, int quantity, double price)
        {
            _id = id;
            _quantity = quantity;
            _price = price;
        }

        public void Print()
        {
            System.Console.WriteLine($"O produto com código {_id} custará R$ {(_quantity * _price).ToString("F2")}");
        }
    }
}