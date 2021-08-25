/*For a given integer n calculate the value which is equal to a:
• squared number, if its value is strictly positive;
• modulus of a number, if its value is strictly negative;
• zero, if the integer n is zero.
Example,
n = 4 result = 16
n = -5 result = 5
n = 0 result = 0
*/


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


