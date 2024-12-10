using GeometryLibrary.Figures;

namespace GeometryLibrary.Tests
{
    /// <summary>
    /// Contains unit tests for the <see cref="Circle"/> class to validate its functionality.
    /// </summary>
    public class CircleTests
    {
        /// <summary>
        /// Test to verify the calculation of the area of a circle with different radii.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <param name="expectedArea">The expected area of the circle for the given radius.</param>
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 3.14159)]
        [InlineData(3, 28.27433)]
        [InlineData(5, 78.53981634)]
        public void CalculateArea_Circle_WithDifferentRadius_ReturnsCorrectArea(double radius, double expectedArea)
        {
            var circle = new Circle(radius);
            var area = circle.CalculateArea();

            Assert.Equal(expectedArea, area, precision: 5);
        }

        /// <summary>
        /// Test to verify that an exception is thrown when creating a circle with a non-positive radius.
        /// </summary>
        [Fact]
        public void Circle_ThrowsException_WhenRadiusIsNonPositive()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}