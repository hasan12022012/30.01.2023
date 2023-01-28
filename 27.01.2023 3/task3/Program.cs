using System;
using System.Globalization;
using System.Xml;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədələr siyahısında mənfi ədəd olub olmadığını tapan proqram

            int[] numbers = new int[] { 15, -3, 4, 10 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    Console.WriteLine("mwnfiEdedVar");
                }
                else;
                {
                    Console.WriteLine("menfiEdedYoxdu");
                }







            }
        }
    }   }
