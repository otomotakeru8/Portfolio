using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Common : MonoBehaviour
{
    static public Common instance;
    public static int player1skin;
    public static int player2skin;
    public static int Dpoint = 0;
    public static int point = 0;
    public static string SScene;
    // Start is called before the first frame update
    void Start()
    {
        // イベントにイベントハンドラーを追加
        SceneManager.sceneLoaded += SceneLoaded;
        player1skin = 1;
        player2skin = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SceneLoaded(Scene nextScene, LoadSceneMode mode)
    {
        SScene = ("FirstMap");
        //SScene = SceneManager.GetActiveScene().name;
        Debug.Log(SceneManager.GetActiveScene().name);
        Debug.Log(mode);
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {

            Destroy(this);
        }
    }
}
