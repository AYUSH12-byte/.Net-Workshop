namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        // Create a List<string> containing 3 favorite fruits
        List<string> fruits = new List<string>
        {
            "Mango",
            "Apple",
            "Banana"
        };

        // Add a new fruit
        fruits.Add("Orange");

        // Remove one fruit
        fruits.Remove("Apple");

        // Print all fruits using foreach loop
        Console.WriteLine("Fruits in the list:");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Create a Dictionary<int, string>
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Mango" },
            { 2, "Apple" },
            { 3, "Banana" }
        };

        // Add a new entry to the dictionary
        fruitDictionary.Add(4, "Orange");

        // Print all key-value pairs
        Console.WriteLine("\nFruit Dictionary:");

        foreach (KeyValuePair<int, string> item in fruitDictionary)
        {
            Console.WriteLine($"ID: {item.Key}, Fruit: {item.Value}");
        }
    }
}