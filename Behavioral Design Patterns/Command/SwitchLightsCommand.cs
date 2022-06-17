namespace CommandMethod
{
    public record SwitchLightsCommand(Light light) : Icommand {

    public void execute() {
        light.switchLights();
    }

}
}