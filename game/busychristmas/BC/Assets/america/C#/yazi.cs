using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yazi : MonoBehaviour
{
    public static bool start=false;
    int i = 0;
    public static int iti = 1;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (start == true)
        {
            Vector3 pos = transform.position;
            pos.x = -0.236f;
            transform.position = pos;
            start = false;
            Invoke("mm",0.1f);
            iti = 1;
        }
        if (i == 1)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                //右に移動する
                transform.Translate(-0.4518f, 0, 0);//移動量
                Vector3 pos = transform.position;
                //現在の矢印の位置を特定
                iti++;
                if (pos.x <= -2.495f)
                {
                    Vector3 pos1 = transform.position;
                    pos1.x = -2.495f;
                    transform.position = pos1;
                    iti = 6;
                }
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                //左に移動する
                transform.Translate(0.4518f, 0, 0);//移動量
                Vector3 pos = transform.position;
                //現在の矢印の位置を特定
                iti--;
                if (pos.x>= -0.236f)
                {
                    Vector3 pos1 = transform.position;
                    pos1.x = -0.236f;
                    transform.position = pos1;
                    iti = 1;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && i == 1)
        {
            i = 0;
        }
    }
    void mm()
    {
        i = 1;
    }
    //箱を渡す処理はselectbox2で行う(処理順の順番的にこっちでやると変になる）
    //(今の所デバックログのみで実装しており未実装)
}
