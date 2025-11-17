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

            int output_3541 = MaxFreqSum("aeiaeia");
            Console.WriteLine(output_3541);

            //int output_771 = NumJewelsInStones("aA", "aAAbbbb");
            //Console.WriteLine(output_771);

            //string output_3280 = ConvertDateToBinary("2080-02-29");
            //Console.WriteLine(output_3280);

            //string output_2000 = ReversePrefix("abcdefd", 'd');
            //Console.WriteLine(output_2000);

            //int output_2744 = MaximumNumberOfStringPairs(new string[] { "cd", "ac", "dc", "ca", "zz" });
            //Console.WriteLine(output_2744);

        }

        //1119 Remove Vowels from a String
        static public string RemoveVowels(string s)
        {
            // Create a list of vowels we want to remove from the string.
            // These are the lowercase vowels: a, e, i, o, u.
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            // Find the first index (position) of any vowel in the string 's'.
            // 'IndexOfAny()' returns the index of the *first* character found 
            // that matches any value in the 'vowels' array.
            // If no vowels are found, it returns -1.
            int index = s.IndexOfAny(vowels);

            // Loop as long as there’s still a vowel in the string.
            // Each time we remove a vowel, we check again to see if any remain.
            while (index != -1)
            {
                // Remove the vowel found at position 'index'.
                // 'Remove(index, 1)' removes exactly 1 character at that index.
                s = s.Remove(index, 1);

                // After removing, search again for the next vowel.
                // (This updates 'index' for the next loop iteration.)
                index = s.IndexOfAny(vowels);
            }

            // 6️⃣ Return the new version of the string with all vowels removed.
            return s;
        }

        //2942 Find Words Containing Character
        static public IList<int> FindWordsContaining(string[] words, char x)
        {
            // Create a new integer array to store results
            // This array will hold the indexes (positions) of words that contain the character 'x'.
            int[] outPutArray = new int[0];

            // Initialize a counter to keep track of how many words matched.
            int count = 0;

            // Loop through each word in the array using a 'for' loop.
            // - 'index' starts at 0 (first word)
            // - Loop continues while 'index' is less than the total number of words
            // - 'index++' increases by 1 after each loop
            for (int index = 0; index < words.Length; index++)
            {
                // Check if the current word contains the character 'x'
                // 'words[index]' gives us the current word
                // '.Contains(x)' returns true if that word includes the character we're searching for
                if (words[index].Contains(x))
                {
                    // If the word contains 'x', make room for a new element in the output array
                    // 'Array.Resize' increases the array size by one each time we find a match
                    Array.Resize(ref outPutArray, count + 1);

                    // Store the current index (position of the matching word) in the output array
                    outPutArray[count] = index;

                    // Increase the counter since we just added a new element
                    count++;
                }
            }

            // After the loop finishes, return the array of indexes
            // This list shows which words in the original array contain the character 'x'
            return outPutArray;
        }

        //3541 Find Most Frequent Vowel and Consonant
        static public int MaxFreqSum(string s)
        {
            // Create arrays of vowels and consonants
            // These hold all the letters we’ll check against later.
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n',
                          'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };

            // Create arrays to store how many times each letter appears.
            // The length matches the number of letters in each group.
            int[] vowelFreqs = new int[vowels.Length];
            int[] conFreqs = new int[consonants.Length];

            // Convert the input string to lowercase
            // This makes sure 'A' and 'a' are treated the same.
            s = s.ToLower();

            // Loop through each character in the input string
            foreach (char c in s)
            {
                // Check if the current character is a vowel
                int vowelIndex = Array.IndexOf(vowels, c);

                if (vowelIndex > -1) // if the letter IS a vowel
                {
                    // Increment (add +1) to that vowel’s count
                    vowelFreqs[vowelIndex]++;
                }
                else
                {
                    // If not a vowel, check if it’s a consonant
                    int conIndex = Array.IndexOf(consonants, c);

                    if (conIndex > -1) // if the letter IS a consonant
                    {
                        // Increment that consonant’s count
                        conFreqs[conIndex]++;
                    }
                }
            }

            // Sort both arrays in ascending order (smallest → largest)
            Array.Sort(vowelFreqs);
            Array.Sort(conFreqs);

            // Reverse both arrays so they’re now in descending order
            // (largest → smallest), so index 0 holds the highest frequency.
            Array.Reverse(vowelFreqs);
            Array.Reverse(conFreqs);

            // Add the highest vowel count + highest consonant count
            // vowelFreqs[0] → the most frequent vowel
            // conFreqs[0] → the most frequent consonant
            return vowelFreqs[0] + conFreqs[0];
        }

        //771. Jewels and Stones
        static public int NumJewelsInStones(string jewels, string stones)
        {
            return 0;
        }


        //3280. Convert Date to Binary
        static public string ConvertDateToBinary(string date)
        {
            return "";
        }

        //2000. Reverse Prefix of Word
        static public string ReversePrefix(string word, char ch)
        {
            return "";

        }

        //2744. Find Maximum Number of String Pairs
        static public int MaximumNumberOfStringPairs(string[] words)
        {
            return 0;
        }


    }
}
