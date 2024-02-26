using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class MySingleton
{
    public static string currentDirection = "?";
    public static Room[] theRooms = new Room[100];
    public static int numRooms = 0;
    public static Room theCurrentRoom = null;

    public static void addRoom(Room r)
    {
        //static context
        MySingleton.theRooms[numRooms] = r;
        MySingleton.numRooms++;
    }
}
