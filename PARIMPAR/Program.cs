
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class PARIMPAR
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre com um numero inteiro");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("PAR!");





            }
            else
            {
                Console.WriteLine("IMPAR!");
            }
        }
    }
}