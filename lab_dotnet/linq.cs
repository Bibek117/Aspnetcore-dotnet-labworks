using System;
using System.Linq;
using System.Text;

namespace lab_dotnet
{
     class LinqDemo
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 90, 92, 81, 60, 100 };

            //LINQ query expression
            var result1 = from scr in scores where scr > 80 select scr;

            //execute the query
            Console.WriteLine("scores greater than 80 are: ");
            foreach (int i in result1)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("Lab No.: 14  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}