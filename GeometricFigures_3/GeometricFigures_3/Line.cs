//Giniyatullin Ilyas 220P, GeometricFigures-4, 30.05.2022
using System;
using System.Drawing;

namespace GeometricFigures_3
{
    [Serializable]
    class Line : Figure
    {
        Point point2;

        public Line(Point startingPoint, Point point2, Color color, int thickness)
        {
            this.startingPoint = startingPoint;
            this.point2 = point2;
            this.color = color;
            this.thickness = thickness;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(color, thickness);
            graphics.DrawLine(pen, startingPoint.X, startingPoint.Y, point2.X, point2.Y);
        }
    }
}