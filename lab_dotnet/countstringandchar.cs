using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_dotnet
{
    class CountCharStr
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Count total number of characters
            int charCount = input.Length;
            Console.WriteLine($"Total number of characters: {charCount}");

            // Count total number of words
            string[] words = input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            Console.WriteLine($"Total number of words: {wordCount}");

            // Display occurrence of each word
            Dictionary<string, int> wordOccurrences = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordOccurrences.ContainsKey(word))
                {
                    wordOccurrences[word]++;
                }
                else
                {
                    wordOccurrences[word] = 1;
                }
            }

            Console.WriteLine("Occurrence of each word:");
            foreach (var kvp in wordOccurrences)
            {
                Console.WriteLine($"Word: '{kvp.Key}', Occurrences: {kvp.Value}");
            }
            Console.WriteLine("Lab No.: 4.b  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}
