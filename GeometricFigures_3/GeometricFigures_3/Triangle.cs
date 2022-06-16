//Giniyatullin Ilyas 220P, GeometricFigures-4, 30.05.2022
using System;
using System.Drawing;

namespace GeometricFigures_3
{
    [Serializable]
    class Triangle : Figure
    {
        Point point2;
        Point point3;
        public Triangle(Point point1, Point point2, Point point3, Color color, int thickness)
        {
            this.startingPoint = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.color = color;
            this.thickness = thickness;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(color, thickness);
            graphics.DrawLine(pen, startingPoint.X, startingPoint.Y, point2.X, point2.Y);
            graphics.DrawLine(pen, startingPoint.X, startingPoint.Y, point3.X, point3.Y);
            graphics.DrawLine(pen, point3.X, point3.Y, point2.X, point2.Y);
        }
    }
}