using System;

namespace Blabla
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (n < 0)
                {
                    int x = n * -1;
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine(n*n);
                }
            }

        }
    }
}


