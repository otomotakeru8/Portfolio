using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxManaButtonScript : MonoBehaviour
{
    int m_value;
    int m_maxValue = 5;
    int m_cost = 2;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(MaxManaup);
    }

    void MaxManaup()
    {
        FindObjectOfType<PlayerDirector>().StoreTotalMana();
        FindObjectOfType<Store>().UsePoint(m_cost);
        m_value++;
        if (m_value == m_maxValue)
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
    }
}
