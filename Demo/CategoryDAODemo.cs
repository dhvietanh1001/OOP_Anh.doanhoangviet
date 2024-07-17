using OOP_Anh.doanhoangviet.DAO;
using OOP_Anh.doanhoangviet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anh.doanhoangviet.Demo
{
    internal class CategoryDAODemo
    {
        public static void InsertCategoryTest()
        {
            CategoryDAO dao = new CategoryDAO();
            Category category = new Category(1, "Electronics");
            bool result = dao.Insert("Category", category);
            Console.WriteLine(result);
        }

        public static void UpdateCategoryTest()
        {
            CategoryDAO dao = new CategoryDAO();
            Category category = new Category(1, "Electronics");
            dao.Insert("Category", category);
            category.Name = "Home Electronics";
            bool result = dao.Update("Category",category);
            Console.WriteLine(result);
        }

        public static void DeleteCategoryTest()
        {
            CategoryDAO dao = new CategoryDAO();
            Category category = new Category(1, "Electronics");
            dao.Insert("Category", category);
            bool result = dao.Delete("Category", category);
            Console.WriteLine(result);
        }

        public static void FindAllTest()
        {
            CategoryDAO dao = new CategoryDAO();
            dao.Insert("Category", new Category(1, "Electronics"));
            dao.Insert("Category", new Category(2, "Books"));
            List<Category> categories = dao.FindAll("Category");
            foreach (var item in categories)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void FindByIdTest()
        {
            CategoryDAO dao = new CategoryDAO();
            dao.Insert("Category", new Category(1, "Electronics"));
            Category category = dao.FindById("Category", 1);
            Console.WriteLine(category.ToString());
        }

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Testing CategoryDAO methods...");
        //    Console.WriteLine("1. InsertCategoryTest:");
        //    CategoryDAODemo.InsertCategoryTest();
        //    Console.WriteLine();

        //    Console.WriteLine("2. UpdateCategoryTest:");
        //    CategoryDAODemo.UpdateCategoryTest();
        //    Console.WriteLine();

        //    Console.WriteLine("3. DeleteCategoryTest:");
        //    CategoryDAODemo.DeleteCategoryTest();
        //    Console.WriteLine();

        //    Console.WriteLine("4. FindAllTest:");
        //    CategoryDAODemo.FindAllTest();
        //    Console.WriteLine();

        //    Console.WriteLine("5. FindByIdTest:");
        //    CategoryDAODemo.FindByIdTest();
        //    Console.WriteLine();
        //}
    }
}
