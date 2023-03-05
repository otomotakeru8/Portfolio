using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWall : MonoBehaviour
{
    TestPlayerCont tpc;
    [SerializeField, Tooltip("PlayerObject")] private GameObject Player = null;
    // Start is called before the first frame update
    void Start()
    {
        tpc = Player.GetComponent<TestPlayerCont>();
    }
    void OnTriggerStay(Collider collider)
    {
        if (collider.CompareTag("Wall"))
        {
            tpc.ifHitWall(true);
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Wall"))
        {
            tpc.ifHitWall(false);
        }
    }
}
