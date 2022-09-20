using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite n: ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                int c = 1;
                int t = n;
                for (int i = 1; i <= t; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(' ');
                    }
                    for (int h = 0; h < c; h++)
                    {
                        Console.Write('*');
                    }
                    n = n - 1;
                    c += 2;
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Neverniy vvod dannih!");
            }
        }
    }
}
