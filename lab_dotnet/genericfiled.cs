using System;
namespace lab_dotnet
{
    internal class GenericField<T>
    {
        public void Add(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            T sum = x + y;
            Console.WriteLine("sum of {0} and {1} is {2}", a, b, sum);
        }
    }
    internal class GenericFieldTest
    {
        static void Main(string[] args)
        {
            GenericField<int> gtInt = new GenericField<int>();
            gtInt.Add(7, 4);

            GenericField<double> gtDb1 = new GenericField<double>();
            gtDb1.Add(7.8f, 6.5f);

            Console.WriteLine("Lab No.: 12.b  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }

}