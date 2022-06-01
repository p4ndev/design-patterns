namespace AdapterPattern;

public class Client {
    public void Operation() {
        Target adapter = new Adapter();
        adapter.Request();
    }
}