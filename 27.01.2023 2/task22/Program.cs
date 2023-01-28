using System;

namespace task22
{
    internal class Program
    {
        static void Main(string[] args)
        { //Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan proqram

            int[] numbers = { 5, 3, 7, 25, 15, 49 }; 

            int enBoyuk = numbers[0]; 

           for (var i=0; i<numbers.Length; i++) 
            { 
            if (numbers[i] > enBoyuk) 
                {
                    enBoyuk = numbers[i];
                }
            }
           Console.WriteLine(enBoyuk);
        }
        
       
            
    }
}
