namespace Task_2;

class Circle
{
    public const double PI = 3.14;
    public double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    public double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PI = " + Circle.PI);
        //pi value is already declared as constant so it cannot be modifed and it shows the error saying the left hand side of an assignment must be a variable , property or indexer
        Circle.PI = 3.14159;

        Console.WriteLine("PI = " + Circle.PI);
    }
}