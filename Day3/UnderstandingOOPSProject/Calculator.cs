
using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingOOPSProject
{
 
    class Calculator
    { 
        int num1, num2;//instance member

        
        void TakeInput()
        {
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
       
        public void Add()
        {
            TakeInput();
            int sum = num1 + num2;
            PrintResult(sum);
        }

        
        public void Multiply()
        {
            TakeInput();
            int product = num1 * num2;
            PrintResult(product);
        }

        void PrintResult(int result)
        {
            Console.WriteLine($"The result is {result}");
        }

       
        public Calculator()
        {
            num1 = 0;
            num2 = 0;
        }
    }
}