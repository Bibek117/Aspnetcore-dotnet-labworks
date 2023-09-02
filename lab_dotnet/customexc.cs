using System;

namespace lab_dotnet
{
    // Custom exception class
    class MyCustomException : Exception
    {
        public MyCustomException(string message) : base(message)
        {
        }
    }

    class Program5
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MyCustomException("This is a custom exception.");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
            Console.WriteLine("Lab No.: 16.c  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}
