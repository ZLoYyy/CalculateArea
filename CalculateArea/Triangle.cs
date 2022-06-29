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
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(double a, double b, double c)
        {   
            A = a;
            B = b;
            C = c;
            string error = IsValid();
            if (!string.IsNullOrEmpty(error))
                throw new ArgumentException(error);
        }
        /// <summary>
        /// Проверить, является ли треугольник прямоугольным
        /// </summary>
        public bool IsRectangularCheck() 
        {
            List<double> list = new List<double>() {A,B,C};
            double maxItem = list.Max();
            list.Remove(maxItem);

            double sqrLegsSum = 0;
            foreach (double item in list)
                sqrLegsSum += Math.Pow(item, 2);

            return Math.Pow(maxItem, 2) == sqrLegsSum;
        }
        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double sPerimeter = (A + B + C) / 2;
            double area = Math.Sqrt(sPerimeter * (sPerimeter - A) * (sPerimeter - B) * (sPerimeter - C));
            area = Math.Round(area, 2);
            return area;
        }

        private string IsValid() 
        {
            if (A < 0 || B < 0 || C < 0)
                return "Отрицательные значения сторон недопустимы";
            if (A + B < C || A + C < B || B + C < A)
                return "Некорректное значение сторон";

            return string.Empty;
        }
    }
}
