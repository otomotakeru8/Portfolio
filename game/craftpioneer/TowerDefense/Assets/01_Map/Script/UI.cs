using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    Text WoodCount;
    [SerializeField]
    Text StoneCount;
    [SerializeField]
    Text TowerValue;

    private void Start()
    {
        SetWoodCount(0);
        SetStoneCount(0);
        SetTowerValue(0);
    }

    public void SetWoodCount(int value)
    {
        WoodCount.text = $"Wood {value}";
    }

    public void SetStoneCount(int value)
    {
        StoneCount.text = $"Stone {value}";
    }

    public void SetTowerValue(int value)
    {
        TowerValue.text = $"Tower {value}";
    }
}
