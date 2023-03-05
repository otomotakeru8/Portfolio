using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultChange : MonoBehaviour
{
    [SerializeField] GameObject GameManager = null;
    ScoreManager sm = null;
    void Start()
    {
        sm = GameManager.GetComponent<ScoreManager>();
    }
    public void ResultStart()
    {
        //sm.ScoreResult();
        SceneManager.LoadScene("Result");
    }
}
