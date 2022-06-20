using System;
namespace BridgeDesignPattern
{
    public interface IState
    {
         void MoveState();
    }
    public class OnState : IState
    {
        public void MoveState()
        {
            Console.WriteLine("Turning ON State");
           
        }
       
    }

    public class OffState : IState
    {
        public void MoveState()
        {
            Console.WriteLine("Turning OFF : state");
            
        }
        
    }

    public abstract class ElectronicGoods
    {
        protected IState state;

        protected ElectronicGoods(IState state)
        {
            this.state = state;
        }

        public abstract void MoveState();
    }

    public class SamsungRemoteControl : ElectronicGoods
    {
        public SamsungRemoteControl(IState state) : base(state)
        {
        }
        
        public override void MoveState()
        {   
            System.Console.WriteLine("Samsung Remote Control Functioning at: ");
            state.MoveState();
        }


    }

    public class SonyRemoteControl : ElectronicGoods
    {
        public SonyRemoteControl(IState state) : base(state)
        {
            
        }

        public override void MoveState()
        {   
            System.Console.WriteLine("Sony Remote Control Functioning at: ");
            state.MoveState();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            SonyRemoteControl sony=new SonyRemoteControl(new OnState());
            sony.MoveState();
            SamsungRemoteControl Samsung=new SamsungRemoteControl(new OffState());
            sony.MoveState();
        }
    }
}
