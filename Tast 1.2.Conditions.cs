using System;

namespace switch678
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0,x;
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                x = n % 10;
                n = n / 10;
                if (x % 2 != 1)
                    sum = sum + x;
            }
            Console.WriteLine(sum);
        }
    }
}

