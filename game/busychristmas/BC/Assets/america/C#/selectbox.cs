using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectbox : MonoBehaviour
{
    public static bool taiki;
    int i = 0;
    [SerializeField] GameObject paler;
    // Start is called before the first frame update
    void Start()
    {
        taiki = true;
    }

    // Update is called once per frame
    void Update()
    {
        //処理の開始
        if (selectbox2.set==false) {
            paler.SetActive(false);
            selectbox2.set = true;
        }
        /*箱を持っている場合処理に入らないようにする
        if(任意の箱を持っているか判定する変数==true or false){
        }else
         */
        if (Input.GetKeyDown(KeyCode.Space) && taiki == true && i == 1)
        {
            taiki = false;
            paler.SetActive(true);
            yazi.start = true;
            Invoke("FF", 0.5f);
            //主人公の動きを封じる
            //吹き出しの表示
        }

    }
    void OnTriggerStay(Collider other)
    {
        //プレイヤーがこの中にいるとき
        if (other.gameObject.tag == "P")
        {
            i = 1;
            //この中にいて且スペースを押したとき
        }
    }
    void OnTriggerExit(Collider other)
    {
        //プレイヤーがこの中から出たとき
        if (other.gameObject.tag == "P")
        {
            i = 0;
           
        }
    }

    void FF()
    {
        selectbox2.taiki = true;
        i = 0;
    }
}
