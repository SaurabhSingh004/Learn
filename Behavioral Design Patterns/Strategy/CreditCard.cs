namespace Strategy
{
        public class CreditCard {
            private int amount = 1000;
            private String number;
            private String date;
            private String cvv;
            public CreditCard(String number,String date, String cvv){
                this.number=number;
                this.date=date;
                this.cvv=cvv;
            }
            public int getAmount()
            {
                return amount;
            }
            public void setAmount(int amount)
            {
                this.amount=amount;
            }
    }
}