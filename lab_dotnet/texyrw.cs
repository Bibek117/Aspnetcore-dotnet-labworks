using System;
using System.IO;
using System.Text;
namespace lab_dotnet
{
    class TextReaderWriter
    {
        static void Main(string[] args)
        {
            string fpath = @"test1.txt";
            // Check file if exists
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            // Create the file
            using (TextWriter tw = File.CreateText(fpath))
            {
                tw.WriteLine("C# File Handling textReader and textWriter");
                tw.WriteLine("Its Intersting");
            }

            using (TextReader tr = File.OpenText(fpath))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
            Console.WriteLine("Lab No.: 13.c  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}