int[] broevi = new int[6];
int zbirOdBroevi = 0;

for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Enter integer no.{i + 1}:");
    broevi[i] = int.Parse(Console.ReadLine());
    if (broevi[i] % 2 == 0)
    {
        zbirOdBroevi += broevi[i];
    }
}
Console.WriteLine("The result is: " + zbirOdBroevi);