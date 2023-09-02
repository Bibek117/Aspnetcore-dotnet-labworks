using System;
namespace lab_dotnet
{
    internal class Paramcons
    {
        string name;
        int roll;
        string lab;

        public Paramcons(string n, int a,string labno)       //parameterized constructor
        {
            name = n;
            roll = a;
            lab = labno;
        }
        public void display()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("roll : " + roll);
            Console.WriteLine("lab no : " + lab);
        }

        static void Main(string[] args)
        {
            Paramcons pc = new Paramcons("Bibek Angdembe", 23957,"1.b");
            pc.display();
        }
    }
}