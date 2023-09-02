using System;
namespace lab_dotnet
{
     class Defaultconstructor
    {
        
        public Defaultconstructor()     //constructor
        {
            Console.WriteLine("default constructor is called here");
        }
        static void Main(string[] args)
        {
            Defaultconstructor dc = new Defaultconstructor();  
            Console.WriteLine("Lab No.: 1.a \n Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}