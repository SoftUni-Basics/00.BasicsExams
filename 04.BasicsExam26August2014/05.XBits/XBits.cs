using System;

class XBits
{
    static void Main()
    {
        int[] numbers = new int[8];
        for (int i = 0; i < 8; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        
        int count = 0;
        
        for (int row = 0; row < 6; row++)
        {
            for (int col = 0; col < 29; col++)
            {
                bool firstNumber = (((numbers[row] >> col) & 5) == 5) & ((numbers[row] >> col) & 7) != 7;
                bool secondNumb = 
                    (((numbers[row + 1] >> col) & 2) == 2) & 
                    ((numbers[row + 1] >> col) & 7) != 7 & 
                    ((numbers[row + 1] >> col) & 7) != 3;
                bool thirdNumber = (((numbers[row+2] >> col) & 5) == 5) & ((numbers[row+2] >> col) & 7) != 7;

                if (firstNumber && secondNumb && thirdNumber)
                {
                    count++;

                    // Console.WriteLine(Convert.ToString((numbers[row] >> col), 2));
                    // Console.WriteLine(Convert.ToString((numbers[row+1] >> col), 2));
                    // Console.WriteLine(Convert.ToString((numbers[row+2] >> col), 2));

                }
            }
        }

        Console.WriteLine(count);

        //Console.WriteLine();
        //for (int i = 0; i < numbers.Length-2; i++)
        //{
        //    Console.WriteLine(Convert.ToString(numbers[i], 2).PadLeft(16, '0'));
        //    Console.WriteLine(Convert.ToString(numbers[i+1], 2).PadLeft(16, '0'));
        //    Console.WriteLine(Convert.ToString(numbers[i+2], 2).PadLeft(16, '0'));
        //    Console.WriteLine();
        //}
    }
}

/*
 * 
7583
1374
12345
8888
91834
1234
1852
24912
 * 
365
146
365
365
658
365
640
160
 * 
 */