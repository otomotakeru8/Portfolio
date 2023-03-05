using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAndMove : MonoBehaviour
{
    const int CountrySelection = 0;
    const int RegionSelection = 1;
    int selectmode;
    //進行度（セーブ
    int progress;

    float LStick1Horizontal;
    float LStick1Vertical;
    float LStick2Horizontal;
    float LStick2Vertical;

    bool canmove;
    // Start is called before the first frame update
    void Start()
    {
        progress = PlayerPrefs.GetInt("ProgressData");
        if (progress == 0)
        {
            selectmode = 0;
        }
        if (selectmode == CountrySelection)
        {
            if ((progress / 5) == 0)//日本
            {

            }
            if ((progress / 5) == 1)//アメリカ
            {

            }
            if ((progress / 5) == 2 || (progress / 5) == 3)//オーストラリア
            {

            }
        }
        if (selectmode == RegionSelection)
        {
            if ((progress / 5) == 0)
            {
                if ((progress % 5) == 0)
                {

                }
                if ((progress % 5) == 1)
                {

                }
                if ((progress % 5) == 2)
                {

                }
                if ((progress % 5) == 3)
                {

                }
                if ((progress % 5) == 4)
                {

                }
            }
            if ((progress / 5) == 1)
            {
                if ((progress % 5) == 0)
                {

                }
                if ((progress % 5) == 1)
                {

                }
                if ((progress % 5) == 2)
                {

                }
                if ((progress % 5) == 3)
                {

                }
                if ((progress % 5) == 4)
                {

                }
            }
            if ((progress / 5) == 2 || (progress / 5) == 3)
            {
                if ((progress % 5) == 0)
                {

                }
                if ((progress % 5) == 1)
                {

                }
                if ((progress % 5) == 2)
                {

                }
                if ((progress % 5) == 3)
                {

                }
                if ((progress % 5) == 4)
                {

                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        if (canmove == true)
        {
            if (selectmode == CountrySelection) MoveonWorld();
            if (selectmode == RegionSelection) MoveonCountry();
        }
    }

    void GetInput()
    {
        if (Input.GetButton("A1"))
        { 
            
        }
        if (Input.GetButton("A2"))
        {

        }
        LStick1Horizontal = Input.GetAxis("L_Stick_H");
        LStick1Vertical = Input.GetAxis("L_Stick_V");
        LStick2Horizontal = Input.GetAxis("L_Stick_H2");
        LStick2Vertical = Input.GetAxis("L_Stick_V2");
    }

    void MoveonWorld()
    {

    }

    void Zoom()
    {

    }

    void Zoomout()
    {

    }

    void MoveonCountry()
    {

    }

    public void AddProgress(int number)//クリア後
    {
        progress = number;
        PlayerPrefs.SetInt("ProgressData",progress);
    }

    public void ResetWorldSelectMode()
    {
        selectmode = 0;
    }
    
    public void ResetProgress()
    {
        progress = 0;
    }
}
