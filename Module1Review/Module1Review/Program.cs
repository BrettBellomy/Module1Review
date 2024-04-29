namespace Module1Review
{
    internal class Program
    {
        static double CircleArea(double radius)
        {
            return 3.14159 * radius * radius;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the circle");
            double radius = (Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("The area of the circle is:");
            CircleArea(radius);
        }
    }
}
