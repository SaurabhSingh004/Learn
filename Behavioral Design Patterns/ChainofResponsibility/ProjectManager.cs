namespace ChainMethod
{
    public class ProjectManager : IHandler
    {
        protected IHandler handler;
        public void setNextHandler(IHandler handler)
        {
            this.handler=handler;
        }
        public void approverequest(string name,int amount)
        {
            if(amount<500)
            {
                Console.WriteLine("Request Approved by ProjectManager ");
            }
            else
            {
                handler.approverequest(name, amount);
            }
        }
        
    }
}