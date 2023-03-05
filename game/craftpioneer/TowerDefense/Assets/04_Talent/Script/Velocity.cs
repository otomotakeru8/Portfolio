using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    Vector3 m_vector;

    bool m_useGravity;
    [HideInInspector]
    public float m_massScale;
    [HideInInspector]
    [Tooltip("range 0~1")]
    public float m_airResistance;

    public void Initialize(Vector3 vector, float speed, float airResistance, bool useGravity, float massScale)
    {
        m_vector = vector;
        m_vector *= speed;
        m_airResistance = airResistance;
        m_useGravity = useGravity;
        m_massScale = massScale;
    }

    public void SetAngle(Vector3 angle)
    {
        m_vector = angle.normalized * GetSpeed();
    }

    public float GetSpeed()
    {
        return m_vector.magnitude;
    }

    public void SetSpeed(float value)
    {
        m_vector = m_vector.normalized * value;
    }

    private void LateUpdate()
    {
        if (m_useGravity == true)
        {
            float speed = GetSpeed();
            m_vector.y -= m_massScale * Time.deltaTime;
            m_vector = m_vector.normalized * speed;
        }
        float nowSpeed = GetSpeed();
        nowSpeed -= nowSpeed * m_airResistance * Time.deltaTime; 
        m_vector = m_vector.normalized * nowSpeed;
        transform.Translate(m_vector * Time.deltaTime, Space.World);
        transform.LookAt(transform.position + m_vector);
    }
}
