using System;

namespace ProjectEuler.Problem4
{
    public class Problem4
    {
        // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        //
        // Find the largest palindrome made from the product of two 3-digit numbers.
        public static void Solve()
        {
            var result = 0;
            for (var i = 999; i > 1; i--)
            {
                for (var j = 999; j > 1; j--)
                {
                    if (IsPalindrome(Convert.ToString(i * j)) && (i * j) > result)
                    {
                        result = i * j;
                    }
                }
            }
            Console.WriteLine($"The answer is {result}.");
        }

        private static bool IsPalindrome(string str)
        {
            var reversedString = str.ToCharArray();
            Array.Reverse(reversedString);
            return str.Equals(new string(reversedString));
        }
    }
}