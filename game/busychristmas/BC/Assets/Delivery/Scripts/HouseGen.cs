using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseGen : MonoBehaviour
{
    [SerializeField] private GameObject housePos1 = null;
    [SerializeField] private GameObject housePos2 = null;
    [SerializeField] private GameObject housePos3 = null;
    [SerializeField] private GameObject housePos4 = null;
    [SerializeField] private GameObject rotationObj = null;
    [SerializeField] private GameObject[] HouseType = new GameObject[12];

    Quaternion secondRotation = Quaternion.Euler(0f, 180f, 0f);

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("RoadGenerator"))
        {
            Instantiate(HouseType[RandomType()], housePos1.transform.position, rotationObj.transform.rotation, housePos1.transform);
            Instantiate(HouseType[RandomType()], housePos3.transform.position, rotationObj.transform.rotation, housePos1.transform);

            Instantiate(HouseType[RandomType()], housePos2.transform.position, rotationObj.transform.rotation * secondRotation, housePos1.transform);
            Instantiate(HouseType[RandomType()], housePos4.transform.position, rotationObj.transform.rotation * secondRotation, housePos1.transform);
        }
    }
    int RandomType()
    {
        return Random.Range(0, 12);
    }
}
