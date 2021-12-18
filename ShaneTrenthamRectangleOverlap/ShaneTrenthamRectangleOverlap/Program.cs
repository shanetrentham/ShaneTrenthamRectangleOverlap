using System;

namespace ShaneTrenthamRectangleOverlap
{
    public class Program
    {
        //Method that determines if 2 rectangles are overlapping. Returns true if overlapping and false if not.
        public static bool isOverlapping(Rectangle R1, Rectangle R2)
        {
            Point2D r1_TopRight, r2_TopRight;

            //Checks for null rectangles
            if (R1 == null || R2 == null)
            {
                throw new Exception("One or more of the provided rectangles are null");
            }

            //Top right points that are adjacent to the origin point in each rectangle
            r1_TopRight = new Point2D(R1.origin.x + R1.width, R1.origin.y + R1.height);
            r2_TopRight = new Point2D(R2.origin.x + R2.width, R2.origin.y + R2.height);

            //if Rectangle 1's right side is less than Rectangle 2's left side or vice versa than these two don't intersect
            if (r1_TopRight.x < R2.origin.x || r2_TopRight.x < R1.origin.x)
            {
                return false;
            }

            //if Rectangle 1's top side is less than Rectangle 2's bottom side and vice versa these two won't intersect
            if (r1_TopRight.y < R2.origin.y || r2_TopRight.y < R1.origin.y)
            {
                return false;
            }

            //Returns true if none of the Non-intersect conditions are met meaning the Rectangles must intersect at some point.
            return true;
        }

        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(new Point2D(0, 0), 4.0f, 5.0f);
            Rectangle r2 = new Rectangle(new Point2D(4, 1), 4.0f, 5.0f);

            if(isOverlapping(r1, r2))
            {
                Console.WriteLine("Intersecting");
            }
            else
            {
                Console.WriteLine("Not intersecting");
            }
        }
    }
}
