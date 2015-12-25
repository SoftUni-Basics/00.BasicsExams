using System;

class LocalElections
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int vote = int.Parse(Console.ReadLine());
        string symbol = Console.ReadLine().ToUpper();

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(".............");
            if (i != vote)
            {
                Console.WriteLine(@"...+-----+...
...|.....|...
{0:00}.|.....|...
...|.....|...
...+-----+...", i);
            }
            else if (symbol == "V")
            {
                Console.WriteLine(@"...+-----+...
...|\.../|...
{0:00}.|.\./.|...
...|..V..|...
...+-----+...", i);   
            }
            else
            {
                Console.WriteLine(@"...+-----+...
...|.\./.|...
{0:00}.|..X..|...
...|./.\.|...
...+-----+...", i);
            }
        }
        Console.WriteLine(".............");
    }
}
