namespace Proxy
{
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
}