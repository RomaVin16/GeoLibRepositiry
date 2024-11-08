using GeoLib.Figures;

namespace GeoLibTests
{
    public class UnitTest1
    {
        private static double GetExpectedCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        private static double GetExpectedTriangleArea(double a, double b, double c)
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }


        /// <summary>
        /// �������� ������������ ���������� ������� �����  
        /// </summary>
        [Fact]
        public void True_Test_Correct_Calculating_Circle_Area()
        {
            var radius = 3;

            var circle = new Circle(radius);
            var circleArea = circle.CalculateTheArea();

            Assert.Equal(GetExpectedCircleArea(radius), circleArea);
        }

        /// <summary>
        /// �������� ������������ ���������� ������� �����  
        /// </summary>
        [Fact]
        public void False_Test_Correct_Calculating_Circle_Area()
        {
            double radius = -1;

            var exception = Record.Exception(() => new Circle(radius));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentException>(exception);
            Assert.Contains("���� � ����� �������� �� ����������.", exception.Message);
        }

        /// <summary>
        /// �������� ������������ ���������� ������� ������������ 
        /// </summary>
        [Fact]
        public void True_Test_Correct_Calculating_Triangle_Area()
        {
            double a = 2;
            double b = 4;
            double c = 5;

            var triangle = new Triangle(a, b, c);
            var actualArea = triangle.CalculateTheArea();

            Assert.Equal(GetExpectedTriangleArea(a, b, c), actualArea);
        }

        /// <summary>
        /// �������� ������������ ���������� ������� ������������ 
        /// </summary>
        [Fact]
        public void False_Test_Correct_Calculating_Triangle_Area()
        {
            double a = 2;
            double b = 3;
            double c = 5;

            var exception = Record.Exception(() => new Triangle(a, b, c));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentException>(exception);
            Assert.Contains("����������� �� ����������.", exception.Message);
        }

        /// <summary>
        /// ��������, �������� �� ����������� ������������� (������������� ���������) 
        /// </summary>
        [Fact]
        public void true_Test_Is_Right_Angled_Triangle()
        {
            double a = 6;
            double b = 8;
            double c = 10;

            var triangle = new Triangle(a, b, c);
            var isRightAngled = triangle.IsRightAngledTriangle();

Assert.Equal(true, isRightAngled);
        }

        /// <summary>
        /// ��������, �������� �� ����������� ������������� (������������� ���������) 
        /// </summary>
        [Fact]
        public void False_Test_Is_Right_Angled_Triangle()
        {
            double a = 2;
            double b = 4;
            double c = 5;

            var triangle = new Triangle(a, b, c);
            var isRightAngled = triangle.IsRightAngledTriangle();

            Assert.Equal(false, isRightAngled);
        }
    }
}