using OOP_Anh.doanhoangviet.DAO;
using OOP_Anh.doanhoangviet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anh.doanhoangviet.Demo
{
    internal class ProductDAODemo
    {
        public static void InsertProductTest()
        {
            ProductDAO dao = new ProductDAO();
            Product product = new Product(1, "Laptop", 1);
            bool result = dao.Insert(product);
            Console.WriteLine(result);
        }

        public static void UpdateProductTest()
        {
            ProductDAO dao = new ProductDAO();
            Product product = new Product(1, "Laptop", 1);
            dao.Insert(product);
            product.Name = "Gaming Laptop";
            bool result = dao.Update(product);
            Console.WriteLine(result);
        }

        public static void DeleteProductTest()
        {
            ProductDAO dao = new ProductDAO();
            Product product = new Product(1, "Laptop", 1);
            dao.Insert(product);
            bool result = dao.Delete(product);
            Console.WriteLine(result);
        }

        public static void FindAllTest()
        {
            ProductDAO dao = new ProductDAO();
            dao.Insert(new Product(1, "Laptop", 1));
            dao.Insert(new Product(2, "Smartphone", 1));
            List<Product> products = dao.FindAll();
            Console.WriteLine(products.Count == 2 ? "Test FindAll passed" : "Test FindAll failed");
        }

        public static void FindByIdTest()
        {
            ProductDAO dao = new ProductDAO();
            dao.Insert(new Product(1, "Laptop", 1));
            Product product = dao.FindById(1);
            Console.WriteLine(product != null && product.Name == "Laptop" ? "FindByIdTest passed" : "FindByIdTest failed");
        }

        public static void FindByNameTest()
        {
            ProductDAO dao = new ProductDAO();
            dao.Insert(new Product(1, "Laptop", 1));
            Product product = dao.FindByName("Laptop");
            Console.WriteLine(product != null && product.Name == "Laptop" ? "FindByNameTest passed" : "FindByNameTest failed");
        }

        public static void SearchTest()
        {
            ProductDAO dao = new ProductDAO();
            dao.Insert(new Product(1, "Laptop", 1));
            dao.Insert(new Product(2, "Smartphone", 1));
            dao.Insert(new Product(3, "Televison", 1));
            dao.Insert(new Product(4, "fridge", 1));
            dao.Insert(new Product(5, "air conditioning", 2));
            List<Product> products = dao.Search("",1);
            Console.WriteLine(products.Count == 4 ? " SearchTest passed" : " SearchTest failed");
        }

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Testing ProductDAO methods...");
        //    Console.WriteLine("1. InsertProductTest:");
        //    ProductDAODemo.InsertProductTest();
        //    Console.WriteLine();

        //    Console.WriteLine("2. UpdateProductTest:");
        //    ProductDAODemo.UpdateProductTest();
        //    Console.WriteLine();

        //    Console.WriteLine("3. DeleteProductTest:");
        //    ProductDAODemo.DeleteProductTest();
        //    Console.WriteLine();

        //    Console.WriteLine("4. FindAllTest:");
        //    ProductDAODemo.FindAllTest();
        //    Console.WriteLine();

        //    Console.WriteLine("5. FindByIdTest:");
        //    ProductDAODemo.FindByIdTest();
        //    Console.WriteLine();

        //    Console.WriteLine("6. FindByNameTest:");
        //    ProductDAODemo.FindByNameTest();
        //    Console.WriteLine();

        //    Console.WriteLine("7. SearchTest:");
        //    ProductDAODemo.SearchTest();
        //    Console.WriteLine();
        //}
    }


}
