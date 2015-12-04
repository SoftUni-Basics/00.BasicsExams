using System;

class MagicCarNumbers
{
    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());

        char[] lastInit = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        int magicCounter = 0;

        for (int i = 0; i <= 9999; i++)
        {
            string digits = i.ToString().PadLeft(4, '0');

            bool format = CheckFormatNumber(digits);
            int digitSum = 0;

            if (format)
            {
                for (int d = 0; d < digits.Length; d++)
                {
                    digitSum += int.Parse(digits[d].ToString());
                }

                for (int x = 0; x < lastInit.Length; x++)
                {
                    for (int y = 0; y < lastInit.Length; y++)
                    {
                        int townInitCA = 40;
                        int carWeight = townInitCA + digitSum + GetSymbolValue(lastInit[x]) + GetSymbolValue(lastInit[y]);

                        if (carWeight == magicWeight)
                        {
                            magicCounter++;
                        }
                    }
                }
            }
        }
        Console.WriteLine(magicCounter);
    }

    static bool CheckFormatNumber(string digits)
    {
        //  "aaaa" "abbb" "aaab" "aa bb" "ab ab" "abba"
        bool format =
            (digits[0] == digits[1] && digits[0] == digits[2] && digits[0] == digits[3]) ||
            (digits[0] != digits[1] && digits[1] == digits[2] && digits[1] == digits[3]) ||
            (digits[0] == digits[1] && digits[0] == digits[2] && digits[0] != digits[3]) ||
            (digits[0] == digits[1] && digits[1] != digits[2] && digits[2] == digits[3]) ||
            (digits[0] != digits[1] && digits[0] == digits[2] && digits[1] == digits[3]) ||
            (digits[0] != digits[1] && digits[1] == digits[2] && digits[0] == digits[3]);
        return format;
    }

    static int GetSymbolValue(char symbol)
    {
        int value = 0;
        switch (symbol)
        {
            case 'A': value = 10; break;
            case 'B': value = 20; break;
            case 'C': value = 30; break;
            case 'E': value = 50; break;
            case 'H': value = 80; break;
            case 'K': value = 110; break;
            case 'M': value = 130; break;
            case 'P': value = 160; break;
            case 'T': value = 200; break;
            case 'X': value = 240; break;
        }
        return value;
    }
}
