using System;
namespace lab_dotnet
{
    public delegate void RectDelegate(double length, double breadth);
    class Rect
    {
        public void GetArea(double length, double breadth)
        {
            string result = $"Area of Rectangle = {length * breadth}";
            Console.WriteLine(result);
        }
        public void GetPerimeter(double length, double breadth)
        {
            string result = $"Perimeter of Rectangle = {2 * (length + breadth)}";
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Rect rectangle = new Rect();
            RectDelegate rd1 = rectangle.GetArea;
            RectDelegate rd2 = rectangle.GetPerimeter;
            RectDelegate rd = rd1 + rd2;//cobines rd1 and rd2
            rd.Invoke(34.45, 23.54); //calls both delagates 
            rd -= rd1;//removes rd1 
            Console.WriteLine("------------------------------------");
            rd.Invoke(112.5, 104.7);//calls only rd2

            Console.WriteLine("Lab No.: 10.b  Roll no: 23957 \n Name:Bibek Angdembe");
        }

    }
}
