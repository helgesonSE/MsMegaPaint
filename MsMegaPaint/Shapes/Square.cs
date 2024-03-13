namespace MsMegaPaint
{
    public class Square : Shape
    {
        public Point TopLeft { get; set; }
        public int SideLength { get; set; }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(Color),   //Takes upper left corner and draws a rectangle according to sideLength.
                TopLeft.X, TopLeft.Y,
                SideLength, SideLength);
        }
        public override void UpdateShape(Point startPoint, Point currentPoint)
        {
            SideLength = Math.Max(Math.Abs(currentPoint.X - startPoint.X), Math.Abs(currentPoint.Y - startPoint.Y));    //Calculates sideLength.
        }
    }
}
