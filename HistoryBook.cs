using UnityEngine;
using System.Collections;

public class HistoryBook : JoyceObject
{

    void Start()
    {
        Sentence = "The history book is a central part of the novel because something";
        GameMgr.addToManagerList(this);
        AudioSource source = GetComponent<AudioSource>();
        if (source)
        {
            this.SetSource(source);
        }
        DisableSelf();
    }
}