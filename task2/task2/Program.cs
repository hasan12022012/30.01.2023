using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş qiymət dəyəri 64-dən böyük olarasa console-da "məzun oldunuz",
            //əks halda "məzun olmadınız" yazdırsan proqram. Qiymət dəyərini console-dan qəbul edin (Readline ilə).
            //Qiymət dəyəri 0-100 aralığında olmalıdır, 0-dan kiçin və ya 100-dən böyük dəyər daxil edələrsə
            //yenidən daxil edilməsi istənilsin proqram tərəfindən.

            Console.WriteLine("TopladiginizBaliDaxilEdin");
            string input = Console.ReadLine();
            var num = Convert.ToInt32(input);

            while (num < 0 || num > 100)
            {
                Console.WriteLine("TopladiginizBaliYenidenDaxilEdin");
                input = Console.ReadLine();
                num = Convert.ToInt32(input);
            }

            if (num > 64)
            {
                Console.WriteLine("MezunOldunuz");
            }

            else
                Console.WriteLine("MezunOlmadiniz");
        }
    }
}
