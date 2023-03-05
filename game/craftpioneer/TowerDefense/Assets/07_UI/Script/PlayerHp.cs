using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GameManagerConstant;

public class PlayerHp : MonoBehaviour
{
    [SerializeField]
    GameObject m_gameManager;

    Image m_image;
    int m_hp;
    // Start is called before the first frame update
    void Start()
    {
        m_image = GetComponent<Image>();
        m_hp = maxHp;
        m_image.fillAmount = 1;
    }

    public void DecreaseHp()
    {
        m_hp--;
        m_image.fillAmount = (float)m_hp / maxHp;
        if (m_hp == 0)
        {
            m_gameManager.GetComponent<GameManager>().PlayerLose();
        }
    }
    public void LowestHp()
    {
        m_hp = 0;
        m_image.fillAmount = (float)m_hp / maxHp;
        m_gameManager.GetComponent<GameManager>().PlayerLose();
    }

}
