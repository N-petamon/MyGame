using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private float difference;

	// Use this for initialization
	void Start () {

        this.difference = player.transform.position.z - this.transform.position.z;

	}
	
	// Update is called once per frame
	void Update () {

        

        this.transform.position = player.transform.position - player.transform.forward * difference + new Vector3 (0, 6, 8);

        Vector3 rot = player.transform.rotation.ToEulerAngles();

        this.transform.rotation = Quaternion.EulerAngles(rot.x, rot.y, 0);

	}
}
