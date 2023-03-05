using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMagic : MonoBehaviour
{
    [SerializeField]
    int m_damage;
    [SerializeField]
    float m_moveSpeed;
    [SerializeField]
    float m_lifeTime;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Destroy), m_lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, m_moveSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerScript>().TakeDamage(m_damage);
        }
        Destroy();
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
