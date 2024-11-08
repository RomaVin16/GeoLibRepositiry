using GeoLib.Abstractions;
using GeoLib.Helpers;

namespace GeoLib.Figures
{
    public class Triangle : Figure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;

            Validate.CheckTriangleExistence(_a, _b, _c);
        }

        /// <summary>
        /// Вычисление площади 
        /// </summary>
        /// <returns></returns>
        public override double CalculateTheArea()
        {
            var p = (_a + _b + _c) / 2;

                return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным 
        /// </summary>
        /// <returns></returns>
        public bool IsRightAngledTriangle()
        {
            var sortedSides = new[] { _a, _b, _c };
            Array.Sort(sortedSides);

            return Math.Pow(sortedSides[0], 2) + Math.Pow(sortedSides[1], 2) == Math.Pow(sortedSides[2], 2);
        }
    }
}
