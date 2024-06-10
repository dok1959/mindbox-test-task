namespace GeometricShapes.Core.Validators
{
    /// <summary>
    /// Валидатор круга
    /// </summary>
    public class CircleValidator
    {
        /// <summary>
        /// Проверить корректность радиуса круга
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void ValidateRadius(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), CoreValidationErrors.WrongCircleRadiusValue);
        }
    }
}
