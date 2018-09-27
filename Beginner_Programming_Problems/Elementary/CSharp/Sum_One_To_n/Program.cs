using System;

namespace Sum_One_To_n
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pick a number: ");

            int num;
            string tNum = Console.ReadLine();
            num = Convert.ToInt32(tNum);
            //the top three lines could also be written as
            //int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for(int i = 1;i <= num;i++)
            {
                sum +=i; //this is same as sum = sum + i
            }

            Console.WriteLine($"{sum}");
        }
    }
}
