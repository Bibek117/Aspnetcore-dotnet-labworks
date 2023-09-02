using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace lab_dotnet
{
    public delegate int SqDelegate(int num);
    public delegate void HloDelegate(string name);
    class LamdaExpression
    {
        static void Main(string[] args)
        {
            LamdaExpression le = new LamdaExpression();
            //statement lamda
            HloDelegate hd = (name) =>
            {
                string msg = "Hello " + name + " What's Up!";
                Console.WriteLine(msg);
            };
            hd("Bibek");

            //expression lamda
            SqDelegate sd = (num) => num * num;
            int sqr = sd(9);
            Console.WriteLine("Square of 9 is " + sqr);
            Console.WriteLine("Lab No.: 12.a  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}