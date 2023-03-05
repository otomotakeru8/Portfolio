using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextUI : MonoBehaviour
{
    [SerializeField]
    GameObject farst;
    [SerializeField]
    GameObject second;
    [SerializeField]
    GameObject getTalentPanel;
    [SerializeField]
    GameObject towerPanel;
    [SerializeField]
    PlayerData m_playerData;


    [SerializeField]
    GameObject m_menu;

    int foge=0;

    // Start is called before the first frame update
    void Start()
    {
        farst.SetActive(true);
        second.SetActive(false);
        getTalentPanel.SetActive(false);
        Invoke(nameof(FarstPanel),4.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_playerData.g_wood == 1 && foge == 0)
        {
            foge++;
            second.SetActive(true);
            Invoke(nameof(SecondPanel), 4.0f);
        }
    }

    void FarstPanel()
    {
        farst.SetActive(false);
    }
    void SecondPanel()
    {
        second.SetActive(false);
    }
    public void GetTalentPanel()
    {
        getTalentPanel.SetActive(true);
        Invoke(nameof(FalsePanel), 4.0f);
    }
    void FalsePanel()
    {
        getTalentPanel.SetActive(false);
    }

    public void TowerPanel()
    {
        towerPanel.SetActive(true);
    }
    public void Close()
    {
        towerPanel.SetActive(false);
    }

    public void OpenMenu()
    {
        m_menu.SetActive(true);
    }

    public void TitleButton()
    {
        //titleの名前をいれる↓
        Loading.Scenename = "title";
        Loading.instance.NextScene();
    }
    public void RetryButton()
    {
        Loading.Scenename = "MainGame";
        Loading.instance.NextScene();
    }
    public void BackButton()
    {
        m_menu.SetActive(false);
    }
}
