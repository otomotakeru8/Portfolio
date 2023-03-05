using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseDel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DeliveryGift"))
        {
            Destroy(other.gameObject);
        }
    }
}
