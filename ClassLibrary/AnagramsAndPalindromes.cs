using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public class AnagramsAndPalindromes
    {
        public IEnumerable<string> GenerateAnagrams(string start, string str)
        {
            if (str.Length <= 1)
                yield return start + str;
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    // Concatanate the string, get the letter for the current index. E.g. if the string is "cat", the first time loop runs str[i] would be "c"
                    // Get a range of letters using substring starting at 0 and upto the currect index, the first time the loop runs it should be ""
                    // Get the rest of the string starting with the next letter after the current index

                    str = str[i] + str.Substring(0, i) + str.Substring(i + 1);

                    // Recursion - calls to itself to get all the combinations
                    // Change the start to be the first letter of the string, so for example "c" instead of ""
                    // Pass in the remaining string to itself which starts from the second letter, e.g. "at"

                    // used yield so that can return a list item and
                    // it remembers the last position so that next time the loop runs it starts from the next position

                    foreach (var s in GenerateAnagrams(start + str[0], str.Substring(1)))
                        yield return s;
                }
            }

        }

        public IEnumerable<string> GenerateAnagramsNoYeild(string start, string str)
        {
            IEnumerable<string> permutations = new string[] { };
            if (str.Length <= 1)
                return null;
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    // Concatanate the string, get the letter for the current index. E.g. if the string is "cat", the first time loop runs str[i] would be "c"
                    // Get a range of letters using substring starting at 0 and upto the currect index, the first time the loop runs it should be ""
                    // Get the rest of the string starting with the next letter after the current index

                    str = str[i] + str.Substring(0, i) + str.Substring(i + 1);

                    // Recursion - calls to itself to get all the combinations
                    // Change the start to be the first letter of the string, so for example "c" instead of ""
                    // Pass in the remaining string to itself which starts from the second letter, e.g. "at"
                    permutations = GenerateAnagramsNoYeild(start + str[0], str.Substring(1));
                    //foreach (var s in GenerateAnagrams(start + str[0], str.Substring(1)))
                   
                }

                return permutations;
            }

        }

        public IEnumerable<string> GeneratePermutations(int start, int length, string str)
        {
            IEnumerable<string> permutations = new string[] { };
            if (start == length)
            {
                return null;
            }
            else
            {

                for (int i = start; i <= length; i++)
                {
                    str = Swap(str, start, i);
                    permutations = GeneratePermutations(start + 1, length, str);
                    str = Swap(str, start, i);
                    return permutations;
                }
                return permutations;
            }

            //swap
            //for loop and call to itself
            //swap
        }

        public string Swap(string str, int i, int j)
        {
            char temp;
            char[] c = str.ToCharArray();
            temp = c[i];
            c[i] = c[j];
            c[j] = temp;

            string s = new string(c);
            return s;
        }

        public bool IsPalindrome(string inputStr)
        {
            /*
             * Reverse the input string and if the input string and reversed string are the same then it's a Palindrome
             * For example, word "civic" and "madam"
            */

            char[] letter = inputStr.ToCharArray();
            Array.Reverse(letter);
            string r = new string(letter);

            if (inputStr.Equals(r, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsAnagram(string input1, string input2)
        {
            if (input1.Length != input2.Length)
            {
                return false;
            }

            char[] char1 = input1.ToLower().ToCharArray();
            char[] char2 = input2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string str1 = new string(char1);
            string str2 = new string(char2);

            if (str1 == str2)
            {
                return true;
            } else
            {
                return false;
            }
        }

    }
}
