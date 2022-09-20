using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite pervyu storoni");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                for (int i = 1; i <= a; i++)
                {
                    for (int g = 0; g < i; g++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Neverniy vvod dannih");
        }
    }
}
