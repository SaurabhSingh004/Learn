namespace FactoryMethod
{
    public abstract class Restaurant{
        public void orderBurger()
        {
            Console.WriteLine("Ordering Burger ...");
            IBurger burger= createBurger();
            burger.prepare();
        }
        public abstract IBurger createBurger();
    }
}