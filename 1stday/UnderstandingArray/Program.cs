using System;

namespace UnderstandingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[4];
            int counter = 0;
            string strChoice = "";
            do
            {

                strChoice = Console.ReadLine();
                words[counter] = strChoice;
                counter++;
                //Console.WriteLine(strChoice);
            } while (strChoice!="No" && counter<4);
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            //Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
