using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaRecoveryButtonScript : MonoBehaviour
{
    int m_value;
    int m_maxValue = 5;
    int m_cost = 3;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ManaRecoveryup);
    }

    void ManaRecoveryup()
    {
        FindObjectOfType<PlayerDirector>().StoreManarecovery();
        FindObjectOfType<Store>().UsePoint(m_cost);
        m_value++;
        if (m_value == m_maxValue)
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
    }
}
