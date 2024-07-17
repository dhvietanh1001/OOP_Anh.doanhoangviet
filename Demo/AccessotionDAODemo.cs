using OOP_Anh.doanhoangviet.DAO;
using OOP_Anh.doanhoangviet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anh.doanhoangviet.Demo
{
    internal class AccessotionDAODemo
    {
        public static void InsertAccessoryTest()
        {
            AccessoryDAO dao = new AccessoryDAO();
            Accessotion accessory = new Accessotion(1, "Mouse");
            bool result = dao.Insert("Product", accessory);
            Console.WriteLine(result );
        }

        public static void UpdateAccessoryTest()
        {
            AccessoryDAO dao = new AccessoryDAO();
            Accessotion accessory = new Accessotion(1, "Mouse");
            dao.Insert("Product", accessory);
            accessory.Name = "Wireless Mouse";
            bool result = dao.Update("Product", accessory);
            Console.WriteLine(result);
        }

        public static void DeleteAccessoryTest()
        {
            AccessoryDAO dao = new AccessoryDAO();
            Accessotion accessory = new Accessotion(1, "Mouse");
            dao.Insert("Product", accessory);
            bool result = dao.Update("Product",accessory);
            Console.WriteLine(result);
        }

        public static void FindAllTest()
        {
            AccessoryDAO dao = new AccessoryDAO();
            dao.Insert("Product", new Accessotion(1, "Mouse"));
            dao.Insert("Product", new Accessotion(2, "Keyboard"));
            List<Accessotion> accessories = dao.FindAll("Product");
            Console.WriteLine(accessories.Count == 2 ? "Test FindAll passed" : "Test FindAll failed");
        }

        public static void FindByIdTest()
        {
            AccessoryDAO dao = new AccessoryDAO();
            dao.Insert("Product", new Accessotion(1, "Mouse"));
            Accessotion accessory = dao.FindById("Product", 1);
            Console.WriteLine(accessory != null && accessory.Name == "Mouse" ? "Test FindById passed" : "Test FindById failed");
        }

        public static void FindByNameTest()
        {
            AccessoryDAO dao = new AccessoryDAO();
            dao.Insert("Product", new Accessotion(1, "Mouse"));
            Accessotion accessory = dao.FindByName("Mouse");
            Console.WriteLine(accessory != null && accessory.Name == "Mouse" ? "Test FindByName passed" : "Test FindByName failed");
        }

        public static void SearchTest()
        {
            AccessoryDAO dao = new AccessoryDAO();
            dao.Insert("Product", new Accessotion(1, "Mouse"));
            dao.Insert("Product", new Accessotion(2, "Keyboard"));
            List<Accessotion> accessories = dao.Search(a=>a.Name.Equals("Mouse"));
            Console.WriteLine(accessories.Count == 1 ? "Test Search passed" : "Test Search failed");
        }

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Testing AccessoryDAO methods...");
        //    Console.WriteLine("1. InsertAccessoryTest:");
        //    AccessotionDAODemo.InsertAccessoryTest();
        //    Console.WriteLine();

        //    Console.WriteLine("2. UpdateAccessoryTest:");
        //    AccessotionDAODemo.UpdateAccessoryTest();
        //    Console.WriteLine();

        //    Console.WriteLine("3. DeleteAccessoryTest:");
        //    AccessotionDAODemo.DeleteAccessoryTest();
        //    Console.WriteLine();

        //    Console.WriteLine("4. FindAllTest:");
        //    AccessotionDAODemo.FindAllTest();
        //    Console.WriteLine();

        //    Console.WriteLine("5. FindByIdTest:");
        //    AccessotionDAODemo.FindByIdTest();
        //    Console.WriteLine();

        //    Console.WriteLine("6. FindByNameTest:");
        //    AccessotionDAODemo.FindByNameTest();
        //    Console.WriteLine();

        //    Console.WriteLine("7. SearchTest:");
        //    AccessotionDAODemo.SearchTest();
        //    Console.WriteLine();
        //}

    }
}
