using System;
namespace lab_dotnet
{
    class Demo
    {
        static int count;
        public Demo()
        {
            Console.WriteLine("Hello from Instance Constructor");
            count++;
        }
        static Demo()
        {
            Console.WriteLine("Hello from Static Constructor");
            count = 100;
        }
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            Console.WriteLine("Hello from main");
            Console.WriteLine("value of count= " + count);
            Demo d2 = new Demo();
            Console.WriteLine("value of count= " + count);
            Console.WriteLine("Lab No.: 1.d  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}
