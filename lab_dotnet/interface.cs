using System;
namespace lab_dotnet
{
    using System;
    public interface Drawable // Drawable is an interface
    {
        void Draw();
    }
    public class Rectangle1 : Drawable //implementing interface by a class
    {
        public void Draw() //implementing interface method
        {
            Console.WriteLine("Drawing rectangle...");
        }
    }
    public class Circle1 : Drawable
    {
        public void Draw() //implementing interface method
        {
            Console.WriteLine("Drawing circle...");
        }
    }
    public class TestInterface
    {
        public static void Main()
        {
            Drawable d;
        d = new Rectangle1();
            d.Draw();
            d = new Circle1();
            d.Draw();
            Console.WriteLine("Lab No.: 8.b  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}