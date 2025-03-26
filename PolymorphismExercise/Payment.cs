using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    abstract class Payment
    {
        public abstract void ProcessPayment(double amount);
        
    }
}
