using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCounter3 : MonoBehaviour
{
    //カウントダウン
    public static float countdown3 = 300.0f;

    //時間を表示するText型の変数
    public Text timeText;
    [SerializeField] private GameObject TimeOverPanel;
    [SerializeField] private GameObject ButtonPanel;
    [SerializeField] private Button TimeButton;
    bool isCalledOnce;
    bool isCalledSelect;

    public static int tTime3;

    void Start()
    {
        TimeOverPanel.SetActive(false);
        ButtonPanel.SetActive(false);
        tTime3 = 0;
        isCalledOnce = false;
        isCalledSelect = false;
        countdown3 = 300.0f;
    }
    // Update is called once per frame
    void Update()
    {
        if (tTime3 == 1)
        {
            //時間をカウントダウンする
            countdown3 -= Time.deltaTime;
            //時間を表示する
            timeText.text = "残り" + ((int)countdown3) ;//countdown3.ToString("f1") + "秒";

            //countdownが0以下になったとき
            if (countdown3 <= 0)
            {
                timeText.text = "時間になりました！";
                TimeOverPanel.SetActive(true);
                TimeImage.fadeIn = true;
                Invoke("ActiveButtonPanel", 2.0f);
                if (!isCalledOnce)
                {
                    //タイムオーバー音
                    NewSoundScriot.GameOver1 = true;
                    isCalledOnce = true;
                }
            }
        }
    }
    void ActiveButtonPanel()
    {
        ButtonPanel.SetActive(true);
        if (!isCalledSelect)
        {
            TimeButton.Select();
            isCalledSelect = true;
        }
    }
    //やり直しボタン
    public void OnClick()
    {
        FadeController2.isFadeOut = true;
        Invoke("Retry", 2.0f);
    }
    void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //タイトルに行くボタン
    public void OnClickT()
    {
        FadeController2.isFadeOut = true;
        Invoke("Title", 2.0f);
    }
    void Title()
    {
        SceneManager.LoadScene("Prologue");
    }
}