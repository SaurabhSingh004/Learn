namespace Strategy
{
        public interface PaymentStrategy {

        void collectPaymentDetails();

        bool validatePaymentDetails();

        void pay(int amount);

    }
}