using System;
using System.IO;

namespace lab_dotnet
{
    class ContentToAnotherFile
    {
        static void Main()
        {
            string sourceFilePath = @"test3.txt";  // Path to the source file
            string destinationFilePath = @"test4.txt";     // Path to the destination file

            // Read the contents of the source file
            string[] fileLines = File.ReadAllLines(sourceFilePath);

            // Write the contents to the destination file
            File.WriteAllLines(destinationFilePath, fileLines);

            Console.WriteLine("File contents copied successfully!");
            Console.WriteLine("Lab No.: 13.e  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}