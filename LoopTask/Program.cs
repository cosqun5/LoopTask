using System;

namespace LoopTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin:");
            int a = int.Parse(Console.ReadLine());
            if (a > 10 && a < 20)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("Eded cutdur");
                }
                else
                {
                    Console.WriteLine("Eded tekdir");
                }
            }
            else
            {
                Console.WriteLine("Eded 10-20 aralığına daxil deyil. ");
            }

        }
    }
}
