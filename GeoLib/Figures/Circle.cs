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
        }

        /// <summary>
        /// Вычисление площади 
        /// </summary>
        /// <returns></returns>
        public override double CalculateTheArea()
        {
            try
            {
                Validate.CheckCircleExistence(_radius);
                return Math.PI * Math.Pow(_radius, 2);
            }
            catch (Exception e)
            {
Console.WriteLine(e);
            }

            return 0;
        }
    }
}
