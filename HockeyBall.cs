using UnityEngine;

public class HockeyBall : JoyceObject
{
	void Start () {
        Sentence = "Throughout the Nestor chapter, the sounds of children playing hockey " +
            "in the street serve as a backdrop to the central action of the narrative," +
            " Stephen Dedalus’s conversation with his superior, Mr. Deasy.";

        GameMgr.addToManagerList(this);
        AudioSource source = GetComponent<AudioSource>();
        if (source)
        {
            this.SetSource(source);
        }

        DisableSelf();
    }
}