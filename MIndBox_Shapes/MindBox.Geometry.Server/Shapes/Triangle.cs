using MindBox.Geometry.Server.Abstract;
using MindBox.Geometry.Server.Common.Models;
using System;

namespace MindBox.Geometry.Server.Shapes
{
    public class Triangle : Shape
    {
        internal double Side1 { get; private set; }
        internal double Side2 { get; private set; }
        internal double Side3 { get; private set; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double CalculateArea()
        {
            var sumSides = CalculatePerimeter() / 2;
            return Math.Sqrt(sumSides * (sumSides - Side1) * (sumSides - Side2) * (sumSides - Side3));
        }

        public override double CalculatePerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public override BaseMindBoxResponse Validate()
        {
            if (Side1 <= 0 || Side2 <= 0 || Side3 <= 0)
                return new BaseMindBoxResponse(false, $"Стороны треугольника должны быть положительными. {ToString()}");

            // Проверяем, можно ли составить треугольник с такими сторонами
            if (Side1 + Side2 <= Side3 || Side1 + Side3 <= Side2 || Side2 + Side3 <= Side1)
                return new BaseMindBoxResponse(false, $"Треугольник с такими сторонами не может существовать. {ToString()}");

            return new BaseMindBoxResponse();
        }

        // Метод для проверки, является ли треугольник прямоугольным
        public bool IsRightAngled()
        {
            // Находим самую длинную сторону
            double[] sides = { Side1, Side2, Side3 };
            Array.Sort(sides);
            double hypotenuse = sides[2];
            double side1 = sides[0];
            double side2 = sides[1];

            // Проверяем теорему Пифагора
            return Math.Abs(hypotenuse * hypotenuse - (side1 * side1 + side2 * side2)) < 1e-10;
        }

        public override string ToString()
        {
            return $"{nameof(Triangle)}: Side1: {Side1}, Side2: {Side2}, Side3: {Side3}";
        }
    }
}
