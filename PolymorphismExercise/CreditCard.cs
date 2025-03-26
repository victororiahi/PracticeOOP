using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    class CreditCard : Payment
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Credit Card payment of {amount}");
        }
    }
}
