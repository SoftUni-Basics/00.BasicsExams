using System;
using System.Linq;
using System.Text;

class PerfectGirlfriend
{
    static void Main()
    {
        string[] dayOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        int count = 0;

        while (true)
        {
            int result = 0;
            string[] input = Console.ReadLine().Split('\\').ToArray();

            if (input[0] != "Enough dates!")
            {
                result += Array.IndexOf(dayOfTheWeek, input[0]) + 1;

                string phone = input[1];
                for (int i = 0; i < input[1].Length; i++)
                {
                    result += int.Parse(phone[i].ToString());
                }

                int braVolume = int.Parse(input[2].Substring(0, input[2].Length - 1));
                int braSize = input[2].Last();
                result += braVolume * braSize;

                int firstLetter = input[3].First() * input[3].Length;
                result -= firstLetter;

                if (result < 6000)
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", input[3]);
                }
                else
                {
                    Console.WriteLine("{0} is perfect for you.", input[3]);
                    count++;
                }
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(count);
    }
}
