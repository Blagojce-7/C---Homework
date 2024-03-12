Console.WriteLine("Enter student group: ( there are 1 and 2 )");

string[] studentsG1 = {"Blagojce", "Riste", "Trajko", "Irina", "Vlatko"};
string[] studentsG2 = { "Nikola", "Aleksandar", "Gordana", "Sasho", "Vlado" };

int groupNumber = int.Parse(Console.ReadLine());

if (groupNumber == 1)
{
    Console.WriteLine("The students G1: ");
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}

if (groupNumber == 2)
{
    Console.WriteLine("The students G2: ");
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}

else
{
    Console.WriteLine("ERROR, please next time enter 1 or 2");
}