using GeometricShapes.Core.Shapes;

namespace GeometricShapes.Tests.Unit
{
    public class CircleGetAreaTests
    {
        [Fact]
        public void GetArea_Valid()
        {
            var circle = new Circle(4);

            var result = circle.GetArea();

            Assert.Equal(50.27, Math.Round(result, 2));
        }
    }
}
