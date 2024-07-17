using OOP_Anh.doanhoangviet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anh.doanhoangviet.Demo
{
    internal class CategoryDemo
    {
        public static Category CreateProductTest()
        {
            return new Category(1, "apple");
        }
        public static void printCategory(Category category)
        {
            Console.WriteLine(category.ToString());
        }
    }
}
