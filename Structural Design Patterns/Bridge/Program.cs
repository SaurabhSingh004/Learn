using System;
namespace BridgeDesignPattern
{
    public interface LEDTV
    {
         string SwitchOn();
         void SwitchOff();
         void SetChannel(int channelNumber);
    }
    public class SonyLedTv : LEDTV
    {
        public string SwitchOn()
        {
            Console.WriteLine("Turning ON : Sony TV");
            return "mumu";
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Sony TV");
        }

        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Sony TV");
        }
    }

    public class SamsungLedTv : LEDTV
    {
        public string SwitchOn()
        {
            Console.WriteLine("Turning ON : Samsung TV");
            return "switchedon";
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Samsung TV");
        }

        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Samsung TV");
        }
    }

    public abstract class AbstractRemoteControl
    {
        protected LEDTV ledTv;

        protected AbstractRemoteControl(LEDTV ledTv)
        {
         //   Console.WriteLine(this.ledTv+" helloabstract");
            this.ledTv = ledTv;
        }

        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }

    public class SamsungRemoteControl : AbstractRemoteControl
    {
        public SamsungRemoteControl(LEDTV ledTv) : base(ledTv)
        {
        }
        
        public override void SwitchOn()
        {   
            ledTv.SwitchOn();
        }

        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }

        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }
    }

    public class SonyRemoteControl : AbstractRemoteControl
    {
        public SonyRemoteControl(LEDTV ledTv) : base(ledTv)
        {
            
        }

        public override void SwitchOn()
        {
            ledTv.SwitchOn();
        }

        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }

        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            SonyRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTv());
            sonyRemoteControl.SwitchOn();
            sonyRemoteControl.SetChannel(101);
            sonyRemoteControl.SwitchOff();
            
            Console.WriteLine();

            SamsungRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SonyLedTv());
            samsungRemoteControl.SwitchOn();
            samsungRemoteControl.SetChannel(202);
            samsungRemoteControl.SwitchOff();
            
            Console.ReadKey();
        }
    }
}
