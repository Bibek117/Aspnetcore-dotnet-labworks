using System;
namespace lab_dotnet
{
    class IndexersB
    {
        int id;
        string name;

        public IndexersB(int i, string n)           //parameterized constructor
        {
            id = i;
            name = n;

        }
        //indexer
        public object this[string inx]
        {
            get
            {
                if (inx == "id")
                {
                    return id;
                }
                else if (inx == "name")
                {
                    return name;
                }

                return null;
            }
            set
            {
                if (inx == "id")
                {
                    id = (int)value;
                }
                else if (inx == "name")
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
    class StudentStr
    {
        static void Main(string[] args)
        {
            IndexersB student1 = new IndexersB(82, "Ram");
            IndexersB Student2 = new IndexersB(23, "shyam");

            //getting values using indexer. 
            //Here string is passed as index 
            string name1 = (string)student1["name"];
            string name2 = (string)Student2["name"];

            Console.WriteLine("Name of student1 is {0}", name1);
            Console.WriteLine("Name of student2 is {0}", name2);

            Console.WriteLine("Lab No.: 5.b  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}