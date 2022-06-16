//Giniyatullin Ilyas 220P, GeometricFigures-4, 30.05.2022
using System;
using System.Drawing;

namespace GeometricFigures_3
{
    [Serializable]
    class Rectangle : Figure
    {
        int width;
        int height;

        public Rectangle(Point startingPoint, int width, int height, Color color, int thickness)
        {
            this.startingPoint = startingPoint;
            this.width = width;
            this.height = height;
            this.color = color;
            this.thickness = thickness;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(color, thickness);
            graphics.DrawRectangle(pen,startingPoint.X,startingPoint.Y,width,height);
        }
    }
}