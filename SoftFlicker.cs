using UnityEngine;
using System.Collections;

public class SoftFlicker : MonoBehaviour {
    private Light light;
    private Color originalColor;
    private float timePassed;
    private float changeValue;
    private float multiplier;

    float random;

	// Use this for initialization
	void Start () {
        light = this.GetComponent<Light>();

        if (light != null)
        {
            originalColor = light.color;
        }
        else
        {
            enabled = false;
            return;
        }

        changeValue = 0;
        timePassed = Random.Range(0, 2f);
        multiplier = Random.Range(2,3);
	}
	
	// Update is called once per frame
	void Update () {
        timePassed = Time.time;
        timePassed = timePassed - Mathf.Floor(timePassed);

        light.color = originalColor * CalculateChange();
	}

    private float CalculateChange()
    {
        changeValue = -Mathf.Sin(timePassed * multiplier * Mathf.PI) * 0.05f + 0.95f;
        return changeValue;
    }
}
