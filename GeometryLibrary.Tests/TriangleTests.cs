using GeometryLibrary.Figures;

namespace GeometryLibrary.Tests
{
    /// <summary>
    /// Contains unit tests for the <see cref="Triangle"/> class to validate its functionality.
    /// </summary>
    public class TriangleTests
    {
        /// <summary>
        /// Test to verify the calculation of the area of a triangle.
        /// </summary>
        /// <param name="sideA">First side length.</param>
        /// <param name="sideB">Second side length.</param>
        /// <param name="sideC">Third side length.</param>
        /// <param name="expectedArea">Area of the given triangle.</param>
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 6, 7, 14.696938456699069)]
        public void Triangle_CalculateArea_ReturnsCorrectResult(double sideA, double sideB, double sideC,
            double expectedArea)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            var calculatedArea = triangle.CalculateArea();

            Assert.Equal(expectedArea, calculatedArea, precision: 5);
        }

        /// <summary>
        /// Test to verify if the triangle is a right triangle using the Pythagorean theorem.
        /// </summary>
        [Fact]
        public void Triangle_IsRightTriangle_ReturnsTrueForRightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            var isRight = triangle.IsRightTriangle();

            Assert.True(isRight);
        }

        /// <summary>
        /// Test to verify that a non-right triangle is correctly identified as not being a right triangle.
        /// </summary>
        [Fact]
        public void Triangle_IsRightTriangle_ReturnsFalseForNonRightTriangle()
        {
            var triangle = new Triangle(2, 3, 4);
            var isRight = triangle.IsRightTriangle();

            Assert.False(isRight);
        }

        /// <summary>
        /// Test for creating a triangle with invalid sides.
        /// </summary>
        /// <param name="sideA">First side length.</param>
        /// <param name="sideB">Second side length.</param>
        /// <param name="sideC">Third side length.</param>
        [Theory]
        [InlineData(1, 2, 10)]
        [InlineData(0, 4, 5)]
        [InlineData(2, 3, -4)]
        public void Triangle_ThrowsException_WhenSidesAreInvalid(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }
    }
}