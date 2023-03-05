using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    GameObject m_player;
    Vector3 m_latePlayerPostion;

    // Start is called before the first frame update
    void Start()
    {
        m_player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += m_player.transform.position - m_latePlayerPostion;
        m_latePlayerPostion = m_player.transform.position;
    }
}