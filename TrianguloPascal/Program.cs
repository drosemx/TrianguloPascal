using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace TrianguloPascal
{
    class Program
    {
      

        public static void Main()
        {
            int j, k, n, r;    /*   variables */
            int comb, h, i;


            Console.WriteLine("Hola Triangulo de Pascal");
            Console.ReadKey();
            Console.WriteLine("1");

            for (n = 1; n <= 7; n++)
            {
                Console.WriteLine("\n");
                for (r = 0; r <= 7; r++)
                {
                    h = factorial(n);
                    k = (n - r);
                    i = factorial(k);
                    j = factorial(r);
                    comb = h / (i * j);
                    if (comb == 0)
                        Console.Write(" ");
                    else
                    {
                        Console.Write(comb.ToString("g"));
                    }
                }
            }
            Console.ReadKey();
        }


         static  int factorial(int n)
         {
             int fact,c,a;
             //factorial   
             if (n == 0)
             {
                 fact = 1;
             }
             else
             {
                 fact = 1;
                 for (a = 1; a <= n; a++)
                     fact = fact * a;
             }
             c = fact;
             return c;
         }
      

    }
}
