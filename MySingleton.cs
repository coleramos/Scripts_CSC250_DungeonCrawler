using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySingleton
{
    public static string currentDirection = "?";
    public static Room[] theRooms = new Room[100];
    public static int numRooms = 0;


    public static void addRoom(Room r)
    {
        theRooms[numRooms] = r;
        numRooms++;
    }
}
