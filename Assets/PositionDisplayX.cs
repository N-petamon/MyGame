using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionDisplayX : MonoBehaviour {


    //変数設定
float m_X;

//知りたい座標のGaeObjectの設定
public GameObject target;

// Use this for initialization
void Start()
{

}

// Update is called once per frame
void Update()
{

    //それぞれに座標を挿入
    m_X = target.transform.position.x;


    //テキストに表示
    this.GetComponent<Text>().text = "X:" + m_X.ToString();

}
}
