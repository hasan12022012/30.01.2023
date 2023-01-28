using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədədlər siyahısındaki 21-ə bölünən ədədlərin ədədi ortasını tapan proqram

            int[] numbers = new int[] { 21, 42, 63, 40, 84, 60 };

            double sum = 0;

            double count = 0;


            for (int i = 0; i < numbers.Length; i++)

                if (numbers[i] % 21 == 0)
                {
                    sum += numbers[i];
                    count++;
                }
            if (count == 0)
                Console.WriteLine("21eBolunenEdedYoxdur");

            else
                Console.WriteLine(sum / count);
        }
    }
}
