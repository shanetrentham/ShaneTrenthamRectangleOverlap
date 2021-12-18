using System;
using System.Collections.Generic;
using System.Text;

namespace ShaneTrenthamRectangleOverlap
{
    public class Rectangle
    {
        //X, Y coordinate for bottom left corner of the Rectangle
        public Point2D origin;

        public float width;
        public float height;


        public Rectangle(Point2D origin, float width, float height)
        {
            this.origin = origin;
            this.width = width;
            this.height = height;
        }
    }
}
