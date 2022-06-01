namespace BridgeExample;

public class ColorAbstraction : ShapeAbstraction{

    public ColorAbstraction(IDrawing impl) : base(impl) { }
     
    public override void Operation() {
        _impl.DrawLines();
        _impl.Colorize();
    }

}