using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLib.Helpers
{
    public static class Validate
    {
        /// <summary>
        /// Проверка круга на существование 
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void CheckCircleExistence(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Круг с таким радиусом не существует.");
            }
        }

        /// <summary>
        /// Проверка треугольника на существование 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void CheckTriangleExistence(double a, double b, double c)
        {
            if (new[] { a, b, c }.Any(x => x <= 0))
                throw new ArgumentException(" Длины сторон должны быть положительными. ");

            if (!(a + b > c && a + c > b && b + c > a))
            {
                throw new ArgumentException("Треугольник не существует.");
            }
            
        }
    }
}
