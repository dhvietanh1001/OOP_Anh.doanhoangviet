// See https://aka.ms/new-console-template for more information
using OOP_Anh.doanhoangviet.DAO;
using OOP_Anh.doanhoangviet.Demo;
using OOP_Anh.doanhoangviet.Entity;

class Program
{

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Test ProductDAODemo ");
            Console.WriteLine("2. Test AccessoryDAODemo ");
            Console.WriteLine("3. Test CategoryDAODemo ");
            Console.WriteLine("4. Test DatabaseDemo");

            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    TestProductDAO();
                    break;
                case "2":
                    TestAccessoryDAO();
                    break;
                case "3":
                    TestCategoryDAO();
                    break;
                case "4":
                    TestDatabaseDemo();
                    return;
            }

            Console.WriteLine();
        }
    }

    private static void TestProductDAO()
    {
        Console.WriteLine("Testing ProductDAO methods...");
        Console.WriteLine("1. InsertProductTest:");
        ProductDAODemo.InsertProductTest();
        Console.WriteLine();

        Console.WriteLine("2. UpdateProductTest:");
        ProductDAODemo.UpdateProductTest();
        Console.WriteLine();

        Console.WriteLine("3. DeleteProductTest:");
        ProductDAODemo.DeleteProductTest();
        Console.WriteLine();

        Console.WriteLine("4. FindAllTest:");
        ProductDAODemo.FindAllTest();
        Console.WriteLine();

        Console.WriteLine("5. FindByIdTest:");
        ProductDAODemo.FindByIdTest();
        Console.WriteLine();

        Console.WriteLine("6. FindByNameTest:");
        ProductDAODemo.FindByNameTest();
        Console.WriteLine();

        Console.WriteLine("7. SearchTest:");
        ProductDAODemo.SearchTest();
        Console.WriteLine();
    }

    private static void TestAccessoryDAO()
    {
        Console.WriteLine("Testing AccessoryDAO methods...");
        Console.WriteLine("1. InsertAccessoryTest:");
        AccessotionDAODemo.InsertAccessoryTest();
        Console.WriteLine();

        Console.WriteLine("2. UpdateAccessoryTest:");
        AccessotionDAODemo.UpdateAccessoryTest();
        Console.WriteLine();

        Console.WriteLine("3. DeleteAccessoryTest:");
        AccessotionDAODemo.DeleteAccessoryTest();
        Console.WriteLine();

        Console.WriteLine("4. FindAllTest:");
        AccessotionDAODemo.FindAllTest();
        Console.WriteLine();

        Console.WriteLine("5. FindByIdTest:");
        AccessotionDAODemo.FindByIdTest();
        Console.WriteLine();

        Console.WriteLine("6. FindByNameTest:");
        AccessotionDAODemo.FindByNameTest();
        Console.WriteLine();

        Console.WriteLine("7. SearchTest:");
        AccessotionDAODemo.SearchTest();
        Console.WriteLine();
    }

    private static void TestCategoryDAO()
    {
        Console.WriteLine("Testing CategoryDAO methods...");
        Console.WriteLine("1. InsertCategoryTest:");
        CategoryDAODemo.InsertCategoryTest();
        Console.WriteLine();

        Console.WriteLine("2. UpdateCategoryTest:");
        CategoryDAODemo.UpdateCategoryTest();
        Console.WriteLine();

        Console.WriteLine("3. DeleteCategoryTest:");
        CategoryDAODemo.DeleteCategoryTest();
        Console.WriteLine();

        Console.WriteLine("4. FindAllTest:");
        CategoryDAODemo.FindAllTest();
        Console.WriteLine();

        Console.WriteLine("5. FindByIdTest:");
        CategoryDAODemo.FindByIdTest();
        Console.WriteLine();
    }

    private static void TestDatabaseDemo() 
    {
        Databasedemo demo = new Databasedemo();

        Console.WriteLine("1. InsertTableTest:");
        demo.InsertTableTest();
        Console.WriteLine();

        Console.WriteLine("2. SelectTableTest:");
        demo.SelectTableTest();
        Console.WriteLine();

        Console.WriteLine("3. UpdateTableTest:");
        demo.UpdateTableTest();
        Console.WriteLine();

        Console.WriteLine("4. DeleteTableTest:");
        demo.DeleteTableTest();
        Console.WriteLine();

        Console.WriteLine("5. TruncateTableTest:");
        demo.TruncateTableTest();
        Console.WriteLine();
    }
}