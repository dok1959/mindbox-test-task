using GeometricShapes.Core.Shapes;

namespace GeometricShapes.Tests.Unit
{
    public class TriangleIsRightTests
    {
        [Fact]
        public void IsRight_Valid()
        {
            var triangle = new Triangle(3, 4, 5);

            var result = triangle.IsRight();

            Assert.True(result);
        }

        [Fact]
        public void IsRight_NotValid_WrongSides()
        {
            var triangle = new Triangle(4, 4, 5);

            var result = triangle.IsRight();

            Assert.False(result);
        }
    }
}
