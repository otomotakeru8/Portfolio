using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpawnButton : MonoBehaviour
{
    [SerializeField] Sprite imageBlue;

    float m_cameraDistance;
    Camera m_camera;
    RectTransform m_rectTransform;
    Canvas m_canvas;
    RectTransform m_canvasRect;
    Vector2 m_pos;
    Vector3 m_offSet = new Vector3(0, 1.5f, 0);
    public Transform m_spawnTransform;

    GameObject m_enemyPool;

    string m_filename = "CSV/setWave";

    public MapData mapData;

    AudioSource audioSource;

    int flag=0;

    Image myPhoto;

    int myNuber;

    // Start is called before the first frame update
    void Start()
    {
        //UI表示
        m_camera = Camera.main;
        m_rectTransform = GetComponent<RectTransform>();
        m_canvas = GetComponent<Graphic>().canvas;
        m_canvasRect = m_canvas.GetComponent<RectTransform>();
        TransformChange();

        m_enemyPool = GameObject.Find("EnemyPool");
        myPhoto = this.gameObject.GetComponent<Image>();

        SpawnPosition();

        if (myNuber > 3)
        {
            myPhoto.enabled = false;
        }

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //UI表示
        if (m_spawnTransform == null)
        {
            m_spawnTransform = transform.parent.transform;
        }
        if (m_canvasRect == null)
        {
            GetComponent<Graphic>().canvas.GetComponent<RectTransform>();
        }
        TransformChange();

        if (StageCtrl.nowWaveLoad == true)
        {
            myPhoto.enabled = false;
        }
        
        if (StageCtrl.nowWaveLoad == false)
        {
            if(flag == 0)
            {
                if (myNuber > 3)
                {
                    if (m_enemyPool.GetComponent<ClearUIControl>().SearchList(myNuber - 4) == true)
                    {
                        myPhoto.enabled = true;
                    }
                }
                else
                {
                    myPhoto.enabled = true;
                }
            }
            else if(flag == 1 && m_enemyPool.GetComponent<ClearUIControl>().NowClear() == true)
            {
                myPhoto.enabled = true;
            }
            
        }
    }

    //UI表示
    void TransformChange()
    {
        var screenPos = RectTransformUtility.WorldToScreenPoint(m_camera, m_spawnTransform.position + m_offSet);
        RectTransformUtility.ScreenPointToLocalPointInRectangle(m_canvasRect, screenPos, m_camera, out m_pos);
        m_rectTransform.localPosition = m_pos;
    }

    public void WaveStart()
    {
        if (flag == 0 && StageCtrl.nowWaveLoad == false)
        {
            m_enemyPool.GetComponent<StageCtrl>().WaveStart(m_filename);
            audioSource.PlayOneShot(audioSource.clip);
            Invoke(nameof(spriteChange), 1.5f);
            
        }
        if(flag == 1 && m_enemyPool.GetComponent<ClearUIControl>().GetTalent() == true)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().RandomUnLock();
            GameObject.Find("Canvas/TalentPanel").GetComponent<TalentPanel>().PopTalents();
            ObjDestroy();
        }

    }

    void spriteChange()
    {
        myPhoto.sprite = imageBlue;
        flag++;
    }

    void ObjDestroy()
    {
        m_enemyPool.GetComponent<ClearUIControl>().AddList(myNuber);
        Destroy(this.gameObject);
    }

    void SpawnPosition()
    {
        Vector3 worldPos = m_spawnTransform.position;
        Vector3 pos;
        for (int i=0; i< mapData.EnemySpawnPosition.Count;i++)
        {
            pos = mapData.EnemySpawnPosition[i];
            if(pos.x == worldPos.x && pos.z == worldPos.z)
            {
                if (i==0)
                {
                    m_filename= "CSV/wave";
                    myNuber=i;
                }
                else if (i==1)
                {
                    m_filename= "CSV/wave1";
                    myNuber = i;
                }
                else if(i == 2)
                {
                    m_filename = "CSV/wave2";
                    myNuber = i;
                }
                else if(i == 3)
                {
                    m_filename = "CSV/wave3";
                    myNuber = i;
                }
                else if(i == 4)
                {
                    m_filename = "CSV/wave4";
                    myNuber = i;
                }
                else if (i == 5)
                {
                    m_filename = "CSV/wave5";
                    myNuber = i;
                }
                else if (i == 6)
                {
                    m_filename = "CSV/wave6";
                    myNuber = i;
                }
                else if (i == 7)
                {
                    m_filename = "CSV/wave7";
                    myNuber = i;
                }
                else if (i == 8)
                {
                    m_filename = "CSV/wave8";
                    myNuber = i;
                }
                else if (i == 9)
                {
                    m_filename = "CSV/wave9";
                    myNuber = i;
                }
                else if (i == 10)
                {
                    m_filename = "CSV/wave10";
                    myNuber = i;
                }
                else if (i == 11)
                {
                    m_filename = "CSV/wave11";
                    myNuber = i;
                }
                else if (i == 12)
                {
                    m_filename = "CSV/wave12";
                    myNuber = i;
                }
            }
        }

    }
}
