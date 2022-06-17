// See https://aka.ms/new-console-template for more information
using ChainMethod;
namespace ChainMethod
{
    public class program
    {
        static void Main(string[] args)
        {   
            ProjectManager projectmanager =new ProjectManager();
            TeamLeader teamleader =new TeamLeader();
            CEO ceo =new CEO();
            projectmanager.setNextHandler(ceo);
            teamleader.setNextHandler(projectmanager);

            teamleader.approverequest("name",450);
            Console.WriteLine();

        }
    }



}