using GeoLib.Abstractions;
using GeoLib.Helpers;

namespace GeoLib.Figures
{
    public class Circle: Figure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
            Validate.CheckCircleExistence(_radius);
        }

        /// <summary>
        /// Вычисление площади 
        /// </summary>
        /// <returns></returns>
        public override double CalculateTheArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
