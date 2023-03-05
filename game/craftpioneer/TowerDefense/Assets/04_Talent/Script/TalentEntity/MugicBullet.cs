using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugicBullet : MonoBehaviour
{
    Searcher m_searcher = new Searcher();
    Velocity m_velocity;
    int m_progressFrame;
    const int m_FrameSpan = 15;
    [SerializeField]
    float m_seachRadius;

    // Start is called before the first frame update
    void Start()
    {
        m_velocity.GetComponent<Velocity>();
    }

    // Update is called once per frame
    void Update()
    {
        m_progressFrame++;
        if (m_progressFrame == m_FrameSpan)
        {
            GameObject target = m_searcher.SearchObjectByTag(transform.position, m_seachRadius, "Enemy");
            m_velocity.SetAngle(target.transform.position - transform.position);
            m_progressFrame = 0;
        }
    }
}
