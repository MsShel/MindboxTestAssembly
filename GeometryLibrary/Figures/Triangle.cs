using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Figures
{
    /// <summary>
    /// Represents a triangle with three sides and provides methods for calculating its area and checking if it's a right triangle.
    /// </summary>
    public class Triangle : IAreaCalculatable
    {
        /// <summary>
        /// The length of the first side of the triangle.
        /// </summary>
        public double SideA { get; }
        /// <summary>
        /// The length of the second side of the triangle.
        /// </summary>
        public double SideB { get; }
        /// <summary>
        /// The length of the third side of the triangle.
        /// </summary>
        public double SideC;

        // Measurement error threshold for checking if the triangle is right-angled.
        // This precision is chosen to accommodate floating-point arithmetic limitations.
        private const double MeasurementError = 1e-10;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class with the specified side lengths.
        /// </summary>
        /// <param name="sideA">The length of first side of the triangle.</param>
        /// <param name="sideB">The length of second side of the triangle.</param>
        /// <param name="sideC">The length of third side of the triangle.</param>
        /// <exception cref="ArgumentException">Thrown when any side is less than or equal to zero,or when the triangle inequality is violated.</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Sides must be greater than zero.");
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("The sum of any two sides must be greater than the third side.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Calculates the area of the triangle using Heron's formula.
        /// </summary>
        /// <returns>The area of the triangle.</returns>
        public double CalculateArea()
        {
            var semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        /// <summary>
        /// Checks if the triangle is a right triangle using the Pythagorean theorem.
        /// </summary>
        /// <returns><c>true</c> if the triangle is a right triangle, otherwise <c>false</c>.</returns>
        public bool IsRightTriangle()
        {
            double[] sides = [SideA, SideB, SideC];
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < MeasurementError;
        }
    }
}