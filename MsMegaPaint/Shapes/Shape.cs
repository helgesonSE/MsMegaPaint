namespace MsMegaPaint
{
    public abstract class Shape //We never create a Shape object, therefore abstract.
    {
        public Color Color { get; set; }    //All shapes have Color in common.

        public abstract void Draw(Graphics graphics);

        public abstract void UpdateShape(Point startPoint, Point currentPoint);
    }
}
