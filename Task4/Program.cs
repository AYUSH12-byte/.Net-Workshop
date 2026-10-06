namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        // Create an integer array with 5 favorite numbers
        int[] favoriteNumbers = { 7, 3, 9, 1, 5 };

        // Sort the array in ascending order
        Array.Sort(favoriteNumbers);

        Console.WriteLine("Sorted array:");

        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        // Reverse the sorted array
        Array.Reverse(favoriteNumbers);

        Console.WriteLine("\nReversed array:");

        // Print each element using a for loop
        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        // Find the position of a specific number
        int searchNumber = 5;
        int position = Array.IndexOf(favoriteNumbers, searchNumber);

        Console.WriteLine($"\nPosition of {searchNumber}: {position}");
    }
}