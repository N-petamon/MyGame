using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleFlash : MonoBehaviour {

    public GameObject muzzleflash;

	// Use this for initialization
	void Start () {
		
        

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {

            GameObject MuzzleFlash = Instantiate(muzzleflash) as GameObject;

            MuzzleFlash.transform.position = transform.position - this.transform.forward;

            Vector3 rot = this.transform.rotation.ToEulerAngles();

            this.transform.rotation = Quaternion.EulerAngles(rot.x, rot.y, rot.z);
            
            
        }
		
	}
}
