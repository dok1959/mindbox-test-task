namespace GeometricShapes.Core.Validators
{
    /// <summary>
    /// Валидатор треугольника
    /// </summary>
    public static class TriangleValidator
    {
        /// <summary>
        /// Проверить корректность сторон треугольника
        /// </summary>
        /// <param name="firstSide">Первая сторона (A)</param>
        /// <param name="secondSide">Вторая сторона (B)</param>
        /// <param name="thirdSide">Третья сторона (C)</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static void ValidateSides(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentOutOfRangeException(nameof(firstSide), CoreValidationErrors.WrongTriangleSideValue);

            var isTriangleInequal = IsTriangleInequal(firstSide, secondSide, thirdSide);
            if (!isTriangleInequal)
                throw new ArgumentException(CoreValidationErrors.WrongTriangleInequality);
        }

        private static bool IsTriangleInequal(double firstSide, double secondSide, double thirdSide)
        {
            return firstSide < (secondSide + thirdSide)
                && secondSide < (firstSide + thirdSide)
                && thirdSide < (firstSide + secondSide);
        }
    }
}
