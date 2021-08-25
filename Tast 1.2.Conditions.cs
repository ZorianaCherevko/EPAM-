/*Find the maximum integer, that can be obtained by permutation of
numbers of an arbitrary three-digit positive integer n (100<=n<=999).
Example,
n =165 result = 651
*/


using System;

namespace switch678
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = n % 100;

            int a = (n - x) / 100;
            int c = x % 10;
            int b = (n - (n - x) - c) / 10;

            int max3 = Math.Max(a, Math.Max(b, c));
            int min3 = Math.Min(a, Math.Min(b, c));

            int median = a;
            if (a < b && a < c)
            {
                median = Math.Min(b, c);
            }
            if (a > b && a > c)
            {
                median = Math.Max(b, c);
            }
            return int.Parse($"{max3}{median}{min3}");

        }
    }
}

