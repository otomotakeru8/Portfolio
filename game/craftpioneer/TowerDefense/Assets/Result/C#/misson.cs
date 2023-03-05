using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class misson : MonoBehaviour
{

    [SerializeField]GameObject m1;
    [SerializeField]Text m1t;
    [SerializeField] GameObject m2;
    [SerializeField] Text m2t;
    [SerializeField] GameObject m3;
    [SerializeField] Text m3t;
    [SerializeField]GameObject usu;
    [SerializeField]GameObject clearobject;
    [SerializeField]GameObject failureobject;
    //ミッションが達成したかどうかの判定
    public static bool mission1 = true;
    public static bool mission2 = true;
    public static bool mission3 = true;
    //ステージをクリアしたかの判定
    public static bool stageclear = false;


    bool stop = true;
    bool end = false;
    int i=0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(tasseidoline.achend==true) {
            if(mission1 == true) {
                m1t.color =new Color(0.0f,0.0f,0.0f,1.0f);
                m1.SetActive(true);
            }
            if(stop == true) {
                stop = false;
                i++;
                Invoke("gmon", 1f);
            }
        }
        if(Input.GetMouseButtonDown(0) == true && end == true) {
            usu.SetActive(true);
            //クリア時と失敗時で別の判定を返す。
            if(stageclear == true) {
                clearobject.SetActive(true);
            } else {
                failureobject.SetActive(true);
            }
        }
    } 

    void gmon(){
        if(i ==1) { 
            if(mission2 == true) {
                m2t.color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                m2.SetActive(true);
            }
            stop = true;
        }
        if(i == 2) {
            if(mission3 == true) {
                m3t.color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                m3.SetActive(true);
            }
            end =true;
        }
    }
}
