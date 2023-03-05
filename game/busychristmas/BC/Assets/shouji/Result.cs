using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Result : MonoBehaviour
{
    [SerializeField]GameObject St1;
    [SerializeField]GameObject St2;
    [SerializeField]GameObject St3;
    [SerializeField]GameObject St4;
    [SerializeField] GameObject Cha11;
    [SerializeField] GameObject Cha12;
    [SerializeField] GameObject Cha13;
    [SerializeField] GameObject Cha14;
    [SerializeField] GameObject Cha21;
    [SerializeField] GameObject Cha22;
    [SerializeField] GameObject Cha23;
    [SerializeField] GameObject Cha24;
    [SerializeField] GameObject Menu;
    [SerializeField] GameObject Menu2;
    [SerializeField] EventSystem eventSystem;
    [SerializeField] GameObject Button;
    [SerializeField] GameObject Button1;
    [SerializeField] GameObject Button2;
    [SerializeField] GameObject Button3;
    [SerializeField] GameObject Button4;
    [SerializeField] GameObject Button5;
    [SerializeField] GameObject leaf;
    [SerializeField] GameObject leaf1;
    [SerializeField] GameObject leaf2;
    [SerializeField] GameObject leaf3;
    [SerializeField] GameObject leaf4;
    [SerializeField] GameObject leaf5;
    GameObject selectedObj;

    bool isCalledSelect;

    public Text pointtext;
    // Start is called before the first frame update
    void Start()
    {
        Common.point += FeverTimeScript.OnlyDeliveryScore;
        St1.gameObject.SetActive(false);
        St2.gameObject.SetActive(false);
        St3.gameObject.SetActive(false);
        St4.gameObject.SetActive(false);
        Cha11.gameObject.SetActive(false);
        Cha12.gameObject.SetActive(false);
        Cha13.gameObject.SetActive(false);
        Cha14.gameObject.SetActive(false);
        Cha21.gameObject.SetActive(false);
        Cha22.gameObject.SetActive(false);
        Cha23.gameObject.SetActive(false);
        Cha24.gameObject.SetActive(false);
        Menu.gameObject.SetActive(false);
        Menu2.gameObject.SetActive(false);
        leaf.gameObject.SetActive(false);
        leaf1.gameObject.SetActive(false);
        leaf2.gameObject.SetActive(false);
        leaf3.gameObject.SetActive(false);
        leaf4.gameObject.SetActive(false);
        leaf5.gameObject.SetActive(false);


        isCalledSelect = false;

        SetA();
        Invoke("SetA",0.5f);
        Invoke("setPlayer", 0.5f);
        setPlayer();
        Common.point+=Common.Dpoint;
    }

    // Update is called once per frame
    void Update()
    {
        if(Menu == true || Menu2 == true)
        {
            selectedObj = EventSystem.current.currentSelectedGameObject;
            if (Button == selectedObj)
            {
                leaf.gameObject.SetActive(true);
                leaf1.gameObject.SetActive(false);
                leaf2.gameObject.SetActive(false);
            }
            if (Button1 == selectedObj)
            {
                leaf.gameObject.SetActive(false);
                leaf1.gameObject.SetActive(true);
                leaf2.gameObject.SetActive(false);
            }
            if (Button2 == selectedObj)
            {
                leaf.gameObject.SetActive(false);
                leaf1.gameObject.SetActive(false);
                leaf2.gameObject.SetActive(true);
            }
            if (Button3 == selectedObj)
            {
                leaf3.gameObject.SetActive(true);
                leaf4.gameObject.SetActive(false);
                leaf5.gameObject.SetActive(false);
            }
            if (Button4 == selectedObj)
            {
                leaf3.gameObject.SetActive(false);
                leaf4.gameObject.SetActive(true);
                leaf5.gameObject.SetActive(false);
            }
            if (Button5 == selectedObj)
            {
                leaf3.gameObject.SetActive(false);
                leaf4.gameObject.SetActive(false);
                leaf5.gameObject.SetActive(true);
            }
        }
    }

    public void SetA()
    {
        string str = Common.point.ToString();
        pointtext.text = str;
        if(Common.point >= 30)
        {
            Invoke("Ster1",0.5f);
        }
        if (Common.point >= 60)
        {
            Invoke("Ster2", 1.0f);
        }
        if (Common.point >= 90)
        {
            Invoke("Ster3", 1.5f);
        }
        if (Common.point >= 360)
        {
            Invoke("Ster4", 2.0f);
        }
        Invoke("menu",4.5f);
    }
    public void setPlayer()
    {
        if (Common.player1skin == 1)
        {
            Cha11.gameObject.SetActive(true);
        }
        if (Common.player1skin == 2)
        {
            Cha12.gameObject.SetActive(true);
        }
        if (Common.player1skin == 3)
        {
            Cha13.gameObject.SetActive(true);
        }
        if (Common.player1skin == 4)
        {
            Cha14.gameObject.SetActive(true);
        }
        if (Common.player2skin == 1)
        {
            Cha21.gameObject.SetActive(true);
        }
        if (Common.player2skin == 2)
        {
            Cha22.gameObject.SetActive(true);
        }
        if (Common.player2skin == 3)
        {
            Cha23.gameObject.SetActive(true);
        }
        if (Common.player2skin == 4)
        {
            Cha24.gameObject.SetActive(true);
        }
    }
    void Ster1()
    {
        St1.gameObject.SetActive(true);
    }
    void Ster2()
    {
        St2.gameObject.SetActive(true);
    }
    void Ster3()
    {
        St3.gameObject.SetActive(true);
    }
    void Ster4()
    {
        St4.gameObject.SetActive(true);
    }


    void menu()
    {
        if (Common.SScene == "Japanst5")
        {
            Menu2.gameObject.SetActive(true);
            if (!isCalledSelect)
            {
                EventSystem.current.SetSelectedGameObject(Button4);
                isCalledSelect = true;
            }
            goto A;
        }
        if (Common.SScene == "st5")
        {
            Menu2.gameObject.SetActive(true);
            if (!isCalledSelect)
            {
                EventSystem.current.SetSelectedGameObject(Button4);
                isCalledSelect = true;
            }
            goto A;
        }
        if (Common.SScene == "GreatBarrierReef")
        {
            Menu2.gameObject.SetActive(true);
            if (!isCalledSelect)
            {
                EventSystem.current.SetSelectedGameObject(Button4);
                isCalledSelect = true;
            }
            goto A;
        }
        Menu.gameObject.SetActive(true);
        if (!isCalledSelect)
        {
            EventSystem.current.SetSelectedGameObject(Button);
            isCalledSelect = true;
            Debug.Log(selectedObj);
        }
    A:;
    }
}
