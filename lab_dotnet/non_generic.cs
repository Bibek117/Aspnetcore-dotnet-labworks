using System;
using System.Collections;
namespace lab_dotnet
{
    public class NonGeneric
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            Console.WriteLine("-------lets Add numbers-------");
            al.Add(10);
            al.Add(56);
            al.Add(33);

            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);

            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("Lab No.: 11.a  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}