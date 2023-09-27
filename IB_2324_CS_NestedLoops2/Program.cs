using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB_2324_CS_NestedLoops2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compound Triangles");

            Console.WriteLine("Pyramid 1 (3 for loops)");

            for(int x = 1; x < 11; x++)
            {
                for(int y = 10 - x; y > 0; y--)
                {
                    Console.Write("-");
                }
                for (int y = 1; y < x * 2; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pyramid 2 (4 for loops)");

            for (int x = 1; x < 11; x++)
            {
                for (int y = 10 - x; y > 0; y--)
                {
                    Console.Write("-");
                }
                for (int y = 0; y < x; y++)
                {
                    Console.Write("*");
                }
                for (int y = 1; y < x; y++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Reverse Pyramid 1 (3 for loops)");

            for (int x = 1; x < 11; x++)
            {
                for (int y = x - 1; y > 0; y--)
                {
                    Console.Write("-");
                }
                for (int y = (10 - x) * 2; y >= 0; y--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Reverse Pyramid 2 (4 for loops)");

            for (int x = 1; x < 11; x++)
            {
                for (int y = x - 1; y > 0; y--)
                {
                    Console.Write("-");
                }
                for (int y = 10 - x; y >= 0; y--)
                {
                    Console.Write("*");
                }
                for (int y = 10 - x; y > 0; y--)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();

        }
    }
}
