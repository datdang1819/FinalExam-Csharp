using System;
using System.Collections.Generic;

namespace FinalExamCsharp
{
    /// <summary>
    /// ProductID ProductName Price
    /// MN001     Monitor     $38
    /// C01022     CPU        $94
    /// </summary>
    class Program
    {
        static private List<Product> listProducts = new List<Product>();
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");
                var choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Display();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                }
            }
        }
        
        public static void Add()
        {
            Console.WriteLine("Add information");
            Console.WriteLine("----------------");
            Console.WriteLine("Product ID: ");
            var productID = Console.ReadLine();
            Console.WriteLine("Product Name: ");
            var productName = Console.ReadLine();
            Console.WriteLine("Price: ");
            var price = double.Parse(Console.ReadLine());
            Product product = new Product(productID, productName, price);
            listProducts.Add(product);
            Console.WriteLine("Success!");
        }

        public static void Display()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("{0,-20} {1,-15} {2,-5}", "Product ID", "Product Name", "Price");
            if (listProducts.Count > 0)
            {
                foreach (var product in listProducts)
                {
                    Console.WriteLine("{0,-20} {1,-15} {2,-5}", product.ProductId, product.ProductName,"$" + product.Price);       
                }
            }
            else
            {
                Console.WriteLine("No product added !!");
            }
        }

        public static void Delete()
        {
            Console.WriteLine("Delete");
            Console.WriteLine("-----------");
            Console.Write("Please enter product Id to delete: ");
            var idDelete = Console.ReadLine();
            var count = 0;
            for (var i = 0; i < listProducts.Count; i++)
            {
                if (listProducts[i].ProductId == idDelete)
                {
                    listProducts.RemoveAt(i);
                    Console.WriteLine("Delete Success");
                    break;
                }
                count++;
            }

            if (count == listProducts.Count)
            {
                Console.WriteLine("There is no product id : " + idDelete);
            }
        }
        
    }
}