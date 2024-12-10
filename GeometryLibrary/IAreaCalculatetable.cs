namespace GeometryLibrary
{
    /// <summary>
    /// Interface for shapes that can calculate their area.
    /// Any class that implements this interface must provide an implementation 
    /// for the CalculateArea method to compute the area of the shape.
    /// </summary>
    public interface IAreaCalculatetable
    {
        /// <summary>
        /// Method to calculate the area of the shape.
        /// </summary>
        /// <returns>The area of the shape as a double.</returns>
        double CalculateArea();
    }
}