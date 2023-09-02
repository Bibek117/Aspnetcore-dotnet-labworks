using System;

namespace lab_dotnet
{
    interface Printable
    {
        void Print();
    }
    interface Drawable1
    {
        void Draw();
    }

    public class Test : Printable, Drawable1 // multiple inheritance 
    {
        public void Print()
        {
            Console.WriteLine("Printing");
        }
        public void Draw()
        {
            Console.WriteLine("Drawing");
        }
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.Draw();
            t1.Print();
            Console.WriteLine("Lab No.: 8.c  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }

}
