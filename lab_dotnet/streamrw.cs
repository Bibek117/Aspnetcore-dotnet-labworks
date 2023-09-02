using System;
using System.IO;
using System.Text;
namespace lab_dotnet
{
    class StreamReaderWriter
    {
        static void Main(string[] args)
        {
            string fpath = @"test2.txt";
            FileStream f1 = new FileStream(fpath, FileMode.OpenOrCreate);
            StreamWriter s1 = new StreamWriter(f1);
            s1.WriteLine("StreamReader and StreamWriter");
            s1.Close();
            f1.Close();
            FileStream f2 = new FileStream(fpath, FileMode.Open);
            StreamReader s2 = new StreamReader(f2);
            string data = s2.ReadLine();
            Console.WriteLine("The file is handle  through:");
            Console.WriteLine(data);
            s2.Close();
            f2.Close();
            Console.WriteLine("Lab No.: 13.d  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}