namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        double radius = 5;

        Console.WriteLine($"PI = {Circle.PI}");
        Console.WriteLine($"Area = {Circle.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter = {Circle.CalculatePerimeter(radius)}");

        // Uncomment this line to see the compilation error:
        //Circle.PI = 3.14159;
    }
}