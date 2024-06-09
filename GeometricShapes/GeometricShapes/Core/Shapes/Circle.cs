using GeometricShapes.Core.Validators;

namespace GeometricShapes.Core.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IShape
    {
        private readonly double _radius;

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Circle(double radius)
        {
            CircleValidator.Validate(radius);

            _radius = radius;
        }

        /// <inheritdoc />
        public double GetArea() => Math.PI * Math.Pow(2, _radius);
    }
}
