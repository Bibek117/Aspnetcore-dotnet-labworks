using System;
namespace lab_dotnet

{
    class GenericMethod<T>
    {
        private T[] data = new T[10];
        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                data[index] = item;
        }
        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return data[index];
            else
                return default(T);
        }
    }
    class TestGenericMethod
    {
        static void Main(string[] args)
        {
            GenericMethod<string> cities = new GenericMethod<string>();
            cities.AddOrUpdate(0, "Kathmandu");
            cities.AddOrUpdate(1, "Pokhara");
            cities.AddOrUpdate(2, "Bhaktapur");

            Console.WriteLine(cities.GetData(0));
            GenericMethod<int> empIds = new GenericMethod<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);
            Console.WriteLine(empIds.GetData(1));

            Console.WriteLine("Lab No.: 12.c  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}