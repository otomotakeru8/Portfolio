using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchChoice : MonoBehaviour
{
    private GameObject Car = null;

    void Start()
    {
        Car = GameObject.Find("Car");
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Car"))
        {
            Car.GetComponent<DriveCont>().TurningCar();
            Debug.Log("aa");
            Destroy(this.gameObject);
        }
    }
}
