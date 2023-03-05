using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EnemyConstant;
using static Utilities;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    GameObject enemy1;
    [SerializeField]
    GameObject enemy2;
    [SerializeField]
    GameObject enemy3;
    [SerializeField]
    GameObject enemy4;

    [SerializeField]
    PlayerData m_playerData;

    public MapData mapData;

    List<Vector3> m_enemySpawnPosition = new List<Vector3>();

    GameObject[] m_enemy;

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
        m_enemySpawnPosition = mapData.Village1Position;
        StartCoroutine(GenerateTimer());
    }

    public void Initialize()
    {
        m_enemy = new GameObject[4];
        m_enemy[0] = enemy1;
        m_enemy[1] = enemy2;
        m_enemy[2] = enemy3;
        m_enemy[3] = enemy4;
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(enemy1, m_enemySpawnPosition[0], Quaternion.identity, transform);
    }

    IEnumerator GenerateTimer()
    {
        yield return new WaitForSeconds(generateInterval);
        GenerateEnemy();
    }

    public void GenerateEnemy()
    {
        /*
        if (m_playerData.g_time > 400)
        {
            for (int i = 0; i < 4; i++)
            {
                int randCount = Random.Range(8, 13);
                StartCoroutine(DelayOfGenerateEnemy(i, randCount));
            }
        }
        else if (m_playerData.g_time > 300)
        {
            for (int i = 0; i < 4; i++)
            {
                int randCount = Random.Range(6, 11);
                StartCoroutine(DelayOfGenerateEnemy(i, randCount));
            }
        }
        else if (m_playerData.g_time > 200)
        {
            for (int i = 0; i < 4; i++)
            {
                int randCount = Random.Range(4, 8);
                StartCoroutine(DelayOfGenerateEnemy(i, randCount));
            }
        }
        else if (m_playerData.g_time > 100)
        {
            for (int i = 0; i < 4; i++)
            {
                int randCount = Random.Range(3, 6);
                StartCoroutine(DelayOfGenerateEnemy(i, randCount));
            }
        }
        else
        {
            for (int i = 0; i < 4; i++)
            {
                int randCount = Random.Range(2,4);
                StartCoroutine(DelayOfGenerateEnemy(i, randCount));
            }
        }
        */
    }

    IEnumerator DelayOfGenerateEnemy(int position , int count)
    {
        int counter = 0;
        LOOPPOINT:

        int randEnemy = Random.Range(0, 4);
        Instantiate(m_enemy[randEnemy], m_enemySpawnPosition[position], Quaternion.identity);

        counter++;
        if (counter != count)
        {
            yield return new WaitForSeconds(1);
            goto LOOPPOINT;
        }
    }



}
