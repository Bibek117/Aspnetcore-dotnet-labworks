using System;
using System.IO;

namespace lab_dotnet
{
    class BinaryReadWrite
    {
        static void Main(string[] args)
        {
            // Getting the directory where the executable is located
            string exeDir = AppDomain.CurrentDomain.BaseDirectory;

            // Combining the executable directory with the text file name
            string FilePath = Path.Combine(exeDir, "test.txt");

            int v1 = 45;
            int v2 = 67;

            using (BinaryWriter bw = new BinaryWriter(File.Open(FilePath, FileMode.Create)))
            {
                bw.Write(v1);
                bw.Write(v2);
            }

            using (BinaryReader br = new BinaryReader(File.Open(FilePath, FileMode.Open)))
            {
                int a = br.ReadInt32();
                int b = br.ReadInt32();
                Console.WriteLine("First value is {0} Second Value is {1}", a, b);
            }

            Console.WriteLine("Lab No.: 13.a  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}
