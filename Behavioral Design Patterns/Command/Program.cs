
using CommandMethod;
namespace CommandMethod
{
    public class program{
        public static void Main(string[] args)
        {
        Room room = new Room();
        room.setCommand(new SwitchLightsCommand(room.getLight()));
        room.executeCommand();
        Console.WriteLine(room.isLightOn());

        // room.setCommand(new OpenCloseCurtainCommand(room.getCurtains()));
        // room.executeCommand();
        // Console.WriteLine(room.isCurtainOn());
        }
    }
}