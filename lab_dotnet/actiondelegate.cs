using System;
namespace lab_dotnet
{
    public class ActionDelegate
    {
        public static void AddNums(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        static void Main(string[] args)
        {
            Action<int, float, double> obj = AddNums;       //action delegate
            obj.Invoke(23, 4.56f, 970.8);
            Console.WriteLine("Lab No.: 10.d  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}