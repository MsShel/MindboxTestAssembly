namespace GeometryLibrary.Figures
{
    /// <summary>
    /// Represents a circle and provides a method to calculate its area.
    /// </summary>
    public class Circle : IAreaCalculatetable
    {
        private readonly double _radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class with the specified radius.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <exception cref="ArgumentException">Thrown when the radius is negative.</exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius must not be negative.");
            _radius = radius;
        }

        /// <summary>
        /// Calculates the area of the circle using the formula: π * radius².
        /// </summary>
        /// <returns>The area of the circle.</returns>
        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}