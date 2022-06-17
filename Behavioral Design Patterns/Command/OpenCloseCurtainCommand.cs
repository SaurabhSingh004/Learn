namespace CommandMethod
{
    public record OpenCloseCurtainCommand(Curtains curtain) : Icommand {

    public void execute() {
        curtain.OpenCurtains();
    }

}
}