using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Remarks { get; set; }
        public string Phone { get; set; }

        public Patient()
        {

        }

        public Patient(int id, string name, int age, string gender, string remarks, string phone)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            Remarks = remarks;
            Phone = phone;
        }

        public override string ToString()
        {
            return "Id : " +Id +
                "\nName: " + Name +
                "\nAge :  " + Age +
                "\nGender:" + Gender +
                "\nPhone:"  + Phone +
                "\nComments:"+ Remarks;
        }
       public void takepatientdetails()
        {
            int id;
            Console.WriteLine("Enter the Patient ID");
            id = Convert.ToInt32(Console.ReadLine());


        }
    }
}
