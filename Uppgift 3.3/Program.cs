using System;
namespace Uppgift3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra en bil?");
            int timmar = int.Parse(Console.ReadLine());
            int summa = timmar * 80;
            if (summa >= 950)
            {
                Console.WriteLine("Det kommer att kosta dig 950kr");
            }
            else
            {
                Console.WriteLine("Det kommer att kosta dig " + summa + "kr.");
            }
            Console.ReadKey();
        }
    }
}