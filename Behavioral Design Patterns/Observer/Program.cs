using System;
namespace ObserverDesignPattern
{
    public interface IObserver
    {
        void update(int i);
    }
    
    public class Observer1 : IObserver
    {
        string nameofobserver;

        public Observer1(string name)
        {
            nameofobserver=name;

        }
        public void update(int i)
        {
            System.Console.WriteLine($"Observer1 of name {nameofobserver} has recieved an alert : Someone has updated myvalue in subject to {i} ");
        }

    }

    public class Observer2 : IObserver
    {
        string nameofobserver;

        public Observer2(string name)
        {
            nameofobserver=name;

        }
        public void update(int i)
        {
            System.Console.WriteLine($"Observer2 of name {nameofobserver} has recieved an alert : Someone has updated myvalue in subject to {i} ");
        }

    }
    public class Observer3 : IObserver
    {
        string nameofobserver;

        public Observer3(string name)
        {
            nameofobserver=name;

        }
        public void update(int i)
        {
            System.Console.WriteLine($"Observer3 of name {nameofobserver} has recieved an alert : Someone has updated myvalue in subject to {i} ");
        }

    }

    public interface ISubject
    {
        void NotifyRegisteredUser(string name);
        void Register(IObserver o);
        void UnRegister(IObserver o);
    }

    public class Subject
    {
        List<IObserver> observerList=new List<IObserver>();
        int flag;
        public int Flag{
            get{
                return flag;
            }
            set{
                flag=value;
                NotifyRegisteredUser(flag);
            }
        }
        public void Register(IObserver o)
        {
            observerList.Add(o);
        }

        public void UnRegister(IObserver o)
        {
            observerList.Remove(o);
        }

        public void NotifyRegisteredUser(int i)
        {
            foreach(IObserver o in observerList)
            {
                o.update(i);
            }
        }

    }


    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Observer Design Pattern **");
            IObserver o1=new Observer1("Sam");
            IObserver o2=new Observer2("Charlie");
            IObserver o3=new Observer3("Donald");
            Subject subject=new Subject();
            
            subject.Register(o1);
            subject.Register(o2);
            subject.Register(o3);
            subject.Flag=5;
            subject.UnRegister(o2);
            subject.Flag=50;            
        }
    }
}