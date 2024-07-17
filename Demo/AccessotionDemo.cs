using OOP_Anh.doanhoangviet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Anh.doanhoangviet.Demo
{
    internal class AccessotionDemo
    {
        public static Accessotion CreateAccessotionDemo()
        {
            return new Accessotion(1, "asss");
        }
        public static void printAccessotion(Accessotion   accessotion)
        {
            Console.WriteLine(accessotion.ToString());
        }
    }
}
