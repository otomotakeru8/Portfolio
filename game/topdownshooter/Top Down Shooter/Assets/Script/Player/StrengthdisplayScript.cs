using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrengthdisplayScript : MonoBehaviour
{
    public Material m_yellow;
    public Material m_red;
    public PlayerDirector m_playerDirector;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material = m_yellow;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(0.1f, m_playerDirector.m_strengthPoint / 100f, 0.01f);
        if(m_playerDirector.m_strengthPoint < 21)
        {
            GetComponent<Renderer>().material = m_red;
        }
        if(m_playerDirector.m_strengthPoint > 20)
        {
            GetComponent<Renderer>().material = m_yellow;
        }
    }
}
