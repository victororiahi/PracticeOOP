using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("Vehicle is driving");
        }
    }
}
