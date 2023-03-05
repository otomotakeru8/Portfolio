using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject m_player;
    [SerializeField]
    GameObject m_magic;
    [SerializeField]
    int m_hp;
    [SerializeField]
    float m_moveSpeed;
    [SerializeField]
    float m_searchRadius;
    [SerializeField]
    float m_holdingDistance;
    [SerializeField]
    float m_attackRadius;
    [SerializeField]
    int m_fireDelayFrame;
    [SerializeField]
    int m_point;
    [SerializeField]
    bool m_encircle;
    [SerializeField]
    float m_encircleRadius;
    int m_rand;
    int m_frame;
    int m_lateHp;

    // Start is called before the first frame update
    void Start()
    {
        m_player = GameObject.Find("Player");
        m_rand = Random.Range(0,2);
    }

    // Update is called once per frame
    void Update()
    {
        float playerdistance = Vector3.Distance(m_player.transform.position, transform.position);
        if (playerdistance < m_searchRadius)
        {
            transform.LookAt(m_player.transform);
        }
        m_frame++;
        if (m_frame == m_fireDelayFrame)
        {
            m_frame = 0;
        }
        if (m_frame == 0)
        {
            if (playerdistance < m_attackRadius)
            {
                Instantiate(m_magic, transform.position + (transform.forward * 0.65f), transform.rotation);
            }
        }
        if (playerdistance < m_searchRadius && playerdistance > m_holdingDistance)
        {
            transform.Translate(0, 0, m_moveSpeed);
        }
        if (m_encircle == true && playerdistance < m_holdingDistance)
        {
            if (m_rand == 0)
            {
                transform.Translate(transform.right * m_moveSpeed);
            }
            else
            {
                transform.Translate(transform.right * -m_moveSpeed);
            }
        }
    }

    public void TakeDamage(int damage)
    {
        m_lateHp = m_hp;
        m_hp -= damage;
        if (m_lateHp > 0 && m_hp <= 0)
        {
            FindObjectOfType<WaveScript>().EnemyDefeat();
            FindObjectOfType<Store>().AddPoint(m_point);
            Destroy(gameObject);
        }
    }
}
