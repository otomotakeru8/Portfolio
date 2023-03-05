using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public GameObject m_tareget;
    Velocity m_velocity;

    // Start is called before the first frame update
    void Start()
    {
        m_velocity = GetComponent<Velocity>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_tareget != null)
        {
            m_velocity.SetAngle(m_tareget.transform.position - transform.position);
        }
    }
}
