using System;

namespace ProjectEuler.Problem3
{
    public class Problem3
    {
        // The prime factors of 13195 are 5, 7, 13 and 29.
        // 
        // What is the largest prime factor of the number 600851475143 ?
        public static void Solve()
        {
            const long target = 600851475143;
            Console.WriteLine(LargestPrimeFactor(target));
        }

        private static long LargestPrimeFactor(long n)
        {
            for (var i = 3; i < Math.Sqrt(n); i++)
            {
                if (n % i != 0) continue;
                n /= i;
                i--;
            }
            return n;
        }
    }
}