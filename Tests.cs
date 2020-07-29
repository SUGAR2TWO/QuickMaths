using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuickMaths
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CircleArea_RadiusZero()
        {
            Assert.ThrowsException<ArgumentException>(
                () => Area.GetArea(0, 3),
                "Radius must be positive");
        }
        
        [TestMethod]
        public void TriangleArea_ResultRight()
        {
            Assert.AreEqual(6, Area.GetArea(3, 4, 5));
        }
        
        [TestMethod]
        public void CircleArea_PrecisionZero()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Area.GetArea(5, -1));
        }

        [TestMethod]
        public void TriangleArea_SidesInvalidZero()
        {
            Assert.ThrowsException<ArgumentException>(() => Area.GetArea(0, 0, 2));
        }

        [TestMethod]
        public void TriangleArea_SidesInvalidNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => Area.GetArea(-1, 5, -2));
        }

        [TestMethod]
        public void CircleArea_SidesValid()
        {
            Assert.AreEqual(Math.PI, Area.GetArea(1), 4);
        }

        [TestMethod]
        public void TriangleRectangular_ResultFalse()
        {
            Assert.IsFalse(TriangleHelpers.IsRectangular(3, 4, 4));
        }

        [TestMethod]
        public void TriangleRectangle_SidesAreZeroAndNegative_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(
                () => TriangleHelpers.IsRectangular(-1, 0, 5),
                "Sides must be positive");
        }
    }
}