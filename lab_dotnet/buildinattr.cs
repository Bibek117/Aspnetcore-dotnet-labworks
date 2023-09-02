using System;
namespace lab_dotnet
{
    [Obsolete("This method is deprecated. Use NewMethod instead.")]
class AttrDemo
{
    [STAThread]
    static void Main(string[] args)
    {
        Console.WriteLine("Using a built-in attribute example.");
        Console.WriteLine("Lab No.: 17.a  Roll no: 23957 \n Name:Bibek Angdembe");
    }
}

}
