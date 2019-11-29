using System;

namespace Leetcode_PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int a = 121;
            if (solution.IsPalindrome(a))
            {
                Console.WriteLine($"Int {a} is palindrome");
            }
            else
            {
                Console.WriteLine($"Int {a} is not a palindrome");
            }
        }
    }

    public class Solution {
        public bool IsPalindrome(int x) {
            string s1 = x.ToString();
            char[] ca = s1.ToCharArray();

            Array.Reverse(ca);
            string s2 = ca.ToString();
        
            if (s1.CompareTo(s2) == 0)
            {
                return true;
            }
        
            else 
            {
                return false;
            }
        }
    }
}
