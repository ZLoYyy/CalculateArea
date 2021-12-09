using CalculateArea.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateArea
{
    public class Triangle: IFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        private bool _isRectangular;
        public bool IsRectangular { get { return _isRectangular; } }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Отрицательные значения сторон недопустимы");
            A = a;
            B = b;
            C = c;

            IsRectangularCheck();
        }
        /// <summary>
        /// Проверить, является ли треугольник прямоугольным
        /// </summary>
        private void IsRectangularCheck() 
        {
            List<double> list = new List<double>() {A,B,C};
            double maxItem = list.Max();
            list.Remove(maxItem);

            double sqrLegsSum = 0;
            foreach (double item in list)
                sqrLegsSum += Math.Pow(item, 2);

            _isRectangular = Math.Pow(maxItem, 2) == sqrLegsSum;
        }
        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double sPerimeter = (A + B + C) / 2;
            double area = Math.Sqrt(sPerimeter * (sPerimeter - A) * (sPerimeter - B) * (sPerimeter - C));

            return area;
        }
    }
}
