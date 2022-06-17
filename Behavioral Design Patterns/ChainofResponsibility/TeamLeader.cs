namespace ChainMethod
{
    public class TeamLeader : IHandler
    {
        protected IHandler handler;
        public void setNextHandler(IHandler handler)
        {
            this.handler=handler;
        }
        public void approverequest(string name,int amount)
        {
            if(amount<=100)
            {
                Console.WriteLine("Request Approved by TeamLeader ");
            }
            else
            {
            handler.approverequest(name, amount); 
            }
        }
        
    }
}