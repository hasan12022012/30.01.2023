using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        { // Verilmiş 3 ədədən ən böyüyünü tapan proqram

            Console.WriteLine("1ciEdediDaxilEdin");
            string input1 = Console.ReadLine();
            var num1=Convert.ToInt32(input1);

            Console.WriteLine("2ciEdediDaxilEdin");
            string input2= Console.ReadLine();
            var num2=Convert.ToInt32(input2);

            Console.WriteLine("3cuEdediDaxilEdin");
            string input3= Console.ReadLine();  
            var num3=Convert.ToInt32(input3);


            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1Boyukdur");
            }

            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("num2Boyukdur");
            }

            else if (num3 > num2 && num3 > num1)
            {
                Console.WriteLine("num3Boyukdur");
            }

            else
            {
                Console.WriteLine("boyukEdedYoxdur");
            }
                   
            

           
            


            

           

                
           


           


            


            
            
          

            

        }
    }
}
