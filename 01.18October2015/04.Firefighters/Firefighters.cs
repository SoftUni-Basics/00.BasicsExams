using System;
using System.Collections.Generic;
using System.Linq;

class Firefighters
{
    static void Main()
    {
        /*  You will be given a number of firefighters, 
            and after that you will receive a sequence of lines, until you receive as input “rain”, which extinguishes all fires. 
         */
        int firefighters = int.Parse(Console.ReadLine());

        int kids = 0;
        int adults = 0;
        int seniors = 0;

        while (true)
        {
            int fireFCount = 0;
            string input = Console.ReadLine();

            if (input == "rain")
            {
                break;
            }
            else
            {
                List<string> type = new List<string>();
                input.ToList().ForEach(x => type.Add(x.ToString().ToUpper()));

                while ((fireFCount < firefighters) && (type.Count > 0) && (type.IndexOf("K") != -1))
                {
                    type.Remove("K");
                    kids++;
                    fireFCount++;
                }
                while ((fireFCount < firefighters) && (type.Count > 0) && (type.IndexOf("A") != -1))
                {
                    type.Remove("A");
                    adults++;
                    fireFCount++;
                }
                while ((fireFCount < firefighters) && (type.Count > 0) && (type.IndexOf("S") != -1))
                {
                    type.Remove("S");
                    seniors++;
                    fireFCount++;
                }
            }
        }
        Console.WriteLine("Kids: {0}", kids);
        Console.WriteLine("Adults: {0}", adults);
        Console.WriteLine("Seniors: {0}", seniors);
    }
}
/*
Person types:
K – Kid
A – Adult
S – Senior
*/