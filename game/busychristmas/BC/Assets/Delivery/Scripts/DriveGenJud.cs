using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveGenJud : MonoBehaviour
{
    [SerializeField] private GameObject genBlock = null;
    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Ground"))
        {
            genBlock.GetComponent<GroundGenerator>().RoadGen();
        }
    }
}
