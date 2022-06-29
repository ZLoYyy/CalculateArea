using NUnit.Framework;
using System;

namespace CalculateArea.Tests
{
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// Circle validation
        /// </summary>
        [Test]
        public void CircleValidationTest()
        {
            Assert.Throws<ArgumentException>(()=> new Circle(-1));
        }        
        /// <summary>
        /// Calculate Circle area 
        /// </summary>
        [Test]
        public void CircleCalculateAreaTest()
        {
            Circle circle = new Circle(14);

            var area = circle.GetArea();

            Assert.AreEqual(615.75, area);
        }
        /// <summary>
        /// Triangle validation
        /// </summary>
        [Test]
        public void TriangleValidationTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(10, 24, -15));
            Assert.Throws<ArgumentException>(() => new Triangle(10, -24, 15));
            Assert.Throws<ArgumentException>(() => new Triangle(-10, 24, -15));
            Assert.Throws<ArgumentException>(() => new Triangle(9, 12, 23));
        }
        /// <summary>
        /// Calculate trinagle area 
        /// </summary>
        [Test]
        public void TrinagleCalculateAreaTest()
        {
            Triangle triangle = new Triangle(10, 24, 15);

            var area = triangle.GetArea();

            Assert.AreEqual(41.08, area);
        }
        /// <summary>
        /// Trinagle is rectangular
        /// </summary>
        [Test]
        public void TrinagleIsRectangularTrueTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            var area = triangle.IsRectangularCheck();

            Assert.AreEqual(true, area);
        }
        /// <summary>
        /// Trinagle is not rectangular
        /// </summary>
        [Test]
        public void TrinagleIsRectangularFalseTest()
        {
            Triangle triangle = new Triangle(10, 24, 15);

            var area = triangle.IsRectangularCheck();

            Assert.AreEqual(false, area);
        }
        /// <summary>
        /// Figure Validation
        /// </summary>
        [Test]
        public void FigureValidationTest()
        {
            Assert.Throws<ArgumentException>(() => new Figure(new Circle(-9)));
            Assert.Throws<ArgumentException>(() => new Figure(new Triangle(10, 24, -15)));
            Assert.Throws<ArgumentException>(() => new Figure(new Triangle(10, -24, 15)));
            Assert.Throws<ArgumentException>(() => new Figure(new Triangle(-10, 24, 15)));
            Assert.Throws<ArgumentException>(() => new Figure(new Triangle(9, 12, 23)));
        }
        /// <summary>
        /// Calculating area without knowing the figure type (Circle)
        /// </summary>
        [Test]
        public void FigureCircleCalculateAreaTest()
        {
            Figure figure= new Figure(new Circle(9));

            var area = figure.GetArea();

            Assert.AreEqual(254.47, area);
        }
        /// <summary>
        /// Calculating area without knowing the figure type (Triangle)
        /// </summary>
        [Test]
        public void FigureTriangleCalculateAreaTest()
        {
            Figure figure = new Figure(new Triangle(13, 12, 23));
            var area = figure.GetArea();

            Assert.AreEqual(56.28, area);
        }
    }
}