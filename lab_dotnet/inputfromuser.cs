using System;

namespace lab_dotnet
{
    class InputFromUSER
    {
        static void Main()
        {
            string filePath = @"inputfromuser.txt"; 

            Console.WriteLine("Enter text to write to the file (press Enter on an empty line to finish):");

            // Collect user input and write it to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string userInput;
                do
                {
                    userInput = Console.ReadLine();
                    writer.WriteLine(userInput);
                } while (!string.IsNullOrEmpty(userInput));
            }

            Console.WriteLine("File written successfully!");
            Console.WriteLine("Lab No.: 13.f  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}