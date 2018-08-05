using System;

namespace Wool.Test.LinkedList.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Wool.Test.LinkedList.App!");
            Console.WriteLine("Press Enter to execute GetFromEnd");
            Console.ReadLine();
            var list = new Domain.LinkedList();
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);
            list.AddNode(5);
            list.AddNode(6);
            list.AddNode(7);
            list.AddNode(8);
            list.AddNode(9);
            list.AddNode(10);
            list.AddNode(11);
            Console.WriteLine(list.GetFromEnd(5).ToString());
            Console.ReadLine();
        }
    }
}
