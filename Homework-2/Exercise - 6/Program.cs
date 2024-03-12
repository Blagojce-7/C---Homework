
string firstName = "Blagojce";
string secondName = "Ronaldo";
string thirdName = "Trajko";

string[] anArrayOfNames = new string[3];
anArrayOfNames[0] = firstName;
anArrayOfNames[1] = secondName;
anArrayOfNames[2] = thirdName;

Console.WriteLine("Enter a name you would like to put to an existing array: ");
string newAddedName = Console.ReadLine();
Array.Resize(ref anArrayOfNames, 4);

anArrayOfNames[3] = newAddedName;

for (int i = 0; i < anArrayOfNames.Length; i++)
{
    Console.WriteLine("Would you like to put another name in the same array?: (Y/N)");
    string character = Console.ReadLine();
    if (character == "Y" || character == "y" || character == "N" || character == "n")
    {
        Console.WriteLine("Write the name: ");
        string anotherNameToAdd = Console.ReadLine();
        Array.Resize(ref anArrayOfNames, 4 + i);
        anArrayOfNames[3 + i] = anotherNameToAdd;
    }
    else
    {
        foreach (string name in anArrayOfNames)
        {
            Console.WriteLine(name);
        }
        break;
    }
}
