using UnityEngine;

public class ShavingBowl : JoyceObject
{
    void Start()
    {
        Sentence = "";
        GameMgr.addToManagerList(this);
        AudioSource source = GetComponent<AudioSource>();
        if (source)
        {
            this.SetSource(source);
        }
        DisableSelf();
    }
}
