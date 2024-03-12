Console.WriteLine("\n\n======== Exercise 5 ============ \n");

int[] fiveElements = new int[5];
int result = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Enter number - {i + 1}: ");
    try
    {
        fiveElements[i] = int.Parse(Console.ReadLine());
        result += fiveElements[i];
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        i--;
    }
}

Console.WriteLine($"Result of numbers = {result}");
