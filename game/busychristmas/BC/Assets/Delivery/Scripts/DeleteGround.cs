using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteGround : MonoBehaviour
{
    void OnTriggerEnter(Collider ground)
    {
        if (ground.CompareTag("Ground"))
        {
            Destroy(ground.transform.parent.gameObject);
        }
    }
}
