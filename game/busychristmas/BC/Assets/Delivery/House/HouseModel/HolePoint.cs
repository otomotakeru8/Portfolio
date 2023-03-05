using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolePoint : MonoBehaviour
{
    GiftHitting gh;
    LightChange lc;
    [SerializeField, Tooltip("親オブジェクト")]GameObject houseObject = null;

    private void Start()
    {
        lc = houseObject.GetComponent<LightChange>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DeliveryGift"))
        {
            gh = other.GetComponent<GiftHitting>();
            gh.HitHole();
            lc.SetHoleColor();
        }
    }
}
