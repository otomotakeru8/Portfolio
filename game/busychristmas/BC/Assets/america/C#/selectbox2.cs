using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectbox2 : MonoBehaviour
{
    public static bool taiki;
    public static bool set;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && taiki==true)
        {
            //これを消す
            //0.5秒間、新たな操作を受け付けない
            taiki = false;
            set = false;
            i = 0;
            Invoke("FF", 0.5f);
            switch (yazi.iti)
            {
                case 1:
                    Debug.Log("赤色の箱を渡す");
                    break;
                case 2:
                    Debug.Log("青色の箱を渡す");
                    break;
                case 3:
                    Debug.Log("黄色の箱を渡す");
                    break;
                case 4:
                    Debug.Log("緑色の箱を渡す");
                    break;
                case 5:
                    Debug.Log("深い青色の箱を渡す");
                    break;
                case 6:
                    Debug.Log("紫色の箱を渡す");
                    break;
            }
        }
    }
    void FF()
    { 
        selectbox.taiki = true;
        i = 1;
    }
}
