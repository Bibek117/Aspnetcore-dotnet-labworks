using System;
namespace lab_dotnet
{
    public class Animal
    {
        public void Makesound()
        {
            Console.WriteLine("Animal makes sound..");
        }
    }
    public class Dog : Animal
    {
        public void Barksound()
        {

            Console.WriteLine("Dog barking..");
            base.Makesound();
        }
    }
    public class TestSound
    {
        static void Main()
        {
            Dog d = new Dog();
            d.Barksound();

            Console.WriteLine("Lab No.: 6.b  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}