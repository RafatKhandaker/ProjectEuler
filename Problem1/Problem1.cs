using System;

namespace ProjectEuler.Problem1
{
    public static class Problem1
    {
        // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        //
        // Find the sum of all the multiples of 3 or 5 below 1000.
        public static void Solve()
        {
            const int target = 1000;
            var result = 0;
            for (var n = 0; n < target; n++)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    result += n;
                }
            }
            Console.WriteLine($"The answer is {result}.");
        }
    }
}