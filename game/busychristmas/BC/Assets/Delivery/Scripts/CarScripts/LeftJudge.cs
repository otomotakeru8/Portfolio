using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftJudge : MonoBehaviour
{
    [SerializeField] private GameObject Car = null;
    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Car.GetComponent<DriveCont>().ChoiceLeft();
        }
    }
}
