using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePlanGroupTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AnagramsAndPalindromes ap = new AnagramsAndPalindromes();

            Console.Write("Enter first word:");
            string input1 = Console.ReadLine();

            Console.Write("Enter second word:");
            string input2 = Console.ReadLine();

            if (ap.IsAnagram(input1, input2))
            {
                Console.WriteLine(" \"{0}\" and \"{1}\" are Anagrams", input1, input2);
            } else
            {
                Console.WriteLine(" \"{0}\" and \"{1}\" are not Anagrams", input1, input2);
            }

            if (ap.IsPalindrome(input1))
            {
                Console.WriteLine(input1 + " is a Palindrome!");
            } else
            {
                Console.WriteLine(input1 + " is not a Palindrome!");
            }

            if (ap.IsPalindrome(input2))
            {
                Console.WriteLine(input2 + " is a Palindrome!");
            } else
            {
                Console.WriteLine(input2 + " is not a Palindrome!");
            }

            Console.ReadLine();
        }

    }
}




   
       
    

