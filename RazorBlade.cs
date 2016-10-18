using UnityEngine;

public class RazorBlade : JoyceObject
{
    void Start()
    {
        Sentence = "";
        GameMgr.addToManagerList(this);
        DisableSelf();
    }
}
