using CalculateArea.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateArea
{
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius { get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            if (radius < 0 )
                throw new ArgumentException("Отрицательные значение радиуса недопустимо");
            Radius = radius;
        }
        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double s = Math.PI * Math.Pow(Radius, 2);
            s = Math.Round(s, 2);
            return s;
        }
    }
}
