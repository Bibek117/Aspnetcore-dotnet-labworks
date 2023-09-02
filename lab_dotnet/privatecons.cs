using System;
namespace lab_dotnet
{
    class Counter
    {
        private Counter() { }
        public static int cnt;
        public static int IncrementCount()
        {
            return ++cnt;
        }
    }
    class TestCounter
    {
        static void Main(string[] args)
        {
            // If you uncomment the following statement, it willgenerate
            // an error because the constructor is inaccessible:
            // Counter aCounter = new Counter(); // Error
            Counter.cnt = 200;
            Counter.IncrementCount();
            Console.WriteLine("Now the value of cnt = {0}", Counter.cnt);
            Console.WriteLine("Lab No.: 1.e  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}