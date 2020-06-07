using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MFController : MonoBehaviour {

    public float timer = 0.1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Destroy(gameObject, timer);
		
	}
}
