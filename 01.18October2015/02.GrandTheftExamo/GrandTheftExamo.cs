using System;

class GrandTheftExamo
{
    static void Main()
    {
        int numberOfEscapeAttempts = int.Parse(Console.ReadLine());
        
        long slappedThieves = 0;
        long escapeThieves = 0;
        long allBeerBottles = 0;

        for (int i = 0; i < numberOfEscapeAttempts; i++)
        {
            int amountOfThieves = int.Parse(Console.ReadLine());
            int amountOfBeers = int.Parse(Console.ReadLine());
            if (amountOfThieves > 5)
            {
                slappedThieves += 5;
                escapeThieves += amountOfThieves - 5;
            }
            else
            {
                slappedThieves += amountOfThieves;
            }
            allBeerBottles += amountOfBeers;
        }

        Console.WriteLine("{0} thieves slapped.", slappedThieves);
        Console.WriteLine("{0} thieves escaped.", escapeThieves);
        Console.WriteLine("{0} packs, {1} bottles.", (allBeerBottles / 6), (allBeerBottles % 6));
    }
}
