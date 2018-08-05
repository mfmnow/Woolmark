using System;
using Wool.Test.ReverseWords.Domain;

namespace Wool.Test.ReverseWords.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Wool.Test.ReverseWords.App!");
            Console.WriteLine("Press input text then Enter to execute ResverseString for input string");
            var text = Console.ReadLine();
            Console.WriteLine("Method 1");
            Console.WriteLine(ReverseWordsService.ResverseString(text));
            Console.WriteLine("Method 2");
            Console.WriteLine(ReverseWordsService.ResverseString2(text));
            Console.ReadLine();
        }
    }
}
