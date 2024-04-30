using System.Transactions;

namespace Module1Review
{
    internal class Program
    {
        static double CircleArea(double radius)
        {
            return 3.14159 * radius * radius;
        }
        static double TriangleArea(double baseLength, double height)
        {
            return .5 * baseLength * height;
        }
        static double RectangleArea(double length, double width)
        {
            return length * width;
        }
        static double SquareAre(double side)
        {
            return side * side;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the shape you would like to calculate the area of. Please enter the following:\n'Circle' for circle\n'Triangle' for triangle\n'Rectangle' for rectangle\n'Square' for square");
            string shape = Console.ReadLine();
            if (shape == "Circle")
            {
                Console.WriteLine("Please enter the radius of the circle");
                double radius = (Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("The area of the circle is:");
                double areaOfCircle = CircleArea(radius);
                Console.WriteLine(areaOfCircle);
            }
            else if (shape == "Triangle")
            {
                Console.WriteLine("Please enter the length of the triangle");
                double baseLength = (Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Please enter the height of the triangle");
                double height = (Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("The area of the triangle is:");
                double areaOfTriangle = TriangleArea(baseLength, height);
                Console.WriteLine(areaOfTriangle);
            }
            else if (shape == "Rectangle")
            {
                Console.WriteLine("Please enter the length of the rectangle");
                double length = (Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Please enter the width of the rectangle");
                double width = (Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("The are of the rectangle is:");
                double areaOfRectangle = RectangleArea(length, width);
                Console.WriteLine(areaOfRectangle);
            }
            else if (shape == "Square")
            {
                Console.WriteLine("Please enter the side length of  the square");
                double side = (Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("The are of the square is:");
                double areaOfSquare = SquareAre(side);
                Console.WriteLine(areaOfSquare);
            }
            else
            {
                Console.WriteLine($"I'm sorry, but '{shape}' was not a valid response. Please restart the program and try again");
            }
            
        }
    }
}
