using GeoLib.Figures;

namespace GeoLibTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Проверка корректности вычисления площади круга  
        /// </summary>
        [Fact]
        public void Test_Correct_Calculating_Circle_Area()
        {
            var radius = 3;

            var circle = new Circle(radius);
            var circleArea = circle.CalculateTheArea();

            Assert.Equal(Math.PI * Math.Pow(radius, 2), circleArea);
        }

        /// <summary>
        /// Проверка корректности вычисления площади треугольника 
        /// </summary>
        [Fact]
        public void Test_Correct_Calculating_Triangle_Area()
        {
            double a = 2;
            double b = 4;
            double c = 5;
            var expectedArea = Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c));

            var triangle = new Triangle(a, b, c);
            var actualArea = triangle.CalculateTheArea();

            Assert.Equal(expectedArea, actualArea);
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным 
        /// </summary>
        [Fact]
        public void Test_Is_Right_Angled_Triangle()
        {
            double a = 6;
            double b = 8;
            double c = 10;

            var triangle = new Triangle(a, b, c);
            var isRightAngled = triangle.IsRightAngledTriangle();

Assert.Equal(true, isRightAngled);
        }
    }
}