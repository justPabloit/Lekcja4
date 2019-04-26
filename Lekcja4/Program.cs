using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja4
{
    class Program
    {
        static void Main(string[] args)
        {
            // PĘTLE |WHILE|FOR|DO WHILE

            //WHILE
            int a = 0;

            while (a < 5)
            {
                Console.WriteLine(a);
                Console.WriteLine("Tekst");
                a++;
            }

            //FOR
            for (int b = 0; b < 5; b++)
            {
                Console.WriteLine(b);
                Console.WriteLine("Tekst");
            }
            Console.WriteLine();
            Console.ReadKey();

            //DO WHILE

            do
            {
                Console.WriteLine("Tekst");
            } while (false);

        }
    }
}
