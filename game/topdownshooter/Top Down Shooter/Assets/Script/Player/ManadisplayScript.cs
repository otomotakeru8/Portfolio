using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManadisplayScript : MonoBehaviour
{
    public PlayerDirector m_playerDirector;

    // Update is called once per frame
    void Update()
    {
       transform.localScale = new Vector3(0.1f, m_playerDirector.m_manaPoint / 100f, 0.01f);
    }
}
