using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            int summa = 0;
            for (int i = 1; i <= n; i++)
            {
                if (((i % 3) == 0) || ((i % 5) == 0))
                {
                    Console.Write(' ');
                    Console.Write(i);
                    summa += i;
                    Console.Write(" sum=");
                    Console.WriteLine(summa);
                }
            }
        }
    }
}
