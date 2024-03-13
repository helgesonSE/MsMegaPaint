namespace MsMegaPaint
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Point Center { get; set; }
        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(Color),
                Center.X - Radius,
                Center.Y - Radius,
                Radius * 2,
                Radius * 2);
        }
        public override void UpdateShape(Point startPoint, Point currentPoint)  //"Delta" represents difference between startpoint and currentpoint.
        {
            int deltaX = currentPoint.X - startPoint.X;
            int deltaY = currentPoint.Y - startPoint.Y;
            Radius = (int)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);     //Calculates radius of circle.
        }
    }
}
