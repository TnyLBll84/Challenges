using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MS_CS_Pt1.Strings
{
    internal class LeetCodeString
    {
        static void Main(string[] args)
        {
            //string output_1119 = RemoveVowels("leetcodeisacommunityforcoders");
            //Console.WriteLine(output_1119);

            //IList<int> output_2942 = FindWordsContaining(new string[] { "leet", "code" }, 'e');
            //Console.WriteLine(string.Join(",", output_2942));

            //int output_3541 = MaxFreqSum("aeiaeia");
            //Console.WriteLine(output_3541);

            //int output_771 = NumJewelsInStones("aA", "aAAbbbb");
            //Console.WriteLine(output_771);

            //string output_3280 = ConvertDateToBinary("2080-02-29");
            //Console.WriteLine(output_3280);

            //string output_2000 = ReversePrefix("abcdefd", 'd');
            //Console.WriteLine(output_2000);

            int output_2744 = MaximumNumberOfStringPairs(new string[] { "cd", "ac", "dc", "ca", "zz" });
            Console.WriteLine(output_2744);

        }

        //1119 Remove Vowels from a String
        static public string RemoveVowels(string s)
        {
            // Step 1: Create a list of vowels to remove from the string
            // These are the lowercase vowels: a, e, i, o, u
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            // Step 2: Find the first index of any vowel in the string 's'
            // IndexOfAny returns the index of the first character in 's' that matches any character in 'vowels'
            // If no vowels are found, it returns -1
            int index = s.IndexOfAny(vowels);

            // Step 3: Loop as long as there is a vowel in the string
            // Each time a vowel is removed, check again if there are more vowels
            while (index != -1)
            {
                // Step 4: Remove the vowel at position 'index'
                // Remove(index, 1) removes exactly one character from 's' starting at 'index'
                s = s.Remove(index, 1);

                // Step 5: Search for the next vowel in the updated string
                // This updates 'index' for the next iteration of the loop
                index = s.IndexOfAny(vowels);
            }

            // Step 6: Return the modified string with all vowels removed
            return s;
        }

        //2942 Find Words Containing Character
        static public IList<int> FindWordsContaining(string[] words, char x)
        {
            // Step 1: Create a new integer array to store results
            // - This array will hold the indexes (positions) of words that contain the character 'x'.
            int[] outPutArray = new int[0];

            // Step 2: Initialize a counter to keep track of how many words matched
            int count = 0;

            // Step 3: Loop through each word in the 'words' array using a 'for' loop
            // - 'index' starts at 0 (first word)
            // - Loop continues while 'index' is less than the total number of words
            // - 'index++' increases by 1 after each iteration
            for (int index = 0; index < words.Length; index++)
            {
                // Step 4: Check if the current word contains the character 'x'
                // - 'words[index]' gives us the current word
                // - '.Contains(x)' returns true if that word includes the character 'x'
                if (words[index].Contains(x))
                {
                    // Step 5: If the word contains 'x', resize the output array by 1
                    // - Array.Resize copies existing elements and adds space for one more element
                    Array.Resize(ref outPutArray, count + 1);

                    // Step 6: Store the current index in the output array
                    // - This tells us the position of the word that contains 'x'
                    outPutArray[count] = index;

                    // Step 7: Increase the counter since we just added a new element
                    count++;
                }
            }

            // Step 8: After the loop finishes, return the array of indexes
            // - This array shows which words in the original array contain the character 'x'
            return outPutArray;
        }

        //3541 Find Most Frequent Vowel and Consonant
        static public int MaxFreqSum(string s)
        {
            // Step 1: Create arrays of vowels and consonants
            // - These hold all the letters we'll check against later
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' }; // Vowels array
            char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n',
                      'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' }; // Consonants array

            // Step 2: Create arrays to store how many times each letter appears
            // - The length matches the number of letters in each group
            int[] vowelFreqs = new int[vowels.Length];      // Counts of vowels
            int[] conFreqs = new int[consonants.Length];   // Counts of consonants

            // Step 3: Convert the input string to lowercase
            // - This ensures 'A' and 'a' are treated the same
            s = s.ToLower();

            // Step 4: Loop through each character in the input string
            foreach (char c in s)
            {
                // Step 5: Check if the current character is a vowel
                // - Array.IndexOf returns the index of the character in the vowels array
                // - If the character is not found, it returns -1
                int vowelIndex = Array.IndexOf(vowels, c);

                if (vowelIndex > -1) // If the letter IS a vowel
                {
                    // Step 6: Increment (add +1) to that vowel's count
                    vowelFreqs[vowelIndex]++;
                }
                else
                {
                    // Step 7: If not a vowel, check if it’s a consonant
                    int conIndex = Array.IndexOf(consonants, c);

                    if (conIndex > -1) // If the letter IS a consonant
                    {
                        // Step 8: Increment that consonant’s count
                        conFreqs[conIndex]++;
                    }
                    // Step 9: If the character is neither a vowel nor consonant, do nothing
                    // - This ignores spaces, numbers, punctuation, etc.
                }
            }

            // Step 10: Sort both arrays in ascending order (smallest → largest)
            // - Array.Sort rearranges the elements from lowest to highest
            Array.Sort(vowelFreqs);
            Array.Sort(conFreqs);

            // Step 11: Reverse both arrays so they’re now in descending order
            // - After reversing, index 0 holds the highest frequency
            Array.Reverse(vowelFreqs);
            Array.Reverse(conFreqs);

            // Step 12: Add the highest vowel count + highest consonant count
            // - vowelFreqs[0] → the most frequent vowel
            // - conFreqs[0] → the most frequent consonant
            // - The result is the combined count of the most frequent vowel and consonant
            return vowelFreqs[0] + conFreqs[0];
        }

        //771. Jewels and Stones
        static public int NumJewelsInStones(string jewels, string stones)
        {
            // Step 1: Start a counter to track how many stones are also jewels
            int count = 0; // Initialize count to 0

            // Step 2: Loop through every character in the "stones" string
            // - Each character represents a stone you have
            foreach (char stone in stones)
            {
                // Step 3: Check if the current stone exists in the "jewels" string
                // - 'Contains' returns true if the stone is also a jewel
                if (jewels.Contains(stone))
                {
                    // Step 4: Increase the counter by 1 if the stone is a jewel
                    count++;
                }
            }

            // Step 5: Return the total number of stones that are jewels
            return count;
        }

        //3280. Convert Date to Binary
        static public string ConvertDateToBinary(string date)
        {
            // Step 1: Split the input string into 3 pieces
            // Substring(startIndex, length) extracts part of a string
            string year = date.Substring(0, 4);   // Take first 4 characters
            string month = date.Substring(5, 2);  // Take 2 characters starting at index 5
            string day = date.Substring(8, 2);    // Take 2 characters starting at index 8

            // Step 2: Convert each part to an integer and then convert that integer to binary
            // int.Parse(string) converts a string to an integer
            // Convert.ToString(number, 2) converts an integer to binary (base 2)
            string yearBinary = Convert.ToString(int.Parse(year), 2);   // year converted to binary
            string monthBinary = Convert.ToString(int.Parse(month), 2); // month converted to binary
            string dayBinary = Convert.ToString(int.Parse(day), 2);     // day converted to binary

            // Step 3: Return the date in binary format
            // $"{...}" is string interpolation, it inserts values directly into the string
            return $"{yearBinary}{monthBinary}{dayBinary}";  
        }

        //2000. Reverse Prefix of Word
        static public string ReversePrefix(string word, char ch)
        {
            // Step 1: Find the first occurrence of the character 'ch' in the word
            // - IndexOf returns the position of 'ch'
            // - If 'ch' is not in the word, IndexOf returns -1
            int index = word.IndexOf(ch);

            //// Step 2: Check if the character was not found
            //// - If IndexOf returned -1, we just return the original word
            //// - Nothing to reverse if the character does not exist
            //if (index == -1)
            //    return word;

            // Step 3: Get the part of the word from the start up to the found character
            // - word.Substring(0, index + 1) extracts characters from position 0 to 'index'
            // - .ToCharArray() converts the substring into an array of characters
            char[] wordPrefix = word.Substring(0, index + 1).ToCharArray();

            // Step 4: Reverse the prefix array
            // - Array.Reverse(wordPrefix) flips the order of characters
            Array.Reverse(wordPrefix);

            // Step 5: Combine reversed prefix with the remaining part of the word
            // - new string(wordPrefix) converts reversed char array back to string
            // - word.Substring(index) gets the rest of the word after the reversed part
            // - Concatenate them to get final result
            return new string(wordPrefix) + word.Substring(index +1);
        }

        //2744. Find Maximum Number of String Pairs
        static public int MaximumNumberOfStringPairs(string[] words)
        {
            // Step 1: Create a counter to store how many valid pairs we find
            int count = 0;

            // Step 2: Create a boolean array to remember which words have already been used in a pair
            bool[] paired = new bool[words.Length];

            // Step 3: Loop through every word in the array
            for (int index = 0; index < words.Length; index ++)
            {
                // Step 4: Skip this word if it was already paired earlier
                if (paired[index]) continue;

                // Step 5: Store the current word and also create its reversed version
                string current = words[index];
                string reverse = ReverseString(current);

                // Step 6: Start a second loop to compare the current word with all later words
                for (int remaining = index + 1; remaining < words.Length; remaining++)
                {
                    // Step 7: Check two things
                    // The second word has not been used yet
                    // The second word is equal to the reversed version of the current word
                    if (!paired[remaining] && words[remaining] == reverse)
                    {
                        // Step 8: A valid pair has been found
                        // Increase the counter
                        count++;

                        // Step 9: Mark both words as used
                        paired[index] = true;
                        paired[remaining] = true;

                        // Step 10: Stop checking more words for this current word
                        break;
                    }
                }
            }

            // Step 11: Return the total number of pairs found
            return count;
        }

        private static string ReverseString(string word)
        {
            // Step 1: Convert the string into an array of characters
            char[] wordArray = word.ToCharArray();

            // Step 2: Reverse the order of the characters
            System.Array.Reverse(wordArray);

            // Step 3: Build a new string from the reversed character array
            return new string(wordArray);
        }


    }
}
