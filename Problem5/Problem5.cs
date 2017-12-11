using System;

namespace ProjectEuler.Problem5
{
    public class Problem5
    {
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