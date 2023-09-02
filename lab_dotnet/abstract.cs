using System;
namespace lab_dotnet{
    public abstract class ParentShape //abstract class
    {
        public abstract void Draw(); // abstract method
    }
    public class Rectangle : ParentShape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circ : ParentShape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
    public class TestAbstract
    {
        public static void Main(string[] args)
        {
            ParentShape s;
            s = new Rectangle();
            s.Draw();
            s = new Circ();
            s.Draw();
        }
    }
}
