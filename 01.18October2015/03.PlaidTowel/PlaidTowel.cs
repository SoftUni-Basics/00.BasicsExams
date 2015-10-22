using System;

class PlaidTowel
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char bgSymb = char.Parse(Console.ReadLine());
        char rmbSymb = char.Parse(Console.ReadLine());

        string outLine = new string(bgSymb, size) + rmbSymb + new string(bgSymb, (size * 2) - 1) + rmbSymb + new string(bgSymb, size);
        string middleLine = rmbSymb + new string(bgSymb, (size * 2) - 1) + rmbSymb + new string(bgSymb, (size * 2) - 1) + rmbSymb;

        Console.WriteLine(outLine);
        for (int i = 0; i < 2; i++)
        {
            for (int up = 0; up < size - 1; up++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{6}{5}{4}{3}{2}{1}{0}",
                    new string(bgSymb, (size - 1) - up), rmbSymb, new string(bgSymb, up), bgSymb,
                    new string(bgSymb, up), rmbSymb, new string(bgSymb, (size - 2) - up), bgSymb);
            }

            Console.WriteLine(middleLine);
            for (int down = 0; down < size - 1; down++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{6}{5}{4}{3}{2}{1}{0}",
                    new string(bgSymb, down + 1), rmbSymb, new string(bgSymb, (size - 2) - down), bgSymb,
                    new string(bgSymb, (size - 2) - down), rmbSymb, new string(bgSymb, down), bgSymb);
            }
            Console.WriteLine(outLine);
        }

    }
}
