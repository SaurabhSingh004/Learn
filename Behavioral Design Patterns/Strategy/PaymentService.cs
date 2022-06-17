namespace Strategy
{
    public class PaymentService {

    private int cost;
    private bool includeDelivery = true;

    private PaymentStrategy strategy;
    public void setStrategy(PaymentStrategy strategy)
    {
        this.strategy=strategy;
    }
    public void processOrder(int cost) {
        this.cost = cost;
        strategy.collectPaymentDetails();
        if (strategy.validatePaymentDetails()) {
            strategy.pay(getTotal());
        }
    }

    private int getTotal() {
        return includeDelivery ? cost + 10 : cost;
    }

}
}