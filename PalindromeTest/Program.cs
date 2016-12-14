using System;
using System.Collections.Generic;
using System.Linq;

namespace PalindromeTest
{
    public class Program
    {
        /// <summary>
        /// Accept a string from windows console and display a message
        /// </summary>
        public static void Main(string[] args)
        {
            Program test = new Program();

            string s = "";
            Console.WriteLine("Enter string");
            s = Console.ReadLine();

            test.IsAnagramOrPalindrome(s);

            Console.ReadKey();
        }

        /// <summary>
        /// Analyse the string is whether a palindrome, an anagram of a palindrome or neither
        /// </summary>
        /// <param name="s">Input string</param>
        /// <returns>True if the input string is a palindrome or an anagram of a palindrome, else false</returns>
        public bool IsAnagramOrPalindrome(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            string backwards = new string(array);

            var charCount = s.GroupBy(c => c, (c, i) => new
            {
                character = c,
                count = i.Count()
            });

            if (s == backwards) // If the string is same as the reversed string
            {
                Console.WriteLine("Entered string {0} is a palindrome", s);
                return true;
            }
            else if (charCount.Count(c => c.count % 2 == 1) <= 1) //If the single character number of the string is 0 or 1
            {
                Console.WriteLine("Entered string {0} is an anagram of a palindrome", s);
                return true;
            }
            else
            {
                Console.WriteLine("Entered string {0} is neither a palindrome nor an anagram of a palindrome", s);
                return false;
            }

        }
    }
}
