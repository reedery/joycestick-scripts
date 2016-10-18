using UnityEngine;
using System.Collections;

public class NewspaperCollider : MonoBehaviour
{

    public GameObject stringsGameObject;
    public GameObject bellsGameObject;

    private AudioSource stringSrc;
    private AudioSource bellsSrc;

    private bool paperWasRead = false;
    private bool correctCollider = false;
    private float timer = 0;
    private float timeTakenToReadPaper = 8;

    // check to make sure player enters area, stays for at least 5 ish seconds (this way
    // we know they read the advertisement in the paper), then OTExit, we can (+) the volume of the string sections. 

    void Start()
    {
        stringSrc = stringsGameObject.GetComponent<AudioSource>();
        bellsSrc = bellsGameObject.GetComponent<AudioSource>();
        Debug.Log("hello");
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENTERED");
        Debug.Log(other.name);
        if (other.gameObject.name.Equals("Head") || (other.gameObject.name.Equals("Body")))
        {
            correctCollider = true;
            Debug.Log("CC = true");
            timer = 0;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (correctCollider)
        {

            timer += Time.deltaTime;
            if (timer > timeTakenToReadPaper)
            {
                paperWasRead = true;
            }
        }
    }


    void OnTriggerExit(Collider c)
    {
        if (paperWasRead)
        {
            stringSrc.volume = 0.8f;
            StartCoroutine(BringUpBells(20));
        }

        // reset booleans
        paperWasRead = false;
        correctCollider = false;
    }


    IEnumerator BringUpBells(int n)
    {
        float adjustment = 0.8f / n;
        for (int i = 0; i < n; i++)
        {
            if (bellsSrc.volume > 0.70f)
            {
                break;
            }
            bellsSrc.volume += adjustment;
            yield return new WaitForSeconds(1);
        }
    }

}