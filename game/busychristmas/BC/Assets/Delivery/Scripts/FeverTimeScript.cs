using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeverTimeScript : MonoBehaviour
{
    [SerializeField] private Text scoreText = null;
    [SerializeField, Tooltip("スコア追加テキスト")] private Text addScoreText = null;
    [SerializeField, Tooltip("スコア追加テキスト2")] private Text addHouseScoreText = null;
    private int score = 0;
    private int houseScore = 10;

    int firstColor = 0, secondColor = 0, thirdColor = 0, fourthColor = 0;
    [SerializeField] Image firstColorImage = null;
    [SerializeField] Image secondColorImage = null;
    [SerializeField] Image thirdColorImage = null;
    [SerializeField] Image fourthColorImage = null;

    [SerializeField] Sprite[] houseColorSprite = new Sprite[3];

    private int feverGrade = 0;

    public static int OnlyDeliveryScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = (score).ToString("d4");
        StartSettingColor();
    }

    void Update()
    {
        OnlyDeliveryScore = score;//最終スコア
    }

    private void StartSettingColor()
    {
        firstColor = Random.Range(0, 3); //赤:0  青:1 　緑:2
        secondColor = Random.Range(0, 3);
        thirdColor = Random.Range(0, 3);
        fourthColor = Random.Range(0, 3);

        SetColor();
    }

    private void NextSettingColor()
    {
        firstColor = secondColor;
        secondColor = thirdColor;
        thirdColor = fourthColor;
        fourthColor = Random.Range(0, 3);

        SetColor();
    }

    private void SetColor()
    {
        firstColorImage.sprite = houseColorSprite[firstColor];
        secondColorImage.sprite = houseColorSprite[secondColor];
        thirdColorImage.sprite = houseColorSprite[thirdColor];
        fourthColorImage.sprite = houseColorSprite[fourthColor];
    }

    public void AddScore(int color)//家に当たった時
    {
        if (firstColor == color)//上の色と同じ色の家に当たった時
        {
            score += houseScore;
            addScoreText.text = ("+" + (houseScore));
            StartCoroutine("ClearText");
            scoreText.text = (score).ToString("d4");
            FeverCheck();

            NextSettingColor();
        }
        else
        {
            score += houseScore;
            addScoreText.text = ("+" + (houseScore));
            StartCoroutine("ClearText");
            scoreText.text = (score).ToString("d4");
        }
    }

    public void AddPerfectScore(int color)//窓、扉に当たった時
    {
        if (firstColor == color)
        {
            score += houseScore * 2;
            scoreText.text = (score).ToString("d4");
            FeverCheck();
            NextSettingColor();
        }
        else
        {
            score += houseScore * 2;
            scoreText.text = (score).ToString("d4");
        }
        addScoreText.text = ("+" + (houseScore * 2));
    }

    private void FeverCheck()
    {
        score += houseScore;
        addHouseScoreText.text = ("+" + (houseScore));
        StartCoroutine("ClearText");
        scoreText.text = (score).ToString("d4");
    }


    private IEnumerator ClearText()
    {
        yield return new WaitForSeconds(1.5f);
        addHouseScoreText.text = ("");
        addScoreText.text = ("");
    }
}
