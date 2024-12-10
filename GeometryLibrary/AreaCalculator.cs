using GeometryLibrary.Figures;

namespace GeometryLibrary
{
    /// <summary>
    /// Provides a method for calculating the area of a given shape.
    /// This class is designed to work with any shape that implements the IAreaCalculatetable interface.
    /// </summary>
    public static class AreaCalculator
    {
        /// <summary>
        /// Calculates the area of the given shape by calling its CalculateArea method.
        /// </summary>
        /// <param name="shape">An object that implements the IAreaCalculatetable interface, representing the shape.</param>
        /// <returns>The area of the shape as a <c>double</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the provided shape is null.</exception>
        public static double CalculateArea(IAreaCalculatetable shape)
        {
            if (shape == null)
            {
                throw new ArgumentNullException(nameof(shape), "Shape cannot be null.");
            }

            return shape.CalculateArea();
        }
    }
}