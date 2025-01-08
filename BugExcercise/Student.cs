using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugExcercise
{
    internal class Student
    {
        public string firstName;
        public string lastName;
        public int age;
        public int id;
        public string notes;

        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.notes = "";
            SetAge(age);
        }
        public Student()
        {
            this.firstName = "";
            this.lastName = "";
            this.age = 0;
            this.notes = "";
        }

        internal void PrintInformation()
        {
            // Print student info to console
            Console.WriteLine($"Etunimi: {this.firstName}, Sukunimi: {this.lastName}, Ikä {this.age}, huom: {this.notes} ");
            
        }

        public void SetAge(int age)
        {
            if (age < 18)
            {
                this.notes = "Tarkista opiskelijan ikä.";
            }

            this.age = age;        
        }

    }

}
