using UnityEngine;
using System.Collections;

public class CrashSound : MonoBehaviour
{
    public AudioClip crashLow;
    public AudioClip crashMedium;
    public AudioClip crashHigh;


    private AudioSource source;
    private float lowPitchRange = .75F;
    private float highPitchRange = 1.5F;
    private float velToVol = .2F;
    private float velocityClipSplit = 10F;


    void Awake()
    {
        source = GetComponent<AudioSource>();
    }


    void OnCollisionEnter(Collision coll)
    {
        //source.pitch = Random.Range(lowPitchRange, highPitchRange);
        float hitVol = coll.relativeVelocity.magnitude * velToVol;
        if (coll.relativeVelocity.magnitude < velocityClipSplit / 2)
            source.PlayOneShot(crashLow, hitVol);
        else if (coll.relativeVelocity.magnitude < velocityClipSplit)
            source.PlayOneShot(crashMedium, hitVol);
        else
            source.PlayOneShot(crashHigh, hitVol);
    }

}