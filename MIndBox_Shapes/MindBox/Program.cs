using MindBox.Geometry.Server.Abstract;
using MindBox.Geometry.Server.Interfaces;
using MindBox.Geometry.Server.Shapes;
using System;

namespace MindBox
{
    internal class Program
    {
        static void Main()
        {
            IShape shape1 = new Circle(-1);
            IShape shape2 = new Rectangle(4, -1);
            IShape shape3 = new Triangle(3, 4, 5);

            if (ValidateShapeArea(shape1))
                Console.WriteLine($"Circle area: {CalculateShapeArea(shape1)}");

            if (ValidateShapeArea(shape2))
                Console.WriteLine($"Rectangle area: {CalculateShapeArea(shape2)}");

            if (ValidateShapeArea(shape3))
                Console.WriteLine($"Triangle area: {CalculateShapeArea(shape3)}");

            Console.ReadKey();
        }

        static bool ValidateShapeArea(IShape shape) 
        {
            if (shape is Shape form) 
            {
                var validate = form.Validate();
                if (!validate.IsSuccess) 
                {
                    Console.WriteLine(validate.Message);
                    return false;
                }

                return true;
            }

            return false;
        }

        static double CalculateShapeArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
