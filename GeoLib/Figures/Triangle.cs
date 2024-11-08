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
        }

        /// <summary>
        /// Вычисление площади 
        /// </summary>
        /// <returns></returns>
        public override double CalculateTheArea()
        {
            try
            {
                Validate.CheckTriangleExistence(_a, _b, _c);

                var p = (_a + _b + _c) / 2;

                return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return 0;
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным 
        /// </summary>
        /// <returns></returns>
        public bool IsRightAngledTriangle()
        {
            Validate.CheckTriangleExistence(_a, _b, _c);

            var sortedSides = new[] { _a, _b, _c };
            Array.Sort(sortedSides);

            return Math.Pow(sortedSides[0], 2) + Math.Pow(sortedSides[1], 2) == Math.Pow(sortedSides[2], 2);
        }
    }
}
