using UnityEngine;

public class Coin : JoyceObject
{
    void Start()
    {
        Sentence = "We encounter the three sovereign coins in the Nestor chapter, as Stephen collects " +
            "his teaching wage from his superior, Mr. Deasy. Here, Joyce comments on the different ways " +
            "in which humans encounter the material world and the power dynamics of financial and other modes of exchange.";
        GameMgr.addToManagerList(this);
        AudioSource source = GetComponent<AudioSource>();
        if (source)
        {
            this.SetSource(source);
        }
        DisableSelf();
    }
}
