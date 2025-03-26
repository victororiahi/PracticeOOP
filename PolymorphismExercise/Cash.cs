using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    class Cash : Payment
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Cash payment of {amount}");
        }
    }
}
