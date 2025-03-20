using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOP
{
    public class Student
    {
        //Encapsulation
        private double grade;

        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;

                else throw new ArgumentException("Name cannot be empty");
            }
        }

        public double Grade
        {
            get { return grade; }
        }

        public Student(string name, double grade)
        {
            Name = name;
            this.grade = grade;
        }

        public void ShowGraduationStatus() 
        {
            if (grade >= 70)
            {
                Console.WriteLine($"{Name} has graduated with a First Class");
            }

            else if (grade >= 60)
            {
                Console.WriteLine($"{Name} has graduated with a Second Class Upper");
            }

            else if (grade >= 50)
            {
                Console.WriteLine($"{Name} has graduated with a Second Class Lower");
            }

            else if (grade >= 45)
            {
                Console.WriteLine($"{Name} has graduated with a Third Class");
            }

            else
            {
                Console.WriteLine($"{Name} has failed");
            }
        }

        //Method to show student details
        public void ShowStudentDetails()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Grade: {grade}");
           
            Console.WriteLine();
        }

        
        //Method to Update grade
        public void UpdateGrade(double newGrade)
        {
            if(newGrade >= 0 && newGrade <= 100)
            {
                grade = newGrade;
                Console.WriteLine($"{Name}'s grade has been updated to {grade}");
            }

            else
            {
                Console.WriteLine("Invalid! Grade must be between 0 and 100");
            }
        }
        
    }
}
