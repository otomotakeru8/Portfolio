using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    //クリックされたときに出すオブジェクト
    [SerializeField]
    GameObject Tree;
    [SerializeField]
    GameObject Rock;
    [SerializeField]
    GameObject Selector;

    //木が建ってるかどうか
    public bool onTree { get; set; }
    //岩が建ってるかどうか
    public bool onRock { get; set; }
    //タワーが建ってるかどうか
    public bool onTower { get; set;}
    //選択されてるかどうか
    public bool onSelectMode { get; set;}

    //消すためにアドレスを保存
    GameObject m_tree;
    GameObject m_rock;
    GameObject m_selecter;


    private void Start()
    {
        onTree = false;
        onRock = false;
        onTower = false;
        onSelectMode = false;
    }

    public void ShowTree()
    {
        onTree = true;
        m_tree = Instantiate(Tree, transform.position + new Vector3(0, 0, 0), transform.rotation, transform);
    }
    public void HideTree()
    {
        onTree = false;
        Destroy(m_tree);
    }

    public void ShowRock()
    {
        onRock = true;
        m_rock = Instantiate(Rock, transform.position + new Vector3(0, 0.2f, 0), transform.rotation, transform);
    }
    public void HideRock()
    {
        onRock = false;
        Destroy(m_rock);
    }

    public void ShowSelecter()
    {
        onSelectMode = true;
        m_selecter = Instantiate(Selector,transform.position + new Vector3(0,1.5f,0),transform.rotation);
    }

    public void HideSelevter()
    {
        onSelectMode = false;
        Destroy(m_selecter);
    }


}
