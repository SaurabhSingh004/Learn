namespace CommandMethod
{
    public class Curtains
    {
        private bool openCurtains=false;
        public void OpenCurtains()
        {
            openCurtains=!openCurtains;
        }
        public bool isOpen() {
            return openCurtains;
    }
    }
}