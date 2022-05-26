namespace Proxy
{
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
}