using System;

namespace lab_dotnet
{
    public class Birds
    {
        public string color = "black";
    }
    public class sparrow : Birds
    {
        string color = "Grey";
        public void display()
        {
            Console.WriteLine("The color of parent class is {0}", base.color);     //parent class 
            Console.WriteLine("The color of parent class is {0}", color);       //child class
        }
    }
    public class Testbirds
    {
        static void Main(string[] args)
        {
            sparrow sp = new sparrow();
            sp.display();

            Console.WriteLine("Lab No.: 6.a  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}