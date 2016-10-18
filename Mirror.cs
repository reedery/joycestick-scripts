using UnityEngine;

public class Mirror : JoyceObject
{
    void Start()
    {
        Sentence = "The bowl of shaving cream, mirror, and razor are the very first items encountered " +
            "in the novel and occupy the first lines of text in the opening Telemachus chapter" +
            "It is fitting that the novel opens in this way, with a theatrical scene that depicts Buck " +
            "Mulligan making a mockery of the rite of the Catholic mass. Here and elsewhere, Joyce attacks" +
            "the authority of religious and political institutions.";
        GameMgr.addToManagerList(this);
        DisableSelf();
    }
}
