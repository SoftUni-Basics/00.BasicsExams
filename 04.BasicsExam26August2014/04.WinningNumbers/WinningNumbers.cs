using System;

class WinningNumbers
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        int letSum = 0;

        foreach (var letter in input)
        {
            letSum += (int)letter - 96;
        }

        // Console.WriteLine(letSum);
        bool winNumbers = false;

        for (int a = 1; a <= 9; a++)
        {
            for (int b = 1; b <= 9; b++)
            {
                for (int c = 1; c <= 9; c++)
                {
                    for (int d = 1; d <= 9; d++)
                    {
                        for (int e = 1; e <= 9; e++)
                        {
                            for (int f = 1; f <= 9; f++)
                            {
                                if ((a * b * c) == (d * e * f) && (a * b * c) == letSum)
                                {
                                    // format  abc-def   in ascending order
                                    Console.WriteLine("{0}{1}{2}-{3}{4}{5}", a, b, c, d, e, f);
                                    winNumbers = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        if (!winNumbers)
        {
            Console.WriteLine("No");
        }
    }
}

/*
We are given a string S consisting of capital and non-capital letters. 
 * Every letter has a value equal to its position in the English alphabet (a=1, b=2, …, z=26). 
 * First you have to calculate the sum of all letters letSum.

 * Then, find all 6-digits numbers in range [000 000 … 999 999] called winning numbers 
 * for which the following is true: the product of the first three digits is equal to the product of the second three digits, 
 * and both of those are equal to letSum. 

 * Your task is to print on the console all winning numbers.
 
*/