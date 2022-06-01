namespace AdapterPattern;

public class Adapter : Target {
    
    private Adaptee _impl = new Adaptee();

    public override void Request() => _impl.SpecificTask();

}