using UnityEngine;
using System.Collections;

public class PlayerNoCollide : MonoBehaviour {
    private Collider collider;

	// Use this for initialization
	void Start () {
        collider = GetComponent<Collider>();
        disableCollider();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void disableCollider()
    {
        collider.enabled = false;
        Debug.Log(collider.enabled + " " +collider.gameObject);
    }
}
