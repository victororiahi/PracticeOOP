using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOP
{
    public class PostGraduate : Student
    {
        public PostGraduate(string name, double grade) : base(name, grade)
        {
            
        }

        public void ShowThesisStatus()
        {
            Console.WriteLine($"{Name} is a Post Graduate student researching on their thesis.");
        }

        
    }
}
