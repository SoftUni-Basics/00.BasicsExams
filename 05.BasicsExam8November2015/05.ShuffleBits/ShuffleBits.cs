using System;

class ShuffleBits
{
    static void Main()
    {
        uint first = uint.Parse(Console.ReadLine());
        uint second = uint.Parse(Console.ReadLine());

        ulong result = 0;

        if (first >= second)
        {
            for (int i = 0; i < 32; i++)
            {
                uint firstBit = (first >> (31 - i)) & 1;
                uint secBit = (second >> (31 - i)) & 1;
                result = (result << 1) | firstBit;
                result = (result << 1) | secBit;
            }
        }
        else
        {
            for (int i = 0; i < 32; i += 2)
            {
                uint firstBit = (first >> (31 - i)) & 1;
                result = (result << 1) | firstBit;
                firstBit = (first >> (31 - (i + 1))) & 1;
                result = (result << 1) | firstBit;

                uint secBit = (second >> (31 - i)) & 1;
                result = (result << 1) | secBit;
                secBit = (second >> (31 - (i + 1))) & 1;
                result = (result << 1) | secBit;
            }
        }
        Console.WriteLine(result);
    }
}
