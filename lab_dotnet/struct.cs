using System;

namespace lab_dotnet
{
    struct Point
    {
        public int X;
        public int Y;
    }

    class ProgramTest
    {
        static void Main(string[] args)
        {
            Point p;
            p.X = 5;
            p.Y = 10;

            Console.WriteLine($"Point coordinates: X = {p.X}, Y = {p.Y}");
            Console.WriteLine("Lab No.: 9.a  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}
