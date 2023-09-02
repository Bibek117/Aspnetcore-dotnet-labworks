using System;
namespace lab_dotnet
{
 //declaring delegates 
 public delegate void AddDelegate(int x, int y);
 public delegate string GreetingDelegate(string str);
 class DelegateDemo
 {
 public void AddNumbers(int a, int b)
 {
 Console.WriteLine("\t sum = "+ (a+b));
 }
 public static string Greeting(string name)
 {
 return "\t Hello "+ name + ", Namaste!";
 }
 static void Main(string[] args)
 {
 DelegateDemo dd = new DelegateDemo();
 //creating delegate instances 
 //setting target methods
 AddDelegate ad = new AddDelegate(dd.AddNumbers);
 GreetingDelegate gd = Greeting;
 //invoking delegates 
 ad.Invoke(50,100);
 string msg = gd("Bibek Angdembe");
 Console.WriteLine(msg);
 }
 }
}
