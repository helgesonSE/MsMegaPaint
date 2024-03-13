namespace MsMegaPaint
{
    public class Triangle : Shape
    {
        public Point[] Vertices { get; set; }
        public override void Draw(Graphics graphics)
        {
            if (Vertices.Length == 3)   //Since this is a triangle, we are done at 3 vertices.
                graphics.FillPolygon(new SolidBrush(Color), Vertices);
        }
        public override void UpdateShape(Point startPoint, Point currentPoint)
        {
            Point vertex1 = startPoint;
            Point vertex2 = currentPoint;
            Point vertex3 = new Point(vertex1.X - (vertex2.X - vertex1.X), vertex2.Y);  //Calculate the position of vertex 3 mirrored across the y-axis, relative to vertex 1.

            Vertices = new Point[] { vertex1, vertex2, vertex3 };   //Update the vertices array.
        }
    }
}
