# GeometryLibrary

## Assembly
- **Name**: GeometryLibrary

## Classes

### `GeometryLibrary.Figures.Circle`
Represents a circle and provides a method to calculate its area.

#### Properties
- **Radius**  
  The radius of the circle.

#### Methods
- **`#ctor(System.Double)`**  
  Initializes a new instance of the `Circle` class with the specified radius.  
  - **radius**: The radius of the circle.  
  - **Throws**: `System.ArgumentException` if the radius is negative.

- **`CalculateArea()`**  
  Calculates the area of the circle using the formula: `π * radius²`.  
  - **Returns**: The area of the circle.

### `GeometryLibrary.Figures.Triangle`
Represents a triangle with three sides and provides methods for calculating its area and checking if it's a right triangle.

#### Properties
- **SideA**  
  The length of the first side of the triangle.

- **SideB**  
  The length of the second side of the triangle.

- **SideC**  
  The length of the third side of the triangle.

#### Methods
- **`#ctor(System.Double, System.Double, System.Double)`**  
  Initializes a new instance of the `Triangle` class with the specified side lengths.  
  - **sideA**: The length of the first side of the triangle.  
  - **sideB**: The length of the second side of the triangle.  
  - **sideC**: The length of the third side of the triangle.  
  - **Throws**: `System.ArgumentException` if any side is less than or equal to zero, or when the triangle inequality is violated.

- **`CalculateArea()`**  
  Calculates the area of the triangle using Heron's formula.  
  - **Returns**: The area of the triangle.

- **`IsRightTriangle()`**  
  Checks if the triangle is a right triangle using the Pythagorean theorem.  
  - **Returns**: `true` if the triangle is a right triangle, otherwise `false`.

### `GeometryLibrary.Interfaces.IAreaCalculatable`
Interface for objects, shapes, or figures that can calculate their area. Any class that implements this interface must provide an implementation for the `CalculateArea` method to compute the area of the shape.

#### Methods
- **`CalculateArea()`**  
  Method to calculate the area of the shape.  
  - **Returns**: The area of the shape as a `double`.

### `GeometryLibrary.Providers.AreaCalculator`
Provides a method for calculating the area of a given shape. This class is designed to work with any shape that implements the `IAreaCalculatable` interface.

#### Methods
- **`CalculateArea(GeometryLibrary.Interfaces.IAreaCalculatable)`**  
  Calculates the area of the given shape by calling its `CalculateArea` method.  
  - **shape**: An object that implements the `IAreaCalculatable` interface, representing the shape.  
  - **Returns**: The area of the shape as a `double`.  
  - **Throws**: `System.ArgumentNullException` if the provided shape is null.
