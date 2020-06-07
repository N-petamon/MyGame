using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartController : MonoBehaviour {

    public float steptime;

	// Use this for initialization
	void Start () {

        steptime = 0.0f;
		
	}
	
	// Update is called once per frame
	void Update() {

        steptime += Time.deltaTime;
        if (steptime >= 10.0f)
        {
            SceneManager.LoadScene("Start");
        }

		if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("protocol");
        }
	}
}
