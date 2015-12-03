using System;

class DetectiveBoev
{
    static void Main()
    {
        string secretWord = Console.ReadLine();
        string encryptedMessage = Console.ReadLine();

        string secretWordSum = SumCharInString(secretWord);

        int mask = int.Parse(secretWordSum);
        while (mask.ToString().Length > 1)
        {
            string tempString = mask.ToString();
            int tempSum = 0;
            for (int i = 0; i < tempString.Length; i++)
            {
                tempSum += int.Parse(tempString[i].ToString());
            }
            mask = tempSum;
        }
       

        string output = string.Empty;
        for (int i = 0; i < encryptedMessage.Length; i++)
        {
            if (encryptedMessage[i] % mask == 0)
            {
                output = (char)(encryptedMessage[i] + mask) + output;
            }
            else
            {
                output = (char)(encryptedMessage[i] - mask) + output;
            }
        }
        Console.WriteLine(output);
    }

    static string SumCharInString(string word)
    {
        int sum = 0;
        for (int i = 0; i < word.Length; i++)
        {
            sum += word[i];
        }
        return sum.ToString();
    }
}
