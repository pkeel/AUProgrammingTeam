using System;

namespace Sum_Mult_of_Three_or_Five
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pick a number: ");

            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for(int i = 1;i <= num;i++)
            {
                if(i%3 == 0 || i%5 == 0)
                {
                    sum +=i; //this is same as sum = sum + i
                }
                
            }

            Console.WriteLine($"{sum}");
        }
    }
}
