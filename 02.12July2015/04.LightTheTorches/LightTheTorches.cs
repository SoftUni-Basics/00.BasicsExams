using System;
using System.Linq;

class LightTheTorches
{
    static void Main()
    {
        int basementRooms = int.Parse(Console.ReadLine());
        string roomsStage = Console.ReadLine().ToString();

        string[] rooms = new string[basementRooms];
        int curentStage = 0;

        for (int i = 0; i < rooms.Length; i++)
        {
            rooms[i] = roomsStage[curentStage].ToString();
            curentStage++;
            if (curentStage == roomsStage.Length)
            {
                curentStage = 0;
            }
        }

        int baseRoom = basementRooms / 2;
        int curentRoom = baseRoom;
        int lastRoom = baseRoom;

        while (true)
        {
            string[] command = Console.ReadLine().Split().ToArray();

            if (command[0] != "END")
            {
                int numbOfSteps = int.Parse(command[1]);
                int nextRoom;
                if (command[0] == "RIGHT") 
                {
                    nextRoom = curentRoom + (numbOfSteps + 1);
                    if (nextRoom >= rooms.Length - 1) 
                    { 
                        curentRoom = rooms.Length - 1; 
                    }
                    else 
                    {
                        curentRoom = nextRoom; 
                    }
                }
                else
                {
                    nextRoom = curentRoom - (numbOfSteps + 1);
                    if (nextRoom <= 0) 
                    {
                        curentRoom = 0; 
                    }
                    else 
                    { 
                        curentRoom = nextRoom; 
                    }
                }
            }
            else
            {
                break;
            }

            if (curentRoom != lastRoom)
            {
                if (rooms[curentRoom] == "L")
                {
                    rooms[curentRoom] = "D";
                }
                else
                {
                    rooms[curentRoom] = "L";
                }
            }
            lastRoom = curentRoom;
        }

        int darkRoomCounter = 0;
        foreach (var room in rooms)
        {
            if (room == "D")
            {
                darkRoomCounter++;
            }
        }
        Console.WriteLine(darkRoomCounter * 'D');
    }
}
