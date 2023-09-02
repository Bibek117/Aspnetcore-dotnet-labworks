using System;
namespace lab_dotnet
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    class CircleShape : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a square");
        }
    }

    class DynamicPolymerphism
    {
        static void Main(string[] args)
        {
            Shape shape1 = new CircleShape();
            Shape shape2 = new Square();

            shape1.Draw(); // Output: Drawing a circle
            shape2.Draw(); // Output: Drawing a square
            Console.WriteLine("Lab No.: 7.b  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }

}