namespace GeometryLibrary.Figures
{
    /// <summary>
    /// Represents a triangle with three sides and provides methods for calculating its area and checking if it's a right triangle.
    /// </summary>
    public class Triangle : IAreaCalculatetable
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        // Measurement error threshold for checking if the triangle is right-angled.
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

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        /// <summary>
        /// Calculates the area of the triangle using Heron's formula.
        /// </summary>
        /// <returns>The area of the triangle.</returns>
        public double CalculateArea()
        {
            var semiPerimeter = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
        }

        /// <summary>
        /// Checks if the triangle is a right triangle using the Pythagorean theorem.
        /// </summary>
        /// <returns><c>true</c> if the triangle is a right triangle, otherwise <c>false</c>.</returns>
        public bool IsRightTriangle()
        {
            double[] sides = [_sideA, _sideB, _sideC];
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < MeasurementError;
        }
    }
}