using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite n: ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write(' ');
                    }
                    Console.WriteLine('#');
                    int c = 1;
                    int t = i;
                    int y = n;
                    for (int g = 1; g <= t; g++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            Console.Write(' ');
                        }
                        for (int h = 0; h < c; h++)
                        {
                            Console.Write('*');
                        }
                        y = y - 1;
                        c += 2;
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Neverniy vvod dannih!");
            }
        }
    }
}
