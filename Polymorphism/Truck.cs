using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Truck : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Truck is driving");
        }
    }
}
