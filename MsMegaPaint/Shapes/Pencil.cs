using System.Drawing;

namespace MsMegaPaint
{
    public class Pencil : Shape
    {
        public List<Point> Path { get; } = new List<Point>();

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color, 3);            //Creates a pen with the selected color and a size 3 tip.
            for (int i = 1; i < Path.Count; i++)    //Draws all points in the list.
            {
                graphics.DrawLine(pen, Path[i - 1], Path[i]);
            }
            pen.Dispose();
        }

        public override void UpdateShape(Point startPoint, Point endPoint)
        {
            Path.Add(endPoint); //As user is drawing, we add the points to the list.
        }
    }
}
