Console.WriteLine("Homework - 1");

Console.WriteLine("========= 2 TASK - AverageNumber ==========");

int firstNumber, secondNumber, thirdNumber, fourNumber;

Console.WriteLine("Enter first number: ");
if (!int.TryParse(Console.ReadLine(), out firstNumber))
{
    Console.WriteLine("Invalid input.Please next time enter a valid number:");
}
Console.WriteLine("Enter second number: ");
if (!int.TryParse(Console.ReadLine(), out secondNumber))
{
    Console.WriteLine("Invalid input.Please next time enter a valid number:");
}
Console.WriteLine("Enter third number: ");
if (!int.TryParse(Console.ReadLine(), out thirdNumber))
{
    Console.WriteLine("Invalid input.Please next time enter a valid number:");
}
Console.WriteLine("Enter four number: ");
if (!int.TryParse(Console.ReadLine(), out fourNumber))
{
    Console.WriteLine("Invalid input.Please next time enter a valid number:");
}

// So WHILE mislam e podobro mesto IF vo ovaa situacija

int resultFromNumbers = firstNumber + secondNumber + thirdNumber + fourNumber;
int finalResult = (firstNumber + secondNumber + thirdNumber + fourNumber) / 4;
Console.WriteLine($"{firstNumber} + {secondNumber} + {thirdNumber} + {fourNumber} = {resultFromNumbers} and average number is: {finalResult}");

Console.ReadLine();

