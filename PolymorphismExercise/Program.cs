using PolymorphismExercise;

    class Program
    {
        static void Main(string[] args)
        {
            Payment creditCard = new CreditCard();
            Payment transfer = new Transfer();
            Payment cash = new Cash();

            creditCard.ProcessPayment(100567.27);
            transfer.ProcessPayment(561000);
            cash.ProcessPayment(12300.80);
        }
    }