using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodsGen : MonoBehaviour
{
    [SerializeField] private GameObject woods = null;
    [SerializeField] private GameObject woodPosition = null;
    private GameObject copyWoods = null;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("RoadGenerator"))
        {
            copyWoods = Instantiate(woods,woodPosition.transform.position,this.transform.rotation);
        }
        if (collider.gameObject.CompareTag("WoodsDel"))
        {
            Destroy(copyWoods);
        }
    }
}
