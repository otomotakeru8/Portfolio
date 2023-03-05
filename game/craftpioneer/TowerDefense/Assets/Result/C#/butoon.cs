using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butoon : MonoBehaviour
{
    // Start is called before the first frame update
    public void map() {
        //マップのsceneの名前をいれる↓
        Loading.Scenename = "MainGame";
        Loading.instance.NextScene();
    }
    public void title() {
        //titleの名前をいれる↓
        Loading.Scenename = "title";
        Loading.instance.NextScene();
    }
    public void retry() {
        //retryのsceneの名前をいれる↓
        Loading.Scenename = "MainGame";
        Loading.instance.NextScene();
    }
}
