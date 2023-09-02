using System;

namespace lab_dotnet
{
    class StrUpper
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Find the index of the first comma
            int commaIndex = input.IndexOf(',');

            if (commaIndex != -1)
            {
                // Extract the substring before the first comma
                string substringBeforeComma = input.Substring(0, commaIndex);

                // Convert the substring to upper case
                string uppercaseSubstring = substringBeforeComma.ToUpper();

                Console.WriteLine($"Substring before the first comma: {uppercaseSubstring}");
            }
            else
            {
                Console.WriteLine("No comma found in the input string.");
            }
            Console.WriteLine("Lab No.: 4.d  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}
