using System;

class InsideTheBuilding
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());

        int rect1X1 = 0;
        int rect1Y1 = 0;
        int rect1X2 = 3 * h;
        int rect1Y2 = h;

        int rect2X1 = h;
        int rect2Y1 = 0;
        int rect2X2 = 2 * h;
        int rect2Y2 = 4 * h;

        for (int i = 0; i < 5; i++)
        {
            int pointX = int.Parse(Console.ReadLine());
            int pointY = int.Parse(Console.ReadLine());

            bool rect1 = (pointX >= rect1X1 && pointX <= rect1X2) && (pointY >= rect1Y1 && pointY <= rect1Y2);
            bool rect2 = (pointX >= rect2X1 && pointX <= rect2X2) && (pointY >= rect2Y1 && pointY <= rect2Y2);

            if (rect1 || rect2)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
