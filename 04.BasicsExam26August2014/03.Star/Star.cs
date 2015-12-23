using System;

class Star
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('.', input));

        for (int i = 0; i < (input / 2) - 1; i++)
        {
            Console.WriteLine("{0}*{1}.{1}*{0}",
                              new string('.', input - (1 + i)), new string('.', i));
        }

        Console.WriteLine("{0}*{1}.{1}*{0}",
                          new string('*', input / 2), new string('.', (input / 2) - 1));
        for (int i = 1; i <= (input / 2) - 1; i++)
        {
            Console.WriteLine("{0}*{1}.{1}*{0}",
                              new string('.', i), new string('.', input - (1 + i)));
        }

        Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', input / 2), new string('.', (input / 2) - 1));

        for (int i = 0; i < (input / 2) - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}.{2}*{1}*{0}",
                              new string('.', input / 2 - (1 + i)),
                              new string('.', (input / 2) - 1),
                              new string('.', i));
        }
        Console.WriteLine("{0}*{1}.{1}*{0}",
                          new string('*', input / 2), new string('.', (input / 2) - 1));
    }
}
