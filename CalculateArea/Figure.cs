using CalculateArea.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateArea
{
    public class Figure : IFigure
    {
        private IFigure _figure;
        public Figure(IFigure figure) 
        {
            if(figure == null)
                throw new ArgumentException("Значение не может быть пустым");
            _figure = figure;
        }
        public double GetArea()
        {
            return _figure.GetArea();
        }
    }
}
