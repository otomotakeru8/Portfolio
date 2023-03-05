using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    PlayerHp m_playerHp;
    // Start is called before the first frame update
    void Start()
    {
        m_playerHp = GameObject.Find("HpImage").GetComponent<PlayerHp>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<Enemy>().Dead();
            m_playerHp.DecreaseHp();
        }
        if (other.gameObject.CompareTag("BossEnemy"))
        {
            other.gameObject.GetComponent<Enemy>().Dead();
            m_playerHp.LowestHp();
        }
    }
}
