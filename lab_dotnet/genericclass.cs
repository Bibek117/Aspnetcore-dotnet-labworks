using System;
namespace lab_dotnet
{
    class DataStore<T>
    {
        public T Data { get; set; }
    }


    class GenericsClassDemo
    {
        static void Main(string[] args)
        {
            DataStore<string> strStore = new DataStore<string>();
            strStore.Data = "Hello I am Bibek";
            //strStorage.Data = 123; // compile-time error
            Console.WriteLine(strStore.Data);

            Console.WriteLine("Lab No.: 12.a  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}