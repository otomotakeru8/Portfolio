using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallcheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            FindObjectOfType<PlayerDirector>().Checkdeth();
        }
    }
}
