using System;

namespace UnderstandingArraysProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter the size of the array you wish to create");
            int length = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[length];
            int counter = 0;
            string strChoice = "";
            Console.WriteLine("Please enter the words and enter  No if you wish to exit.");
            Console.WriteLine($"You can enter teh maximum of {length} words");
            do
            {
                strChoice = Console.ReadLine();
                words[counter] = strChoice;
                counter++;

            } while (strChoice != "No" && counter <= words.Length);
            Console.WriteLine("You have entered teh following words");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.ReadKey();
        }
    }
}