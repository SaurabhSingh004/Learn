namespace CompositeDemo
{
    public interface IEmployee
    {
        void PrintStructure();
    }

    public class Employee : IEmployee
    {
        string dept;
        string name;
        public Employee(string name,string dept)
        {
            this.name=name;
            this.dept=dept;
        }
        public void PrintStructure()
        {
            System.Console.WriteLine($"{name} works in {dept}");
        }
    }
    public class CompositeEmployee : IEmployee
    {
        string name;
        string dept ;
        List<IEmployee> controls;

        public CompositeEmployee(string name,string dept)
        {
            this.name=name;
            this.dept=dept;
            controls=new List<IEmployee>();

        }
        public void Add(IEmployee emp)
        {
            controls.Add(emp);
        }
        public void PrintStructure()
        {
            System.Console.WriteLine($"{name} works in {dept}");
            foreach(IEmployee e in controls)
            {
                e.PrintStructure();
            }
        }
        public void Remove(IEmployee emp)
        {
            controls.Remove(emp);
        }
    }
    public class MainApp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***Composite Pattern Demo ***");

            CompositeEmployee principle=new CompositeEmployee("Dr. X","Planning-Supervising-Managing");
            CompositeEmployee hodmaths=new CompositeEmployee("Dr. MathsX","Mathematics");
            CompositeEmployee hodscience=new CompositeEmployee("Dr. ScienceX","Science");
            Employee emp1=new Employee("Employee1","Mathematics");
            Employee emp2=new Employee("Employee2","Mathematics");
            Employee emp3=new Employee("Employee3","Science");
            Employee emp4=new Employee("Employee4","Science");
            Employee emp5=new Employee("Employee5","Science");

            principle.Add(hodmaths);
            principle.Add(hodscience);

            hodmaths.Add(emp1);
            hodmaths.Add(emp2);
            hodscience.Add(emp3);
            hodscience.Add(emp4);
            hodscience.Add(emp5);
            
            hodscience.PrintStructure();
        }
    }

    
    
}