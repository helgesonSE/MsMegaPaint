namespace MsMegaPaint
{
    public class Line : Shape
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color, 3);    //Creates a pen with the selected color and a size 3 tip.
            graphics.DrawLine(pen, StartPoint, EndPoint);   //DrawLine creates line between two points.
            pen.Dispose();
        }

        public override void UpdateShape(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }
    }
}
