using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert number");
            int Num = int.Parse(Console.ReadLine());
            if (Num>=0 & Num<=30)
            {
                Console.WriteLine("Your number is between 0 and 30");
            }
            else if (Num>30 & Num<=60)
            {
                Console.WriteLine("Your number is between 31 and 60");
            }
            else if (Num>60 & Num <=100)
            {
                Console.WriteLine("Your number is between 60 and 100");
            }
            else
            {
                Console.WriteLine("Unknown number");
            }
        }
    }
}
