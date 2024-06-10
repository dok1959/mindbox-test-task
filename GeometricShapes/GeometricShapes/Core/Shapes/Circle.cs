using GeometricShapes.Core.Validators;

namespace GeometricShapes.Core.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public readonly double Radius;

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Circle(double radius)
        {
            CircleValidator.ValidateRadius(radius);

            Radius = radius;
        }

        /// <inheritdoc />
        public double GetArea() => Math.PI * Math.Pow(2, Radius);
    }
}
