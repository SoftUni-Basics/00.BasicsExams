using System;

class StudentCables
{
    static void Main()
    {
        int numberOfCables = int.Parse(Console.ReadLine());

        int studentCables = 0;
        int usableCounter = 0;
        int studentCablesLenght = 0;

        for (int i = 0; i < numberOfCables; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string incomeCable = Console.ReadLine();

            if (incomeCable == "centimeters" && number < 20)
            {
                continue;
            }
            else if (incomeCable == "meters")
            {
                studentCablesLenght += number * 100;
                usableCounter++;
            }
            else
            {
                if (number == 504 && incomeCable == "centimeters")
                {
                    studentCables++;
                }
                else
                {
                    studentCablesLenght += number;
                    usableCounter++;
                }
            }
        }
        if (usableCounter > 1)
        {
            studentCablesLenght -= (usableCounter-1) * 3;
        }

        studentCables += studentCablesLenght / 504;
        int remainder = studentCablesLenght % 504;

        Console.WriteLine(studentCables);
        Console.WriteLine(remainder);
    }
}
