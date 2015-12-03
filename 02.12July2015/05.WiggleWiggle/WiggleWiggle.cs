using System;
using System.Linq;

class WiggleWiggle
{
    static void Main()
    {
        ulong[] input = Console.ReadLine().Split().Select(ulong.Parse).ToArray();

        int firstNum = 0;
        int secNumb = 1;
        int rounds = input.Length / 2;

        while (rounds > 0)
        {
            for (int i = 0; i < 64; i += 2)
            {
                ulong firstBit = input[firstNum] & ((ulong)1 << i);
                ulong secondBit = input[secNumb] & ((ulong)1 << i);

                if (firstBit != secondBit)
                {
                    input[firstNum] ^= (ulong)1 << i;
                    input[secNumb] ^= (ulong)1 << i;
                }
            }

            for (int i = 0; i < 63; i++)
            {
                input[firstNum] ^= (ulong)1 << i;
                input[secNumb] ^= (ulong)1 << i;
            }

            firstNum += 2;
            secNumb += 2;
            rounds--;
        }

        foreach (var number in input)
        {
            string bin = UlongToString(number);
            Console.WriteLine("{0} {1}", number, bin);
        }
    }

    static string UlongToString(ulong number)
    {
        string output = string.Empty;
        for (int i = 0; i < 63; i++)
        {
            ulong result = (number & ((ulong)1 << i)) >> i;
            output = result + output;
        }
        return output;
    }
}