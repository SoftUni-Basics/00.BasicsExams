using System;

class SummertimeForProgrammers
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int halfInput = input / 2;

        Console.WriteLine("{0}{1}{1}{0}", new string(' ', halfInput), new string('*', halfInput+1));
        for (int i = 0; i < halfInput; i++)
        {
            Console.WriteLine("{0}*{0}{0}*{0}", new string(' ', halfInput));
        }
        for (int i = 0; i < halfInput; i++)
        {
            Console.WriteLine("{0}*{1}{1}*{0}", new string(' ', halfInput - i), new string(' ', halfInput + i));
        }
        for (int i = 0; i < input; i++)
        {
            Console.WriteLine("*{0}*", new string('.', (input * 2) - 2));
        } 
        for (int i = 0; i < input; i++)
        {
            Console.WriteLine("*{0}*", new string('@', (input * 2) - 2));
        }
        Console.WriteLine("{0}", new string('*', input * 2));
    }
}
