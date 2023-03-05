using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EnvironmentalDestructionConstant;

public class Player : MonoBehaviour
{
    [SerializeField]
    GameObject Tower;
    [SerializeField]
    PlayerData m_playerData;

    int m_BaseHp = 3;
    int m_Wood = 0;
    int m_Stone = 0;
    int m_Tower = 0;

    int flag=0;

    UI ui;
    [SerializeField]
    GameObject lackTreePanel;

    //最後に選択した床を覚えておく
    GameObject m_SelectGround;

    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.Find("Canvas").GetComponent<UI>();
        lackTreePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //ray打ってヒットしたオブジェクトを保存
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            Physics.Raycast(ray, out raycastHit, 30f);
            if (raycastHit.collider == null) goto Skip;
            GameObject hitObject = raycastHit.collider.gameObject;
            if (hitObject.name.Contains("Ground") == true)
            {
                //選択が残り続けないように消しとく
                if (m_SelectGround != null)
                {
                    m_SelectGround.GetComponent<Ground>().HideSelevter();
                }
                Ground ground = hitObject.GetComponent<Ground>();
                m_SelectGround = hitObject;
                if (ground.onTower == false && ground.onSelectMode == false)
                {
                    ground.ShowSelecter();
                }
            }
            else if (hitObject.name.Contains("Build") == true)
            {
                //ui.SetTowerValue(m_Tower);
                if(m_playerData.g_wood >= 3)
                {
                    m_playerData.g_wood -= 3;
                    if (flag == 0) { GameObject.Find("GameManager").GetComponent<TextUI>().TowerPanel(); flag++;}
                    Instantiate(Tower, m_SelectGround.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                    m_SelectGround.GetComponent<Ground>().onTower = true;
                    m_SelectGround.GetComponent<Ground>().HideSelevter();
                }
                else
                {
                    lackTreePanel.SetActive(true);
                    Invoke(nameof(LackTreePanel),3.0f);
                }
                m_SelectGround.GetComponent<Ground>().HideSelevter();
            }
            else if (hitObject.name.Contains("Cancel") == true)
            {
                m_SelectGround.GetComponent<Ground>().HideSelevter();
            }
            else if (hitObject.CompareTag("Tree") == true)
            {
                //2つのオブジェクトで木を作ったからこうなってる
                if (hitObject.GetComponent<Tree>() == null)
                {
                    hitObject = hitObject.transform.parent.parent.gameObject;
                }
                if (hitObject.GetComponent<Tree>().isCut == false)
                {
                    hitObject.GetComponent<Tree>().CutTree();
                    m_playerData.g_environmentalDestruction += DestructionValue;
                }
            }
            else if (hitObject.CompareTag("Rock") == true)
            {
                //2つのオブジェクトで木を作ったからこうなってる
                if (hitObject.GetComponent<Rock>() == null)
                {
                    hitObject = hitObject.transform.parent.gameObject;
                }
                if (hitObject.GetComponent<Rock>().isCut == false)
                {
                    hitObject.GetComponent<Rock>().CutRock();
                    m_playerData.g_environmentalDestruction += DestructionValue;
                }
            }
        Skip:;
        }
    }

    public void EnemyGoaled()
    {
        m_BaseHp--;
        if (m_BaseHp == 0)
        {
            Debug.Log("ゲームオーバー");
        }
    }

    public void Craft()
    {
        if (m_Wood >= 3)
        {
            m_Wood -= 3;
            m_Tower++;
            ui.SetWoodCount(m_Wood);
            ui.SetTowerValue(m_Tower);
        }
    }

    public void AddWoodvalue()
    {
        m_Wood++;
        ui.SetWoodCount(m_Wood);
    }

    public void AddStonevalue()
    {
        m_Stone++;
        ui.SetStoneCount(m_Stone);
    }


    void LackTreePanel() 
    {
        lackTreePanel.SetActive(false);
    }
}
