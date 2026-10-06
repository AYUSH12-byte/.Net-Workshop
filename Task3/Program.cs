namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        // Declare and initialize different data types
        byte byteValue = 10;
        short shortValue = 1000;
        int intValue = 42;
        long longValue = 100000L;
        float floatValue = 3.14f;
        double doubleValue = 3.14159;
        decimal decimalValue = 99.99m;
        char charValue = 'A';
        bool boolValue = true;

        // Type conversion
        string intToString = intValue.ToString();
        double stringToDouble = Convert.ToDouble("3.14");

        // Print all variables
        Console.WriteLine($"byte    - Type: {byteValue.GetType().Name}, Value: {byteValue}");
        Console.WriteLine($"short   - Type: {shortValue.GetType().Name}, Value: {shortValue}");
        Console.WriteLine($"int     - Type: {intValue.GetType().Name}, Value: {intValue}");
        Console.WriteLine($"long    - Type: {longValue.GetType().Name}, Value: {longValue}");
        Console.WriteLine($"float   - Type: {floatValue.GetType().Name}, Value: {floatValue}");
        Console.WriteLine($"double  - Type: {doubleValue.GetType().Name}, Value: {doubleValue}");
        Console.WriteLine($"decimal - Type: {decimalValue.GetType().Name}, Value: {decimalValue}");
        Console.WriteLine($"char    - Type: {charValue.GetType().Name}, Value: {charValue}");
        Console.WriteLine($"bool    - Type: {boolValue.GetType().Name}, Value: {boolValue}");

        Console.WriteLine($"int to string - Type: {intToString.GetType().Name}, Value: {intToString}");
        Console.WriteLine($"string to double - Type: {stringToDouble.GetType().Name}, Value: {stringToDouble}");
    }
}