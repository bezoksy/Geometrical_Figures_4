//Giniyatullin Ilyas 220P, GeometricFigures-4, 30.05.2022
using System;
using System.Drawing;

namespace GeometricFigures_3
{
    [Serializable]
    class Circle : Figure
    {
        int radius;

        public Circle(Point startingPoint, int radius, Color color, int thickness)
        {
            this.startingPoint = startingPoint;
            this.radius = radius;
            this.color = color;
            this.thickness = thickness;
        }

        public override void Draw(Graphics graphics)
        { 
            Pen pen = new Pen(color, thickness);
            graphics.DrawEllipse(pen, startingPoint.X, startingPoint.Y, radius * 2, radius * 2);
        }
    }
}