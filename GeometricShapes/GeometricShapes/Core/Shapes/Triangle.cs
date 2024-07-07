using GeometricShapes.Core.Validators;

namespace GeometricShapes.Core.Shapes
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Первая сторона (A)
        /// </summary>
        public readonly double FirstSide;

        /// <summary>
        /// Вторая сторона (B)
        /// </summary>
        public readonly double SecondSide;

        /// <summary>
        /// Третья сторона (C)
        /// </summary>
        public readonly double ThirdSide;

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="firstSide">Первая сторона (A)</param>
        /// <param name="secondSide">Вторая сторона (B)</param>
        /// <param name="thirdSide">Третья сторона (C)</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            TriangleValidator.ValidateSides(firstSide, secondSide, thirdSide);

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        /// <inheritdoc />
        public double GetArea()
        {
            var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Sqrt(semiPerimeter
                * (semiPerimeter - FirstSide)
                * (semiPerimeter - SecondSide)
                * (semiPerimeter - ThirdSide));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRight()
        {
            return Math.Round(FirstSide, 2) == Math.Round(Math.Sqrt(Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2)), 2)
                || Math.Round(SecondSide, 2) == Math.Round(Math.Sqrt(Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2)), 2)
                || Math.Round(ThirdSide, 2) == Math.Round(Math.Sqrt(Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2)), 2);
        }
    }
}
