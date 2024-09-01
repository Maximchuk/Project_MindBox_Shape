using MindBox.Geometry.Server.Abstract;
using MindBox.Geometry.Server.Common.Models;
using System;

namespace MindBox.Geometry.Server.Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            throw new System.NotImplementedException();
        }

        public override BaseMindBoxResponse Validate()
        {
            return Radius < 0 ? new BaseMindBoxResponse(false, $"Радиус не может быть отрицательным. {ToString()}") : new BaseMindBoxResponse();
        }

        public override string ToString()
        {
            return $"{nameof(Circle)}: Radius: {Radius}";
        }
    }
}
