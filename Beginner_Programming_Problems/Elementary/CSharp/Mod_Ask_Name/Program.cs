using System;

namespace Mod_Ask_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");

            string name;

            name = Console.ReadLine();
            
            if(name == "Alice" || name == "Bob")
            {
                Console.WriteLine("Hello {0}!!",name);
            }
            else
            {
                Console.WriteLine("Hello!!");
            }
        }
    }
}
