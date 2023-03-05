using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantUI : MonoBehaviour
{
    public GameObject obj;
    Button cube;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject obj = (GameObject)Resources.Load("MainCanvas");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate(obj, new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
        cube = GameObject.Find("MainCanvas(Clone)/CountryPanel/Japan").GetComponent<Button>();
        // 最初に選択状態にしたいボタンの設定
        cube.Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
