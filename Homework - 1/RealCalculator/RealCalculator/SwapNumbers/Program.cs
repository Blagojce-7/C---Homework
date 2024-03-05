Console.WriteLine("Homework - 1!");

Console.WriteLine("========= 3 TASK - Swapnumbers ==========");


long firstNumber, secondNumber;
string textFNumber, textSNumber;

Console.WriteLine("Write first number");
while (!long.TryParse(Console.ReadLine(), out firstNumber)){
    Console.WriteLine("ERROR, please write number");
}
Console.WriteLine("Write second number");
while (!long.TryParse(Console.ReadLine(),out secondNumber))
{
    Console.WriteLine("ERROR, please write number");
}

long result1 = firstNumber;
long result2 = secondNumber;
string resultFNum = "Second number: ";
string resultSNum = "First number: ";
Console.WriteLine(resultSNum + result2);
Console.WriteLine(resultFNum + result1);

Console.ReadLine();