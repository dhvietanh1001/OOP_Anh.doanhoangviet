using OOP_Anh.doanhoangviet.DAO;
using OOP_Anh.doanhoangviet.Entity;
using System;
using System.Linq;

namespace OOP_Anh.doanhoangviet.Demo
{
    internal class Databasedemo
    {
        private Database db = Database.Instance;

        public Databasedemo()
        {
            InitDatabase();
        }

        public void InsertTableTest()
        {
            Product newProduct = new Product { Id = 11, Name = "New Product", CategoryId = 1 };
            db.InsertTable<Product>(newProduct);
            PrintTableTest();
        }

        public void SelectTableTest()
        {
            var products = db.SelectTable<Product>();
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Category ID: {product.CategoryId}");
            }
        }

        public void UpdateTableTest()
        {
            Product updatedProduct = new Product { Id = 1, Name = "Updated Product", CategoryId = 2 };
            db.UpdateTable<Product>(updatedProduct);
            PrintTableTest();
        }


        public void DeleteTableTest()
        {
            Product productToDelete = new Product { Id = 2, Name = "Product 2", CategoryId = 1 };
            db.DeleteTable<Product>(productToDelete);
            PrintTableTest();
        }

        public void TruncateTableTest()
        {
            Console.WriteLine("Truncating product table.");
            db.TruncateTable<Product>();
            PrintTableTest();
        }

        public void InitDatabase()
        {
            for (int i = 1; i <= 10; i++)
            {
                Product product = new Product { Id = i, Name = $"Product {i}", CategoryId = i % 3 + 1 };
                db.InsertTable<Product>(product);
            }
        }

        public static void PrintTableTest()
        {
            Database db2 = Database.Instance;
            db2.PrintTable<Product>();
        }

        //public static void Main(string[] args)
        //{
        //    Databasedemo demo = new Databasedemo();

        //    Console.WriteLine("1. InsertTableTest:");
        //    demo.InsertTableTest();
        //    Console.WriteLine();

        //    Console.WriteLine("2. SelectTableTest:");
        //    demo.SelectTableTest();
        //    Console.WriteLine();

        //    Console.WriteLine("3. UpdateTableTest:");
        //    demo.UpdateTableTest();
        //    Console.WriteLine();

        //    Console.WriteLine("4. DeleteTableTest:");
        //    demo.DeleteTableTest();
        //    Console.WriteLine();

        //    Console.WriteLine("5. TruncateTableTest:");
        //    demo.TruncateTableTest();
        //    Console.WriteLine();
        //}
    }
}
