using FigureSquareCalculator.Primitives;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class SqrCalculatorTests
    {
        [Test]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
        }
        
        [Test]
        public void TriangleNegativeSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -1, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, -10, -10));
        }
        
        [Test]
        public void CircleSqrCalculationTest()
        {
            //Arrange
            var circle = new Circle(10);

            //Act
            var circleSquare = circle.Square;

            //Assert
            Assert.That(circleSquare, Is.EqualTo(314.15926535897931));
        }
        
        [Test]
        public void TriangleSqrCalculationTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var triangleSquare = triangle.Square;

            //Assert
            Assert.That(triangleSquare, Is.EqualTo(6));
        }
        
        [Test]
        public void RightAngleTriangleTest()
        {
            var rightTriangle = new Triangle(3, 4, 5);
            Assert.That(rightTriangle.IsRightAngled(), Is.EqualTo(true));

            var triangle = new Triangle(2, 3, 4);
            Assert.That(triangle.IsRightAngled(), Is.EqualTo(false));
        }
        
    }
}