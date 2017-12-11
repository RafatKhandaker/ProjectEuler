using System;

namespace ProjectEuler.Problem5
{
    public class Problem5
    {
        // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        //
        // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        public static void Solve()
        {
            var i = 40;
            while (true)
            {
                if (IsDivBy1To20(i))
                {
                    Console.WriteLine($"The answer is {i}.");
                    break;
                }
                i += 20;
            }
        }

        private static bool IsDivBy1To20(int n)
        {
            for (var i = 1; i <= 20; i++)
            {
                if (n % i != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}