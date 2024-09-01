using MindBox.Geometry.Server.Common.Models;
using MindBox.Geometry.Server.Interfaces;

namespace MindBox.Geometry.Server.Abstract
{

    public abstract class Shape : IShape, IValidator
    {
        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public abstract BaseMindBoxResponse Validate();
    }
}
