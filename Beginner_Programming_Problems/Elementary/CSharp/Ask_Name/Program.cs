using System;

namespace Ask_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");

            string name;

            name = Console.ReadLine();
            
            Console.WriteLine($"Hello {name}!!");
        }
    }
}
