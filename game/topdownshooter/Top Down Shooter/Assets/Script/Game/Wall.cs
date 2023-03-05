using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject m_redCube;
    public GameObject m_greenCube;
    public GameObject m_blueCube;
    int m_color;
    Vector3 m_generatePos;

    // Start is called before the first frame update
    void Start()
    {
        m_generatePos = new Vector3(15, 0, 0);
        for (int i = 0; i < 150; i++)
        {
            int rength = Random.Range(3, 6);
            int hight = Random.Range(1, 6);
            m_color = Random.Range(1, 4);
            m_generatePos.z += rength;
            m_generatePos.y = hight;
            if (m_color == 1)
            {
                Instantiate(m_redCube, m_generatePos, Quaternion.identity, transform);
            }
            if (m_color == 2)
            {
                Instantiate(m_greenCube, m_generatePos, Quaternion.identity, transform);
            }
            if (m_color == 3)
            {
                Instantiate(m_blueCube, m_generatePos, Quaternion.identity, transform);
            }
        }
    }
}
