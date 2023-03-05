using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    public GameObject PMaxSpeed;
    public GameObject PAddLevel;
    public GameObject ShiftTime;
    public GameObject DPS;
    public GameObject MaxMana;
    public GameObject MaxStrength;
    public GameObject Manarecovery;
    public GameObject Strengthrecovery;
    public GameObject Range;
    public GameObject Exit;

    public Text PointText;

    int m_point;

    // Update is called once per frame
    void Update()
    {
        if (m_point < 1)
        {
            PMaxSpeed.SetActive(false);
            PAddLevel.SetActive(false);
            ShiftTime.SetActive(false);
        }
        if (m_point < 2)
        {
            DPS.SetActive(false);
            MaxMana.SetActive(false);
            MaxStrength.SetActive(false);
        }
        if (m_point < 3)
        {
            Manarecovery.SetActive(false);
            Strengthrecovery.SetActive(false);
            Range.SetActive(false);
        }
        PointText.text = "Point:" + m_point.ToString();
    }

    public void StorOn()
    {
        PMaxSpeed.SetActive(true);
        PAddLevel.SetActive(true);
        ShiftTime.SetActive(true);
        DPS.SetActive(true);
        MaxMana.SetActive(true);
        MaxStrength.SetActive(true);
        Manarecovery.SetActive(true);
        Strengthrecovery.SetActive(true);
        Range.SetActive(true);
        Exit.SetActive(true);
    }

    public void StorOff()
    {
        PMaxSpeed.SetActive(false);
        PAddLevel.SetActive(false);
        ShiftTime.SetActive(false);
        DPS.SetActive(false);
        MaxMana.SetActive(false);
        MaxStrength.SetActive(false);
        Manarecovery.SetActive(false);
        Strengthrecovery.SetActive(false);
        Range.SetActive(false);
        Exit.SetActive(false);
    }

    public void AddPoint(int value)
    {
        m_point += value;
    }

    public void UsePoint(int value)
    {
        m_point -= value;
    }
}
