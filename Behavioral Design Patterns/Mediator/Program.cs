namespace MediatorDemo
{
    public interface IMediator
    {
        void Register(Friend friend);
        void Send(Friend friend, string msg);
    }
    public class ConcreteMediator : IMediator
    {
        List<Friend> participants =new List<Friend>();
        public void Register(Friend friend)
        {
            participants.Add(friend);
        }
        public void DisplayDetails()
        {
            Console.WriteLine("At present, registered Participants are:");
            foreach (Friend f in participants)
            {
                Console.WriteLine("{0}", f.Name);
            }
        }
        public void Send(Friend friend,string msg)
        {
            if(participants.Contains(friend))
            {
                Console.WriteLine(String.Format("[{0}] posts: {1} Last message ", friend.Name, msg, DateTime.Now));
            }
            else
            {
                Console.WriteLine("An outsider named {0} trying to send some messages", friend.Name);
            }

        }

    }
    public abstract class Friend
    {
        IMediator mediator;
        string name;
        public string Name{
            get{
                return name;
            }
            set{
                name=value;
            }
        }
        public Friend(IMediator mediator)
        {
            this.mediator=mediator;
        }
    }
    public class Friend1:Friend
    {
        IMediator mediator;
        public Friend1(IMediator mediator,string name):base(mediator)
        {
            this.Name=name;
            this.mediator=mediator;
        }
        public void Send(string msg)
        {
            mediator.Send(this,msg);
        }

    }

    public class Friend2:Friend
    {
        IMediator mediator;
        public Friend2(IMediator mediator,string name):base(mediator)
        {
            this.Name=name;
            this.mediator=mediator;
        }
        public void Send(string msg)
        {
            mediator.Send(this,msg);
        }

    }

    public class Unknown:Friend
    {
        IMediator mediator;
        public Unknown(IMediator mediator,string name):base(mediator)
        {
            this.mediator=mediator;
            this.Name=name;
        }
        public void Send(string msg)
        {
            mediator.Send(this,msg);
        }

    }
    public class Boss:Friend
    {
        IMediator mediator;
        public Boss(IMediator mediator,string name):base(mediator)
        {
            this.Name=name;
            this.mediator=mediator;
        }
        public void Send(string msg)
        {
            mediator.Send(this,msg);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator=new ConcreteMediator();
            Friend1 amit=new Friend1(mediator,"Amit");
            Friend2 raj=new Friend2(mediator,"Raj");
            Boss manoj=new Boss(mediator,"Manoj");
            mediator.Register(amit);
            mediator.Register(raj);
            mediator.Register(manoj);

            mediator.DisplayDetails();
            Console.WriteLine("Communication starts among participants...");
            amit.Send("Hi manoj,can we start with mediator pattern?");
            manoj.Send("Hi Amit,Yup, we can discuss now.");
            raj.Send("Please get back to work quickly.");
            Unknown anonymous=new Unknown(mediator,"anonymous");
            anonymous.Send("Hello Guys ..");
        }

    }

}
