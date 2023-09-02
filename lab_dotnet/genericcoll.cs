using System;
using System.Collections.Generic;
namespace lab_dotnet
{
    public class GenericTest
    {
        public static void Main(string[] args)
        {
            // Create a List of strings
            List<string> li = new List<string>();

            // Add elements to the List
            li.Add("Apple");
            li.Add("Ball");
            li.Add("Cat");

            // Access elements in the List
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Lab No.: 11.b \n Roll no: 23957 \n Name:Bibek Angdembe");
        
    }
    }
}