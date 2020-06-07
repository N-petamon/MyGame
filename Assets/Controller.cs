using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Aeroplane;
using UnityStandardAssets.CrossPlatformInput;

public class Controller : MonoBehaviour
{

    AeroplaneController controller;

    private void Awake()
    {
        controller = GetComponent<AeroplaneController>();
    }

    void FixedUpdate()
    {
        var pitch = Input.GetAxis("Vertical");
        var roll = Input.GetAxis("Horizontal");

        // ロール, ピッチ, ヨー, スロットル, エアブレーキ
        controller.Move(roll, pitch, 0, 1, false);

        if (Input.GetKey(KeyCode.F))
        {
            controller.Move(roll, pitch, 0, 1, true);
        }

        else if (Input.GetKey(KeyCode.B))
        {
            controller.Move(roll, pitch, 0, 2, false);
        }

        else if (Input.GetKey(KeyCode.N))
        {
            controller.Move(roll, pitch, 0, 3, false);
        }

    }

    

}
