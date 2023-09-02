using System;
using System.IO;
using System.Text;
namespace lab_dotnet
{
    class WriteFile
    {
        static void Main(string[] args)
        {
            string myfilepath = @"test.txt";
            FileStream f = new FileStream(myfilepath, FileMode.OpenOrCreate);
            Console.WriteLine("File is created and contents are being written");
            f.WriteByte(65);//writing multiple bytes 
            f.WriteByte(10);//newline
            for (int i = 65; i <= 90; i++)
            {
                f.WriteByte((byte)i);
                f.WriteByte(32);//space
            }
            //converting string into byte array and writing to file
            string msg = "\nWhat's Up!!";
            byte[] byteArrayOfMsg = new UTF8Encoding(true).GetBytes(msg);
            f.Write(byteArrayOfMsg);
            Console.WriteLine("File writing completed");
            f.Close();//closing stream 
            Console.WriteLine("Lab No.: 13.b  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}