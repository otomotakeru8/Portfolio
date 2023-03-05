using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Startbuttonscript : MonoBehaviour
{
    GameObject m_titleImage;
    GameObject m_startButton;
    public GameObject Point;
    public GameObject Shift;
    public GameObject W;
    public GameObject A;
    public GameObject S;
    public GameObject D;
    public GameObject MLB;
    public GameObject MRB;

    // Start is called before the first frame update
    void Start()
    {
        m_titleImage = GameObject.Find("TitleImage");
        m_startButton = GameObject.Find("StartButton");
        gameObject.GetComponent<Button>().onClick.AddListener(Gamestart);
    }

    void Gamestart()
    {
        Invoke(nameof(FirstWave), 2);
        FindObjectOfType<PlayerScript>().GameStart();
        m_titleImage.SetActive(false);
        m_startButton.SetActive(false);
        Point.SetActive(true);
        Shift.SetActive(true);
        W.SetActive(true);
        A.SetActive(true);
        S.SetActive(true);
        D.SetActive(true);
        MLB.SetActive(true);
        MRB.SetActive(true);
    }

    void FirstWave()
    {
        FindObjectOfType<WaveScript>().Nextwave();
    }
}