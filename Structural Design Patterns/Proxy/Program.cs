// See https://aka.ms/new-console-template for more information
namespace Proxy
{ 
    internal interface ISafeDb
    {
        public void DisplayDbname();
    }
    internal class SafeDb : ISafeDb
    {
        private string _dbname;
        public SafeDb(string Dbname)
        {
            _dbname=Dbname;
        }
        public void DisplayDbname()
        {
            Console.WriteLine("Display Database Name: "+_dbname);
        }

    }

    internal class SafeDbProxy : ISafeDb
    {
        private SafeDb SafeDb;
        private string Dbname;
        private string pass;
        public SafeDbProxy(string Dbname,string pass)
        {
            this.Dbname=Dbname;
            this.pass=pass;
        }
        public void DisplayDbname()
        {
            if(pass.Equals("password"))
            {
                if(SafeDb==null)
                {
                    SafeDb=new SafeDb(Dbname);
                }
                SafeDb.DisplayDbname();
            }
        }
    }
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            
            ISafeDb safeDatabase=new SafeDbProxy("Testing","password");
            safeDatabase.DisplayDbname();

        }
    } 
 }