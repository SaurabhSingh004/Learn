namespace FlyWeightDemo
{
    public interface IRobot
    {
        void Print();
    }
    public class Robot : IRobot
    {
        String robotType;
        public String colorOfRobot;
        public Robot(String robotType)
        {
            this.robotType = robotType;
        }
        public void SetColor(String colorOfRobot)
        {
            this.colorOfRobot = colorOfRobot;
        }
        public void Print()
        {
        Console.WriteLine("This is a" + robotType + "type robot with "
        + colorOfRobot + "color ");
        }
    }
    public class RobotFactory
    {
        Dictionary<string, IRobot> shapes = new Dictionary<string,IRobot>();

        public int TotalObjectCreated()
        {
                return shapes.Count;
        }
        public IRobot GetRobotFromFactory(string robotType)
        {
            IRobot robotCategory=null;
            if (shapes.ContainsKey(robotType))
            {
            robotCategory = shapes[robotType];
            }
            else
            {
                
            switch (robotType)
                {
                case "Small":
                robotCategory = new Robot("Small");
                shapes.Add("Small", robotCategory);
                break;
                case "Large":
                robotCategory = new Robot("Large");
                shapes.Add("Large", robotCategory);
                break;
                default:
                throw new Exception("Robot Factory can create only small and large robots");
                }
            }
            return robotCategory;
            }
    }
    public class MainApp
    {
        public static void Main(String[] args)
        {
            RobotFactory myfactory = new RobotFactory();
            Console.WriteLine("\n***Flyweight Pattern Example Modified***\n");
            Robot shape;
            for (int i = 0; i < 3; i++)
            {
            shape = (Robot)myfactory.GetRobotFromFactory("Small");
            Thread.Sleep(1000);
            shape.SetColor("Blue");
            shape.Print();
            }
            
            for (int i = 0; i < 3; i++)
            {
            shape = (Robot)myfactory.GetRobotFromFactory("Large");
            Thread.Sleep(1000);
            shape.SetColor("Red");
            shape.Print();
            }
            int NumOfDistinctRobots = myfactory.TotalObjectCreated();
            Console.WriteLine("\n Finally no of Distinct Robot objects created: " + NumOfDistinctRobots);
            

        }
    }
    
}