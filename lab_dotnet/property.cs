using System;
namespace lab_dotnet
{
    class Circle
    {
        double _radius = 5.3; // private field
        public double Radius //property
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
    }
class TestCircle
    {
        static void Main(string[] args)
        {
            Circle firstCircle = new Circle();
            double oldRadius = firstCircle.Radius; // getting value using property
            Console.WriteLine("Old Radius of the First Circle = " + oldRadius);
            firstCircle.Radius = 5.6;//seetting value using property
            double newRadius = firstCircle.Radius;
            Console.WriteLine("New Radius of the First Circle = " + newRadius);
            Console.WriteLine("Lab No.: 2  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}
