using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float st1, st2, st3;
            Console.Write("vvedite first storonu");
            if (float.TryParse(Console.ReadLine(), out st1))
            {
                Console.Write("vvedite second storonu");
                if (float.TryParse(Console.ReadLine(), out st2))
                {
                    Console.Write("vvedite third storonu");
                    if ((float.TryParse(Console.ReadLine(), out st3) && ((st1 + st2) > st3) && ((st2 + st3) > st1) && ((st1 + st3) > st2)))
                    {
                        float p = 0;
                        p = (st1 + st2 + st3) / 2;
                        Console.WriteLine(Math.Sqrt(p * (p - st1) * (p - st2) * (p - st3)));

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
            else
            {
                Console.WriteLine("Neverniy vvod dannih");
            }
        }
    }


}
