namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        // Create a DateTime variable representing birthdate
        DateTime birthDate = new DateTime(2000, 1, 15);

        // Create a DateTime variable representing current date and time
        DateTime currentDate = DateTime.Now;

        // Calculate the difference between current date and birthdate
        TimeSpan ageDifference = currentDate - birthDate;

        // Calculate age in years
        int age = (int)(ageDifference.TotalDays / 365.25);

        // Print the required information
        Console.WriteLine($"Birthdate: {birthDate:dd/MM/yyyy}");
        Console.WriteLine($"Current Date and Time: {currentDate}");
        Console.WriteLine($"Age: {age} years");

        // Add 10 days to the birthdate
        DateTime dateAfter10Days = birthDate.AddDays(10);

        Console.WriteLine($"Birthdate after 10 days: {dateAfter10Days:dd/MM/yyyy}");
    }
}