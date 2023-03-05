using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic1Script : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.1f);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().TakeDamage(m_damage);
        }
        Destroy(gameObject);
    }
}
