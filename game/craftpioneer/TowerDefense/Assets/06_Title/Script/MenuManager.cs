using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    Sprite m_menuNone;
    [SerializeField]
    Sprite m_menuStart;
    [SerializeField]
    Sprite m_menuPose;
    [SerializeField]
    Sprite m_menuShop;
    [SerializeField]
    Sprite m_menuExit;
    Image m_image;
    [SerializeField]
    Text m_startText;
    [SerializeField]
    Text m_poseText;
    [SerializeField]
    Text m_shopText;
    [SerializeField]
    Text m_exitText;

    // Start is called before the first frame update
    void Start()
    {
        m_image = transform.GetChild(0).GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        bool anyTrue = false;
        if (m_startText.color == Color.black)
        {
            m_image.sprite = m_menuStart;
            anyTrue = true;
        }
        if (m_poseText.color == Color.black)
        {
            m_image.sprite = m_menuPose;
            anyTrue = true;
        }
        if (m_shopText.color == Color.black)
        {
            m_image.sprite = m_menuShop;
            anyTrue = true;
        }
        if (m_exitText.color == Color.black)
        {
            m_image.sprite = m_menuExit;
            anyTrue = true;
        }
        if (anyTrue == false)
        {
            m_image.sprite = m_menuNone;
        }
    }
}
