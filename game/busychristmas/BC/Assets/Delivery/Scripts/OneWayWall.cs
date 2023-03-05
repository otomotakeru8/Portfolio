using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayWall : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if (CompareTag("OneWay"))
        {
            Collider cl = this.GetComponent<Collider>();
            cl.isTrigger = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (CompareTag("OneWay"))
        {
            Collider cl = this.GetComponent<Collider>();
            cl.isTrigger = false;
        }
    }
}
