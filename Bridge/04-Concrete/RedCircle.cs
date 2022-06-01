namespace BridgeExample;

public class RedCircle : IDrawing{

    private const string SHAPE_NAME     = "CIRCLE";
    private const string SHAPE_COLOR    = "RED";

    public void DrawLines() => Console.WriteLine($"Drawing a {SHAPE_NAME}");
    public void Colorize()  => Console.WriteLine($"Filling a {SHAPE_NAME} with {SHAPE_COLOR}");

}
