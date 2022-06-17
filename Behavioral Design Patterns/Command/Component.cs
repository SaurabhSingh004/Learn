namespace CommandMethod
{
    public class Component
    {
        Icommand command;
        public void setCommand(Icommand command)
        {
            this.command=command;
        }
        public void executeCommand()
        {
            command.execute();
        }
    }


}