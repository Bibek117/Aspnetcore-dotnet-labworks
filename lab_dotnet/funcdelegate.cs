using System;

namespace lab_dotnet
{
    public class FuncDelegate
    {
        public static double AddNums(int x,float y,double z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj = AddNums;     //Func Delegate
            double result = obj.Invoke(18, 34.5f, 1928.789);
            Console.WriteLine("The Result is in double");
            Console.WriteLine("result :" + result);
            Console.WriteLine("Lab No.: 10.c \n Roll no: 23957 \n Name:Bibek Angdembe");
        }
}
}