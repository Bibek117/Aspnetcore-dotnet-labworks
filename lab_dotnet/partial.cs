using System;

namespace lab_dotnet
{
    partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    partial class Person
    {
        public void PrintFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Doe";

            person.PrintFullName();

            Console.WriteLine("Lab No.: 9.c  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}
