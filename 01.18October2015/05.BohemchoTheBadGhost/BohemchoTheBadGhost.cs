using System;
using System.Linq;

class BohemchoTheBadGhost
{
    static void Main()
    {
        long score = 0;
        int lightsCounter = 0;
        while (true)
        {
            uint curentPoints = 0;
            string input = Console.ReadLine();

            if (input == "Stop, God damn it")
            {
                break;
            }
            else
            {
                uint floor = uint.Parse(input);
                int[] apartments = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                curentPoints = floor;

                for (int i = 0; i < apartments.Length; i++)
                {
                    curentPoints ^= ((uint)1 << apartments[i]);
                }
                score += curentPoints;

                while (curentPoints > 0)
                {
                    if ((curentPoints & 1) == 1)
                    {
                        lightsCounter++;
                    }
                    curentPoints >>= 1;
                }
            }
        }
        Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", lightsCounter, score);
    }
}
