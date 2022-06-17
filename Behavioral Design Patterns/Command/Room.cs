namespace CommandMethod
{
    public class Room : Component {

        private Light light;
        private Curtains curtain;

        public Room() {
            this.light = new Light();
            this.curtain=new Curtains();
        }

        public Light getLight() {
            return light;
        }
        public Curtains getCurtains() {
            return curtain;
        }
        public bool isLightOn() {
            return light.isSwitchedOn();
        }
        public bool isCurtainOn()
        {
            return curtain.isOpen();
        }
    }
}