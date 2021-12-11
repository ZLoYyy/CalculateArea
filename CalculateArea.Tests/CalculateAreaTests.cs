using NUnit.Framework;

namespace CalculateArea.Tests
{
    [TestFixture]
    public class Tests
    {        
        /// <summary>
        /// Площадь круга
        /// </summary>
        [Test]
        public void CircleCalculateAreaTest()
        {
            Circle circle = new Circle(14);

            var area = circle.GetArea();

            Assert.AreEqual(615.7521601035994, area);
        }
        /// <summary>
        /// Площадь треугольника
        /// </summary>
        [Test]
        public void TrinagleCalculateAreaTest()
        {
            Triangle triangle = new Triangle(10, 24, 15);

            var area = triangle.GetArea();

            Assert.AreEqual(41.07843108006926, area);
        }
        /// <summary>
        /// Проверка, является ли треугольник прямоугольным
        /// </summary>
        [Test]
        public void TrinagleIsRectangularTrueTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            var area = triangle.IsRectangular;

            Assert.AreEqual(true, area);
        }
        /// <summary>
        /// Проверка, не является ли треугольник прямоугольным
        /// </summary>
        [Test]
        public void TrinagleIsRectangularFalseTest()
        {
            Triangle triangle = new Triangle(10, 24, 15);

            var area = triangle.IsRectangular;

            Assert.AreEqual(false, area);
        }
        /// <summary>
        /// Вычисление площади фигуры без знания типа фигуры
        /// </summary>
        [Test]
        public void FigureCalculateAreaTest()
        {
            Figure figure= new Figure(new Circle(9));

            var area = figure.GetArea();

            Assert.AreEqual(254.46900494077323, area);
        }
    }
}