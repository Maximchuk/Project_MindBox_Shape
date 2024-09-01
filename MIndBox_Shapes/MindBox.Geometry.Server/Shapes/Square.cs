using MindBox.Geometry.Server.Abstract;
using MindBox.Geometry.Server.Common.Models;

namespace MindBox.Geometry.Server.Shapes
{
    public class Square : Shape
    {
        internal int Width { get; private set; }
        internal int Height { get; private set; }

        public Square(int width)
        {
            Width = width;
            Height = width;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public override BaseMindBoxResponse Validate()
        {
            if (Width <= 0)
                return new BaseMindBoxResponse(false, $"Ширина должна быть положительным числом. {ToString()}");

            if (Height <= 0)
                return new BaseMindBoxResponse(false, $"Высота должна быть положительным числом. {ToString()}");

            return new BaseMindBoxResponse();
        }

        public override string ToString()
        {
            return $"{nameof(Square)}: Width: {Width}, Height: {Height}";
        }
    }
}
