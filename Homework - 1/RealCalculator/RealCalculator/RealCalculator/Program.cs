Console.WriteLine("Homework - 1");

Console.WriteLine("========= 1 TASK RealCalculator==================");

double firstNumber, secondNumber, result;
char operation;

Console.WriteLine("Enter the First number:");
while (!double.TryParse(Console.ReadLine(), out firstNumber))
{
    Console.WriteLine("Invalid input. Please enter a valid number:");
}

Console.WriteLine("Enter the Second number:");
while (!double.TryParse(Console.ReadLine(), out secondNumber))
{
    Console.WriteLine("Invalid input. Please enter a valid number:");
}
Console.WriteLine("Enter the Operation (+, -, *, /):");
while (!char.TryParse(Console.ReadLine(), out operation) ||
       (operation != '+' && operation != '-' && operation != '*' && operation != '/'))
{
    Console.WriteLine("Invalid operation. Please enter a valid operation (+, -, *, /):");
}

switch (operation)
{
    case '+':
        result = firstNumber + secondNumber;
        Console.WriteLine($"The result of {firstNumber} + {secondNumber} is: {result}");
        break;
    case '-':
        result = firstNumber - secondNumber;
        Console.WriteLine($"The result of {firstNumber} - {secondNumber} is: {result}");
        break;
    case '*':
        result = firstNumber * secondNumber;
        Console.WriteLine($"The result of {firstNumber} * {secondNumber} is: {result}");
        break;
    case '/':
        if (secondNumber != 0)
        {
            result = firstNumber / secondNumber;
            Console.WriteLine($"The result of {firstNumber} / {secondNumber} is: {result}");
        }
        else
        {
            Console.WriteLine("Error: Division by zero!");
            return;
        }
        break;
}

Console.ReadLine();

