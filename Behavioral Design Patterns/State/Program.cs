interface MobileAlertState 
{
    public void alert(AlertStateContext ctx);
}
  
class AlertStateContext 
{
    private MobileAlertState currentState;
  
    public AlertStateContext() 
    {
        currentState = new Vibration();
    }
  
    public void setState(MobileAlertState state) 
    {
        currentState = state;
    }
  
    public void alert() 
    {
        currentState.alert(this);
    }
}
  
class Vibration : MobileAlertState 
{
       public void alert(AlertStateContext ctx) 
    {
         Console.WriteLine("vibration...");
    }
  
}
  
class Silent : MobileAlertState
{
       public void alert(AlertStateContext ctx) 
    {
        Console.WriteLine("silent...");
    }
  
}
  
class StatePattern 
{
    public static void main(String[] args) 
    {
        AlertStateContext stateContext = new AlertStateContext();
        stateContext.alert();
        stateContext.alert();
        stateContext.setState(new Silent());
        stateContext.alert();
        stateContext.alert();
        stateContext.alert();        
    }
}