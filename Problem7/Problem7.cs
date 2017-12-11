using System;

namespace ProjectEuler.Problem7
{
    public class Problem7
    {
        // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        //
        // What is the 10 001st prime number?
        public static void Solve()
        {
            var primeFound = 2;
            var number = 3;
            while (true)
            {
                if (IsPrime(number))
                {
                    if (primeFound == 10001)
                    {
                        Console.WriteLine($"The answer is {number}.");
                        break;
                    }
                    primeFound++;
                }
                number += 2;
            }
        }

        private static bool IsPrime(long n)
        {
            for (var i = 3; i < n / 2; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}