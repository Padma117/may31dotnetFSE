using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        int check;
        public int Check
        {
            get
            {
                return check;

            }

            set
            {
                check = value;
            }
        }
        public void PrintCheck()
        {
            Console.WriteLine("Check is now :" + check);
        }


    }
}