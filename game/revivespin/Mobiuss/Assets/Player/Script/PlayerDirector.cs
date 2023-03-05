using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//タイミング200
public class PlayerDirector : MonoBehaviour
{
    public GameObject Player;
    public GameObject cadaver;
    public GameObject cadaverl;
    public GameObject cadaver3;
    public GameObject cadaverl3;
    int m_respawnCount;
    [SerializeField] Vector3[] SpawnPoint;
    bool m_respawnStack;

    // Start is called before the first frame update
    void Start()
    {
        m_respawnCount = 0;
        m_respawnStack = false;
        PassInitialize();
        SetPass();
        Invoke(nameof(FirstReSpawn),0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Pass.PlayerCanMove == true) && (m_respawnStack == false) && ((Input.GetKeyDown(KeyCode.R)) || (Input.GetKeyDown("joystick button 2")))){
            if (Pass.PlayerCanMove == true){
                StartRespawn();
            }
        }
        SetPass();
    }

    public void StartRespawn(){
        Invoke(nameof(PlayerSpawn), 1f);
        m_respawnStack = true;
    }

    void FirstReSpawn(){
        m_respawnStack = true;
        Instantiate(Player, SpawnPoint[Pass.StageNumber], Quaternion.identity,this.transform);
        Invoke(nameof(SpawnDirector), 0.3f);
    }

    void PassInitialize(){
        Pass.RespawnPoint = m_respawnCount;
        Pass.RespawnStack = m_respawnStack;
    }

    void SetPass(){
        Pass.RespawnPoint = m_respawnCount;
        Pass.RespawnStack = m_respawnStack;
    }

    void PlayerSpawn(){
        if (Pass.StageNumber == 1 || Pass.StageNumber == 2){
            if (Pass.PlayerRight == true){
                Instantiate(cadaver,Pass.PlayerPosition,Quaternion.identity);
            }
            if (Pass.PlayerRight == false){
                Instantiate(cadaverl, Pass.PlayerPosition, Quaternion.identity);
            }
        }
        if (Pass.StageNumber == 3){
            if (Pass.PlayerRight == true){
                Instantiate(cadaver3, Pass.PlayerPosition, Quaternion.identity);
            }
            if (Pass.PlayerRight == false){
                Instantiate(cadaverl3, Pass.PlayerPosition, Quaternion.identity);
            }
        }
        Instantiate(Player,SpawnPoint[Pass.StageNumber],Quaternion.identity,this.transform);
        Invoke(nameof(SpawnDirector),0.3f);
        Invoke(nameof(CanMove),0.1f);
        m_respawnCount++;
    }

    void CanMove(){
        Pass.PlayerCanMove = true;
    }

    void SpawnDirector(){
        m_respawnStack = false;
    }
}
