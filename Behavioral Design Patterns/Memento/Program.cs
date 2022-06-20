namespace MementoDemo
{
    public class Originator
    {
        string state;
        Memento newMemento;
        public string State{
            get
            {
                return state;
            }
            set{
                state=value;
                System.Console.WriteLine($"Current state: {value}");
            }
        }
        public Memento getMemento()
        {
             newMemento=new Memento();
             newMemento.State=state;
            return newMemento;
        }
        public void revertTostate(Memento prevMemento)
        {
            System.Console.WriteLine("* Reverting to Previous State *");
            newMemento=prevMemento;
            System.Console.WriteLine($"Current state: {newMemento.State}");
        }

    }

    public class Memento
    {
        string state;
        public string State{
            get
            {
                return state;
            }
            set{
                state=value;
            }
        }
    }
    public class MainApp
    {
        public static void Main(String[] args)
        {
            System.Console.WriteLine("** Memento Design Pattern **");
            Originator og1=new Originator();
            og1.State="Initial State !!";
            Memento temp;
            temp=og1.getMemento();
            og1.State="Intermediate State !!";
            
            og1.revertTostate(temp);

        }

    }
    
}