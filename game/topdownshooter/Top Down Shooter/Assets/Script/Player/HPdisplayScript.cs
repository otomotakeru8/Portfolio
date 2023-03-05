using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPdisplayScript : MonoBehaviour
{
    bool m_death;
    public Material m_green;
    public Material m_red;
    public int m_hp;
    public GameObject m_retryText;
    public GameObject m_retryButton;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material = m_green;
        m_hp = 100;
    }

    // Update is called once per frame
    void Update()
    {

        transform.localScale = new Vector3(0.1f, m_hp / 100f, 0.01f);
        if (m_hp < 21)
        {
            GetComponent<Renderer>().material = m_red;
        }
        if (m_hp > 20)
        {
            GetComponent<Renderer>().material = m_green;
        }
    }

    public void HpDown(int value)
    {
        m_hp -= value;
        if (m_hp <= 0)
        {
            FindObjectOfType<PlayerScript>().Gamestop();
            FindObjectOfType<PlayerDirector>().Stop();
            if (m_death == false)
            {
                m_retryText.SetActive(true);
                m_retryButton.SetActive(true);
                m_death = true;
            }
        }
    }

    public void HPUp()
    {
        m_hp += 20;
    }
}
