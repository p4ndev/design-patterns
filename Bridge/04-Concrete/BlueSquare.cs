namespace BridgeExample;

public class BlueSquare : IDrawing{

    private const string SHAPE_NAME     = "SQUARE";
    private const string SHAPE_COLOR    = "BLUE";

    public void DrawLines() => Console.WriteLine($"Drawing a {SHAPE_NAME}");
    public void Colorize()  => Console.WriteLine($"Filling a {SHAPE_NAME} with {SHAPE_COLOR}");

}
