using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tasseidoline : MonoBehaviour
{
    [SerializeField]
    PlayerData m_playerData;

    public static bool achend = false;
    [SerializeField]Image en;
    public float achievement = 0.5f;
    float i = 0f;
    // Start is called before the first frame update
    void Start()
    {
        achievement = m_playerData.g_environmentalDestruction / 100f;
    }

    // Update is called once per frame
    void Update()
    {
        if(achievement >= i) {
            i+=0.0002f;
            en.fillAmount= i;
        }
        else
        {
            //達成度メーターがとまった事の判定
            achend = true;
        }
    }
}
