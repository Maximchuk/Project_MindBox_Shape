using MindBox.Geometry.Server.Shapes;

namespace UTestShapes
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void Circle_CalculateArea_ReturnsCorrectValue()
        {
            double radius = 3;
            var circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        public void Rectangle_GetArea_ReturnsCorrectValue()
        {
            
            double width = 4;
            double height = 5;
            var rectangle = new Rectangle(width, height);
            double expectedArea = width * height;

            double actualArea = rectangle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void Rectangle_GetPerimeter_ReturnsCorrectValue()
        {
            double width = 4;
            double height = 5;
            var rectangle = new Rectangle(width, height);
            double expectedPerimeter = 2 * (width + height);

            double actualPerimeter = rectangle.CalculatePerimeter();

            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

    }
}