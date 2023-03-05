using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    AllSoundsScript ss;

    private float countTime = 3f;
    [SerializeField] private Image countTimeImg = null;
    [SerializeField] private Sprite[] numberSprite = new Sprite[4];
    [SerializeField] private Text timerText = null;
    [SerializeField] private GameObject Car = null;
    [SerializeField] private float timer = 90f;

    //　スタート時のDateTime構造体
    private DateTime startDataTime;
    //　時間経過のTimeSpan構造体
    private TimeSpan totalTime;

    private bool isStart = false;
    void Start()
    {
        ss = GetComponent<AllSoundsScript>();

        StartCoroutine(CountMethod(0f, 3));
        StartCoroutine(CountMethod(1.0f, 2));
        StartCoroutine(CountMethod(2.0f, 1));
        StartCoroutine(CountMethod(3.0f, 0));
        StartCoroutine(CountMethod(4.0f, 4));
    }

    void Update()
    {
        if (isStart == true)
        {
            //　現在のDateTimeから初期のDetaTimeを計算し経過した時間を計算する
            totalTime = startDataTime - DateTime.Now.AddSeconds(-timer);
            //　TimeSpan構造体のプロパティで分と秒をテキストに入れる
            timerText.text = totalTime.Minutes.ToString("00") + ":" + totalTime.Seconds.ToString("00");

            countTime -= Time.deltaTime;
        }

        
        if(countTime < 0f)
        {
            isStart = false;
            SceneManager.LoadScene("Result");
        }
    }

    private IEnumerator CountMethod(float waitTime, int count)
    {
        yield return new WaitForSeconds(waitTime);
        if(count == 4)
        {
            Destroy(countTimeImg);
        }
        else if (count == 0)
        {
            countTimeImg.sprite = numberSprite[count];
            Car.GetComponent<DriveCont>().StartCar();
            ss.PopSE(0);//ホイッスル音
            isStart = true;
            //　現在のDateTime構造体を設定
            startDataTime = DateTime.Now;
            countTime = timer;
        }
        else
        {
            countTimeImg.sprite = numberSprite[count];
        }
    }
}
