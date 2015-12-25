using System;
using System.Linq;

class SudokuResults
{
    static void Main()
    {
        int count = 0;

        int timeSumSeconds = 0;

        while (true)
        {
            string[] input = Console.ReadLine().Split(':').ToArray();
            
            if (input[0] != "Quit")
            {
                timeSumSeconds += (int.Parse(input[0]) * 60) + int.Parse(input[1]);
                count++;
            }
            else
            {
                break;
            }
        }

        int average = (int)Math.Ceiling((double)timeSumSeconds / count);

        if (average < 720)
        {
            Console.WriteLine("Gold Star");
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", count, average);
        }
        else if (average >= 720 && average <= 1440)
        {
            Console.WriteLine("Silver Star");
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", count, average);
        }
        else
        {
            Console.WriteLine("Bronze Star");
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", count, average);
        }
    }
}

/*
Gold Star
Games - 3 \ Average seconds - 600
 */
/*
10:00
05:00
15:00
Quit
 */