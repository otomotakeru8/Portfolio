using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text scoreText = null;
    private int score = 0;
    private int houseScore = 10;

    public static int deliveryScore = 0;

    void Start()
    {
        scoreText.text = (score).ToString("d4");
    }


    public void ScoreResult()
    {
        this.GetComponent<AllGetterSetter>().SetDeliveryScore(score);
    }
}
