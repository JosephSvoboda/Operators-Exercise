namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;

            int b = 4;

            int add = a + b;

            int sub = a - b;

            int mult = a * b;

            int quotient = a / b;

            int remainder = a % b;

                Console.WriteLine($"{a}/{b} is {b} remainder {remainder}");
                Console.WriteLine();

            double AreaOfCircle(double r)
            {
                double radius = Math.PI * Math.Pow(r, 2);
                return radius;
            }

                Console.Write("What is the radius of your circle?:");

            double radius = double.Parse(Console.ReadLine());

                Console.WriteLine($"The area of a circle with the radius of {radius} is {AreaOfCircle(radius)}");
        }
    }
}