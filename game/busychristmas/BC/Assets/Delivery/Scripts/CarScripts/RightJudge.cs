using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightJudge : MonoBehaviour
{
    [SerializeField] private GameObject Car = null;
    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Car.GetComponent<DriveCont>().ChoiceRight();
        }
    }
}
