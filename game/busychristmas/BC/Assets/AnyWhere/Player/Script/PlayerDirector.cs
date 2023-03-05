using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDirector : MonoBehaviour
{
    PlayerMath m_playerMath = new PlayerMath();
    ResorceArrey m_resorceArrey = new ResorceArrey();

    [SerializeField]
    float m_moveSpeed;
    float m_playerDash = 1;
    float LStick1Horizontal;
    float LStick1Vertical;
    Vector3 m_playerSpawnPoint;
    public bool m_playerHold;
    bool m_playerCanMove;
    bool m_isController;
    bool m_PlayerWorking;
    int m_playerSkinNumber;
    public GameObject m_playerHoldItem;
    [SerializeField]GameObject[] m_allItem;
    [SerializeField]GameObject[] m_allObject;
    [SerializeField,HideInInspector] GameObject[] m_resourcesItem;
    Object[] m_resourcesObject;
    GameObject m_player;
    public GameObject m_playerUi;

    bool m_playerLateHold;

    // Start is called before the first frame update
    void Start()
    {
        CheckInputType();//コントローラーが刺さっているかどうか
        Initialize();//プレイヤーの状態をリセット
        m_playerCanMove = true;//待機用
        m_playerSpawnPoint = GameObject.Find("Player").transform.position;//設置場所からポジションを取得
        m_resourcesObject = Resources.LoadAll("");//リソースからアイテムを取得
        m_resourcesItem = new GameObject [m_resourcesObject.Length];
        for (int i = 0; i < m_resourcesObject.Length; i++){
            m_resourcesItem[i] = m_resourcesObject[i] as GameObject;
        }
        m_player = GameObject.Find("Player");
        m_resorceArrey.Initialize();
        m_playerLateHold = false;
    }

    void CheckInputType(){
        m_isController = false;
        string[] controllernames = Input.GetJoystickNames();
        if (controllernames.Length != 0) m_isController = true;
    }

    void Initialize(){
        m_playerHold = false;
        m_PlayerWorking = false;
        m_playerHoldItem = null;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxis("L_Stick_H"));
        if (m_playerCanMove == true){
            GetInput();
            PlayerMove();
        }
        Animation();
    }

    void GetInput(){
        if (m_isController == true)
        {
            if (Input.GetButtonDown("A1"))
            {
                ItemFunction();
            }
            if (Input.GetButtonDown("B1"))
            {
                ActionFunction();
            }
            if (Input.GetButtonDown("R1"))
            {
                m_playerDash = 2;
            }
            else m_playerDash = 1;
            LStick1Horizontal = Input.GetAxis("Horizontal");
            LStick1Vertical = Input.GetAxis("Vertical");
        }
        if (m_isController == false)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                ItemFunction();
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                ActionFunction();
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                m_playerDash = 2;
            }
            else m_playerDash = 1;
            LStick1Horizontal = 0;
            LStick1Vertical = 0;
            if (Input.GetKey(KeyCode.W)) LStick1Vertical = 1;
            if (Input.GetKey(KeyCode.S)) LStick1Vertical = -1;
            if (Input.GetKey(KeyCode.D)) LStick1Horizontal = 1;
            if (Input.GetKey(KeyCode.A)) LStick1Horizontal = -1;
        }
    }

    void PlayerMove(){
        if (Mathf.Abs(LStick1Horizontal) > 0 || Mathf.Abs(LStick1Vertical) > 0)
        {
            FindObjectOfType<Player>().Look(m_playerMath.Lookdirection(LStick1Horizontal, LStick1Vertical, m_player.transform.rotation));
            FindObjectOfType<Player>().Move(m_moveSpeed, m_playerDash);
        }
    }

    public void PlayerCanMove(){
        m_playerCanMove = true;
    }

    public void Checkdeth(){
        Invoke(nameof(PlayerSpawn), 4);
    }

    void PlayerSpawn(){
        FindObjectOfType<Player>().Spawn(m_playerSpawnPoint);
    }

    void ItemFunction(){
        if (m_playerHold == false && m_PlayerWorking == false){
            FindItem();
        }
        if (m_playerHold == true){
            FindObject();
        }
    }

    void FindItem(){
        GameObject nearestobject = m_playerMath.FindObject(m_allItem, m_player.transform.position);
        if (nearestobject != null)
        {
            if (nearestobject.tag.Contains("Box"))
            {
                nearestobject.SendMessage("BoxAnimation", 1);
                m_playerHold = true;
            }
            if (nearestobject.tag.Contains("Table"))
            {
                nearestobject.GetComponent<WorkDesk>().workGet(1);
            }
        }
    }

    void FindObject()
    {
        GameObject[] objects = new GameObject[m_allObject.Length];
        m_allObject.CopyTo(objects,0);
        GameObject nearestobject = m_playerMath.FindObject(objects, m_player.transform.position);
        if (nearestobject != null)
        {
            if (nearestobject.GetComponent<WorkDesk>().set(m_playerHoldItem.name) == true)
            {
                m_playerHold = false;
                m_playerHoldItem = null;
            }
        }
    }

    void ActionFunction(){
        if (m_playerHold == false && m_PlayerWorking == false){
            FindWaitstateobject();
        }
    }

    void FindWaitstateobject(){
        GameObject[] objects = new GameObject[m_allObject.Length];
        m_allObject.CopyTo(objects, 0);
        GameObject nearestobject = m_playerMath.FindObject(objects, m_player.transform.position);
        if (nearestobject != null)
        {
            if (nearestobject.GetComponent<WorkDesk>().work() == true)
            {
                m_PlayerWorking = true;
                m_playerCanMove = false;
                Instantiate(m_playerUi, m_player.transform.position, Quaternion.identity);
                Invoke(nameof(PlayerStopWorking), 2f);
            }
        }
    }

    public void PlayerStopWorking(){
        m_PlayerWorking = false;
        m_playerCanMove = true;
    }

    public void GetItem(string itemname,int playernumber){
        if (playernumber == 1)
        {
            m_playerHoldItem = m_resorceArrey.Search(itemname);
            m_playerHold = true;
        }
    }

    void Animation(){
        FindObjectOfType<Player>().ItemHold(m_playerHold, m_playerHoldItem, m_playerLateHold);
        m_playerLateHold = m_playerHold;
    }
    
    public GameObject Itemcheck()
    {
        return m_playerHoldItem;
    }
}
