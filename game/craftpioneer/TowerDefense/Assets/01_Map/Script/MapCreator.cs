using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MapConstant;

public class MapCreator : MonoBehaviour
{
    //プレハブ格納
    [SerializeField]
    GameObject Ground;
    [SerializeField]
    GameObject Biome;
    [SerializeField]
    GameObject Biome1;
    [SerializeField]
    GameObject Biome2;
    [SerializeField]
    GameObject Biome3;
    [SerializeField]
    GameObject Castle;
    [SerializeField]
    GameObject Village1;
    [SerializeField]
    GameObject Village2;
    [SerializeField]
    GameObject Road;
    [SerializeField]
    MapData mapData;

    //マップ配列の構造体
    public struct MapType
    {
        public int groundData;
        public int biomeData;
    }

    MapType[,] mapDatas = new MapType[mapX, mapY];
    int[,] roadableRaitoData = new int[mapX, mapY];
    int x;
    int y;
    float r = 45.0f;
    float r1 = 15.0f;
    float r2 = 30.0f;
    public GameObject[,] GroundAddress = new GameObject[mapX, mapY];
    public int RockPercentage = 20;
    public int NormalPercentage = 50;
    bool m_generateUnSuccess;
    int m_tryGenerateLoadCount;

    //Enemy
    List<List<Vector2>> m_EnemyMoveRoute = new List<List<Vector2>>();
    List<Vector2> m_localEnemyMoveRoute = new List<Vector2>();

    private void Start()
    {
        //マップの初期化
        mapData.Initialize();
        m_generateUnSuccess = false;

        for (int i = 0; i < 4; i++)
        {
            m_EnemyMoveRoute.Add(new List<Vector2>());
        }
        mapDatas[center, center].groundData = 1;
        mapDatas[51, 50].groundData = 6;
        mapDatas[50, 51].groundData = 6;
        mapDatas[49, 50].groundData = 6;
        mapDatas[50, 49].groundData = 6;
        float theta;
        theta = Random.Range(0, Mathf.PI / 2);
        x = (int)(r * Mathf.Cos(theta)) + center;
        y = (int)(r * Mathf.Sin(theta)) + center;
        mapDatas[x, y].biomeData = 0;
        mapDatas[x, y].groundData = 2;
        theta += Random.Range(Mathf.PI / 3, Mathf.PI / 2);
        x = (int)(r * Mathf.Cos(theta)) + center;
        y = (int)(r * Mathf.Sin(theta)) + center;
        mapDatas[x, y].biomeData = 1;
        mapDatas[x, y].groundData = 2;
        theta += Random.Range(Mathf.PI / 3, Mathf.PI / 1.5f);
        x = (int)(r * Mathf.Cos(theta)) + center;
        y = (int)(r * Mathf.Sin(theta)) + center;
        mapDatas[x, y].biomeData = 2;
        mapDatas[x, y].groundData = 2;
        theta += Random.Range(Mathf.PI / 3, Mathf.PI / 2);
        x = (int)(r * Mathf.Cos(theta)) + center;
        y = (int)(r * Mathf.Sin(theta)) + center;
        mapDatas[x, y].biomeData = 3;
        mapDatas[x, y].groundData = 2;

        //マップ生成
        Vector2[] castles = MapSearch(2).ToArray();
        GenerateBiome(castles);
        GenerateVillage(r1, r2);
        Vector2[] village1 = MapSearch(3).ToArray();
        Vector2[] village2 = MapSearch(4).ToArray();
        GenerateLoad();
        if (m_generateUnSuccess == false)
        {
            m_generateUnSuccess = true;
            ReGenerate(castles, village1, village2);
            MapGenerate();
            GenerateTree();

            //エネミーの発生場所
            Vector3[] Village1Spawn = SearchSpawnPosition(3).ToArray();
            foreach (Vector3 k in Village1Spawn)
            {
                mapData.Village1Position.Add(k);
                mapData.EnemySpawnPosition.Add(k);
            }
            Vector3[] Village2Spawn = SearchSpawnPosition(4).ToArray();
            foreach (Vector3 k in Village2Spawn)
            {
                mapData.Village2Position.Add(k);
                mapData.EnemySpawnPosition.Add(k);
            }
            Vector3[] CastleSpawn = SearchSpawnPosition(2).ToArray();
            foreach (Vector3 k in CastleSpawn)
            {
                mapData.CastlePosition.Add(k);
                mapData.EnemySpawnPosition.Add(k);
            }
            //エネミーのルート
            mapData.EnemyMoveRoute = m_EnemyMoveRoute;
        }
    }

    //バイオーム作る
    void GenerateBiome(Vector2[]targets)
    {
        for (int i = 0; i < mapDatas.GetLength(0); i++)
        {
            for (int j = 0; j < mapDatas.GetLength(1); j++)
            {
                float a = 1000.0f;
                Vector2 target = new Vector2(0, 0);
                foreach (Vector2 k in targets)
                {
                    if (a >= Vector2.Distance(new Vector2(i, j), k))
                    {
                        a = Vector2.Distance(new Vector2(i, j), k);
                        target = k;
                    }
                }
                mapDatas[i, j].biomeData = mapDatas[(int)target.x, (int)target.y].biomeData;
                if(i >= 47 && i <= 50 && j>= 51 && j <= 53)//i X j Y
                {
                    mapDatas[i, j].biomeData = 1;
                }
                if (i >= 47 && i <= 49 && j >= 47 && j <= 50)
                {
                    mapDatas[i, j].biomeData = 2;
                }
                if (i >= 50 && i <= 53 && j >= 47 && j <= 49)
                {
                    mapDatas[i, j].biomeData = 3;
                }
                if (i >= 51 && i <= 53 && j >= 50 && j <= 53)
                {
                    mapDatas[i, j].biomeData = 0;
                }
            }
        }
    }

    void GenerateVillage(float r1,float r2)
    {
        float theta = 0;
        for (int i= 0; i < 4; i++)
        {
            while (true)
            {
                theta += Random.Range(Mathf.PI / 3, Mathf.PI / 2);
                x = (int)(r1 * Mathf.Cos(theta)) + 50;
                y = (int)(r1 * Mathf.Sin(theta)) + 50;
                if (mapDatas[x, y].biomeData == i)
                {
                    mapDatas[x, y].groundData = 3;
                    break;
                }
            }
        }
        theta = 0;
        for (int i = 0; i < 4; i++)
        {
            while (true)
            {
                theta += Random.Range(Mathf.PI / 3, Mathf.PI / 2);
                x = (int)(r2 * Mathf.Cos(theta)) + 50;
                y = (int)(r2 * Mathf.Sin(theta)) + 50;
                if (mapDatas[x, y].biomeData == i)
                {
                    mapDatas[x, y].groundData = 4;
                    break;
                }
            }
        }
    }

    void GenerateLoad()
    {
        m_tryGenerateLoadCount++;
        List<Vector2> roadStarts = MapSearch(2);
        foreach (Vector2 roadStart in roadStarts)
        {
            Vector2 start = roadStart;
            int a = 0;
            m_localEnemyMoveRoute = new List<Vector2>();
            while (true)
            {
                if (LoadSection(MapSearchOnBiome(4,mapDatas[(int)start.x,(int)start.y].biomeData), start, out start))
                {
                    break;
                }
                a++;
                if(a>50)
                {
                    m_generateUnSuccess = true;
                    break;
                }
            }
            a=0;
            m_localEnemyMoveRoute = new List<Vector2>();
            while (true)
            {
                if (LoadSection(MapSearchOnBiome(3, mapDatas[(int)start.x, (int)start.y].biomeData), start, out start))
                {
                    break;
                }
                a++;
                if (a > 50)
                {
                    m_generateUnSuccess = true;
                    break;
                }
            }
            a=0;
            m_localEnemyMoveRoute = new List<Vector2>();
            while (true)
            {
                if (mapDatas[(int)roadStart.x, (int)roadStart.y].biomeData == 0)
                {
                    if (LoadSection(new Vector2(51, 50), start, out start))
                    {
                        m_EnemyMoveRoute[mapDatas[(int)roadStart.x, (int)roadStart.y].biomeData].Add(new Vector2(51, 50));
                        m_EnemyMoveRoute[mapDatas[(int)roadStart.x, (int)roadStart.y].biomeData].Add(new Vector2(50, 50));
                        break;
                    }
                }
                if (mapDatas[(int)roadStart.x, (int)roadStart.y].biomeData == 1)
                {
                    if (LoadSection(new Vector2(50, 51), start, out start))
                    {
                        m_EnemyMoveRoute[mapDatas[(int)roadStart.x, (int)roadStart.y].biomeData].Add(new Vector2(50, 51));
                        m_EnemyMoveRoute[mapDatas[(int)roadStart.x, (int)roadStart.y].biomeData].Add(new Vector2(50, 50));
                        break;
                    }
                }
                if (mapDatas[(int)roadStart.x, (int)roadStart.y].biomeData == 2)
                {
                    if (LoadSection(new Vector2(49, 50), start, out start))
                    {
                        m_EnemyMoveRoute[mapDatas[(int)roadStart.x, (int)roadStart.y].biomeData].Add(new Vector2(49, 50));
                        m_EnemyMoveRoute[mapDatas[(int)roadStart.x, (int)roadStart.y].biomeData].Add(new Vector2(50, 50));
                        break;
                    }
                }
                if (mapDatas[(int)roadStart.x, (int)roadStart.y].biomeData == 3)
                {
                    if (LoadSection(new Vector2(50, 49), start, out start))
                    {
                        m_EnemyMoveRoute[mapDatas[(int)roadStart.x, (int)roadStart.y].biomeData].Add(new Vector2(50, 49));
                        m_EnemyMoveRoute[mapDatas[(int)roadStart.x, (int)roadStart.y].biomeData].Add(new Vector2(50, 50));
                        break;
                    }
                }
                a++;
                if (a > 50)
                {
                    m_generateUnSuccess = true;
                    break;
                }
            }
        }
        if (m_generateUnSuccess == true && m_tryGenerateLoadCount < 50)
        {
            for (int i = 0; i < mapX; i++)
            {
                for (int j = 0; j < mapY; j++)
                {
                    mapDatas[i, j].biomeData = 0;
                    mapDatas[i, j].groundData = 0;
                }
            }
            Start();
        }
    }

    void ReGenerate(Vector2[] ca, Vector2[] vi1, Vector2[] vi2)
    {
        foreach (Vector2 k in ca)
        {
            mapDatas[(int)k.x,(int)k.y].groundData= 2;
        }
        foreach (Vector2 k in vi1)
        {
            mapDatas[(int)k.x, (int)k.y].groundData = 3;
        }
        foreach (Vector2 k in vi2)
        {
            mapDatas[(int)k.x, (int)k.y].groundData = 4;
        }
    }

    void MapGenerate()
    {
        for (int x = 0; x < mapDatas.GetLength(0); x++)
        {
            for (int y = 0; y < mapDatas.GetLength(1); y++)
            {
                switch (mapDatas[x, y].groundData)
                {
                    case 0:
                        switch (mapDatas[x, y].biomeData)
                        {
                            case 0:
                                GroundAddress[x, y] = Instantiate(Biome, new Vector3(x, 0, y),Biome.transform.rotation, transform);
                                break;
                            case 1:
                                GroundAddress[x, y] = Instantiate(Biome1, new Vector3(x, 0, y), Quaternion.identity, transform);
                                break;
                            case 2:
                                GroundAddress[x, y] = Instantiate(Biome2, new Vector3(x, 0, y), Quaternion.identity, transform);
                                break;
                            case 3:
                                GroundAddress[x, y] = Instantiate(Biome3, new Vector3(x, 0, y), Quaternion.identity, transform);
                                break;
                        }
                        break;
                    case 1:
                        GroundAddress[x, y] = Instantiate(Ground, new Vector3(x, 0, y), Quaternion.identity, transform);
                        break;
                    case 2:
                        GroundAddress[x, y] = Instantiate(Castle, new Vector3(x, 0, y), Quaternion.identity, transform);
                        break;
                    case 3:
                        GroundAddress[x, y] = Instantiate(Village1, new Vector3(x, 0, y), Quaternion.identity, transform);
                        break;
                    case 4:
                        GroundAddress[x, y] = Instantiate(Village2, new Vector3(x, 0, y), Quaternion.identity, transform);
                        break;
                    case 5:
                        GroundAddress[x, y] = Instantiate(Road, new Vector3(x, 0, y), Quaternion.identity, transform);
                        break;
                    case 6:
                        GroundAddress[x, y] = Instantiate(Road, new Vector3(x, 0, y), Quaternion.identity, transform);
                        break;
                }
            }
        }
    }

    void GenerateTree()
    {
        for (int x = 0; x < mapDatas.GetLength(0); x++)
        {
            for (int y = 0; y < mapDatas.GetLength(1); y++)
            {
                int foge = Random.Range(0, 100);
                if (mapDatas[x,y].groundData != 0)//城村道は木が生えない
                {
                    continue;
                }
                if (NormalPercentage < foge)
                {
                    continue;
                }
                if (RockPercentage < foge && foge < NormalPercentage)
                {
                    GroundAddress[x, y].GetComponent<Ground>().ShowTree();
                }
                else
                {
                    GroundAddress[x, y].GetComponent<Ground>().ShowRock();
                }
            }
        }
    }

    List<Vector2> MapSearch(int SearchNumber)
    {
        List<Vector2> taterget = new List<Vector2>();
        for (int i = 0; i < mapDatas.GetLength(0); i++)
        {
            for (int j = 0; j < mapDatas.GetLength(1); j++)
            {
                if (mapDatas[i, j].groundData == SearchNumber)
                {
                    taterget.Add(new Vector2(i, j));
                    //Debug.Log("探した場所"+ i + "," + j);
                }
            }
        }
        return taterget;
    }
    List<Vector3> SearchSpawnPosition(int SearchNumber)
    {
        List<Vector3> taterget = new List<Vector3>();
        for (int k = 0; k < MapConstant.biomeLength; k++)//バイオームごとにそれぞれ城や村があるため
        {
            for (int i = 0; i < mapDatas.GetLength(0); i++)//全検索
            {
                for (int j = 0; j < mapDatas.GetLength(1); j++)
                {
                    if (mapDatas[i, j].groundData == SearchNumber && mapDatas[i, j].biomeData == k)//村や城でバイオームの順番で加える
                    {
                        taterget.Add(new Vector3(i, 0, j));
                        //Debug.Log("探した場所"+ i + "," + j);
                    }
                }
            }
        }
        
        return taterget;
    }

    Vector2 MapSearchOnBiome (int groundValue , int biomeValue)
    {
        Vector2 result = new Vector2();
        foreach(Vector2 tagetPos in MapSearch(groundValue))
        {
            if(mapDatas[(int)tagetPos.x, (int)tagetPos.y].biomeData == biomeValue)
            {
                result = tagetPos;
            }
        }
        return result;
    }


    bool LoadSection(Vector2 target ,Vector2 roadStart , out Vector2 result)
    {
        Vector2 targetOffset = target - new Vector2(50, 50);
        float targetSqrLen = targetOffset.sqrMagnitude;
        Vector2 offset1 = roadStart - new Vector2(50, 50);
        float roadStartSqrLen = offset1.sqrMagnitude;

        List<int> coordinateDataX = new List<int> { (int)target.x, (int)roadStart.x };
        List<int> coordinateDataY = new List<int> { (int)target.y, (int)roadStart.y};
        coordinateDataX.Sort();
        coordinateDataY.Sort();

        int roadNumber = mapDatas[(int)roadStart.x, (int)roadStart.y].biomeData;

        for (int x = 0; x < roadableRaitoData.GetLength(0); x++)
        {
            for (int y = 0; y < roadableRaitoData.GetLength(1); y++)
            {
                roadableRaitoData[x, y] = 100;
                if (coordinateDataX[0] <= x && x <= coordinateDataX[1])
                {
                    if (coordinateDataY[0] <= y && y <= coordinateDataY[1])
                    {
                        if (mapDatas[(int)roadStart.x , (int)roadStart.y].biomeData == mapDatas[x,y].biomeData)
                        {
                            if (mapDatas[x, y].groundData != 5)
                            {
                                roadableRaitoData[x, y] = 0;
                            }
                        }
                    }
                }
            }
        }
        int a = 0;
        ho:
        a++;
        if(a > 100)
        {
            result = default;
            return false;
        }
        Vector2 rnd = UnityEngine.Random.insideUnitCircle;
        if(rnd.x < rnd.y)
        {
            rnd.x = 0;
        }
        else
        {
            rnd.y = 0;
        }
        int rndSize = Random.Range(1, 3);
        rnd = rnd.normalized * rndSize;

        Vector2 resultTarget = new Vector2( (int)rnd.x + (int)roadStart.x, (int)rnd.y + (int)roadStart.y);
        if (resultTarget.x < 0 || resultTarget.x > 100)
        {
            goto ho;
        }
        if (resultTarget.y < 0 || resultTarget.y > 100)
        {
            goto ho;
        }

        if (roadableRaitoData[(int)resultTarget.x, (int)resultTarget.y] < 100)
        {

            if(roadableRaitoData[(int)resultTarget.x, (int)resultTarget.y] < Random.Range(0, 100))
            {
                for (int i = 1; i <= rndSize + 1; i++)
                {
                    if (mapDatas[(int)resultTarget.x - (int)rnd.x / i, (int)resultTarget.y - (int)rnd.y / i].groundData == mapDatas[(int)target.x, (int)target.y].groundData)
                    {
                        result = resultTarget;
                        for (int j = 0; j < m_localEnemyMoveRoute.Count; j++)
                        {
                            m_EnemyMoveRoute[roadNumber].Add(m_localEnemyMoveRoute[j]);
                        }
                        return true;
                    }
                    m_localEnemyMoveRoute.Add(new Vector2((int)resultTarget.x - (int)rnd.x / i, (int)resultTarget.y - (int)rnd.y / i));
                    mapDatas[(int)resultTarget.x - (int)rnd.x / i, (int)resultTarget.y - (int)rnd.y / i].groundData = 5;
                    roadableRaitoData[(int)resultTarget.x - (int)rnd.x / i, (int)resultTarget.y - (int)rnd.y / i] = 100;
                }
            }
            else {goto ho;}
        }
        else
        {
            goto ho;
        }
        result = resultTarget;
        return false;
    }
}
