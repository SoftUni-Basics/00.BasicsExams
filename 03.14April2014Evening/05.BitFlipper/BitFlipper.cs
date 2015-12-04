using System;

class BitFlipper
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        
        int countZeros = 0;
        int countOnes = 0;
        
        for (int i = 64 - 1; i >= 0; i--)
        {
            ulong bit = (input >> i) & 1;
            
            if (bit == 1)
            {
                countOnes++;
                countZeros = 0;
            }
            else
            {
                countZeros++;
                countOnes = 0;
            }

            if (countOnes == 3 || countZeros == 3)
            {
                for (int b = 0; b < 3; b++)
                {
                    int pos = (i + b);

                    input ^= (ulong)1 << pos;
                }
                countOnes = 0;
                countZeros = 0;
            }
        }
        
        Console.WriteLine(input);
    }
}
