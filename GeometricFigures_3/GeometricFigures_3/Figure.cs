//Giniyatullin Ilyas 220P, GeometricFigures-4, 30.05.2022
using System;
using System.Drawing;

namespace GeometricFigures_3
{
    [Serializable]
    struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    [Serializable]
    abstract class Figure
    {
        protected Point startingPoint;
        protected Color color;
        protected int thickness;

        public virtual void Draw(Graphics graphics)
        {
            return;
        }
    }
}