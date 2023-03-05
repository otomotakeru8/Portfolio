using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EffectConstant;

public delegate void TriggerHit();

public class Talent : MonoBehaviour
{
    [HideInInspector]
    public int m_damage;
    [HideInInspector]
    public int m_criticalChance;
    float m_speed;
    [HideInInspector]
    public float Speed
    {
        get
        {
            m_speed = m_velocity.GetSpeed();
            return m_speed;
        }
        set
        {
            m_speed = value;
            m_velocity.SetSpeed(m_speed);
        }
    }

    [HideInInspector]
    public float m_lifeTime;

    bool m_pierceing;
    Vector3 m_shotVector;
    List<StatusEffect> m_enemyEvents = new List<StatusEffect>();
    Velocity m_velocity;

    public TriggerHit m_triggerHit;

    public void SetStates(int damage, int criticalChance, float speed, float lifeTime, bool pierceing, Vector3 vector, float airResistance, float massScale)
    {
        m_damage = damage;
        m_criticalChance = criticalChance;
        m_speed = speed;
        m_lifeTime = lifeTime;
        Invoke(nameof(OutOfLife), m_lifeTime);
        m_pierceing = pierceing;
        m_velocity = GetComponent<Velocity>();
        m_velocity.Initialize(transform.forward, m_speed, airResistance, true, massScale);
        m_shotVector = vector;
    }

    public void AddEvent(StatusEffect enemyEvent)
    {
        m_enemyEvents.Add(enemyEvent);
    }

    private void OnTriggerEnter(Collider other)
    {
        string targetTag = other.tag;
        if (targetTag.Contains("Enemy") == true)
        {
            Enemy enemy = other.GetComponent<Enemy>();
            enemy.TakeDamage(m_damage, m_criticalChance);
            enemy.HitEvent(m_enemyEvents);
            m_triggerHit?.Invoke();
        }
        if (m_pierceing == false && targetTag.Contains("Tower") == false)
        {
            CancelInvoke();
            Destroy(this.gameObject);
        }
    }

    void OutOfLife()
    {
        Destroy(this.gameObject);
    }
}
