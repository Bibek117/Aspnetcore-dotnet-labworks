using System;

namespace lab_dotnet
{
    class ThrowException
    {
        static void Main(string[] args)
        {
            try
            {
                int age = -5;

                if (age < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }

                Console.WriteLine("Age: " + age);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Lab No.: 16.b  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}
