using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite pervyu storoni");
            if ((float.TryParse(Console.ReadLine(), out float a)) && (float.TryParse(Console.ReadLine(), out float b)))
            {
                if (a <= 0 || b <= 0)
                    Console.WriteLine("Neverniy vvod");
                else
                    Console.WriteLine("Ploshad: " + a * b);
            }
            else
                Console.WriteLine("Neverniy vvod dannih");
        }
    }
}
