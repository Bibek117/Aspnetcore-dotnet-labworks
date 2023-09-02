using System;

namespace lab_dotnet
{
    public delegate void Notify(); // delegate
    public class Process
    {
        public event Notify ProcessCompleted; // event
        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            Console.WriteLine("processing ...");
            OnProcessCompleted(); //raises an even
        }
        protected virtual void OnProcessCompleted() //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke(); //'?.' is null-conditional operator
        }
    }
    public class EventDemo
    {
        public static void Main(string[] args)
        {
            Process pl = new Process();
            pl.ProcessCompleted += pl_ProcessCompleted; // register with an event
            pl.StartProcess();
            Console.WriteLine("Lab No.: 10.f  Roll no: 23957 \n Name:Bibek Angdembe");
        }
        // event handler
        public static void pl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }
    }
}