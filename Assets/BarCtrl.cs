using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarCtrl : MonoBehaviour {

    Slider _slider;
    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    float _hp = 30;
    void Update()
    {
        // HP上昇
        _hp -= 0.01f;
        if (_hp < 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (Input.GetKey(KeyCode.B))
        {
            _hp -= 0.03f;
        }

        if (Input.GetKey(KeyCode.N))
        {
            _hp -= 0.05f;
        }

        if (this.transform.position.y <= -20)
        {
            _hp -= 0.1f;
        }

        // HPゲージに値を設定
        _slider.value = _hp;
    }
}
