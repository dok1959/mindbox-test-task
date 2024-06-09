namespace GeometricShapes.Shapes
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IShape
    {
        private readonly double _firstSide;

        private readonly double _secondSide;

        private readonly double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        /// <inheritdoc />
        public double GetArea()
        {
            var semiPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;

            return Math.Sqrt(semiPerimeter
                * (semiPerimeter - _firstSide)
                * (semiPerimeter - _secondSide)
                * (semiPerimeter - _thirdSide));
        }
    }
}
