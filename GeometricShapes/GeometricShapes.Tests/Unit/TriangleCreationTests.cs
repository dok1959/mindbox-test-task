using GeometricShapes.Core.Shapes;
using GeometricShapes.Core.Validators;

namespace GeometricShapes.Tests.Unit
{
    public class TriangleCreationTests
    {
        [Fact]
        public void CreateTriangle_Valid()
        {
            var resultMessage = string.Empty;

            try
            {
                var triangle = new Triangle(4, 4, 4);
            }
            catch (ArgumentException ex)
            {
                resultMessage = ex.Message;
            }

            Assert.Empty(resultMessage);
        }

        [Fact]
        public void CreateTriangle_NotValid_OneSideEqualZero()
        {
            var resultMessage = string.Empty;

            try
            {
                var triangle = new Triangle(0, 4, 4);
            }
            catch (ArgumentException ex)
            {
                resultMessage = ex.Message;
            }

            Assert.Contains(CoreValidationErrors.WrongTriangleSideValue, resultMessage);
        }

        [Fact]
        public void CreateTriangle_NotValid_OneSideBiggerThenSumOfOtherSides()
        {
            var resultMessage = string.Empty;

            try
            {
                var triangle = new Triangle(10, 4, 4);
            }
            catch (ArgumentException ex)
            {
                resultMessage = ex.Message;
            }

            Assert.Contains(CoreValidationErrors.WrongTriangleInequality, resultMessage);
        }
    }
}
