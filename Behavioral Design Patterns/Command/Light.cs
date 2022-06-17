namespace CommandMethod
{
    public class Light
    {
        private bool switchedon;
        public void switchLights()
        {
            switchedon=!switchedon;
        }
        public bool isSwitchedOn() {
            return switchedon;
    }
    }
}