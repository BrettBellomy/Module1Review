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
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the circle");
            double radius = (Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("The area of the circle is:");
            CircleArea(radius);

            Console.WriteLine("Please enter the length of the triangle");
            double baseLength = (Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Please enter the height of the triangle");
            double height = (Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("The area of the triangle is:");
            TriangleArea(baseLength, height);

            Console.WriteLine("Please enter the length of the rectangle");
            double length = (Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Please enter the width of the rectangle");
            double width = (Convert.ToDouble(Console.ReadLine()));


        }
    }
}
