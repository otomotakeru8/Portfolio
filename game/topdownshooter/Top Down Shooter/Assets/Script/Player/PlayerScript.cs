using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float m_maxSpeed;
    Rigidbody m_rigidbody;
    Plane m_plane = new Plane();
    public float m_acceleration;
    public float m_dashTime;
    float m_boost;
    bool m_onDash;
    public bool m_gameStop;
    public PlayerDirector m_playerDirector;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        m_boost = 1;
        m_dashTime = 0.5f;
        m_gameStop = true;
    }

    // Update is called once per frame
    void Update()//プレイヤーの移動
    {
        if (m_gameStop == false)
        {
            if (Input.GetKey(KeyCode.W))
            {
                m_rigidbody.AddForce(0, 0, 30 * m_boost);
            }
            if (Input.GetKey(KeyCode.S))
            {
                m_rigidbody.AddForce(0, 0, -30 * m_boost);
            }
            if (Input.GetKey(KeyCode.D))
            {
                m_rigidbody.AddForce(30 * m_boost, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                m_rigidbody.AddForce(-30 * m_boost, 0, 0);
            }
        }
        if(m_playerDirector.m_strengthPoint > 20 && m_onDash == false)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Invoke(nameof(DashDone), m_dashTime);
                m_boost = 2 + m_acceleration;
                FindObjectOfType<PlayerDirector>().UseStrengthPoint20();
                m_onDash = true;
            }
        }
        if(m_rigidbody.velocity.magnitude > m_maxSpeed * m_boost + m_acceleration)
        {
            m_rigidbody.velocity = m_rigidbody.velocity.normalized * m_maxSpeed * m_boost;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        m_plane.SetNormalAndPosition(Vector3.up, transform.localPosition);
        if (m_plane.Raycast(ray, out float distance))
        {
            var loockPoint = ray.GetPoint(distance);
            transform.LookAt(loockPoint);
        }
    }
    void DashDone()
    {
        m_boost = 1;
        m_onDash = false;
    }

    private void OnTriggerEnter(Collider other)//当たり判定
    {
        if (other.CompareTag("Fall"))
        {
            float Rez = transform.position.z;
            if (Rez < 0)
            {
                Rez = 0;
            }
            transform.position = new Vector3(0,1,Rez);
        }
    }

    public void GameStart()
    {
        m_gameStop = false; 
        transform.position = new Vector3(0,1,0);
    }

    public void Gamestop()
    {
        m_gameStop = true;
    }

    public void StorMaxSpeed()
    {
        m_maxSpeed += 0.5f;
    }

    public void StorShift()
    {
        m_acceleration += 0.5f;
    }

    public void StorShiftTime()
    {
        m_dashTime += 0.25f;
    }

    public void TakeDamage(int damage)
    {
        FindObjectOfType<HPdisplayScript>().HpDown(damage);
    }
}
