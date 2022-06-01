namespace BridgeExample;

public class ShapeAbstraction{

    protected IDrawing _impl;

    public ShapeAbstraction(IDrawing impl) => _impl = impl;

    public virtual void Operation() => _impl.DrawLines();

}