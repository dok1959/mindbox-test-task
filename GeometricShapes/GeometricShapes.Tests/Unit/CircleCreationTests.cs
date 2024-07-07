using GeometricShapes.Core.Shapes;
using GeometricShapes.Core.Validators;

namespace GeometricShapes.Tests.Unit
{
    public class CircleCreationTests
    {
        [Fact]
        public void CreateCircle_Valid()
        {
            var resultMessage = string.Empty;

            try
            {
                var circle = new Circle(4);
            }
            catch (ArgumentException ex)
            {
                resultMessage = ex.Message;
            }

            Assert.Empty(resultMessage);
        }

        [Fact]
        public void CreateCircle_NotValid_RadiusEqualZero()
        {
            var resultMessage = string.Empty;

            try
            {
                var circle = new Circle(0);
            }
            catch (ArgumentException ex)
            {
                resultMessage = ex.Message;
            }

            Assert.Contains(CoreValidationErrors.WrongCircleRadiusValue, resultMessage);
        }
    }
}
