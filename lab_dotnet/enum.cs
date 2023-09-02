using System;

namespace lab_dotnet
{
    class Program1
    {
        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            DaysOfWeek today = DaysOfWeek.Wednesday;

            Console.WriteLine($"Today is {today}");
            Console.WriteLine("Lab No.: 9.b \n Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}
