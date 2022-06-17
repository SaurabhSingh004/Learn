namespace ChainMethod
{
    public interface IHandler
    {
        public void setNextHandler(IHandler handler);
        public void approverequest(string name,int amount);
    }
}