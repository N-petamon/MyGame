using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetonatorController : MonoBehaviour {

    public float timer = 0.5f;

    public AudioClip sound01;

    

    


    // Use this for initialization
    void Start () {



	}
	
	// Update is called once per frame
	void Update () {

        AudioSource.PlayClipAtPoint(sound01, transform.position);

        Destroy(gameObject, timer);

    }


}
