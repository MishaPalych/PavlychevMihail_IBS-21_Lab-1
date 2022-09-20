using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a, b;
            Console.Write("vvedite first chislo");
            if (byte.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("vvedite second chisli");
                if (byte.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine($"операция и: {a & b}");
                    Console.WriteLine($"операция или: {a | b}");
                    Console.WriteLine($"операция исключающее или и: {a ^ b}");
                }
                else
                {
                    Console.WriteLine("Neverniy vvod dannih");
                }
            }
            else
            {
                Console.WriteLine("Neverniy vvod dannih");
            }
        }
    }
}
