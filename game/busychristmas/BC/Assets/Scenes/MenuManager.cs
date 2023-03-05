using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject MenuPanel;
    [SerializeField] private Button MenuButon;
    //
    public Image image1;
    public Image image2;
    public Sprite[] m_Sprite;



    void Start()
    {
        MenuPanel.SetActive(false);
        //プレゼントの数を初期化
        GiftGen.DeliveryPresents = 0;
        //ポイントを初期化
        Common.Dpoint = 0;
        Common.point = 0;
        //イメージを

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 7"))
        {
            MenuPanel.SetActive(true);
            MenuButon.Select();
            Time.timeScale = 0;
        }
        if (GiftGen.DeliveryPresents%10 == 0){
            image1.sprite = m_Sprite[0];
            image2.sprite = m_Sprite[0];
        }
        if (GiftGen.DeliveryPresents % 10 == 1){
            image2.sprite = m_Sprite[1];
        }
        if (GiftGen.DeliveryPresents % 10 == 02){
            image2.sprite = m_Sprite[2];
        }
        if (GiftGen.DeliveryPresents % 10 == 03){
            image2.sprite = m_Sprite[3];
        }
        if (GiftGen.DeliveryPresents % 10 == 04){
            image2.sprite = m_Sprite[4];
        }
        if (GiftGen.DeliveryPresents % 10 == 05){
            image2.sprite = m_Sprite[5];
        }
        if (GiftGen.DeliveryPresents % 10 == 06){
            image2.sprite = m_Sprite[6];
        }
        if (GiftGen.DeliveryPresents % 10 == 07){
            image2.sprite = m_Sprite[7];
        }
        if (GiftGen.DeliveryPresents % 10 == 08){
            image2.sprite = m_Sprite[8];
        }
        if (GiftGen.DeliveryPresents % 10 == 09){
            image2.sprite = m_Sprite[9];
        }
        if (GiftGen.DeliveryPresents/10 == 1){
            image1.sprite = m_Sprite[1];
        }
        if (GiftGen.DeliveryPresents / 10 == 2)
        {
            image1.sprite = m_Sprite[2];
        }
        if (GiftGen.DeliveryPresents / 10 == 3)
        {
            image1.sprite = m_Sprite[3];
        }
        if (GiftGen.DeliveryPresents / 10 == 4)
        {
            image1.sprite = m_Sprite[4];
        }

    }
    public void ContinueSelection()
    {
        MenuPanel.SetActive(false);
        Time.timeScale = 1;
    }

}
