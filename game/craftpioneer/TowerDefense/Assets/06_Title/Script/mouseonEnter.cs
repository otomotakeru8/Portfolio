using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mouseonEnter : MonoBehaviour
{
    [SerializeField]Text one;
    [SerializeField]Outline utline;
    [SerializeField] int select;
    [SerializeField] GameObject Load;
    [SerializeField]GameObject END;
    //マウスが触れた時文字の色を変える
    void OnMouseEnter()
    {
        one.color = Color.black;
        utline.enabled = true;
    }
    //マウスが離れた時文字の色を戻す
    void OnMouseExit()
    {
        one.color = Color.white;
        utline.enabled = false;
    }
    //クリックされたときこれが呼び出される
    void OnMouseDown()
    {
        switch (select) { 
            case 1:
                Loading.Scenename = "MainGame";
                Load.GetComponent<Loading>().NextScene();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                END.SetActive(true);
                Invoke("FF",2.5f);
                break;   
        }
    }
    void FF()
    {
        Debug.Log("ゲームを終了しました。");
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }

}
