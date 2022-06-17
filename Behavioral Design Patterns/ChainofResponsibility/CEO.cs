namespace ChainMethod
{
    public class CEO : IHandler
    {
        protected IHandler handler;
        public void setNextHandler(IHandler handler)
        {
            this.handler=handler;
        }
        public void approverequest(string name,int amount)
        {
            if(amount<=1000)
            {
                Console.WriteLine("Request Approved by CEO ");
            }
            else
            {
                Console.WriteLine("Request Is Invaid ");
            }
        }
        
    }
}