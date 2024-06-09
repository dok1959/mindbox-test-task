namespace GeometricShapes.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// Получить площадь
        /// </summary>
        public double GetArea() => Math.PI * Math.Pow(2, _radius);
    }
}
