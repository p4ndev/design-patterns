using BridgeExample;

public static class Usage {

    public static void Start() {

        // O que queremos
        IDrawing blueSquare = new BlueSquare();

        // O que fará / como
        ShapeAbstraction shape = new(blueSquare);

        // Como ligaremos
        DrawingClient client = new DrawingClient();        

        // Transferência de objeto
        client.Init(shape);

    }

}