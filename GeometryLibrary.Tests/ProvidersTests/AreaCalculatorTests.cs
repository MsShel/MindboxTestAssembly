using GeometryLibrary.Figures;
using GeometryLibrary.Interfaces;
using GeometryLibrary.Providers;

namespace GeometryLibrary.Tests.ProvidersTests
{
    /// <summary>
    /// This class contains unit tests for the AreaCalculator class, 
    /// verifying the correct calculation of areas for different shapes 
    /// (e.g., Circle, Triangle) and ensuring proper handling of invalid inputs.
    /// </summary>
    public class AreaCalculatorTests
    {
        /// <summary>
        /// Test to verify the calculation of the area of a circle.
        /// </summary>
        [Fact]
        public void CalculateArea_Circle_ReturnsCorrectArea()
        {
            var circle = new Circle(5);
            var area = AreaCalculator.CalculateArea(circle);

            Assert.Equal(78.53981633974483, area, precision: 5);
        }

        /// <summary>
        ///  Test to verify the calculation of the area of a triangle.
        /// </summary>
        [Fact]
        public void CalculateArea_Triangle_ReturnsCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);
            var area = AreaCalculator.CalculateArea(triangle);

            Assert.Equal(6, area, precision: 5);
        }

        /// <summary>
        ///  Test to verify the calculation of the null IFigure.
        /// </summary>
        [Fact]
        public void CalculateArea_InvalidShape_ThrowsException()
        {
            IAreaCalculatable nullShape = null;

            Assert.Throws<ArgumentNullException>(() => AreaCalculator.CalculateArea(nullShape));
        }
    }
}