using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameMgr : MonoBehaviour {

    public static List<JoyceObject> objects = new List<JoyceObject>();
    private static JoyceObject currentObj;
    private static int index = 0;

    // Use this for initialization
    void Start () {
        nextTask();
    }


    public static void addToManagerList(JoyceObject obj)
    {
        objects.Add(obj);
    }

    private static void incrementCurrentObject()
    {
        currentObj = objects[index++];
    }

    public static void nextTask()
    {
        if (!isFinished())
        {
            incrementCurrentObject();
            // reset stingers (strings and bells) to 0f
            EnableCurrentObject();
        }
    }
    
    private static void EnableCurrentObject()
    {
        Debug.Log(currentObj.name); 
        currentObj.EnableSelf();
    }

    private static bool isFinished()
    {
        return index >= objects.Count; //Checking the objects Array for completion
    }
}   

