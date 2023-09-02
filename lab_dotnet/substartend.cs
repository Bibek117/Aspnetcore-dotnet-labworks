using System;

namespace lab_dotnet
{
    class SubStrStartEnd
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter the substring to check at the beginning: ");
            string startSubstring = Console.ReadLine();

            Console.Write("Enter the substring to check at the end: ");
            string endSubstring = Console.ReadLine();

            bool startsWithSubstring = input.StartsWith(startSubstring);
            bool endsWithSubstring = input.EndsWith(endSubstring);

            Console.WriteLine($"Does the string start with '{startSubstring}'? {startsWithSubstring}");
            Console.WriteLine($"Does the string end with '{endSubstring}'? {endsWithSubstring}");

            Console.WriteLine("Lab No.: 4.c  Roll no: 23957 \n Name:Bibek Angdembe");

        }
    }
}
