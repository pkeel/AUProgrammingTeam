using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3nplus1problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is just a run function so you can see what the output is
            //see below at CycleCount and MaxCycleCount for how to solve problemß
            while (true)
            {
                Console.Write("What number ");
                string num = Console.ReadLine();
                int n = Convert.ToInt32(num);
                Console.WriteLine(CycleCount(n));
                Console.WriteLine("What range ");
                Console.Write("First number ");
                string num2 = Console.ReadLine();
                int n2 = Convert.ToInt32(num2);
                Console.Write("Second number ");
                string num3 = Console.ReadLine();
                int n3 = Convert.ToInt32(num3);
                Console.WriteLine(MaxCycleCount(n2, n3));
            }
            
                        
        }
        // Actual code is here to solve problem
        static int CycleCount(int num)
        {
            int n = num;
            int count = 1;
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                count++;
            }
            return count;
        }

        //This finds the the max cycle out of a range of numbers
        static int MaxCycleCount(int ax, int ay)
        {
            int x = ax;
            int y = ay;
            int max = 0;
            while (x <= y)
            {
                if(max <= CycleCount(x))
                {
                    max = CycleCount(x);
                }
                x++;
            }
            return max;
        }
    }
}
