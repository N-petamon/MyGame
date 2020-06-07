using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject bulletPrefab;
    public float shotSpeed;
    private float shotInterval;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {


            shotInterval += 1;

            if (shotInterval % 5 == 0 )
            {


                GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);

                //射撃されてから3秒後に銃弾のオブジェクトを破壊する.

                Destroy(bullet, 1.0f);

            }
            

        }
        

    }
}
