using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EffectConstant;
using static AnimationConstant;
using System.Linq;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    EnemyData enemyData;
    [HideInInspector]
    public EnemyData m_enemyData;
    [SerializeField]
    MapData m_mapData;
    [SerializeField]
    PlayerData m_playerData;


    GameObject m_gameManager;


    //HPUIのため
    [SerializeField]
    GameObject m_enemyHpUI;
    GameObject m_uiObject;
    GameObject m_canvas;

    List<StatusEffect> m_statusEffects = new List<StatusEffect>();
    int m_intervalCount;
    bool m_frozen;

    int m_status_wet;
    int m_status_oiled;

    List<Vector2> m_moveRoute;
    int m_movePoint = 0;

    int m_hp;

    CustomAnimation m_customAnimation;

    // Start is called before the first frame update
    void Start()
    {
        m_canvas = GameObject.Find("Canvas");
        m_gameManager = GameObject.Find("GameManager");
        m_enemyData = ScriptableObject.CreateInstance<EnemyData>();
        m_enemyData.DeepCopy(enemyData);
        m_customAnimation = GetComponentInChildren<CustomAnimation>();
        Vector2 startPos = new Vector2((int)transform.position.x, (int)transform.position.z);
        for (int i = 0; i < m_mapData.EnemyMoveRoute.Count; i++)
        {
            int findValue = m_mapData.EnemyMoveRoute[i].IndexOf(startPos);
            if (findValue >= 0)
            {
                m_moveRoute = new List<Vector2>();
                for (int j = findValue; j < m_mapData.EnemyMoveRoute[i].Count; j++)
                {
                    if (m_moveRoute.IndexOf(m_mapData.EnemyMoveRoute[i][j]) > 0)
                    {
                        continue;
                    }
                    m_moveRoute.Add(m_mapData.EnemyMoveRoute[i][j]);
                }
                break;
            }
        }
        m_hp *= 1 + (int)(Mathf.Pow(m_playerData.g_environmentalDestruction, 2) / 1000);
        Vector2 vector = new Vector2(m_moveRoute[m_movePoint + 1].x - m_moveRoute[m_movePoint].x, m_moveRoute[m_movePoint + 1].y - m_moveRoute[m_movePoint].y);
        transform.rotation = Quaternion.Euler(0, Mathf.Atan2(vector.x, vector.y) * Mathf.Rad2Deg, 0);

        //HpUI
        m_uiObject = Instantiate(m_enemyHpUI, m_canvas.transform);
        m_uiObject.GetComponent<EnemyHpUI>().m_enemyTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //スピードを入れた移動
        if (m_frozen == false)
        {
            transform.Translate(transform.forward * m_enemyData.m_speed * Time.deltaTime, Space.World);
        }
        //移動距離が1ブロック分を超えたら次の配列を参照
        if (Vector2.Distance(m_moveRoute[m_movePoint], new Vector2(transform.position.x, transform.position.z)) > 1)
        {
            m_movePoint++;
            Vector2 vector = new Vector2(m_moveRoute[m_movePoint + 1].x - m_moveRoute[m_movePoint].x, m_moveRoute[m_movePoint + 1].y - m_moveRoute[m_movePoint].y);
            transform.rotation = Quaternion.Euler(0, Mathf.Atan2(vector.x, vector.y) * Mathf.Rad2Deg, 0);
        }

        m_intervalCount++;
        if (m_intervalCount == statusEffectInterval)
        {
            StatusEffectEvent();
            m_intervalCount = 0;
            m_status_wet -= 20;
            m_status_oiled -= 15;
        }
    }

    public void TakeDamage(int damage, int criticalChance)
    {
        int rnd = Random.Range(0, 100);
        if(rnd < criticalChance)
        {
            damage *= 2;
        }
        m_enemyData.m_hp -= damage; 
        if (m_enemyData.m_hp <= 0)
        {
            m_enemyData.m_speed = 0;
            GetComponent<SphereCollider>().enabled = false;
            DeadAnimation();
            Invoke(nameof(Dead), 1);
            if (enemyData.m_enemyName == "BossEnemy1")
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().RandomUnLock();
                GameObject.Find("Canvas/TalentPanel").GetComponent<TalentPanel>().PopTalents();
                m_gameManager.GetComponent<GameManager>().PlayerWin();
            }
            if (enemyData.m_enemyName == "Enemy5")
            {
                GameObject.Find("EnemyPool").GetComponent<ClearUIControl>().ClearCounter();
            }
        }
        m_uiObject.GetComponent<Image>().fillAmount = (float)m_enemyData.m_hp / (float)enemyData.m_hp;
    }

    void StatusEffectEvent()
    {
        foreach (StatusEffect statusEffect in m_statusEffects)
        {
            switch (statusEffect)
            {
                case StatusEffect.fire:
                    if (m_status_oiled > 0)
                    {
                        TakeDamage((int)(fireDamagePercent * m_enemyData.m_fireDamageMultiplier / 100 * 1.5), 0);
                    }
                    else if (m_status_wet > 0)
                    {
                        TakeDamage((int)(fireDamagePercent * m_enemyData.m_fireDamageMultiplier / 100 * 0.5), 0);
                    }
                    break;
                case StatusEffect.toxic:
                    TakeDamage((int)(toxicDamagePercent * m_enemyData.m_toxicDamageMultiplier / 100), 0);
                    break;
            }
        }
    }

    public void AddEffect_Wet()
    {
        m_status_wet = effectMaxValue;
    }

    public void AddEffect_Oiled()
    {
        m_status_oiled = effectMaxValue;
    }

    public void HitEvent(List<StatusEffect> enemyEventType)
    {
        foreach (StatusEffect statusEffect in enemyEventType)
        {
            if (m_statusEffects.IndexOf(statusEffect) < 0)
            {
                StartCoroutine(ReMoveEffect(statusEffectRemoveSec, statusEffect));
                switch (statusEffect)
                {
                    case StatusEffect.electric:
                        if (m_status_wet > 0)
                        {
                            TakeDamage((int)(electricDamagePercent * m_enemyData.m_electricityDamageMultiplier / 100 * 1.5), 0);
                        }
                        else
                        {
                            TakeDamage((int)(electricDamagePercent * m_enemyData.m_electricityDamageMultiplier / 100), 0);
                        }
                        break;
                    case StatusEffect.ice:
                        m_frozen = true;
                        break;
                }
            }
            m_statusEffects.Add(statusEffect);
        }
    }

    IEnumerator ReMoveEffect(float waitTime, StatusEffect statusEffect)
    {
        yield return new WaitForSeconds(waitTime);
        m_statusEffects.Remove(statusEffect);
        if (statusEffect == StatusEffect.ice)
        {
            m_frozen = false;
        }
    }

    void DeadAnimation()
    {
        GetComponent<CustomAnimation>().m_baseAnimationSpeed = 0.5f;
    }

    public void Dead()
    {
        Destroy(m_uiObject);
        Destroy(gameObject);
    }
}
