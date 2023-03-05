using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderBlockScript : MonoBehaviour
{
    [SerializeField]
    float m_dethTime;
    [SerializeField]
    int m_damage;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Destroy), m_dethTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().TakeDamage(m_damage);
        }
    }
    private void Destroy()
    {
        Destroy(gameObject);
    }
}
