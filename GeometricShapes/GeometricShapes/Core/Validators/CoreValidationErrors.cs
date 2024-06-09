namespace GeometricShapes.Core.Validators
{
    /// <summary>
    /// Сообщения об ошибках валидации фигур
    /// </summary>
    public class CoreValidationErrors
    {
        public const string WrongTriangleSideValue = "Сторона треугольника не может быть меньше или равна нулю";

        public const string WrongTriangleInequality = "Длина любой стороны треугольника не может быть больше суммы длин двух других сторон";

        public const string WrongCircleRadiusValue = "Радиус круга не может быть меньше либо равен нулю";
    }
}
