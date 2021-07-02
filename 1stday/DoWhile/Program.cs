using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            num1 = 100;
            num2 = 200;
            sum = num1 + num2;
            Console.WriteLine("The sum is "+sum);
            Console.WriteLine($"The {sum} is",sum);
            Console.WriteLine("The sum is {0}",+sum);
            if(num1==num2)
                Console.WriteLine("The number is Equal");
            else if(num2>num1)
            Console.WriteLine("num2 is greater");
            else
                Console.WriteLine("num1 is greater");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            int abc = 0;
            while (abc<10)
            {
                Console.WriteLine(abc);
                abc = abc + 1;

            }
            Console.WriteLine("Hello World!");
        }
    }
}
