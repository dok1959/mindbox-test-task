using GeometricShapes.Core.Validators;

namespace GeometricShapes.Core.Shapes
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IShape
    {
        private readonly double _firstSide;

        private readonly double _secondSide;

        private readonly double _thirdSide;

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="firstSide">Первая сторона</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// <param name="thirdSide">Третья сторона</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            TriangleValidator.Validate(firstSide, secondSide, thirdSide);

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

        /// <summary>
        /// Является ли треугольный прямоугольным
        /// </summary>
        public bool IsRight()
        {
            return _firstSide == Math.Sqrt(Math.Pow(_secondSide, 2) + Math.Pow(_thirdSide, 2))
                || _secondSide == Math.Sqrt(Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2))
                || _thirdSide == Math.Sqrt(Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2));
        }
    }
}
