using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {

    public GameObject DetonatorPrefab;

    private int hitPoint = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(hitPoint <= 0)
        {
            GameObject Detonator = Instantiate(DetonatorPrefab) as GameObject;
            Detonator.transform.position = transform.position;

            Destroy(gameObject);


        }
		
	}

    public void Damage(int damage)
    {

        hitPoint -= damage;

    }



}
