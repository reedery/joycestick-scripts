using UnityEngine;

public class PoisonBottle : JoyceObject
{
    void Start()
    {
        Sentence = "In Ithaca Bloom thinks of his father's death in 1886 from aconite poisoning. " +
            "In Circe, as he reflects on \"Patriotism, sorrow for the dead, music,\" and paternity " +
            "(the “future of the race”), he mentally reenacts his father’s suicide, imagining the " +
            "drawn blinds of the hotel room in Ennis, a suicide letter, and the soft breaths before asphyxiation.";
        GameMgr.addToManagerList(this);
        AudioSource source = GetComponent<AudioSource>();
        if (source)
        {
            this.SetSource(source);
        }
        DisableSelf();
    }
}
