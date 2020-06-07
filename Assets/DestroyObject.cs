using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    public int damage;


    private HP hp;

	// Use this for initialization
	void Start () {

        

        hp = this.GetComponent<HP>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Shell")
        {

            hp.Damage(damage);

            Destroy(other.gameObject);

        }
    }

}
