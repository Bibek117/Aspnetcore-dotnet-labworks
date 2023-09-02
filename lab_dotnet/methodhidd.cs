using System;
namespace lab_dotnet
{
    public class MethodHide
    {
        public void Display()
        {
            Console.WriteLine("BaseClass method");
        }
    }

    class  MethodHidding: MethodHide
    {
        public new void Display()
        {
            Console.WriteLine("DerivedClass method");
        }
    }
    class Overhiding
    {
        static void Main(string[] args)
        {
            MethodHidding d = new MethodHidding();
            d.Display();
            Console.WriteLine("Lab No.: 7.a  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }

}