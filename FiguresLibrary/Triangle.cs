using System.Drawing;

namespace FiguresLibrary
{
    public class Triangle : Polygon
    {
        public Triangle(int id, Point[] points, string u_name=null) : base(id, points)
        {
            unique_name = u_name;
            name = "Треугольник";
        }
        public void ResetPoints(int x1, int x2, int x3, int y1, int y2, int y3)
        {
            this.points[0].X = x1;
            this.points[0].Y = y1;
            this.points[1].X = x2;
            this.points[1].Y = y2;
            this.points[2].X = x3;
            this.points[2].Y = y3;
            this.DeleteF(this, false);
            this.Draw();
        }
    }
}