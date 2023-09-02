using System;
namespace lab_dotnet
{
    internal class ArrayOne
    {
        static void Main(string[] args)
        {
            string[] words = new string[10];

            Console.WriteLine("Enter ten words:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Word {i + 1}: ");
               // words[i] = Console.ReadLine();
            }

            Array.Sort(words);

            Console.WriteLine("\nWords in ascending order:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}