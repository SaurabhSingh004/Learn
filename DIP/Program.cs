namespace Solid
{

    public interface IConnect
    {
         void connect();
    }

    public class Service: IConnect{
        IConnect connection;
        public Service(IConnect connect) 
        {
            this.connection=connect;
        }
        public void connect()
        {
            connection.connect();
        }
    }
    public class MyDBConnection : IConnect{
        public void connect()
        {
            Console.WriteLine("Connected With MyDbConnnection... ");
        }
    }
    public class FirebaseConnection : IConnect{
        public void connect()
        {
            Console.WriteLine("Connected With FirebaseDbConnnection... ");
        }
    }
    public class Program
    {
        static void Main(String[] args)
        {
        Service service=new Service(new FirebaseConnection());
        service.connect();
        }
    }
    
}
