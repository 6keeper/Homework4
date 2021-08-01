using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 200;
            while (Num<500)
            {
                Num++;
                if (Num%17 == 0)
                {
                    Console.Write($"{Num}, ");
                }
            }
        }
    }
}
