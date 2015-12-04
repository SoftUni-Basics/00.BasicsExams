using System;

class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string startChar = Console.ReadLine();

        string[] letters = { "A", "B", "C", "D", "E", "F", "G" };
        int index = Array.IndexOf(letters, startChar);

        int counter = 0;
        while (n > counter)
        {
            for (int i = 0; i < 3; i++)
            {
                PrintDNALine(letters, ref index, ref counter, i);
                if (counter == n)
                {
                    return;
                }
            }
            for (int i = 7 / 2; i >= 0; i--)
            {
                PrintDNALine(letters, ref index, ref counter, i);
                if (counter == n)
                {
                    break;
                }
            }
        }
    }

    static void PrintDNALine(string[] letters, ref int index, ref int counter, int i)
    {
        int dnaLenght = 1 + (2 * i);
        string dots = new string('.', 3 - i);
        string DNA = GetDNALine(index, dnaLenght, letters);

        Console.WriteLine("{0}{1}{0}", dots, DNA);

        index += dnaLenght;
        if (index > letters.Length - 1)
        {
            index -= (letters.Length);
        }
        counter++;
    }

    private static string GetDNALine(int start, int count, string[] letters)
    {
        string output = string.Empty;
        for (int i = 0; i < count; i++)
        {
            output += letters[start];
            start++;

            if (start > letters.Length-1)
            {
                start = 0;
            }
        }
        return output;
    }
}
