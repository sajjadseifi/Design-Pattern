namespace Design_Pattern.Facade.Shape
{
    public class ShapeMaker
    {
        public void DrawCircle() => new Circle().Draw();
        public void DrawRectangle() => new Rectangle().Draw();
        public void DrawPentagon() => new Pentagon().Draw();

    }
}