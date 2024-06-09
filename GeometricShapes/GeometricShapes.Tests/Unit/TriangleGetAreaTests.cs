using GeometricShapes.Core.Shapes;

namespace GeometricShapes.Tests.Unit
{
    public class TriangleGetAreaTests
    {
        [Fact]
        public void GetArea_Valid()
        {
            var triangle = new Triangle(4, 4, 4);

            var result = triangle.GetArea();

            Assert.Equal(6.93, Math.Round(result, 2));
        }
    }
}
