using MontyHall;

namespace MontyHall;

internal class Program
{
    static void Main()
    {
        int antalGentagelser = 100;
        float antalVundet = 0;

        Random rand = new Random();

        for (int i = 1; i <= antalGentagelser; i++)
        {
            int winDoor = rand.Next(3);
            int firstPick = rand.Next(3);

            if (winDoor != firstPick)
            {
                antalVundet++;
            }

        }
        var antal = (antalVundet / antalGentagelser) * 100.00;
        Console.WriteLine(antal);
    }
}
