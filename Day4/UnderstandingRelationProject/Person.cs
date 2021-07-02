using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingRelationProject
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        int check;
        string phone;
        public string Phone
        {
            get
            {
                return phone.Substring(0, 5) + "*****";
            }
            set
            {
                phone = value;
            }
        }
        public int Check
        {
            get
            {
                return check;
            }
            set
            {
                check = value * 100;
            }
        }
        public void PrintCheck()
        {
            Console.WriteLine("check now is " + check);
        }
    }
}