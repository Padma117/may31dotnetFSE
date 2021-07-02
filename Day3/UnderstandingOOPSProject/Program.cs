using System;

namespace UnderstandingOOPSProject
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("Program class constructor");
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Add();
            Console.WriteLine("Hello World!");
        }
    }
}
