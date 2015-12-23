using System;
using System.Linq;

class JumpingSums
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int jumps = int.Parse(Console.ReadLine());

        long maxValue = 0;

        for (int lng = 0; lng < numbers.Length; lng++)
        {
            int currentValue = 0;
            int currentIndex = lng;

            for (int j = 0; j <= jumps; j++)
            {
                currentValue += numbers[currentIndex];
                int nextIndex = numbers[currentIndex] + currentIndex;

                if (nextIndex <= numbers.Length - 1)
                {
                    currentIndex = nextIndex;
                }
                else
                {
                    currentIndex = nextIndex % numbers.Length;
                }
            }

            if (currentValue > maxValue)
            {
                maxValue = currentValue;
            }
        }

        Console.WriteLine("max sum = {0}", maxValue);
    }
}
