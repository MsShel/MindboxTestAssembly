using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Figures
{
    /// <summary>
    /// Represents a circle and provides a method to calculate its area.
    /// </summary>
    public class Circle : IAreaCalculatable
    {
        /// <summary>
        /// The radius of the circle.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class with the specified radius.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <exception cref="ArgumentException">Thrown when the radius is negative.</exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius must not be negative.");
            Radius = radius;
        }

        /// <summary>
        /// Calculates the area of the circle using the formula: π * radius².
        /// </summary>
        /// <returns>The area of the circle.</returns>
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}