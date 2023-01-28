using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədədin rəqəmləri cəmini tapan proqram

            Console.WriteLine("EdediDaxilEdin");
            string input = Console.ReadLine();
            var number = Convert.ToInt32(input);


            var sum = 0;

            while (number != 0)
            {
                int qaliq = number % 10;
                number = number / 10;
                sum += qaliq;

            }
            Console.WriteLine(sum);
        }
    }
}
