using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            AnagramsAndPalindromes ap = new AnagramsAndPalindromes();
            
            Console.Write("Enter a word:");
            string word1 = Console.ReadLine();

            // There will be duplicates if a letter appears twice in a string, therefore, use distinct.
            IEnumerable<string> anagrams = ap.GenerateAnagrams(string.Empty, word1).ToList().Distinct();
            //IEnumerable<string> anagrams = ap.GeneratePermutations(0, word1.Length-1, word1).ToList();
            
            foreach (var v in anagrams)
            {
                Console.WriteLine(v);
               
            }

            foreach (var v in anagrams)
            {
                if (ap.IsPalindrome(v))
                {
                    Console.WriteLine(v + " is also a palindrome");
                }
            }
            Console.ReadLine();
        }

    }
}
