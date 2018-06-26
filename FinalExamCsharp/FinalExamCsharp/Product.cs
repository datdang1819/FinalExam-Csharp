namespace FinalExamCsharp
{
    public class Product
    {
        private string _productID;
        private string _productName;
        private double _price;

        public string ProductId
        {
            get => _productID;
            set => _productID = value;
        }

        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public Product()
        {
        }

        public Product(string productId, string productName, double price)
        {
            _productID = productId;
            _productName = productName;
            _price = price;
        }
    }
}