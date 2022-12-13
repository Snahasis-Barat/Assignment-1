// See https://aka.ms/new-console-template for more information
using StudentMnagementSystem.Data_Access;
using StudentMnagementSystem.Data_Access;
using StudentMnagementSystem.Models;

class Program
{
    static void Main(string[] args)
    {
        DataAccess ob = new DataAccess();
        
        Console.WriteLine("1.Add data");
        Console.WriteLine("2.Get all data");
        Console.WriteLine("3.Get data by id");
        Console.WriteLine("4.Update data by id");
        Console.WriteLine("5.Delete data by Id");
        Console.WriteLine("6.Exit");
        int ch = 1000;
        while (ch != 0)
        {
            Console.WriteLine("Enter your choice");
            ch = int.Parse(Console.ReadLine());
            switch (ch)
           {
                case 1:
                    ob.AddData();
                    break;
                case 2:
                    ob.getData();
                    break;
                case 3:
                    Console.WriteLine("Enter id to display");
                    int id = int.Parse(Console.ReadLine());
                    ob.getDataId(id);
                    break;
                case 4:
                    Console.WriteLine("Enter id to update");
                    int id2 = int.Parse(Console.ReadLine());
                    ob.updateId(id2);
                    break;
                case 5:
                    Console.WriteLine("Enter id to delete");
                    int id3 = int.Parse(Console.ReadLine());
                    ob.deleteId(id3);
                    break;
                default:
                    //Console.WriteLine("Thank you");
                    break;
        }
        }
    }
}