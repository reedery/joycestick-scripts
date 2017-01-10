using UnityEngine;
using VRTK;

abstract public class JoyceObject : MonoBehaviour {
    private AudioSource source;
    public AudioClip Dialogue;
    private bool DialogueHasPlayed = false;
    private bool isFinished = false;
    public string Sentence { get; set; }
    private bool canPlayDialogue = false;

    public void SetSource(AudioSource src)
    {
        source = src;
    }

    void OnTriggerEnter(Collider other)
    {

        if ( (other.gameObject.name.Equals("Head") || (other.gameObject.name.Equals("Body"))) && !DialogueHasPlayed && canPlayDialogue)
        {
            DialogueHasPlayed = true;
            source.PlayOneShot(Dialogue);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name.Equals("ObjectArea"))
        {
            if (!isFinished)
            {
                source.Stop();
                GameMgr.nextTask();
            }

            isFinished = true;

        }
    }

    public bool IsFinished()
    {
        return isFinished;
    }

    void PlayDialogue()
    {

    }

    void PlayFinishAnimation()
    {

    }

    public void DisableSelf()
    {
        VRTK_InteractableObject interactableObject = GetComponent<VRTK_InteractableObject>();
        interactableObject.isGrabbable = false;
    }

    public void EnableSelf()
    {
        VRTK_InteractableObject interactableObject = GetComponent<VRTK_InteractableObject>();
        interactableObject.isGrabbable = true;
        canPlayDialogue = true;
    }

}
