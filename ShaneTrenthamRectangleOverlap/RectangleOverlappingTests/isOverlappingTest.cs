using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShaneTrenthamRectangleOverlap;

namespace RectangleOverlappingTests
{
    [TestClass]
    public class isOverlappingTest
    {
        private Rectangle R1, R2;
        [TestMethod]
        //Tests for the condition that R2 is completely contained inside R1
        public void isOverlappingFullyContainedRectangleTest()
        {
            R1 = new Rectangle(new Point2D(0, 0), 4, 5);
            R2 = new Rectangle(new Point2D(1, 1), 2, 3);

            var result = Program.isOverlapping(R1, R2);
            Assert.IsTrue(result, "Returns false. Expected true");
        }

        [TestMethod]
        //Tests for the codition of if just the top left corner of R2 overlaps with R1
        public void isOverlappingOneCornerTest()
        {
            R1 = new Rectangle(new Point2D(0, 0), 4, 5);
            R2 = new Rectangle(new Point2D(3, -3), 3, 4);

            var result = Program.isOverlapping(R1, R2);
            Assert.IsTrue(result, "Returns false. Expected true");
        }

        [TestMethod]
        //Tests for the condition when only the bottom edge of R1 and top edge of R2 overlap
        public void isOverlappingBottomEdgeTest()
        {
            R1 = new Rectangle(new Point2D(0, 0), 4, 5);
            R2 = new Rectangle(new Point2D(0, -3), 2, 3);

            var result = Program.isOverlapping(R1, R2);
            Assert.IsTrue(result, "Returns false. Expected true");
        }

        [TestMethod]
        //Tests for the condition when R1 is completely to the left of R2 with no point of intersection
        public void isOverlappingR1ToLeftOfR2()
        {
            R1 = new Rectangle(new Point2D(0, 0), 4, 5);
            R2 = new Rectangle(new Point2D(5, 0), 2, 3);

            var result = Program.isOverlapping(R1, R2);
            Assert.IsFalse(result, "Returns true. Expected false");
        }

        [TestMethod]
        //Tests for the condition when R1 is completely above R2 with no point of intersection
        public void isOverlappingR1AboveR2()
        {
            R1 = new Rectangle(new Point2D(4, 0), 2, 3);
            R2 = new Rectangle(new Point2D(0, 0), 2, 3);

            var result = Program.isOverlapping(R1, R2);
            Assert.IsFalse(result, "Returns true. Expected false");
        }
    }
}
