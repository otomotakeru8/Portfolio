using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveScript : MonoBehaviour
{
    GameObject m_player;
    float m_playerPosZ;
    int m_activeEnemy;
    public GameObject m_clearText;
    public GameObject m_retryButton;
    [SerializeField]
    GameObject[] m_enemys;
    Vector3[] m_generatePositions = new Vector3[]
    {
        new Vector3(0, 1, 15),
        new Vector3(3, 1, 15),
        new Vector3(-3, 1, 15),
        new Vector3(0, 1, 17),
        new Vector3(2, 1, 17),
        new Vector3(4, 1, 17),
        new Vector3(-2, 1, 17),
        new Vector3(-4, 1, 17),
        new Vector3(1, 1, 18.5f),
        new Vector3(-1, 1, 18.5f)
    };
    int m_waveNumber;
    [SerializeField]
    WaveData m_waveData;
    [SerializeField]
    FloorScript m_floorScript;

    // Start is called before the first frame update
    void Start()
    {
        m_player = GameObject.Find("Player");
    }

    public void Nextwave()
    {
        Invoke(nameof(WaveGenerate), 5f);
    }

    public void WaveGenerate()
    {
        m_playerPosZ = m_player.transform.position.z;
        Wave wave = m_waveData.waves[m_waveNumber];
        m_activeEnemy = wave.m_generateEnemyDatas.Length;
        for (int i = 0; i < m_activeEnemy; i++)
        {
            int rand = Random.Range(wave.m_generateEnemyDatas[i].m_minEnemyLevel, wave.m_generateEnemyDatas[i].m_maxEnemyLevel);
            Instantiate(m_enemys[rand], m_generatePositions[i] + new Vector3(0, 0, m_playerPosZ), Quaternion.identity);
        }
    }

    public void EnemyDefeat()
    {
        m_activeEnemy -= 1;
        if (m_activeEnemy <= 0)
        {
            m_waveNumber += 1;
            if (m_waveNumber == 8)
            {
                m_clearText.SetActive(true);
                m_retryButton.SetActive(true);
                FindObjectOfType<Store>().StorOff();
            }
            else
            {
                FindObjectOfType<Store>().StorOn();
                m_floorScript.ChangeColor();
            }
        }
    }
}
