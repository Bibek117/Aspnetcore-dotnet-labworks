using System;
namespace lab_dotnet
{
    public class Student
    {

        int id;
        string name;

        //constructor 
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        //indexer 
        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return id;
                }
                else if (index == 1)
                {
                    return name;
                }

                return null;
            }
            set
            {
                if (index == 0)
                {
                    id = (int)value;
                }
                else if (index == 1)
                {
                    name = (string)value;
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
        }

    }

    class TestStudent
    {
        static void Main(string[] args)
        {
            Student S1 = new Student(4, "Bibek");
            Student S2 = new Student(15, "razz");

            //getting the detail of Student using indexer 
            Console.WriteLine("--------Detail of Student-----------");
            Console.WriteLine("Student ID : " + S1[0]);
            Console.WriteLine("Student Name : " + S1[1]);
            Console.WriteLine("Student Name : " + S2[1]);
            //change id 
            S1[0] = 10;
            Console.WriteLine("Updated Student ID of S1 : " + S1[0]);

            Console.WriteLine("Lab No.: 5.a  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }

}