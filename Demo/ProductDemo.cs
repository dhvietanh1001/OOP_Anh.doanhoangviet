using OOP_Anh.doanhoangviet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Anh.doanhoangviet.Demo
{
    internal class ProductDemo
    {
        public static Product CreateProductTest()
        {
            return new Product(1,"iphone",1);
        }
        public static void printProduct(Product product)
        { 
            product.Print();
        }

        //public static void Main(string[] args)
        //{
        //    Product p = CreateProductTest();
        //    printProduct(p);

        //}
    }
}
