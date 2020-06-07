using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearController : MonoBehaviour {

    private GameObject[] targets;

    public float step_time;

	// Use this for initialization
	void Start () {
        step_time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

        targets = GameObject.FindGameObjectsWithTag("Target");



        if (targets.Length == 0)
        {

            step_time += Time.deltaTime;

            if (step_time >= 1.0f)
            {
                SceneManager.LoadScene("GameClear");
            }
        }

	}
}
