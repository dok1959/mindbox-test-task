namespace GeometricShapes.Shapes
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
            var isValid = ValidateRadius(radius);
            if (isValid)
                throw new ArgumentOutOfRangeException(nameof(radius));

            _radius = radius;
        }

        /// <summary>
        /// Получить площадь
        /// </summary>
        public double GetArea() => Math.PI * Math.Pow(2, _radius);

        private bool ValidateRadius(double radius) => radius > 0;
    }
}
