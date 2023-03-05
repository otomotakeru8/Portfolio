using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnvironmentalDestruction : MonoBehaviour
{
    [SerializeField]
    PlayerData m_playerData;
    [SerializeField]
    GameObject m_gameManager;

    public static bool achend = false;
    [SerializeField] Image en;
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
        achievement = m_playerData.g_environmentalDestruction / 100f;
        if (achievement >= i)
        {
            i += 0.002f;
            en.fillAmount = i;
        }
        else if (i >= 1)//クリア条件開拓度が100％になること
        {
            m_gameManager.GetComponent<GameManager>().PlayerWin();
        }
    }
}
