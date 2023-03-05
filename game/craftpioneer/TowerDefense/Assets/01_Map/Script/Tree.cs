using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    //進行度バー
    [SerializeField]
    GameObject ProgressBar;
    [SerializeField]
    PlayerData m_playerData;

    public bool isCut { get; set;}

    private void Start()
    {
        isCut = false;
    }

    public void CutTree()
    {
        Instantiate(ProgressBar,transform.position + new Vector3(0,1.5f,0), ProgressBar.transform.rotation);
        Invoke(nameof(Result), 5);
        isCut = true;
    }

    void Result()
    {
        m_playerData.g_wood++;
        Destroy(this.gameObject);
    }
}
